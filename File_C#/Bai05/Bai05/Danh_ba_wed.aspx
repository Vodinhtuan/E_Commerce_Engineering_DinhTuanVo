<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Danh_ba_wed.aspx.cs" Inherits="Bai05.Danh_ba_wed" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .hplink{
            text-decoration: underline;
            display:block;
            margin-left:5%;
            margin-bottom:1%;
        }
        .Ipic{
            width:25%;
            height:100%;
        }
        .dp{
            background-image:url(bg.jpg);
            background-size:cover;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:100%"; height:50vh">
            <div style="width:50%; height= auto; margin= auto; border=2px solid;" calss="dp">
                <h1 style="text-align:center; color: blue;">DANH BẠ WEBSITE</h1>
                <div class="nd">
                    <h4>Tin tức</h4>
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="" CssClass="www.vnexpress.net">Tin tức Việt Nam</asp:HyperLink>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="" CssClass="www.tuoitre.com.vn">Báo tuổi trẻ</asp:HyperLink>
                </div>
                <div class="nd">
                    <h4>Giải trí</h4>
                    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="" CssClass="www.nhacso.net">Nhạc số online</asp:HyperLink>
                    <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="" CssClass="www.ngoisao.net">Giới thiệu ngôi sao</asp:HyperLink>
                </div>
                <div class="nd" style="width:100%; height:20%">
                    <h4>Liên Kết Quảng Cáo</h4>
                <!--    <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl>
                        <asp:Image ID="Image1" runat="server" ImageUrl="~/Sierra.jpg"/>
                    </asp:HyperLink>
                    <asp:HyperLink ID="HyperLink5" runat="server"NavigateUrl>
                        <asp:Image ID="Image2" runat="server" ImageUrl="~/Sierra.jpg"/>
                    </asp:HyperLink> -->
                </div>
                <p>Liên hệ:</p><a href="">Gởi mail</a>
            </div>
        </div>
    </form>
</body>
</html>
