using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;

namespace DAL
{
    public class RefAdmRepository
    {
        private SqlConnection conn;
        private string spRefAdmSelect = "spRefAdmSelect";
        private string spRefAdmInsert = "spRefAdmInsert";
        private string spRefAdmUpdate = "spRefAdmUpdate";
        private string spRefAdmDelete = "spRefAdmDelete";

        public RefAdmRepository(SqlConnection connection)
        {
            conn = connection;
        }

        private void FillDataRec(SqlDataReader reader, RefAdm adm)
        {
            int resInt = 0;
            if (int.TryParse(reader["RefAdm_Id"].ToString(), out resInt))
            {
                adm.RefAdm_Id = resInt;
            }
            adm.RefAdm_DolNm = reader["RefAdm_DolNm"].ToString();
            adm.RefAdm_TIN = reader["RefAdm_TIN"].ToString();
            adm.RefAdm_FIO = reader["RefAdm_FIO"].ToString();
            adm.RefAdm_OrgCd = reader["RefAdm_OrgCd"].ToString();
            adm.RefAdm_Tel = reader["RefAdm_Tel"].ToString();
        }

        //Получить всю администрацию
        public List<RefAdm> GetAllAdms(out string error)
        {
            error = string.Empty;

            List<RefAdm> refAdms = new List<RefAdm>();

            if (conn == null)
            {
                error = "conn == null";
                return refAdms;
            }

            SqlCommand command = new SqlCommand(spRefAdmSelect, conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    RefAdm refAdm = new RefAdm();
                    FillDataRec(reader, refAdm);
                    refAdms.Add(refAdm);
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
            return refAdms;
        }

        //Получить администрацию по id
        public RefAdm GetAdmById(int id, out string error)
        {
            error = string.Empty;
            RefAdm resRefAdm = null;
            if (conn == null)
            {
                error = "conn == null";
                return null;
            }
            SqlCommand command = new SqlCommand(spRefAdmSelect, conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = conn;
            command.Parameters.AddWithValue("@inRefAdm_Id", id);
            SqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    resRefAdm = new RefAdm();
                    FillDataRec(reader, resRefAdm);
                    //for (int i = 0; i < reader.FieldCount; i++)
                    //{
                    //    FillDataRec(resRefAdm, reader.GetName(i), reader.GetValue(i).ToString());
                    //}
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
            return resRefAdm;
        }
        //Добавить администрацию
        public bool AddAdm(RefAdm adm, out string error)
        {
            error = string.Empty;
            if (adm == null)
            {
                error = "card == null";
                return false;
            }
            if (conn == null)
            {
                error = "conn == null";
                return false;
            }
            SqlCommand command = new SqlCommand(spRefAdmInsert, conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = conn;

            command.Parameters.AddWithValue("@inRefAdm_DolNm", adm.RefAdm_DolNm);
            command.Parameters.AddWithValue("@inRefAdm_TIN", adm.RefAdm_TIN);
            command.Parameters.AddWithValue("@inRefAdm_FIO", adm.RefAdm_FIO);
            command.Parameters.AddWithValue("@inRefAdm_OrgCd", adm.RefAdm_OrgCd);
            command.Parameters.AddWithValue("@inRefAdm_Tel", adm.RefAdm_Tel);

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

        //Изменить администрацию
        public bool ModifyAdm(RefAdm adm, out string error)
        {
            error = string.Empty;
            if (conn == null)
            {
                error = "conn == null";
                return false;
            }
            if (adm == null)
            {
                error = "adm == null";
                return false;
            }
            SqlCommand command = new SqlCommand(spRefAdmUpdate, conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = conn;

            command.Parameters.AddWithValue("@inRefAdm_Id"   , adm.RefAdm_Id);
            command.Parameters.AddWithValue("@inRefAdm_DolNm", adm.RefAdm_DolNm);
            command.Parameters.AddWithValue("@inRefAdm_TIN"  , adm.RefAdm_TIN);
            command.Parameters.AddWithValue("@inRefAdm_FIO"  , adm.RefAdm_FIO);
            command.Parameters.AddWithValue("@inRefAdm_OrgCd", adm.RefAdm_OrgCd);
            command.Parameters.AddWithValue("@inRefAdm_Tel"  , adm.RefAdm_Tel);
           
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
        //Удалить администрацию
        public bool DeleteAdm(int id, out string error)
        {
            error = string.Empty;
            if (conn == null)
            {
                error = "conn == null";
                return false;
            }
            SqlCommand command = new SqlCommand(spRefAdmDelete, conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = conn;
            command.Parameters.AddWithValue("@inRefAdm_Id", id);
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
