<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bai6.aspx.cs" Inherits="BaiTap5.Bai6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Thực hiện phép tính</h1>
            <hr />
            <label>Số thứ nhất: </label>
            <asp:TextBox ID="FirstNumber" runat="server"></asp:TextBox>
            <br />
            <label>Số thứ hai: </label>
            <asp:TextBox ID="SecondNumber" runat="server"></asp:TextBox>
            <br />
            <br />

            <asp:Button ID="add" runat="server" Text="+"  OnClick="add_Click"/>
            <asp:Button ID="sub" runat="server" Text="-" OnClick="sub_Click" />
            <asp:Button ID="mul" runat="server" Text="*" OnClick="mul_Click"/>
            <asp:Button ID="div" runat="server" Text="/" OnClick="div_Click"/>

            <br />
            <br />

            <asp:Label ID="result" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
