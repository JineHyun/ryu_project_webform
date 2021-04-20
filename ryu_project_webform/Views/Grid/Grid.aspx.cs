using System;
using System.Data;
using Framework4._7._2.Dac;
namespace ryu_project_webform
{
    public partial class Grid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            DacData dac = new DacData();
            DataSet ds = new DataSet();
            ds = dac.GetData("Get_TestTable");

            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

    }
}