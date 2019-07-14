using UABCSLib.AccesDate;
using UABCSLib.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Dapper;

namespace UABCSLib.AccesDate
{
    public class SqlConnector : IDataConnection
    {
        public PremiiModel CrearePremii(PremiiModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("UABCSDB")))
            {
                var p = new DynamicParameters();
                p.Add("@NumarLoc", model.LoculOcupat);
                p.Add("@NumeLoC", model.LocNume);
                p.Add("@ValoarePremiu", model.ValoarePremiu);
                p.Add("@ProcentPremiu", model.ProcentPremiu);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spAdauga_Premiu", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
            }
        }
    }
}
