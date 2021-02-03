using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHR.DataAccessLayer
{
    public enum ConnectionType
    {
        Sql,
        Text
    }

    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }
        public static void InitializeConnection(ConnectionType cnnType)
        {
            switch (cnnType)
            {
                case ConnectionType.Sql:
                    Connection = new SqlConnector();
                    break;
                case ConnectionType.Text:
                    Connection = new TextConnector();
                    break;
            }
        }
        public static ConnectionType CnnType 
        {
            get
            {
                string configValue = ConfigurationManager.AppSettings["ConnectionType"];
                ConnectionType value = (ConnectionType)Enum.Parse(typeof(ConnectionType), configValue);
                return value;
            }
        }

    }
}
