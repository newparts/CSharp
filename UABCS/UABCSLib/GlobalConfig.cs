using UABCSLib.AccesDate;
using System;
using System.Collections.Generic;
using System.Text;
using UABCSLib;
using System.Configuration;

namespace UABCSLib
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections (bool database, bool textFiles)
        {
            Connections = new List<IDataConnection>();

            if (database)
            {
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if(textFiles)
            {
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
