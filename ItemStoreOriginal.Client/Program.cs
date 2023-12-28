using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.LocalStorage;
using ItemStoreOriginal.Shared.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddBlazoredLocalStorage();
//builder.Services.AddScoped<IManufacturedItemsService, ManufacturedItemsService>();


await builder.Build().RunAsync();
