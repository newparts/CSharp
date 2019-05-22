using System;
using System.Collections.Generic;
using System.Text;

namespace CSLibrary
{
    public class SqlConnector : IConexiuneDate
    {
        public PremiiModel CrearePremii(PremiiModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}
