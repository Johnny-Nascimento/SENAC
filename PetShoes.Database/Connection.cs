using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShoes.Database
{
    public class Connection
    {
        internal const string CONNECTION_STRING = "Server=localhost;Port=3306;Database=petshoes;Uid=root;Pwd=admin;";

        public static bool ConexaoValida()
        {
            try
            {
                using (var conn = new MySqlConnection(CONNECTION_STRING))
                {
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return false;
        }
    }
}
