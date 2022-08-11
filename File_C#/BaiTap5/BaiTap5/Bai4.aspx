<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bai4.aspx.cs" Inherits="BaiTap5.Bai4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">


        <div>
            <h1>Kiêmr tra sự kiện</h1>
            <hr />
            <label for="name">
                Tên của bạn
            </label>
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
            <label for="grade">Lớp</label>
            <asp:TextBox ID="grade" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Ok" OnClick="Button1_Click" />
        </div>
    </form>
    <asp:Label ID="greeting" runat="server" Text=""></asp:Label>
    
</body>
</html>
