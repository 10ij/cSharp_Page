using System.Globalization;
using System.Net;
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// app.MapGet("/", () => "Hello World!");

// Same as $_SERVER['REQUEST_METHOD'] === 'POST'
// HttpContext gives access to HTTP req and resp
// Use asynchronous
app.MapPost("/submit", async (HttpContext context) =>
{
    string username;
    var form = await context.Request.ReadFormAsync();
    username = form["username"];

    return Results.Content($@"
        <html>
            <body>
                <h1>Hello, {username}!</h1>
                <a href='/'>Back to form</a>
            </body>
        </html>
    ", "text/html");
});

app.MapPost("/word", async (HttpContext context) =>
{
    string input;
    int count;

    var form = await context.Request.ReadFormAsync();
    input = form["words"].ToString();

    // No Len() Function it seems
    count = input.Length;

    return Results.Content($@"
            <body>
                <h1>The word count is: {count}</h1>
                <a href='/'>Back to form</a>
            </body>
        </html>
    ", "text/html");
});

app.Run();
