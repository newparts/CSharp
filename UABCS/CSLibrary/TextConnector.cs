using System;
using System.Collections.Generic;
using System.Text;

namespace CSLibrary
{
    public class TextConnector : IConexiuneDate
    {
        public PremiiModel CrearePremii(PremiiModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}
