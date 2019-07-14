using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ESLibrary.Model;

namespace ESLibrary
{
    public class SqlConector : IDataConnection
    {
        
        public ModelMedic AdaugaMedicNou (ModelMedic model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("ESanatateDB")))
            {
                var p = new DynamicParameters();
                p.Add("@Nume", model.Nume);
                p.Add("@Prenume", model.Prenume);
                p.Add("@CNP", model.CNP);
                p.Add("@SerieCI", model.SerieCI);
                p.Add("@NumarCI", model.NumarCI);
                p.Add("@SerieContract", model.SerieContract);
                p.Add("@NumarContract", model.NumarContract);
                p.Add("@SerieCertificatCM", model.SerieCertificatCM);
                p.Add("@NumarCertificatCM", model.NumarCertificatCM);
                p.Add("@Utilizator", model.Utilizator);
                p.Add("@Parola", model.Parola);
                p.Add("@Telefon", model.Telefon);
                p.Add("@Email", model.Email);
                p.Add("@Adresa", model.Adresa);
                p.Add("@Localitate", model.Localitate);
                p.Add("@Judet", model.Judet);
                p.Add("@Tara", model.Tara);
                p.Add("@Specializarea", model.Specializarea);
                p.Add("@CodPostal", model.CodPostal);                

                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spAdauga_Medic", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
            }
        }
    }
}
