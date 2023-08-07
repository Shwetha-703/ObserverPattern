﻿// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Observer_Pattern.Services;

Console.WriteLine("Hello, World!");

IHost _host = Host.CreateDefaultBuilder()
                  .ConfigureServices(services =>
                    {
                        services.AddSingleton<IApplication, Application>();
                    })
                  .Build();

var app = _host.Services.GetRequiredService<IApplication>();
app.Run();