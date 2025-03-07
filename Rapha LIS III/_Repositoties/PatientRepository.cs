using Microsoft.Data.SqlClient;
using Rapha_LIS_III.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rapha_LIS_III._Repositoties
{
    public class PatientRepository : BaseRepository, IPatientRepository
    {
        public PatientRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(PatientModel patientModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(PatientModel patientModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PatientModel> GetAll()
        {
            var patientList = new List<PatientModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Patient ORDER BY created_at DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var patientModel = new PatientModel();
                        patientModel.FirstName = reader[0].ToString();
                        patientModel.LastName = reader[1].ToString();
                        patientModel.MiddleName = reader[2].ToString();
                        patientModel.Age = Convert.ToInt32(reader[3]);
                        patientModel.Sex = reader[4].ToString();
                        patientModel.Address = reader[5].ToString();
                        patientModel.CivilStatus = reader[6].ToString();
                        patientModel.Religion = reader[7].ToString();
                        patientModel.Contact = reader[8].ToString();
                        patientModel.Test = reader[9].ToString();
                        patientList.Add(patientModel);
                    }
                }
            }
            return patientList;
        }


        public IEnumerable<PatientModel> GetByValue(string value)
        {
            var patientList = new List<PatientModel>();
            string patientName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"    
                                        SELECT * FROM Patient
                                        WHERE last_name LIKE @last_name + '%'
                                        ORDER BY created_at DESC";
                command.Parameters.Add("@last_name", SqlDbType.NVarChar).Value = patientName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var patientModel = new PatientModel();
                        patientModel.FirstName = reader[0].ToString();
                        patientModel.LastName = reader[1].ToString();
                        patientModel.MiddleName = reader[2].ToString();
                        patientModel.Age = Convert.ToInt32(reader[3]);
                        patientModel.Sex = reader[4].ToString();
                        patientModel.Address = reader[5].ToString();
                        patientModel.CivilStatus = reader[6].ToString();
                        patientModel.Religion = reader[7].ToString();
                        patientModel.Contact = reader[8].ToString();
                        patientModel.Test = reader[9].ToString();
                        patientList.Add(patientModel);
                    }
                }
            }
            return patientList;
        }
    }
    
}
