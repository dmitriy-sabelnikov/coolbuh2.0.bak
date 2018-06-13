using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;

namespace DAL
{
    public class PersCardRepository
    {
        private SqlConnection conn;
        private string spPersCardSelect = "spPersCardSelect";
        private string spPersCardInsert = "spPersCardInsert";
        private string spPersCardUpdate = "spPersCardUpdate";
        private string spPersCardDelete = "spPersCardDelete";

        private void FillDataRec(SqlDataReader reader, PersCard card)
        {
            int resInt = 0;
            DateTime resDt = DateTime.MinValue;

            if (int.TryParse(reader["PersCard_Id"].ToString(), out resInt))
            {
                card.PersCard_Id = resInt;
            }
            card.PersCard_FName = reader["PersCard_FName"].ToString();
            card.PersCard_MName = reader["PersCard_MName"].ToString();
            card.PersCard_LName = reader["PersCard_LName"].ToString();
            card.PersCard_TIN   = reader["PersCard_TIN"].ToString();
            if (int.TryParse(reader["PersCard_Exp"].ToString(), out resInt))
            {
                card.PersCard_Exp = resInt;
            }
            if (int.TryParse(reader["PersCard_Grade"].ToString(), out resInt))
            {
                card.PersCard_Grade = resInt;
            }
            if (int.TryParse(reader["PersCard_Grade"].ToString(), out resInt))
            {
                card.PersCard_Grade = resInt;
            }
            if (DateTime.TryParse(reader["PersCard_DOB"].ToString(), out resDt))
            {
                card.PersCard_DOB = resDt;
            }
            if (DateTime.TryParse(reader["PersCard_DOR"].ToString(), out resDt))
            {
                card.PersCard_DOR = resDt;
            }
            if (DateTime.TryParse(reader["PersCard_DOD"].ToString(), out resDt))
            {
                card.PersCard_DOD = resDt;
            }
            //if (int.TryParse(reader["PersCard_Pens"].ToString(), out resInt))
            //{
            //    card.PersCard_Pens = resInt;
            //}
            if (DateTime.TryParse(reader["PersCard_DOP"].ToString(), out resDt))
            {
                card.PersCard_DOP = resDt;
            }
            if (int.TryParse(reader["PersCard_ChldM1"].ToString(), out resInt))
            {
                card.PersCard_ChldM1 = resInt;
            }
            if (int.TryParse(reader["PersCard_ChldM2"].ToString(), out resInt))
            {
                card.PersCard_ChldM2 = resInt;
            }
            if (int.TryParse(reader["PersCard_ChldM3"].ToString(), out resInt))
            {
                card.PersCard_ChldM3 = resInt;
            }
            if (int.TryParse(reader["PersCard_ChldM4"].ToString(), out resInt))
            {
                card.PersCard_ChldM4 = resInt;
            }
            if (int.TryParse(reader["PersCard_ChldM5"].ToString(), out resInt))
            {
                card.PersCard_ChldM5 = resInt;
            }
            if (int.TryParse(reader["PersCard_ChldM6"].ToString(), out resInt))
            {
                card.PersCard_ChldM6 = resInt;
            }
            if (int.TryParse(reader["PersCard_ChldM7"].ToString(), out resInt))
            {
                card.PersCard_ChldM7 = resInt;
            }
            if (int.TryParse(reader["PersCard_ChldM8"].ToString(), out resInt))
            {
                card.PersCard_ChldM8 = resInt;
            }
            if (int.TryParse(reader["PersCard_ChldM9"].ToString(), out resInt))
            {
                card.PersCard_ChldM9 = resInt;
            }
            if (int.TryParse(reader["PersCard_ChldM10"].ToString(), out resInt))
            {
                card.PersCard_ChldM10 = resInt;
            }
            if (int.TryParse(reader["PersCard_ChldM11"].ToString(), out resInt))
            {
                card.PersCard_ChldM11 = resInt;
            }
            if (int.TryParse(reader["PersCard_ChldM12"].ToString(), out resInt))
            {
                card.PersCard_ChldM12 = resInt;
            }
            /*
            if (int.TryParse(reader["PersCard_SpecExpIdM1"].ToString(), out resInt))
            {
                card.PersCard_SpecExpIdM1 = resInt;
            }
            if (int.TryParse(reader["PersCard_SpecExpIdM2"].ToString(), out resInt))
            {
                card.PersCard_SpecExpIdM2 = resInt;
            }
            if (int.TryParse(reader["PersCard_SpecExpIdM3"].ToString(), out resInt))
            {
                card.PersCard_SpecExpIdM3 = resInt;
            }
            if (int.TryParse(reader["PersCard_SpecExpIdM4"].ToString(), out resInt))
            {
                card.PersCard_SpecExpIdM4 = resInt;
            }
            if (int.TryParse(reader["PersCard_SpecExpIdM5"].ToString(), out resInt))
            {
                card.PersCard_SpecExpIdM5 = resInt;
            }
            if (int.TryParse(reader["PersCard_SpecExpIdM6"].ToString(), out resInt))
            {
                card.PersCard_SpecExpIdM6 = resInt;
            }
            if (int.TryParse(reader["PersCard_SpecExpIdM7"].ToString(), out resInt))
            {
                card.PersCard_SpecExpIdM7 = resInt;
            }
            if (int.TryParse(reader["PersCard_SpecExpIdM8"].ToString(), out resInt))
            {
                card.PersCard_SpecExpIdM8 = resInt;
            }
            if (int.TryParse(reader["PersCard_SpecExpIdM9"].ToString(), out resInt))
            {
                card.PersCard_SpecExpIdM9 = resInt;
            }
            if (int.TryParse(reader["PersCard_SpecExpIdM10"].ToString(), out resInt))
            {
                card.PersCard_SpecExpIdM10 = resInt;
            }
            if (int.TryParse(reader["PersCard_SpecExpIdM11"].ToString(), out resInt))
            {
                card.PersCard_SpecExpIdM11 = resInt;
            }
            if (int.TryParse(reader["PersCard_SpecExpIdM12"].ToString(), out resInt))
            {
                card.PersCard_SpecExpIdM12 = resInt;
            }
            */
        }

        public PersCardRepository(SqlConnection connection)
        {
            conn = connection;
        }
        //Получить все карточки
        public List<PersCard> GetAllCards(out string error)
        {
            error = string.Empty;

            List<PersCard> persCards = new List<PersCard>();

            if (conn == null)
            {
                error = "conn == null";
                return persCards;
            }

            SqlCommand command = new SqlCommand(this.spPersCardSelect, conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PersCard persCard = new PersCard();
                    FillDataRec(reader, persCard);
                    persCards.Add(persCard);
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
            return persCards;
        }
        //Получить карточку по id
        public PersCard GetCardById(int id, out string error)
        {
            error = string.Empty;
            PersCard resPersDep = null;
            if (conn == null)
            {
                error = "conn == null";
                return null;
            }
            SqlCommand command = new SqlCommand(spPersCardSelect, conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = conn;
            command.Parameters.AddWithValue("@inPersCard_Id", id);
            SqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    resPersDep = new PersCard();
                    FillDataRec(reader, resPersDep);
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
            return resPersDep;
        }
        //Добавить карточку
        public bool AddCard(PersCard card, out string error)
        {
            error = string.Empty;
            if (card == null)
            {
                error = "card == null";
                return false;
            }
            if (conn == null)
            {
                error = "conn == null";
                return false;
            }
            SqlCommand command = new SqlCommand(spPersCardInsert, conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = conn;
            command.Parameters.AddWithValue("@inPersCard_FName", card.PersCard_FName);
            command.Parameters.AddWithValue("@inPersCard_MName", card.PersCard_MName);
            command.Parameters.AddWithValue("@inPersCard_LName", card.PersCard_LName);
            command.Parameters.AddWithValue("@inPersCard_TIN",   card.PersCard_TIN);
            command.Parameters.AddWithValue("@inPersCard_Exp",   card.PersCard_Exp);
            command.Parameters.AddWithValue("@inPersCard_Grade", card.PersCard_Grade);
            command.Parameters.AddWithValue("@inPersCard_DOB",   card.PersCard_DOB == DateTime.MinValue ? Convert.DBNull : card.PersCard_DOB);
            command.Parameters.AddWithValue("@inPersCard_DOR",   card.PersCard_DOR == DateTime.MinValue ? Convert.DBNull : card.PersCard_DOR);
            command.Parameters.AddWithValue("@inPersCard_DOD",   card.PersCard_DOD == DateTime.MinValue ? Convert.DBNull : card.PersCard_DOD);
            command.Parameters.AddWithValue("@inPersCard_DOP",   card.PersCard_DOP == DateTime.MinValue ? Convert.DBNull : card.PersCard_DOP);
            //command.Parameters.AddWithValue("@inPersCard_Pens",   card.PersCard_Pens);
            command.Parameters.AddWithValue("@inPersCard_ChldM1", card.PersCard_ChldM1);
            command.Parameters.AddWithValue("@inPersCard_ChldM2", card.PersCard_ChldM2);
            command.Parameters.AddWithValue("@inPersCard_ChldM3", card.PersCard_ChldM3);
            command.Parameters.AddWithValue("@inPersCard_ChldM4", card.PersCard_ChldM4);
            command.Parameters.AddWithValue("@inPersCard_ChldM5", card.PersCard_ChldM5);
            command.Parameters.AddWithValue("@inPersCard_ChldM6", card.PersCard_ChldM6);
            command.Parameters.AddWithValue("@inPersCard_ChldM7", card.PersCard_ChldM7);
            command.Parameters.AddWithValue("@inPersCard_ChldM8", card.PersCard_ChldM8);
            command.Parameters.AddWithValue("@inPersCard_ChldM9", card.PersCard_ChldM9);
            command.Parameters.AddWithValue("@inPersCard_ChldM10", card.PersCard_ChldM10);
            command.Parameters.AddWithValue("@inPersCard_ChldM11", card.PersCard_ChldM11);
            command.Parameters.AddWithValue("@inPersCard_ChldM12", card.PersCard_ChldM12);
            //command.Parameters.AddWithValue("@inPersCard_SpecExpIdM1", card.PersCard_SpecExpIdM1 == 0 ? Convert.DBNull : card.PersCard_SpecExpIdM1);
            //command.Parameters.AddWithValue("@inPersCard_SpecExpIdM2", card.PersCard_SpecExpIdM2 == 0 ? Convert.DBNull : card.PersCard_SpecExpIdM2);
            //command.Parameters.AddWithValue("@inPersCard_SpecExpIdM3", card.PersCard_SpecExpIdM3 == 0 ? Convert.DBNull : card.PersCard_SpecExpIdM3);
            //command.Parameters.AddWithValue("@inPersCard_SpecExpIdM4", card.PersCard_SpecExpIdM4 == 0 ? Convert.DBNull : card.PersCard_SpecExpIdM4);
            //command.Parameters.AddWithValue("@inPersCard_SpecExpIdM5", card.PersCard_SpecExpIdM5 == 0 ? Convert.DBNull : card.PersCard_SpecExpIdM5);
            //command.Parameters.AddWithValue("@inPersCard_SpecExpIdM6", card.PersCard_SpecExpIdM6 == 0 ? Convert.DBNull : card.PersCard_SpecExpIdM6);
            //command.Parameters.AddWithValue("@inPersCard_SpecExpIdM7", card.PersCard_SpecExpIdM7 == 0 ? Convert.DBNull : card.PersCard_SpecExpIdM7);
            //command.Parameters.AddWithValue("@inPersCard_SpecExpIdM8", card.PersCard_SpecExpIdM8 == 0 ? Convert.DBNull : card.PersCard_SpecExpIdM8);
            //command.Parameters.AddWithValue("@inPersCard_SpecExpIdM9", card.PersCard_SpecExpIdM9 == 0 ? Convert.DBNull : card.PersCard_SpecExpIdM9);
            //command.Parameters.AddWithValue("@inPersCard_SpecExpIdM10", card.PersCard_SpecExpIdM10 == 0 ? Convert.DBNull : card.PersCard_SpecExpIdM10);
            //command.Parameters.AddWithValue("@inPersCard_SpecExpIdM11", card.PersCard_SpecExpIdM11 == 0 ? Convert.DBNull : card.PersCard_SpecExpIdM11);
            //command.Parameters.AddWithValue("@inPersCard_SpecExpIdM12", card.PersCard_SpecExpIdM12 == 0 ? Convert.DBNull : card.PersCard_SpecExpIdM12);
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
        //Изменить карточку
        public bool ModifyCard(PersCard card, out string error)
        {
            error = string.Empty;
            if (conn == null)
            {
                error = "conn == null";
                return false;
            }
            if (card == null)
            {
                error = "card == null";
                return false;
            }
            SqlCommand command = new SqlCommand(spPersCardUpdate, conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = conn;
            command.Parameters.AddWithValue("@inPersCard_Id"   , card.PersCard_Id);
            command.Parameters.AddWithValue("@inPersCard_FName", card.PersCard_FName);
            command.Parameters.AddWithValue("@inPersCard_MName", card.PersCard_MName);
            command.Parameters.AddWithValue("@inPersCard_LName", card.PersCard_LName);
            command.Parameters.AddWithValue("@inPersCard_TIN"  , card.PersCard_TIN);
            command.Parameters.AddWithValue("@inPersCard_Exp"  , card.PersCard_Exp);
            command.Parameters.AddWithValue("@inPersCard_Grade", card.PersCard_Grade);
            command.Parameters.AddWithValue("@inPersCard_DOB",  card.PersCard_DOB == DateTime.MinValue ? Convert.DBNull : card.PersCard_DOB);
            command.Parameters.AddWithValue("@inPersCard_DOR",  card.PersCard_DOR == DateTime.MinValue ? Convert.DBNull : card.PersCard_DOR);
            command.Parameters.AddWithValue("@inPersCard_DOD",  card.PersCard_DOD == DateTime.MinValue ? Convert.DBNull : card.PersCard_DOD);
            command.Parameters.AddWithValue("@inPersCard_DOP",  card.PersCard_DOP == DateTime.MinValue ? Convert.DBNull : card.PersCard_DOP);
            //command.Parameters.AddWithValue("@inPersCard_Pens", card.PersCard_Pens);
            command.Parameters.AddWithValue("@inPersCard_ChldM1", card.PersCard_ChldM1);
            command.Parameters.AddWithValue("@inPersCard_ChldM2", card.PersCard_ChldM2);
            command.Parameters.AddWithValue("@inPersCard_ChldM3", card.PersCard_ChldM3);
            command.Parameters.AddWithValue("@inPersCard_ChldM4", card.PersCard_ChldM4);
            command.Parameters.AddWithValue("@inPersCard_ChldM5", card.PersCard_ChldM5);
            command.Parameters.AddWithValue("@inPersCard_ChldM6", card.PersCard_ChldM6);
            command.Parameters.AddWithValue("@inPersCard_ChldM7", card.PersCard_ChldM7);
            command.Parameters.AddWithValue("@inPersCard_ChldM8", card.PersCard_ChldM8);
            command.Parameters.AddWithValue("@inPersCard_ChldM9", card.PersCard_ChldM9);
            command.Parameters.AddWithValue("@inPersCard_ChldM10", card.PersCard_ChldM10);
            command.Parameters.AddWithValue("@inPersCard_ChldM11", card.PersCard_ChldM11);
            command.Parameters.AddWithValue("@inPersCard_ChldM12", card.PersCard_ChldM12);
            //command.Parameters.AddWithValue("@inPersCard_SpecExpIdM1", card.PersCard_SpecExpIdM1 == 0 ? Convert.DBNull : card.PersCard_SpecExpIdM1);
            //command.Parameters.AddWithValue("@inPersCard_SpecExpIdM2", card.PersCard_SpecExpIdM2 == 0 ? Convert.DBNull : card.PersCard_SpecExpIdM2);
            //command.Parameters.AddWithValue("@inPersCard_SpecExpIdM3", card.PersCard_SpecExpIdM3 == 0 ? Convert.DBNull : card.PersCard_SpecExpIdM3);
            //command.Parameters.AddWithValue("@inPersCard_SpecExpIdM4", card.PersCard_SpecExpIdM4 == 0 ? Convert.DBNull : card.PersCard_SpecExpIdM4);
            //command.Parameters.AddWithValue("@inPersCard_SpecExpIdM5", card.PersCard_SpecExpIdM5 == 0 ? Convert.DBNull : card.PersCard_SpecExpIdM5);
            //command.Parameters.AddWithValue("@inPersCard_SpecExpIdM6", card.PersCard_SpecExpIdM6 == 0 ? Convert.DBNull : card.PersCard_SpecExpIdM6);
            //command.Parameters.AddWithValue("@inPersCard_SpecExpIdM7", card.PersCard_SpecExpIdM7 == 0 ? Convert.DBNull : card.PersCard_SpecExpIdM7);
            //command.Parameters.AddWithValue("@inPersCard_SpecExpIdM8", card.PersCard_SpecExpIdM8 == 0 ? Convert.DBNull : card.PersCard_SpecExpIdM8);
            //command.Parameters.AddWithValue("@inPersCard_SpecExpIdM9", card.PersCard_SpecExpIdM9 == 0 ? Convert.DBNull : card.PersCard_SpecExpIdM9);
            //command.Parameters.AddWithValue("@inPersCard_SpecExpIdM10", card.PersCard_SpecExpIdM10 == 0 ? Convert.DBNull : card.PersCard_SpecExpIdM10);
            //command.Parameters.AddWithValue("@inPersCard_SpecExpIdM11", card.PersCard_SpecExpIdM11 == 0 ? Convert.DBNull : card.PersCard_SpecExpIdM11);
            //command.Parameters.AddWithValue("@inPersCard_SpecExpIdM12", card.PersCard_SpecExpIdM12 == 0 ? Convert.DBNull : card.PersCard_SpecExpIdM12);
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
        //Удалить карточку
        public bool DeleteCard(int id, out string error)
        {
            error = string.Empty;
            if (conn == null)
            {
                error = "conn == null";
                return false;
            }
            SqlCommand command = new SqlCommand(spPersCardDelete, conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = conn;
            command.Parameters.AddWithValue("@inPersCard_Id", id);
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
