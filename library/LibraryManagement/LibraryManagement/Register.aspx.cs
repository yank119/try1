using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Username.Focus();
            }
        }
        protected void Button_Register(object sender, EventArgs e)
        {
            if (Username.Text == "")
                WebMessage.Show("请输入用户名");
            else if (Password.Text == "" || Password1.Text == "")
                WebMessage.Show("请输入密码");
            else if (Password.Text != Password1.Text)
                WebMessage.Show("两次密码输入不匹配");
            else
            {

                string sqltext = "select * from Users where id='" + Username.Text + "'";
                DataTable table = new DataTable();
                ConnSql cn = new ConnSql();
                table = cn.RunSqlReturnTable(sqltext);
                if (table.Rows.Count > 0)
                    WebMessage.Show("该用户名已存在！");
                else
                {
                    ConnSql con = new ConnSql();
                    string sql = string.Format("Insert into Users (id, pwd, name, class, status, admin) values ('{0}', '{1}', '{2}', '{3}', {4}, {5})", Username.Text, Password.Text, RealName.Text, Class.Text, 1, 0);
                    if (con.RunSql(sql) > 0)
                    {
                        WebMessage.Show("注册成功了！");
                    }
                }
            }
        }
    }
}