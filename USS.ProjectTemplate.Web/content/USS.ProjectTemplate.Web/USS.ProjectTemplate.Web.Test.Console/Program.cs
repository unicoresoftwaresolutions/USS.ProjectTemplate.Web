Console.WriteLine("Hello, World!");

var handler = new SocketsHttpHandler
{
    PooledConnectionLifetime = TimeSpan.FromMinutes(15) // Recreate every 15 minutes
};


var client = new HttpClient(handler);

client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
var result = client.GetStringAsync("/posts").Result;
Console.WriteLine(result);