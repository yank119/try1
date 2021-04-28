using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library.Admin
{
    public partial class Admin_Book : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                Bind();
        }

        private void Bind()
        {
            var now = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string keyword = TextBox1.Text.Trim();
            string sql = "SELECT distinct id,name,author, (SELECT count(*) from Borrows where book_id=id and back_date > '" +
                now + "') as status  from Books where 1 = 1";
            if (!string.IsNullOrEmpty(keyword))
            {
                sql += " and (name like '%" + keyword + "%' or id like '%" + keyword + "%')";
            }

            DataTable dt = new DataTable();
            ConnSql con = new ConnSql();
            dt = con.RunSqlReturnTable(sql);
            GridView1.DataSourceID = null;
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void research_Click(object sender, EventArgs e)
        {
            Bind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ConnSql con = new ConnSql();
            string sql = "delete from Books where id='" + (sender as Button).CommandArgument.ToString() + "'";
            string sql1 = "delete from Borrows where book_id='" + (sender as Button).CommandArgument.ToString() + "'";
            int x = con.RunSql(sql);
            con.RunSql(sql1);
            if (x == 1)
            {
                WebMessage.Show("删除成功", "Index.aspx");
                Bind();
            }
            else
            {
                WebMessage.Show("删除失败");
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Book_edit.aspx?id="+(sender as Button).CommandArgument.ToString());
        }
    }
}