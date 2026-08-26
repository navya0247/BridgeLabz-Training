using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.IdentityModel.Tokens;
using FundooNotesApp.RepositoryLayer.Context;
using FundooNotesApp.RepositoryLayer.Interface;
using FundooNotesApp.RepositoryLayer.Service;
using FundooNotesApp.BusinessLayer.Interface;
using FundooNotesApp.BusinessLayer.Service;
using FundooNotesApp.BusinessLayer.Helper;
using FundooNotesApp.BusinessLayer.BackgroundServices;
using FundooNotesApp.API.Middleware;

var builder = WebApplication.CreateBuilder(args);

// register db context
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// register repository and service
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

// add notes registrations
builder.Services.AddScoped<INotesRepository, NotesRepository>();
builder.Services.AddScoped<INotesService, NotesService>();

// register label services
builder.Services.AddScoped<ILabelRepository, LabelRepository>();
builder.Services.AddScoped<ILabelService, LabelService>();

// smtp settings
string smtpHost = builder.Configuration["Smtp:Host"]!;
int smtpPort = int.Parse(builder.Configuration["Smtp:Port"]!);
string senderEmail = builder.Configuration["Smtp:SenderEmail"]!;
string senderPassword = builder.Configuration["Smtp:SenderPassword"]!;
builder.Services.AddSingleton(new EmailSender(smtpHost, smtpPort, senderEmail, senderPassword));

// rabbitmq settings
string rabbitHost = builder.Configuration["RabbitMQ:HostName"]!;
string queueName = builder.Configuration["RabbitMQ:QueueName"]!;
builder.Services.AddSingleton(new RabbitMqPublisher(rabbitHost, queueName));

// notification services
builder.Services.AddScoped<INotificationRepository, NotificationRepository>();
builder.Services.AddScoped<INotificationService, NotificationService>();

// background services
builder.Services.AddHostedService<ReminderBackgroundService>();
builder.Services.AddHostedService(sp =>
    new EmailConsumerBackgroundService(rabbitHost, queueName, sp.GetRequiredService<EmailSender>()));

// redis cache settings, used for token caching and session control
string redisConnection = builder.Configuration["Redis:ConnectionString"]!;
builder.Services.AddSingleton(new RedisCacheHelper(redisConnection));

// register helpers
builder.Services.AddSingleton<PasswordHasher>();
string secretKey = builder.Configuration["JwtSettings:SecretKey"]!;
builder.Services.AddSingleton(new JwtTokenHelper(secretKey));

// jwt authentication setup
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
    };
});

builder.Services.AddAuthorization();

// rate limiting, protects sensitive endpoints like login from brute force
builder.Services.AddRateLimiter(options =>
{
    options.AddFixedWindowLimiter("fixed", opt =>
    {
        opt.PermitLimit = 10;
        opt.Window = TimeSpan.FromMinutes(1);
    });
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRateLimiter();

app.UseAuthentication();

// checks token against redis after authentication, rejects logged-out tokens
app.UseMiddleware<TokenValidationMiddleware>();

app.UseAuthorization();

app.MapControllers();
app.Run();