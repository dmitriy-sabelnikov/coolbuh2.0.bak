using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;

namespace DAL
{
    public class RefSpecExpRepository
    {
        private SqlConnection conn;
        private string spRefSpecExpSelect = "spRefSpecExpSelect";
        private string spRefSpecExpInsert = "spRefSpecExpInsert";
        private string spRefSpecExpUpdate = "spRefSpecExpUpdate";
        private string spRefSpecExpDelete = "spRefSpecExpDelete";
        public RefSpecExpRepository(SqlConnection connection)
        {
            conn = connection;
        }
        private void FillDataRec(SqlDataReader reader, RefSpecExp specExp)
        {
            int resInt = 0;
            if (int.TryParse(reader["RefSpecExp_Id"].ToString(), out resInt))
            {
                specExp.RefSpecExp_Id = resInt;
            }
            specExp.RefSpecExp_Cd = reader["RefSpecExp_Cd"].ToString();
            specExp.RefSpecExp_ShortName = reader["RefSpecExp_ShortName"].ToString();
            specExp.RefSpecExp_Name = reader["RefSpecExp_Name"].ToString();
        }

        //Получить справочник спец стажа
        public List<RefSpecExp> GetAllSpecExps(out string error)
        {
            error = string.Empty;

            List<RefSpecExp> refSpecExps = new List<RefSpecExp>();

            if (conn == null)
            {
                error = "conn == null";
                return refSpecExps;
            }

            SqlCommand command = new SqlCommand(spRefSpecExpSelect, conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    RefSpecExp refSpecExp = new RefSpecExp();
                    FillDataRec(reader, refSpecExp);
                    refSpecExps.Add(refSpecExp);
                }
            }
            catch (Exception exc)
            {
                error = exc.Message;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            return refSpecExps;
        }
        //Получить строку спец стажа по id
        public RefSpecExp GetSpecExpById(int id, out string error)
        {
            error = string.Empty;
            RefSpecExp resRefSpecExp = null;
            if (conn == null)
            {
                error = "conn == null";
                return null;
            }
            SqlCommand command = new SqlCommand(this.spRefSpecExpSelect, conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = conn;
            command.Parameters.AddWithValue("@inRefSpecExp_Id", id);
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    resRefSpecExp = new RefSpecExp();
                    FillDataRec(reader, resRefSpecExp);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return resRefSpecExp;
        }
        //Добавить спец стаж
        public bool AddSpecExp(RefSpecExp specExp, out string error)
        {
            error = string.Empty;
            if (specExp == null)
            {
                error = "specExp == null";
                return false;
            }
            if (conn == null)
            {
                error = "conn == null";
                return false;
            }
            SqlCommand command = new SqlCommand(spRefSpecExpInsert, conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = conn;

            command.Parameters.AddWithValue("@inRefSpecExp_Cd"       , specExp.RefSpecExp_Cd);
            command.Parameters.AddWithValue("@inRefSpecExp_ShortName", specExp.RefSpecExp_ShortName);
            command.Parameters.AddWithValue("@inRefSpecExp_Name"     , specExp.RefSpecExp_Name);
 
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            return true;
        }
        //Изменить спец стаж
        public bool ModifySpecExp(RefSpecExp specExp, out string error)
        {
            error = string.Empty;
            if (conn == null)
            {
                error = "conn == null";
                return false;
            }
            if (specExp == null)
            {
                error = "specExp == null";
                return false;
            }
            SqlCommand command = new SqlCommand(this.spRefSpecExpUpdate, conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = conn;

            command.Parameters.AddWithValue("@inRefSpecExp_Id"       , specExp.RefSpecExp_Id);
            command.Parameters.AddWithValue("@inRefSpecExp_Cd"       , specExp.RefSpecExp_Cd);
            command.Parameters.AddWithValue("@inRefSpecExp_ShortName", specExp.RefSpecExp_ShortName);
            command.Parameters.AddWithValue("@inRefSpecExp_Name"     , specExp.RefSpecExp_Name);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            return true;
        }
        //Удалить спец стаж
        public bool DeleteSpecExp(int id, out string error)
        {
            error = string.Empty;
            if (conn == null)
            {
                error = "conn == null";
                return false;
            }
            SqlCommand command = new SqlCommand(spRefSpecExpDelete, conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = conn;
            command.Parameters.AddWithValue("@inRefSpecExp_Id", id);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            return true;
        }
    }
}
