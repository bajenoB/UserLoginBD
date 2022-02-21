using System.Data.SqlClient;

namespace UserLoginBD
{
    public class SqlConnect
    {
        private static SqlConnection conn;

        

        public  SqlConnect()
        {
            
        }

        public static SqlConnection GetConnect()
        {
            if(conn == null)
            {
                conn = new SqlConnection("Data Source=Savel;Initial Catalog=bajenob;User Id=bajenob;Password=SavelStan123");
                conn.Open();
            }
            return conn;
             
        }
    }
}
