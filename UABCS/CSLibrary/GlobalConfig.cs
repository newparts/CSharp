using System;
using System.Collections.Generic;
using System.Text;

namespace CSLibrary
{
    public static class GlobalConfig
    {
        public static List<IConexiuneDate> Conexiuni { get; private set; } = new List<IConexiuneDate>();

        public static void InitializareConexiuni (bool database, bool textFiles)
        {
            Conexiuni = new List<IConexiuneDate>();

            if (database)
            {
                SqlConnector sql = new SqlConnector();
                Conexiuni.Add(sql);
            }

            if(textFiles)
            {
                TextConnector text = new TextConnector();
                Conexiuni.Add(text);
            }
        }
    }
}
