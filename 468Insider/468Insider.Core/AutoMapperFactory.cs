using AutoMapper;
using System.Reflection;

namespace _468Insider.Core;

public static class AutoMapperFactory
    {
        public static IConfigurationProvider CreConfigurationProvider()
        {
            var config = new MapperConfiguration(cfg =>
            {
                var assembly = Assembly.GetAssembly(typeof(AutoMapperFactory));

                cfg.AddMaps(assembly);
            });
            return config;
        }
    }