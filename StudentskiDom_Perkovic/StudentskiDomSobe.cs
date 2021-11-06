using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiDom_Perkovic
{
    public class StudentskiDomSobe : SobeCRUD
    {
        string sSqlConnectionString = "Server=193.198.57.183; Database= STUDENTI_PIN; Initial Catalog=StudentskiDom_Perkovic; User Id=pin; Password=Vsmti1234!;";
        public List<Soba> GetSobe()
        {
            var soba = new List<Soba>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM [Perkovic_SOBE]";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        soba.Add(new Soba()
                        {
                            IdSobe = (string)reader["IdSobe"],
                            KapacitetniBrojKreveta = (string)reader["KapacitetniBrojKreveta"],
                            BojaSobe = (string)reader["BojaSobe"],
                            KatSobe = (string)reader["KatSobe"]
                        });
                    }
                }
            }
            return soba;
        }
        public void CreateSobe(Soba soba)
        {
            string sSqlConnectionString = "Server=193.198.57.183; Database= STUDENTI_PIN; Initial Catalog=StudentskiDom_Perkovic; User Id=pin; Password=Vsmti1234!;";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "INSERT INTO Perkovic_SOBE (IdSobe, KapacitetniBrojKreveta, BojaSobe, KatSobe) VALUES ('" + soba.IdSobe + "','" + soba.KapacitetniBrojKreveta + "', '" + soba.BojaSobe + "', '" + soba.KatSobe + "') ";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }
        public void UpdateSobe(Soba soba)
        {
            string sSqlConnectionString = "Server=193.198.57.183; Database= STUDENTI_PIN; Initial Catalog=StudentskiDom_Perkovic; User Id=pin; Password=Vsmti1234!;";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "UPDATE Perkovic_SOBE SET KapacitetniBrojKreveta = '" + soba.KapacitetniBrojKreveta + "', BojaSobe = '" + soba.BojaSobe + "', KatSobe = '" + soba.KatSobe + "' WHERE IdSobe = '" + soba.IdSobe +"'";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }
        public void DeleteSobe(Soba soba)
        {
            string sSqlConnectionString = "Server=193.198.57.183; Database= STUDENTI_PIN; Initial Catalog=StudentskiDom_Perkovic; User Id=pin; Password=Vsmti1234!;";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM Perkovic_SOBE WHERE IdSobe ='" + soba.IdSobe+"'";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }
    }
}
