<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bai5.aspx.cs" Inherits="BaiTap5.Bai5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" onsubmit="">
         <div>
            <h1>Kiêmr tra sự kiện</h1>
            <hr />
            <label for="name">
                Tên của bạn
            </label>
            <asp:TextBox ID="name" OnTextChanged="name_TextChanged" AutoPostBack="true" runat="server"></asp:TextBox>
            <label for="grade">Lớp</label>
            <asp:TextBox OnTextChanged="grade_TextChanged" ID="grade" AutoPostBack="true" runat="server"></asp:TextBox>
            
        </div>
        <asp:Label ID="greeting" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
