using ContactsApp.Models;
using ContactsApp.Repository;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

ContactRepository repository = new ContactRepository(); // one shared repository

app.MapGet("/", () => "Hello World!");

app.MapGet("/contacts", () =>
{
    return repository.GetAll();
});

app.MapPost("/contacts", (Contact contact) =>
{
    repository.Add(contact);
    return Results.Ok("Contact added");
});

app.MapPut("/contacts/{id}", (int id, Contact contact) =>
{
    bool updated = repository.Update(id, contact);
    if (!updated)
        return Results.NotFound("Contact not found");
    return Results.Ok("Contact updated");
});

app.MapDelete("/contacts/{id}", (int id) =>
{
    bool deleted = repository.Delete(id);
    if (!deleted)
        return Results.NotFound("Contact not found");
    return Results.Ok("Contact deleted");
});

app.Run();