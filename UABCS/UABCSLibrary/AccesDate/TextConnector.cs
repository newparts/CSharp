using UABCSLibrary.AccesDate;
using UABCSLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace UABCSLibrary
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
