using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
_______________________________________________

Ime i prezime: Brigita Perković
Godina i smijer: 2. Programsko inženjerstvo
Studentska godina: 2020./21.
Kolegij: .NET
________________________________________________
 
 */

namespace StudentskiDom_Perkovic
{
    public class StudentskiDomStudentiPoSobama : StudentiPoSobamaCRUD
    {
        string sSqlConnectionString = "Server=193.198.57.183; Database= STUDENTI_PIN; Initial Catalog=StudentskiDom_Perkovic; User Id=pin; Password=Vsmti1234!;";
        public List<StudentiPoSobama> GetStudentiPoSobama()
        {
            var studentiPoSobama = new List<StudentiPoSobama>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                
                command.CommandText = "SELECT * FROM [Perkovic_STUDENT_SOBA]";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        studentiPoSobama.Add(new StudentiPoSobama()
                        {
                            OIBStudenta = (string)reader["OIBStudenta"],
                            IdSobe = (string)reader["IdSobe"]    
                        });
                    }
                }
            }
            return studentiPoSobama;
        }

        public List<Studenti>  GetStudentiIzSobe(string idSoba)
        {
            var studenti = new List<Studenti>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT OIB, ImeStudenta, PrezimeStudenta, Adresa, KontaktBroj FROM Perkovic_STUDENTI, Perkovic_STUDENT_SOBA WHERE Perkovic_STUDENTI.OIB = Perkovic_STUDENT_SOBA.OIBStudenta AND Perkovic_STUDENT_SOBA.IdSobe = '" + idSoba + "'";
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

        public List<Studenti> GetStudentiBezSobe()
        {
            var studenti = new List<Studenti>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Perkovic_STUDENTI WHERE Perkovic_STUDENTI.OIB NOT IN(SELECT Perkovic_STUDENT_SOBA.OIBStudenta FROM Perkovic_STUDENT_SOBA)";
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



        public void CreateStudentiPoSobama(string oibStudenta, string idSobe)
        {
            string sSqlConnectionString = "Server=193.198.57.183; Database= STUDENTI_PIN; Initial Catalog=StudentskiDom_Perkovic; User Id=pin; Password=Vsmti1234!;";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "INSERT INTO Perkovic_STUDENT_SOBA (OIBStudenta, IdSobe) VALUES ('" + oibStudenta + "', '" + idSobe + "')";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }
        public void UpdateStudentiPoSobama(string oibStudenta, string idSobe)
        {
            string sSqlConnectionString = "Server=193.198.57.183; Database= STUDENTI_PIN; Initial Catalog=StudentskiDom_Perkovic; User Id=pin; Password=Vsmti1234!;";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "UPDATE Perkovic_STUDENT_SOBA SET OIBStudenta = '" + oibStudenta + "' WHERE IdSobe = '" + idSobe + "'AND OIB";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }
        public void DeleteStudentiPoSobama(string oibStudenta, string idSobe)
        {
            string sSqlConnectionString = "Server=193.198.57.183; Database= STUDENTI_PIN; Initial Catalog=StudentskiDom_Perkovic; User Id=pin; Password=Vsmti1234!;";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM Perkovic_STUDENT_SOBA WHERE OIBStudenta ='" + oibStudenta + "' AND  IdSobe = '" + idSobe + "'";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }
    }
}
