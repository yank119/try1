﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Home/Home.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Library.Home.Index.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
    <div class="center-block" style="margin-top:50px;padding:20px;width:500px;background-color:#fff;border-radius:30px;">
      <h3 class="text-center">
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>：你好！</h3>
      <h3 class="text-center" style="margin-top:70px;">你已借<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>本图书</h3>
      <h3 class="text-center">已超期<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>本书</h3>
      <h4 class="text-center" style="margin-top:70px;">上次登录时间：</h4>
      <h4 class="text-center">
                <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></h4>
    </div>
  </div>
    <style>
        Body{background-size:100%; } 
    </style>
    <script type="text/javascript">
        $(".navbar-nav li").eq(0).addClass("active")
</script>
</asp:Content>
