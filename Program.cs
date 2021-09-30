using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace VOYANQWeb
{
    public class Program
    {
        //add code here agian
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        //addd more comments
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    //add more
                    webBuilder.UseStartup<Startup>();
                });
    }
}
