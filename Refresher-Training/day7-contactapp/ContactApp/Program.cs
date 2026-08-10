using ContactApp.Models;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

List<Contact> contacts = new()
{
    new Contact
    {
        Id = 1,
        Name = "Ujjawal",
        Email = "ujjawal@gmail.com",
        Phone = "9876543210"
    },
    new Contact
    {
        Id = 2,
        Name = "Rahul",
        Email = "rahul@gmail.com",
        Phone = "9876543211"
    }
};

app.MapGet("/contacts", () =>
{
    return contacts;
});

app.Run();