using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library.Home.Book
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();
            }
        }

        protected void research_Click(object sender, EventArgs e)
        {
            Bind();
        }

        protected void Bind()
        {
            var now = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string sql = "SELECT distinct id,name,author, (SELECT count(*) from Borrows where book_id=id and back_date > '" +
                    now + "') as status  from Books where 1=1";
            string keyword = TextBox1.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                sql = sql + " and name like '%" + keyword + "%' or id like '%" + keyword + "%'";
            }

            DataTable dt = new DataTable();
            ConnSql con = new ConnSql();
            dt = con.RunSqlReturnTable(sql);
            GridView1.DataSourceID = null;
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}