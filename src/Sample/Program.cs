﻿using Microsoft.AspNetCore.Blazor.Hosting;
using SampleCore;
using System.Threading.Tasks;
using BlazorStyled;

namespace Sample
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            //Configure Services

            //AddBlazorStyled is needed for BlazorStyled to work
            builder.Services.AddBlazorStyled();

            //The following is only used by the sample sites and is not required for BlazorStyled to work
            builder.Services.AddServicesForSampleSites();

            //End Configure Services

            builder.RootComponents.Add<App>("app");

            //Add BlazorStyled to root components
            builder.RootComponents.Add<ClientSideStyled>("#styled");

            await builder.Build().RunAsync();
        }
    }
}
