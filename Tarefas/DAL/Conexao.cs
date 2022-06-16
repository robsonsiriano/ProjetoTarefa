using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class Conexao
    {
        public static string StringDeConexao
        {
            get
            {
                return @"user Id = sa;Initial Catalog=App;Data Source=DESKTOP-DVK6P6F\SQLEXPRESS;Password=123456789";
            }
        }
    }
}
