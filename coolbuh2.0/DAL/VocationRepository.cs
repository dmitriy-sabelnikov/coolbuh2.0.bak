using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entities;

namespace DAL
{

    public class VocationRepository
    {
        private SqlConnection conn;
        private string spVocationSelect = "spVocationSelect";
        private string spVocationInsert = "spVocationInsert";
        private string spVocationUpdate = "spVocationUpdate";
        private string spVocationDelete = "spVocationDelete";
        public VocationRepository(SqlConnection connection)
        {
            conn = connection;
        }
        private void FillDataRec(SqlDataReader reader, Vocation vocation)
        {
            int resInt = 0;
            DateTime resDate = DateTime.MinValue;
            decimal resDec = 0;

            if (int.TryParse(reader["Vocation_Id"].ToString(), out resInt))
            {
                vocation.Vocation_Id = resInt;
            }

            if (int.TryParse(reader["Vocation_PersCard_Id"].ToString(), out resInt))
            {
                vocation.Vocation_PersCard_Id = resInt;
            }
            if (int.TryParse(reader["Vocation_RefDep_Id"].ToString(), out resInt))
            {
                vocation.Vocation_RefDep_Id = resInt;
            }
            if (DateTime.TryParse(reader["Vocation_Date"].ToString(), out resDate))
            {
                vocation.Vocation_Date = resDate;
            }
            if (int.TryParse(reader["Vocation_Days"].ToString(), out resInt))
            {
                vocation.Vocation_Days = resInt;
            }
            if (decimal.TryParse(reader["Vocation_Sm"].ToString(), out resDec))
            {
                vocation.Vocation_Sm = resDec;
            }
            if (DateTime.TryParse(reader["Vocation_PayDate"].ToString(), out resDate))
            {
                vocation.Vocation_PayDate = resDate;
            }
            if (decimal.TryParse(reader["Vocation_ResSm"].ToString(), out resDec))
            {
                vocation.Vocation_ResSm = resDec;
            }
        }
        //Получить список отпускных
        public List<Vocation> GetAllVocations(out string error)
        {
            error = string.Empty;

            List<Vocation> vocations = new List<Vocation>();

            if (conn == null)
            {
                error = "conn == null";
                return vocations;
            }

            SqlCommand command = new SqlCommand(spVocationSelect, conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Vocation vocation = new Vocation();
                    FillDataRec(reader, vocation);
                    vocations.Add(vocation);
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
            return vocations;
        }
        //Получить отпускные по параметрам
        public List<Vocation> GetVocationsByParams(int vocation_id, int refDep_id, DateTime vocation_dateBeg, DateTime vocation_dateEnd, out string error)
        {
            error = string.Empty;

            List<Vocation> vocations = new List<Vocation>();

            if (conn == null)
            {
                error = "conn == null";
                return vocations;
            }
            if (vocation_id == 0 && refDep_id == 0 && vocation_dateBeg == DateTime.MinValue && vocation_dateEnd == DateTime.MinValue)
            {
                error = "Не задані вхідні параметри";
                return vocations;
            }
            if (vocation_dateBeg == DateTime.MinValue || vocation_dateEnd == DateTime.MinValue)
            {
                error = "Не заданий період";
                return vocations;
            }

            SqlCommand command = new SqlCommand(spVocationSelect, conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = conn;

            command.Parameters.AddWithValue("@inVocation_Id", vocation_id);
            command.Parameters.AddWithValue("@inVocation_RefDep_Id", refDep_id);
            command.Parameters.AddWithValue("@inVocation_DateBeg", (vocation_dateBeg == DateTime.MinValue) ? Convert.DBNull : vocation_dateBeg);
            command.Parameters.AddWithValue("@inVocation_DateEnd", (vocation_dateEnd == DateTime.MinValue) ? Convert.DBNull : vocation_dateEnd);

            SqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Vocation vocation = new Vocation();
                    FillDataRec(reader, vocation);
                    vocations.Add(vocation);
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            return vocations;
        }
        //Добавить отпускные
        public bool AddVocation(Vocation vocation, out string error)
        {
            error = string.Empty;
            if (vocation == null)
            {
                error = "Vocation == null";
                return false;
            }
            if (conn == null)
            {
                error = "conn == null";
                return false;
            }
            SqlCommand command = new SqlCommand(spVocationInsert, conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = conn;
            command.Parameters.AddWithValue("@inVocation_PersCard_Id", vocation.Vocation_PersCard_Id == 0 ? Convert.DBNull : vocation.Vocation_PersCard_Id);
            command.Parameters.AddWithValue("@inVocation_RefDep_Id", vocation.Vocation_RefDep_Id == 0 ? Convert.DBNull : vocation.Vocation_RefDep_Id);
            command.Parameters.AddWithValue("@inVocation_Date", vocation.Vocation_Date == DateTime.MinValue ? Convert.DBNull : vocation.Vocation_Date);
            command.Parameters.AddWithValue("@inVocation_Days", vocation.Vocation_Days);
            command.Parameters.AddWithValue("@inVocation_Sm", vocation.Vocation_Sm);
            command.Parameters.AddWithValue("@inVocation_PayDate", vocation.Vocation_PayDate == DateTime.MinValue ? Convert.DBNull : vocation.Vocation_PayDate);
            command.Parameters.AddWithValue("@inVocation_ResSm", vocation.Vocation_ResSm);
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
        //Изменить запись отпускных
        public bool ModifyVocation(Vocation vocation, out string error)
        {
            error = string.Empty;
            if (conn == null)
            {
                error = "conn == null";
                return false;
            }
            if (vocation == null)
            {
                error = "vocation == null";
                return false;
            }
            SqlCommand command = new SqlCommand(spVocationUpdate, conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = conn;
            command.Parameters.AddWithValue("@inVocation_Id", vocation.Vocation_Id);
            command.Parameters.AddWithValue("@inVocation_PersCard_Id", vocation.Vocation_PersCard_Id == 0 ? Convert.DBNull : vocation.Vocation_PersCard_Id);
            command.Parameters.AddWithValue("@inVocation_RefDep_Id", vocation.Vocation_RefDep_Id == 0 ? Convert.DBNull : vocation.Vocation_RefDep_Id);
            command.Parameters.AddWithValue("@inVocation_Date", vocation.Vocation_Date == DateTime.MinValue ? Convert.DBNull : vocation.Vocation_Date);
            command.Parameters.AddWithValue("@inVocation_Days", vocation.Vocation_Days);
            command.Parameters.AddWithValue("@inVocation_Sm", vocation.Vocation_Sm);
            command.Parameters.AddWithValue("@inVocation_PayDate", vocation.Vocation_PayDate == DateTime.MinValue ? Convert.DBNull : vocation.Vocation_PayDate);
            command.Parameters.AddWithValue("@inVocation_ResSm", vocation.Vocation_ResSm);
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
        //Удалить запись отпускных
        public bool DeleteVocation(int id, out string error)
        {
            error = string.Empty;
            if (conn == null)
            {
                error = "conn == null";
                return false;
            }
            SqlCommand command = new SqlCommand(spVocationDelete, conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = conn;
            command.Parameters.AddWithValue("@inVocation_Id", id);
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
