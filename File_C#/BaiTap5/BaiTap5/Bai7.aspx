<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bai7.aspx.cs" Inherits="BaiTap5.Bai7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Giải pt bậc 2: Ax^2 + Bx + C = 0</h1>
            <hr />
            <label for="a">
                Hệ số A
            </label>
            <asp:TextBox ID="a" runat="server"></asp:TextBox>
            <label for="b">
                Hệ số B
            </label>
            <asp:TextBox ID="b" runat="server"></asp:TextBox>
            <label for="c">
                Hệ số C
            </label>
            <asp:TextBox ID="c" runat="server"></asp:TextBox>

            <asp:Button ID="resolve" runat="server" Text="Giai" OnClick="resolve_Click" />

            <asp:Label ID="result" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
