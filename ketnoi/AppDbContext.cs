using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlykhachsan
{
    class DbContext
    {
        public static SqlConnection Cnn = null;
        public SqlConnection _DbContext()
        {
            Cnn = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;;AttachDbFilename=|DataDirectory|\quanlykhachsan.mdf;Initial Catalog=quanlykhachsan;Integrated Security=True");
            //Cnn = new SqlConnection(@"Data Source=Win\Min;Initial Catalog=quanlykhachsan;Integrated Security=True");
            return Cnn;
        }
    }
}
