using System.Data.SqlClient;

namespace UserLoginBD
{
    public class SqlOper
    {
        SqlConnection conn;
        SqlCommand cmd;
        public SqlOper()
        {
            conn = SqlConnect.GetConnect();
            cmd = new SqlCommand();

        }

        public bool isLoginExist(string login)
        {
            using(cmd= new SqlCommand($"SELECT * FROM [USERINFO] WHERE [LOGIN] ={login}",conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) { return true; }
            }
            return false;
        }

        public bool isMailExist(string mail)
        {
            using (cmd = new SqlCommand($"SELECT * FROM [USERINFO] WHERE [EMAIL] ={mail}", conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) { return true; }
            }
            return false;
        }

        public bool AddUser(UserLoh user)
        {
            using(cmd= new SqlCommand($"INSERT INTO[USERINFO]([NAME],[EMAIL],[BDAY],[HPASS]) VALUES({user.Name},{user.Email},{user.Dbay},{user.Password})",conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) { return true; }
            }
            return false; 
        }
    }
}
