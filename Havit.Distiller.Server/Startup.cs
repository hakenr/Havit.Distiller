using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security;
using Castle.Windsor;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using Havit.Distiller.WebAPI.Infrastructure;
using Havit.Distiller.WebAPI.Infrastructure.ConfigurationExtensions;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.Options;
using Havit.Distiller.WebAPI.Infrastructure.Tools;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.ResponseCompression;
using System.Net.Mime;
using Microsoft.AspNetCore.Blazor.Server;

[assembly: ApiControllerAttribute]

namespace Havit.Distiller.WebAPI
{
    public class Startup
    {
	    private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
	        this.configuration = configuration;
        }

        /// <summary>
        /// Configure services.
        /// </summary>
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddOptions(); // Adds services required for using options.
            services.AddMemoryCache(); // ie. IClaimsCacheStorage

	        services.AddCustomizedRequestLocalization();
			services.AddCustomizedMvc(configuration);

			services.AddResponseCompression(options =>
			{
				options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[]
				{
					MediaTypeNames.Application.Octet,
					WasmMediaTypeNames.Application.Wasm,
				});
			});


			services.AddAuthorization();
            //services.AddCustomizedAuthentication(configuration); // musí být voláno až po AddMvc, jinak nejsou volány IClaimsTransformation.
	        services.AddCustomizedMailing(configuration);
	        
			services.AddExceptionMonitoring(configuration);
            services.AddCustomizedCors(configuration);
            services.AddCustomizedSwagger();			

	        services.AddApplicationInsightsTelemetry(configuration);

			services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();

			IWindsorContainer windsorContainer = WindsorCastleConfiguration.CreateWindsorContainer(configuration);
            return services.AddCustomizedServiceProvider(windsorContainer);
        }

        /// <summary>
        /// Configure middleware.
        /// </summary>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IOptions<Havit.Distiller.WebAPI.Infrastructure.Cors.CorsOptions> corsOptions)
        {
			app.UseResponseCompression();

			if (env.IsDevelopment())
	        {
		        app.UseDeveloperExceptionPage();
	        }

			app.UseCustomizedCors(corsOptions);
            app.UseStaticFiles();
            //app.UseAuthentication();

	        app.UseRequestLocalization();
            app.UseMvc();
            app.UseCustomizedSwaggerAndUI();

	        app.UpgradeDatabaseSchemaAndData();

			app.UseBlazor<Client.Startup>();
		}

	}
}
