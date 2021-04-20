using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ryu_project_webform.Views.Function
{
    public partial class Function : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            functionDictionary();
        }

        private void InitializeControls()
        {
        }

        /// <summary>
        /// 기능모음
        /// </summary>
        public void functionCollection()
        {
        }

        /// <summary>
        /// Dictionary 키 값 가져오기
        /// </summary>
        /// <param name="keyName"></param>
        /// <param name="getDic"></param>
        /// <returns></returns>
        public string getDictionaryValue(string keyName, Dictionary<string, string> getDic)
        {
            string result = string.Empty;
            
            foreach (KeyValuePair<String, String> item in getDic)
            {
                if (keyName.Contains(item.Key))
                {
                    result = item.Value.ToString();
                }
            }

            return result;
        }

        public void functionDictionary()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("id", "1");
            dic.Add("name", "홍길동");

            //키 등록 여부
            if (!dic.ContainsKey("address"))
            {
                //Dictionary는 중복키X
                dic.Add("address", "서울시 서대문구 미근동");
            }

            hidDictionary.Value = getDictionaryValue("address", dic);
        }

        [WebMethod]
        public static string functionAjax(int id, string name)
        {
            string result = string.Empty;
            
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

            result = JsonConvert.SerializeObject(dt);

            return result;
        }
    }
}