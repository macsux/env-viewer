using System;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace EnvironmentViewer
{
    public class Program
    {


        public static async Task Main(string[] args)
        {
            await Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(web => web
                    .Configure(app => app
                        .Run(http => http.Response.WriteAsync(JsonSerializer.Serialize(Environment.GetEnvironmentVariables())))))
                .Build()
                .RunAsync();
        }
    }
}


       