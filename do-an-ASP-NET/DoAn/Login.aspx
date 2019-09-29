<%@ Page Title="" Language="C#" MasterPageFile="~/Master-page-do-an.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DoAn.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Conten12" ContentPlaceHolderID="cphLogin" runat="server">
    <div class="container-login">
      <div class="form-login">
        <h3>Đăng nhập</h3>
        <div class="input-group">
          <input type="text" id="username" required>
          <label for="username">Tên đăng nhập</label>
        </div>
        <div class="input-group mt">
          <input type="password" id="password" required>
          <label for="password">Mật khẩu</label>
        </div>
        <button type="submit">Đăng nhập</button>
        <div class="remember-password">
          <input type="checkbox">
          <label for="Lưu mật khẩu">Nhớ mật khẩu</label>
        </div>
        <div class="forgot-password">
          <a href="#">Quên mật khẩu ?</a>
        </div>
        </div>
      </div>
    </asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="cphShop" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphWishlist" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cphChiTietSP" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="cphCart" runat="server">
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="cphCheckout" runat="server">
</asp:Content>
<asp:Content ID="Content8" ContentPlaceHolderID="cphAboutUS" runat="server">
</asp:Content>
<asp:Content ID="Content9" ContentPlaceHolderID="cphBlog" runat="server">
</asp:Content>
<asp:Content ID="Content10" ContentPlaceHolderID="cphBlogSingle" runat="server">
</asp:Content>
<asp:Content ID="Content11" ContentPlaceHolderID="cphContactUS" runat="server">
</asp:Content>