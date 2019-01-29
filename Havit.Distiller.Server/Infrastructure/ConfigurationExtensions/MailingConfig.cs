using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Havit.Distiller.Services.Mailing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Havit.Distiller.WebAPI.Infrastructure.ConfigurationExtensions
{
    public static class MailingConfig
    {
	    public static void AddCustomizedMailing(this IServiceCollection services, IConfiguration configuration)
	    {
			services.Configure<MailingOptions>(configuration.GetSection("AppSettings:MailingOptions"));
		}
	}
}
