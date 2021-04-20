using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework4._7._2.Dac
{
    public class DacData : DacBase
    {
        public DataSet GetData(string sp)
        {
            DataSet ds = null;

            using (SqlCommand cmd = new SqlCommand(sp, connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataAdapter sqlAdt = new SqlDataAdapter(cmd))
                {
                    ds = new DataSet();
                    sqlAdt.Fill(ds);
                }
            }

            return ds;
        }
    }
}
