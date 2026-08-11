using ContactApp.Models;
using ContactApp.Repository;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

ContactRepository repository = new ContactRepository();
repository.EnsureTableExists(); // creates table on startup if missing

app.MapGet("/", () => "Hello World!");

// get all contacts
app.MapGet("/contacts", () =>
{
    return repository.GetAll();
});

// add a new contact
app.MapPost("/contacts", (Contact contact) =>
{
    repository.Add(contact);
    return Results.Ok("Contact added");
});

// update a contact
app.MapPut("/contacts/{id}", (int id, Contact contact) =>
{
    bool updated = repository.Update(id, contact);
    if (!updated)
        return Results.NotFound("Contact not found");
    return Results.Ok("Contact updated");
});

// delete a contact
app.MapDelete("/contacts/{id}", (int id) =>
{
    bool deleted = repository.Delete(id);
    if (!deleted)
        return Results.NotFound("Contact not found");
    return Results.Ok("Contact deleted");
});

app.Run();