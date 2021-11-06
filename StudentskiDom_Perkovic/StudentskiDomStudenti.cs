using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiDom_Perkovic
{
    public class StudentskiDomStudenti : StudentiCRUD
    {

        string sSqlConnectionString = "Server=193.198.57.183; Database= STUDENTI_PIN; Initial Catalog=StudentskiDom_Perkovic; User Id=pin; Password=Vsmti1234!;";
        public List<Studenti> GetStudent()
        {
            var studenti = new List<Studenti>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM [Perkovic_STUDENTI]";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        studenti.Add(new Studenti()
                        {
                            OIB = (string)reader["OIB"],
                            ImeStudenta = (string)reader["ImeStudenta"],
                            PrezimeStudenta = (string)reader["PrezimeStudenta"],
                            Adresa = (string)reader["Adresa"],
                            KontaktBroj = (string)reader["KontaktBroj"]
                        });
                    }
                }
            }
            return studenti;
        }

        public List<Studenti> GetGdjeJeStudent()
        {
            var studenti = new List<Studenti>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * from Perkovic_STUDENTI RIGHT JOIN Perkovic_STUDENT_SOBA ON Perkovic_STUDENTI.OIB = Perkovic_STUDENT_SOBA.OIBStudenta";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        studenti.Add(new Studenti()
                        {
                            OIB = (string)reader["OIB"],
                            ImeStudenta = (string)reader["ImeStudenta"],
                            PrezimeStudenta = (string)reader["PrezimeStudenta"],
                            Adresa = (string)reader["Adresa"],
                            KontaktBroj = (string)reader["KontaktBroj"],
                            OIBStudenta = (string)reader["OIBStudenta"],
                            IdSobe = (string)reader["IdSobe"]
                        });
                    }
                }
            }
            return studenti;
        }

        public void CreateStudent(Studenti studenti)
        {
            string sSqlConnectionString = "Server=193.198.57.183; Database= STUDENTI_PIN; Initial Catalog=StudentskiDom_Perkovic; User Id=pin; Password=Vsmti1234!;";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "INSERT INTO Perkovic_STUDENTI (OIB, ImeStudenta, PrezimeStudenta, Adresa, KontaktBroj) VALUES ('" + studenti.OIB + "', '" + studenti.ImeStudenta + "', '" + studenti.PrezimeStudenta + "', '" + studenti.Adresa + "', '" + studenti.KontaktBroj + "') ";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }
        public void UpdateStudent(Studenti studenti)
        {
            string sSqlConnectionString = "Server=193.198.57.183; Database= STUDENTI_PIN; Initial Catalog=StudentskiDom_Perkovic; User Id=pin; Password=Vsmti1234!;";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "UPDATE Perkovic_STUDENTI SET ImeStudenta = '" + studenti.ImeStudenta + "', PrezimeStudenta = '" + studenti.PrezimeStudenta + "', Adresa = '" + studenti.Adresa + "', KontaktBroj = '" + studenti.KontaktBroj + "' WHERE OIB = '" + studenti.OIB + "'";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }
        public void DeleteStudent(Studenti studenti)
        {
            string sSqlConnectionString = "Server=193.198.57.183; Database= STUDENTI_PIN; Initial Catalog=StudentskiDom_Perkovic; User Id=pin; Password=Vsmti1234!;";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM Perkovic_STUDENTI WHERE OIB =" + studenti.OIB;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }
    }
    
}
