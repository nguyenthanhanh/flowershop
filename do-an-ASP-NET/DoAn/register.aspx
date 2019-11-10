<%@ Page Title="" Language="C#" MasterPageFile="~/Master-page-do-an.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="DoAn.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphIndex" runat="server">
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
<asp:Content ID="Content9" ContentPlaceHolderID="cphLogin" runat="server">
</asp:Content>
<asp:Content ID="Content10" ContentPlaceHolderID="cphRegister" runat="server">
    <div class="container-register">
      <div class="content">
        <div class="content-left">
          <div class="intro">
            <h2>Counting House</h2>
            <span>Là một website chuyên cung cấp dịch vụ điện hoa, quà tặng chuyên nghiệp đến khắp các tỉnh, thành phố trên cả nước. Với Thông điệp "Flower Delivery Expert", 
                      chúng tôi hướng đến một dịch vụ chuyên nghiệp trong việc truyền tải những thông điệp, cảm xúc của người tặng đến người nhận.</span>
          </div>
          <div class="image-overplay"></div>
          <img src="images/image-intro.jpg" alt="">
        </div>
        <div class="content-right">
          <h3>Đăng ký</h3>
          <div class="input-group">
            <input type="text" id="username" required>
            <label for="username">Tên đăng nhập</label>
          </div>
          <div class="input-group">
            <input type="password" id="password" required>
            <label for="password">Mật khẩu</label>
          </div>
          <div class="input-group">
            <input type="password" id="password" required>
            <label for="password">Xác nhận mật khẩu</label>
          </div>
          <div class="input-group">
            <input type="password" id="password" required>
            <label for="password">Họ tên</label>
          </div>
          <div class="input-group-sex">
            <label for="">Giới tính</label>
            <input type="radio" name="sex" value="0"> Nam
            <input type="radio" name="sex" value="1"> Nữ 
          </div>
          <button type="submit">Đăng ký</button>
          <div class="social">
            <p>Hoặc đăng nhập với</p>
            <i class="fab fa-facebook-square facebook"></i>
            <i class="fab fa-twitter-square twitter"></i>
          </div>
        </div>
      </div>
    </div>
</asp:Content>
