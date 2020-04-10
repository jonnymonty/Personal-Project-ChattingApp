﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fasetto.Word.Web.Server
{
    /// <summary>
    /// A shorthand access class to get DI services with nice clean short code.
    /// </summary>
    public static class IoC
    {
        /// <summary>
        /// The scoped instance of the <see cref="ApplicationDbContext"/>
        /// </summary>
        public static ApplicationDbContext ApplicationDbContext => IocContainer.Provider.GetService<ApplicationDbContext>();
    }

    /// <summary>
    /// The dependency injection container making use of the built in .Net Core service provider.
    /// </summary>
    public static class IocContainer
    {
        /// <summary>
        /// The service provider for this application.
        /// </summary>
        public static ServiceProvider Provider { get; set; }

        /// <summary>
        /// The configuration manager for the application
        /// </summary>
        public static IConfiguration Configuration { get; set;  }
    }
}
