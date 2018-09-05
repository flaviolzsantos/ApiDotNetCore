using MongoDB.Driver;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Repositorio
{
    static class Conexao
    {
        public static IMongoDatabase ObterConexao
        {
            get
            {                
                return new MongoClient("mongodb://localhost:27017").GetDatabase("omni");
            }
        }

        private static IConfigurationRoot ObterConfiguracao(){

            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory());
            //.AddJsonFile("appsettings.json");

            return builder.Build();
        }
    }
}