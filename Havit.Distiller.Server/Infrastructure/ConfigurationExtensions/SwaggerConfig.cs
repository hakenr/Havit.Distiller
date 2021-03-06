﻿using System;
using System.IO;
using Havit.Distiller.WebAPI.Infrastructure.Swagger;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace Havit.Distiller.WebAPI.Infrastructure.ConfigurationExtensions
{
    public static class SwaggerConfig
    {
        public static void AddCustomizedSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("current", new Info { Title = "Distiller" });
                c.CustomSchemaIds(type => type.FullName);
                c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "Havit.Distiller.Server.xml"));
                c.DescribeAllEnumsAsStrings();
                c.OperationFilter<FileUploadOperation>(); //Register File Upload Operation Filter
            });

        }

        public static void UseCustomizedSwaggerAndUI(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/current/swagger.json", "Current");
            });
        }
    }
}
