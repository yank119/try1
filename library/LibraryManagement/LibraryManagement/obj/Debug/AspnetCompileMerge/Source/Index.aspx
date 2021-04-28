<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Library.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
 <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>登录页面</title>
    <%-- bootstrap引入 --%>
    <script src="/js/jquery.min.js"></script>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body style="background-image: url(../Resources/index.jpg);background-size:100%;">
    
        <div class="container">
            <div class="row" >
            <h1 class="text-center" style="color:darkgoldenrod">图书管理系统</h1>
        </div>
            <hr />
            <div  class="row">
                <form id="form1" runat="server" class="form-horizontal" role="form">
                    <div class="form-group">
                        <label for="username" class="col-sm-2 col-sm-offset-2 control-label"  style="color:darkgoldenrod">用户名:</label>
                        <div class="col-sm-5">
                            <asp:TextBox ID="Username" runat="server"  CssClass="form-control" placeholder="请输入用户名"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="password" class="col-sm-2 col-sm-offset-2 control-label"  style="color:darkgoldenrod">密码:</label>
                        <div class="col-sm-5">
                        <asp:TextBox ID="Password" type="password" runat="server" CssClass="form-control" placeholder="请输入密码"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="yzm" class="col-sm-2 col-sm-offset-2 control-label"  style="color:darkgoldenrod">验证码:</label>
                        <div class="col-sm-4">
                        <asp:TextBox ID="yzm" type="text" runat="server" CssClass="form-control" placeholder="请输入验证码"></asp:TextBox>
                        </div>
                        <asp:Button ID="btn_yzm" runat="server" Text="Button" CssClass="btn btn-default btn-lg " OnClick="Button1_Click"  />
                    </div>
                     <asp:Button ID="Submit" runat="server" CssClass="btn btn-default btn-lg col-sm-offset-5 col-sm-3" Text="登录" OnClick="Button_Login" />
                </form>
            </div>
            <div class="row">
            <asp:Label ID="hint" runat="server" Text="" Font-Size="21px" CssClass="col-sm-12 text-center text-success"></asp:Label>
        </div>

        </div>
    <%-- bootstrap引入 --%>
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
