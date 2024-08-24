using NotificationSystemEx.Observers.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<INotificationService, NotificationService>();

var app = builder.Build();

app.MapGet("/", (INotificationService notification) =>
{
    var user1 = new User();
    var user2 = new User();

    notification.Add(user1);
    notification.Add(user2);

    notification.Notify("Hello, User 1 and 2!");

    var notifs = new List<string> { user1.Message, user2.Message };

    return Results.Ok(string.Join("\n", notifs));
});

app.Run();
