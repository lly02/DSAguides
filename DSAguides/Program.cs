using DSAguides;
using DSAguides.Interface;
using DSAguides.Interface.Nodes;
using DSAguides.Interface.Operation;
using DSAguides.Models.DataStructures.Array;
using DSAguides.Models.DataStructures.Array.Operations;
using DSAguides.Models.Shared.Nodes;
using DSAguides.Models.Shared.Operation;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddTransient<IServiceFactory<ArrayOperation>, ArrayServiceFactory>();
builder.Services.AddTransient<ArrayOperation, ArrayAddOperation>();
builder.Services.AddTransient<ArrayOperation, ArrayClearOperation>();
builder.Services.AddTransient<ArrayOperation, ArrayNewOperation>();

builder.Services.AddTransient<IServiceFactory<INodeFactory>, NodeServiceFactory>();
builder.Services.AddTransient<INodeFactory, ArrayNodeFactory>();

var host = builder.Build();

await host.RunAsync();
