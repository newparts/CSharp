using UABCSLib.AccesDate;
using UABCSLib.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace UABCSLib
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
