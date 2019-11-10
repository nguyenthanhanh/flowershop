<%@ Page Title="" Language="C#" MasterPageFile="~/Master-page-do-an.Master" AutoEventWireup="true" CodeBehind="shop.aspx.cs" Inherits="DoAn.shop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphIndex" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="cphShop" runat="server">

    <!-- SHOP PAGE -->
    <div class="hero-wrap hero-bread" style="background-image: url('images/3.jpg');">
      <div class="container">
        <div class="row no-gutters slider-text align-items-center justify-content-center">
          <div class="col-md-9 ftco-animate text-center">
          	<p class="breadcrumbs"><span class="mr-2"><a href="index.html">Home</a></span> <span>Products</span></p>
            <h1 class="mb-0 bread">Products</h1>
          </div>
        </div>
      </div>
    </div>

    <section class="ftco-section">
    	<div class="container">
    		<div class="row justify-content-center">
    			<div class="col-md-10 mb-5 text-center">
    				<ul class="product-category">
    					<li><a href="#" class="active">All</a></li>
    					<li><a href="#">Vegetables</a></li>
    					<li><a href="#">Fruits</a></li>
    					<li><a href="#">Juice</a></li>
    					<li><a href="#">Dried</a></li>
    				</ul>
    			</div>
    		</div>
    		<div class="row">
                <asp:Repeater ID="rptHoa" runat="server">
                    <ItemTemplate>
                        <div class="col-md-6 col-lg-3 ftco-animate">
    				<div class="product">
    					<a href="#" class="img-prod">
                            <asp:Image ID="Image1" runat="server" ImageUrl='<%#"images/products" +Eval("AnhMinhHoa") %>'/>
    						<span class="status">30%</span>
    						<div class="overlay"></div>
    					</a>
    					<div class="text py-3 pb-4 px-3 text-center">
    						<h3><a href="#">
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("TenHoa") %>' />
    						    </a></h3>
    						<div class="d-flex">
    							<div class="pricing">
		    						<p class="price"><span class="mr-2 price-dc">
                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("GiaTien") %>'/></span><span class="price-sale">$80.00</span></p>
		    					</div>
	    					</div>
	    					<div class="bottom-area d-flex px-3">
	    						<div class="m-auto d-flex">
	    							<a href="#" class="add-to-cart d-flex justify-content-center align-items-center text-center">
                                 
	    								<span><i class="ion-ios-menu"></i></span>
	    							</a>
	    							<a href="#" class="buy-now d-flex justify-content-center align-items-center mx-1">
	    								<span><i class="ion-ios-cart"></i></span>
	    							</a>
	    							<a href="#" class="heart d-flex justify-content-center align-items-center ">
	    								<span><i class="ion-ios-heart"></i></span>
	    							</a>
    							</div>
    						</div>
    					</div>
    				</div>
    			</div>
                    </ItemTemplate>
                </asp:Repeater>
                </div>
  
                
    			
	
    		<div class="row mt-5">
          <div class="col text-center">
            <div class="block-27">
              <ul>
                <li><a href="#">&lt;</a></li>
                <li class="active"><span>1</span></li>
                <li><a href="#">2</a></li>
                <li><a href="#">3</a></li>
                <li><a href="#">4</a></li>
                <li><a href="#">5</a></li>
                <li><a href="#">&gt;</a></li>
              </ul>
            </div>
          </div>
        </div>
    	</div>
    </section>
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
</asp:Content>
