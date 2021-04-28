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
            //string sql = "SELECT id,name,author from book_info ";
            //DataTable dt = new DataTable();
            //ConnSql con = new ConnSql();
            //dt = con.RunSqlReturnTable(sql);
            //Table t = new Table();
            

            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    TableRow r = new TableRow();
            //    TableCell id = new TableCell();
            //    TableCell name = new TableCell();
            //    TableCell author = new TableCell();
            //    TableCell b = new TableCell();
            //    TableCell a = new TableCell();
            //    id.Text = dt.Rows[i][0].ToString();
            //    name.Text = dt.Rows[i][1].ToString();
            //    author.Text = dt.Rows[i][2].ToString();
            //    string sql1 = "SELECT * from borrow_list where book_id='" + dt.Rows[i][0].ToString() + "'";
            //    string x = con.RunSqlReturnString(sql1);
            //    if (x == ""||x==null)
            //    {
            //        b.Text = "在馆";
            //    }
            //    else
            //    {
            //        b.Text = "已借出";
            //    }


                
            //    a.Text = "<a  class=\"btn btn-success btn - xs\">修改</a>&nbsp<a href=\"#\" class=\"btn btn-danger btn - xs delete\" >删除</a>";

            //    r.Cells.Add(id);
            //    r.Cells.Add(name);
            //    r.Cells.Add(author);
            //    r.Cells.Add(b);
            //    r.Cells.Add(a);
            //    t.Rows.Add(r);
            //}
          //  PlaceHolder1.Controls.Add(t);
            
            
            
        }

        protected void research_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Trim()==null||TextBox1.Text.Trim()=="")
            {
                string sql = "SELECT distinct id,name,author, (SELECT count(*) from borrow_list where book_id=id) as status  from book_info,borrow_list";
                DataTable dt = new DataTable();
                ConnSql con = new ConnSql();
                dt = con.RunSqlReturnTable(sql);
                GridView1.DataSourceID = null;
                GridView1.DataSource = dt;
                GridView1.DataBind();

            }
            else if (DropDownList1.SelectedValue.Trim()== "keyword")//书名查询
            {
                string sql = "SELECT distinct id,name,author, (SELECT count(*) from borrow_list where book_id=id) as status  from book_info,borrow_list where name='" + TextBox1.Text.Trim()+"'";
                DataTable dt = new DataTable();
                ConnSql con = new ConnSql();
                dt = con.RunSqlReturnTable(sql);
                GridView1.DataSourceID = null;
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else//书号查询
            {
                string sql = "SELECT distinct id,name,author, (SELECT count(*) from borrow_list where book_id=id) as status  from book_info,borrow_list where id='" + TextBox1.Text.Trim() + "'";
                DataTable dt = new DataTable();
                ConnSql con = new ConnSql();
                dt = con.RunSqlReturnTable(sql);
                GridView1.DataSourceID = null;
                GridView1.DataSource = dt;
                GridView1.DataBind();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ConnSql con = new ConnSql();
            string sql = "delete from book_info where id='" + (sender as Button).CommandArgument.ToString() + "'";
            string sql1 = "delete from borrow_list where book_id='" + (sender as Button).CommandArgument.ToString() + "'";
            int x = con.RunSql(sql);
            con.RunSql(sql1);
            if (x == 1)
            {
                WebMessage.Show("删除成功", "Index.aspx");
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