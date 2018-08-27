using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BootStrapLogInPage
{
    public class DataAccess
    {
        SqlConnection strConnString = new SqlConnection(ConfigurationManager.ConnectionStrings["SiteSqlServer"].ConnectionString);

        SqlCommand com;
        SqlParameter Name, Email, Username, PassWord, RoleID, TaskID, Title, UserID, IsCompleted;

        #region Users

        public int IsInsertUSers(string name, string email, string UserName, string Password, int role)
        {
            com = new SqlCommand();
            com.Connection = strConnString;
            if (strConnString.State == ConnectionState.Closed)
                strConnString.Open();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_InsertUsers";

            Name = new SqlParameter();
            Name.SqlDbType = SqlDbType.VarChar;
            Name.Size = 100;
            Name.ParameterName = "@Name";
            Name.Value = name;
            Name.Direction = ParameterDirection.Input;

            Email = new SqlParameter();
            Email.SqlDbType = SqlDbType.VarChar;
            Email.Size = 100;
            Email.ParameterName = "@email";
            Email.Value = email;
            Email.Direction = ParameterDirection.Input;

            Username = new SqlParameter();
            Username.SqlDbType = SqlDbType.VarChar;
            Username.Size = 50;
            Username.ParameterName = "@username";
            Username.Value = UserName;
            Username.Direction = ParameterDirection.Input;

            PassWord = new SqlParameter();
            PassWord.SqlDbType = SqlDbType.VarChar;
            PassWord.Size = 100;
            PassWord.ParameterName = "@Password";
            PassWord.Value = Password;
            PassWord.Direction = ParameterDirection.Input;

            RoleID = new SqlParameter();
            RoleID.SqlDbType = SqlDbType.Int;
            RoleID.Size = 50;
            RoleID.ParameterName = "@roleID";
            RoleID.Value = role;
            RoleID.Direction = ParameterDirection.Input;

            com.Parameters.Add(Name);
            com.Parameters.Add(Email);
            com.Parameters.Add(Username);
            com.Parameters.Add(PassWord);
            com.Parameters.Add(RoleID);

            int status;
            try
            {
                status = Convert.ToInt16(com.ExecuteScalar());
            }
            catch (Exception e)
            {
                string mess = e.Message;
                status = -1;
            }
            finally
            {
                strConnString.Close();
            }
            return status;
        }

        public int IsValidUser(string userName, string passWord)
        {
            com = new SqlCommand();
            com.Connection = strConnString;
            if (strConnString.State == ConnectionState.Closed)
                strConnString.Open();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_IsUserValid";

            Username = new SqlParameter();
            Username.SqlDbType = SqlDbType.VarChar;
            Username.Size = 50;
            Username.ParameterName = "@UserName";
            Username.Value = userName;
            Username.Direction = ParameterDirection.Input;

            PassWord = new SqlParameter();
            PassWord.SqlDbType = SqlDbType.VarChar;
            PassWord.Size = 50;
            PassWord.ParameterName = "@Password";
            PassWord.Value = passWord;
            PassWord.Direction = ParameterDirection.Input;

            com.Parameters.Add(Username);
            com.Parameters.Add(PassWord);

            int status;
            try
            {
                status = Convert.ToInt16(com.ExecuteScalar());
            }
            catch (Exception e)
            {
                string mess = e.Message;
                status = -1;
            }
            finally
            {
                strConnString.Close();
            }
            return status;
        }

        #endregion

        #region Tasks

        public DataSet GetTasks()
        {
            com = new SqlCommand();
            com.Connection = strConnString;
            if (strConnString.State == ConnectionState.Closed)
                strConnString.Open();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "[sp_GetTasks]";
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet dsTasks = new DataSet();
            da.Fill(dsTasks);
            return dsTasks;
        }

        public int IsInsertTasks(string title, int userID, bool Iscompleted)
        {
            com = new SqlCommand();
            com.Connection = strConnString;
            if (strConnString.State == ConnectionState.Closed)
                strConnString.Open();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "[sp_InsertTasks]";

            Title = new SqlParameter();
            Title.SqlDbType = SqlDbType.VarChar;
            Title.Size = 100;
            Title.ParameterName = "@title";
            Title.Value = title;
            Title.Direction = ParameterDirection.Input;

            UserID = new SqlParameter();
            UserID.SqlDbType = SqlDbType.Int;
            UserID.ParameterName = "@userID";
            UserID.Value = userID;
            UserID.Direction = ParameterDirection.Input;

            IsCompleted = new SqlParameter();
            IsCompleted.SqlDbType = SqlDbType.Bit;
            IsCompleted.ParameterName = "@IsCompleted";
            IsCompleted.Value = Iscompleted;
            IsCompleted.Direction = ParameterDirection.Input;


            com.Parameters.Add(Title);
            com.Parameters.Add(UserID);
            com.Parameters.Add(IsCompleted);

            int status;
            try
            {
                status = Convert.ToInt16(com.ExecuteNonQuery());
            }
            catch (Exception e)
            {
                string mess = e.Message;
                status = -1;
            }
            finally
            {
                strConnString.Close();
            }
            return status;
        }

        public int IsUpdateTasks(int taskID, string title, int userID, bool Iscompleted)
        {
            com = new SqlCommand();
            com.Connection = strConnString;
            if (strConnString.State == ConnectionState.Closed)
                strConnString.Open();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "[sp_UpdateTasks]";

            TaskID = new SqlParameter();
            TaskID.SqlDbType = SqlDbType.Int;
            TaskID.ParameterName = "@TaskID";
            TaskID.Value = taskID;
            TaskID.Direction = ParameterDirection.Input;

            Title = new SqlParameter();
            Title.SqlDbType = SqlDbType.VarChar;
            Title.Size = 200;
            Title.ParameterName = "@title";
            Title.Value = title;
            Title.Direction = ParameterDirection.Input;

            UserID = new SqlParameter();
            UserID.SqlDbType = SqlDbType.Int;
            UserID.ParameterName = "@userID";
            UserID.Value = userID;
            UserID.Direction = ParameterDirection.Input;

            IsCompleted = new SqlParameter();
            IsCompleted.SqlDbType = SqlDbType.Bit;
            IsCompleted.ParameterName = "@IsCompleted";
            IsCompleted.Value = Iscompleted;
            IsCompleted.Direction = ParameterDirection.Input;

            com.Parameters.Add(TaskID);
            com.Parameters.Add(Title);
            com.Parameters.Add(UserID);
            com.Parameters.Add(IsCompleted);

            int status;
            try
            {
                status = Convert.ToInt16(com.ExecuteNonQuery());
            }
            catch (Exception e)
            {
                string mess = e.Message;
                status = -1;
            }
            finally
            {
                strConnString.Close();
            }
            return status;
        }

        public int IsDeleteTesk(int taskID, int userID)
        {
            com = new SqlCommand();
            com.Connection = strConnString;
            if (strConnString.State == ConnectionState.Closed)
                strConnString.Open();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "[sp_DeleteTasks]";

            TaskID = new SqlParameter();
            TaskID.SqlDbType = SqlDbType.Int;
            TaskID.ParameterName = "@TaskID";
            TaskID.Value = taskID;
            TaskID.Direction = ParameterDirection.Input;

            UserID = new SqlParameter();
            UserID.SqlDbType = SqlDbType.Int;
            UserID.ParameterName = "@userID";
            UserID.Value = userID;
            UserID.Direction = ParameterDirection.Input;

            com.Parameters.Add(TaskID);
            com.Parameters.Add(UserID);

            int status;
            try
            {
                status = Convert.ToInt16(com.ExecuteNonQuery());
            }
            catch (Exception e)
            {
                string mess = e.Message;
                status = -1;
            }
            finally
            {
                strConnString.Close();
            }
            return status;
        }

        #endregion
    }
}