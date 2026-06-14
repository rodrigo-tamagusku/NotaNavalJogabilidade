using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using NotaNaval.Shared.Services;
using NotaNaval.Web.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add device-specific services used by the NotaNaval.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();

await builder.Build().RunAsync();
