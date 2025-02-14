﻿using CG4.DataAccess;
using Microsoft.Extensions.Configuration;
using ProjectName.Common;

namespace ProjectName.WebApp
{
    public interface IAppSettings
    {
    }

    public class AppSettings : IAppSettings, IConnectionSettings, ISphinxConnectionString
    {
        public AppSettings(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("ProjectName");
            SphinxConnectionString = config.GetConnectionString("Sphinx");
        }

        public string ConnectionString { get; set; }
        
        public string SphinxConnectionString { get; set; }
    }
}
