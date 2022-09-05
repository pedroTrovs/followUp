using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace followUp
{
    public class DB
    {
        public static NpgsqlConnection con;
        public NpgsqlCommand command;
        public NpgsqlDataReader dReader;
        public DataTable dTable;

        public DB()
        {
            try
            {
                if ((con == null) || (con.State != ConnectionState.Open))
                {
                    con = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=2201;Database=fup1;");
                    con.Open();
                }
                command = new NpgsqlCommand();
                command.Connection = con;
            }
            catch (Exception ex)
            {
                throw new Exception("Connection error: " + ex.Message);
            }
        }
    }
}
