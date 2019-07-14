using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ESLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();


        public static void InitializeConnections(bool database, bool textfiles)
        {
            if(database)
            {
                SqlConector sql = new SqlConector();
                Connections.Add(sql);
            }

            if(textfiles)
            {
                TextConector text = new TextConector();
                Connections.Add(text);
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
