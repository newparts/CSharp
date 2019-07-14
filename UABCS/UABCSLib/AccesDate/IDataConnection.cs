using UABCSLib.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace UABCSLib.AccesDate
{
    public interface IDataConnection
    {
        PremiiModel CrearePremii(PremiiModel model);
    }
}
