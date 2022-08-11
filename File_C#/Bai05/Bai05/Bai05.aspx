<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bai05.aspx.cs" Inherits="Bai05.Bai05" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>

        .nut:hover{
            background-color:black;
            color:white;
            border-color:white;
        }
    </style>
</head>
<body style="width: 807px; height: 233px; margin-left: 137px; margin-top: 47px">
    <form id="form1" runat="server">
        <div>
            <h1> Thực hiện phép tính</h1>
            <p>Số thứ nhất: <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox></p>
            <p>Số thứ hai: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></p>
            <asp:Button ID="btnTong" runat="server" Text="+" OnClick="btnTong_Click" CssClass="nut"/>
            <asp:Button ID="btnHieu" runat="server" Text="-" OnClick="btnHieu_Click" CssClass="nut"/>
            <asp:Button ID="btnTich" runat="server" Text="*" OnClick="btnTich_Click" CssClass="nut"/>
            <asp:Button ID="btnThuong" runat="server" Text="/" OnClick="btnThuong_Click" CssClass="nut"/>  
            <p><asp:Label ID="lbHienThi" runat="server" Text="Kết Quả Tính"></asp:Label></p>
        </div>
    </form>
</body>
</html>
