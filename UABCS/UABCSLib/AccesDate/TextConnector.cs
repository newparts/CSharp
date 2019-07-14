using UABCSLib.AccesDate;
using UABCSLib.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace UABCSLib.AccesDate
{
    public class TextConnector : IDataConnection, IDisposable
    {
        public PremiiModel CrearePremii(PremiiModel model)
        {
            model.Id = 1;
            return model;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
