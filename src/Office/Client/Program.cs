using Blazorise;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Office.Client;
using Boost.Proto.Actor.BlazorWasm;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.UseProtoActor((sp, option) =>
{
    
});

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazorise(options => options.ChangeTextOnKeyPress = true)
                .AddBootstrap5Providers()
                .AddFontAwesomeIcons();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
