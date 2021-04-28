<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Library.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="css/bootstrap.min.css" />
    <script src="js/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <title></title>
    <style>
        #login {
            height: 300px;
            width: 400px;
            margin: auto;
            margin-top: 40px;
        }

        * {
            padding: 0;
            margin: 0;
        }

        .footer {
            position: absolute;
            bottom: 0;
            width: 100%;
            /* Set the fixed height of the footer here */
            height: 50px;
            background-color: #f5f5f5;
        }

        body {
            background-color: #f0f2f5;
            min-height: 100vh;
            height: 100%;
            width: 100%;
            background-image: linear-gradient(rgba(0, 0, 0, 0.6), rgba(0, 0, 0, 0.6)), url(/Resources/bg.jpg);
            background-repeat: no-repeat;
            background-size: 100% 100%;
            background-position: center center;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div style="text-align: center; font-family: 'Adobe 楷体 Std R'; color: #fff; background-color: #005a5f; height: 60px; font-size: 24px; padding-top: 10px;">
            图书管理系统
        </div>
        <div class="panel panel-default" id="login">
            <div class="panel-heading" style="background-color: #005a5f; color: #fff">
                <div class="panel-title">请登录</div>
            </div>
            <div class="panel-body">
                <div class="form-group">
                    <label for="id">用户名</label>
                    <asp:TextBox ID="Username" runat="server" CssClass="form-control" placeholder="请输入用户名"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="passwd">密码</label>
                    <asp:TextBox ID="Password" type="password" runat="server" CssClass="form-control" placeholder="请输入密码"></asp:TextBox>
                </div>
                <p style="text-align: right; color: red; position: absolute" id="info"></p>
                <asp:Button ID="Submit" runat="server" CssClass="btn btn-primary btn-lg btn-block" Text="登录" OnClick="Button_Login" />
                <p style="text-align: center; margin-top: 10px"><a href="Register.aspx">注册</a></p>
            </div>
        </div>
    </form>
</body>
</html>
