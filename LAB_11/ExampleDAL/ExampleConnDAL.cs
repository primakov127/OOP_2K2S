using ExampleDAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleConnectedLayer
{
    public class DisciplineDAL
    {
        private SqlConnection connection = null;
        private string connectionString = null;

        public DisciplineDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void OpenConnection()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                connection = new SqlConnection();
                connection.ConnectionString = @"Data Source=.\SQLEXPRESS;Integrated Security=True";
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(@"CREATE DATABASE CsLab", this.connection))
                {
                    cmd.ExecuteNonQuery();
                }
                connection.ChangeDatabase("CsLab");

                string sql = String.Empty;
                using (StreamReader sr = new StreamReader(@"E:\2k2s\LAB\OOP\LAB_11\New.txt"))
                {
                    sql = sr.ReadToEnd();
                    using (SqlCommand cmd = new SqlCommand(sql, this.connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public void CreateDiscipline(Discipline discipline)
        {
            string sql = string.Format("INSERT INTO Discipline(DisciplineName, Course) Values(@DisciplineName, @Course)");

            using (SqlCommand cmd = new SqlCommand(sql, this.connection))
            {
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@DisciplineName";
                param.Value = discipline.DisciplineName;
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 40;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Course";
                param.Value = discipline.Course;
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteDiscipline(int id)
        {
            string sql = string.Format("DELETE FROM Discipline WHERE Id = '{0}'", id);

            using (SqlCommand cmd = new SqlCommand(sql, this.connection))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Exception error = new Exception("Discipline has not been found", ex);
                    throw error;
                }
            }
        }

        public void UpdateDiscipline(Discipline discipline)
        {
            string sql = string.Format("UPDATE Discipline SET DisciplineName = '{0}', Course = '{1}' WHERE Id = '{2}'",
                discipline.DisciplineName, discipline.Course, discipline.Id);

            using (SqlCommand cmd = new SqlCommand(sql, this.connection))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public List<Discipline> GetAllDisciplines(int page = 1)
        {
            List<Discipline> result = new List<Discipline>();

            string sql = String.Format("SELECT * FROM Discipline ORDER BY Id " +
                                        "OFFSET ((@page - 1) * 2) ROWS " +
                                        "FETCH NEXT 2 ROWS ONLY");

            using (SqlCommand cmd = new SqlCommand(sql, this.connection))
            {
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@page";
                param.Value = page;
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);


                SqlDataReader dr = cmd.ExecuteReader();
                Discipline discipline = null;

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        discipline = new Discipline();

                        discipline.Id = Convert.ToInt32(dr["Id"]);
                        discipline.DisciplineName = dr["DisciplineName"].ToString();
                        discipline.Course = Convert.ToInt32(dr["Course"]);

                        result.Add(discipline);
                    }
                }

                dr.Close();
            }

            return result;
        }
    }

    public class LiteratureDAL
    {
        private SqlConnection connection = null;
        public string connectionString = null;

        public LiteratureDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void OpenConnection()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                connection = new SqlConnection();
                connection.ConnectionString = @"Data Source=.\SQLEXPRESS;Integrated Security=True";
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(@"CREATE DATABASE CsLab", this.connection))
                {
                    cmd.ExecuteNonQuery();
                }
                connection.ChangeDatabase("CsLab");

                string sql = String.Empty;
                using (StreamReader sr = new StreamReader(@"E:\2k2s\LAB\OOP\LAB_11\New.txt"))
                {
                    sql = sr.ReadToEnd();
                    using (SqlCommand cmd = new SqlCommand(sql, this.connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public void CreateLiterature(Literature literature)
        {
            string sql = "INSERT INTO Literature(LiteratureName, DisciplineId, Picture) Values(@LiteratureName, @DisciplineId, @Picture)";

            using (SqlCommand cmd = new SqlCommand(sql, this.connection))
            {
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@LiteratureName";
                param.Value = literature.LiteratureName;
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 40;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@DisciplineId";
                param.Value = literature.DisciplineId;
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Picture";
                param.Value = literature.Picture;
                param.SqlDbType = SqlDbType.Image;
                param.Size = literature.Picture.Length;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteLiterature(int id)
        {
            string sql = string.Format("DELETE FROM Literature WHERE Id = '{0}'", id);

            using (SqlCommand cmd = new SqlCommand(sql, this.connection))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Exception error = new Exception("Literature has not been found", ex);
                    throw error;
                }
            }
        }

        public void UpdateLiterature(Literature literature)
        {
            string sql = "UPDATE Literature SET DisciplineId = @DisciplineId, Picture = @Picture, LiteratureName = @LiteratureName WHERE Id = @Id";

            using (SqlCommand cmd = new SqlCommand(sql, this.connection))
            {

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@LiteratureName";
                param.Value = literature.LiteratureName;
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 40;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@DisciplineId";
                param.Value = literature.DisciplineId;
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Picture";
                param.Value = literature.Picture;
                param.SqlDbType = SqlDbType.Image;
                param.Size = literature.Picture.Length;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Id";
                param.Value = literature.Id;
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Literature> GetAllLiteratures()
        {
            List<Literature> result = new List<Literature>();

            string sql = "SELECT * FROM Literature";

            using (SqlCommand cmd = new SqlCommand(sql, this.connection))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                Literature literature = null;

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        literature = new Literature();

                        literature.Id = Convert.ToInt32(dr["Id"]);
                        literature.LiteratureName = dr["LiteratureName"].ToString();
                        literature.Picture = (byte[])dr["Picture"];
                        literature.DisciplineId = Convert.ToInt32(dr["DisciplineId"]);

                        result.Add(literature);
                    }
                }

                dr.Close();
            }

            return result;
        }

        // Stored procedure
        public string GetLiteratureNameById(int literatureId)
        {
            string result = String.Empty;

            using (SqlCommand cmd = new SqlCommand("GetLiteratureName", this.connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@literatureID";
                param.SqlDbType = SqlDbType.Int;
                param.Value = literatureId;
                param.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@literatureName";
                param.SqlDbType = SqlDbType.Char;
                param.Size = 10;
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();
                // Возврат выходного параметра.
                result = ((string)cmd.Parameters["@literatureName"].Value).Trim();
            }
            return result;
        }
    }
}
