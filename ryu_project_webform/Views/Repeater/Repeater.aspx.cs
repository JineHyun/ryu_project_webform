using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ryu_project_webform.Views.Repeater
{
    public partial class Repeater : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            createRepeater();
        }

        public void createRepeater()
        {
            DataTable dt = new DataTable();
            dt.TableName = "example";
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("name", typeof(string));
            DataRow dr = null;
            dr = dt.NewRow();
            dr["id"] = 1;
            dr["name"] = "홍길동";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["id"] = 2;
            dr["name"] = "유관순";
            dt.Rows.Add(dr);

            rptOne.DataSource = dt;
            rptOne.DataBind();
        }
    }
}