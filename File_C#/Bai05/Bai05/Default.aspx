<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Bai05.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Table ID="Table1" runat="server" BorderWidth="1px">
            <asp:TableRow>
                <asp:TableCell ColumnSpan="2">
                    ĐÓNG GÓP Ý KIẾN
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    HỌ TÊN
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell> Nội dung góp ý</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Rows="10"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button ID="Button1" runat="server" Text="Góp ý" />
                    <asp:Button ID="Button2" runat="server" Text="Hủy" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
       </div>
    </form>
</body>
</html>
