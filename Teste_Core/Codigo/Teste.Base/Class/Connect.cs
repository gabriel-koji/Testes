using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using NPoco;

namespace Teste.Base.Class
{
    public class ConnectBD
    {
        public string connect { get; set; }

        public ConnectBD()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder();

            builder.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "Properties", "launchSettings.json"));//Diretório do Json "launchSettings.json"

            var ambiente = builder.Build().GetSection("profiles:IIS Express:environmentVariables:ASPNETCORE_ENVIRONMENT");//Get Valor Da seção ambiente(ASPNETCORE_ENVIRONMENT) dentro do Json(launchSettings.json)

            var jsonAmbiente = "appsettings." + ambiente.Value + ".json";//Montando string de ambiente para o usar o Json(appsettings.json) de acordo com o ambiente estabelecido dentro do Json(launchSettings.json)

            //Exemplo:
            //Se - "ASPNETCORE_ENVIRONMENT" : "Development";
            //Então - JsonAmbiente = appsettings.Development.json

            builder.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), jsonAmbiente));//Adicionando Json(JsonAmbiente) dentro da variavel(builder)

            connect = builder.Build().GetConnectionString("Connection");//Get String(Connection) dentro do Json(JsonAmbiente)
        }

        public Database Connection
        {
            get
            {
                return new Database(connect, DatabaseType.SqlServer2012, SqlClientFactory.Instance);//Fazendo conexão com o banco
            }
        }
    }
}
