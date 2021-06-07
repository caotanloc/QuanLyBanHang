using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_LAYER
{
    public class ConnectString
    {
            protected SqlConnection _conn = new SqlConnection(@"Data Source=TANLOC\SQL123;AttachDbFilename=|DataDirectory|\QLBH.mdf;Integrated Security=True");


    }
}
