<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Y_Kien.aspx.cs" Inherits="Bai05.Y_Kien" %>

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
                <asp:TableCell ColumnSpan="3">
                    THĂM DÒ Ý KIẾN
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    HỌ TÊN
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:RadioButton ID="RadioButton1" runat="server" Text="Nam" GroupName="gioitinh" />
                    <asp:RadioButton ID="RadioButton2" runat="server" Text="Nữ" GroupName="gioitinh" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell> </asp:TableCell>
                <asp:TableCell ColumnSpan="2">
                    Bạn dùng Internet để làm gì? 
                    <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                        <asp:ListItem>Tin tức</asp:ListItem>
                        <asp:ListItem>Giải trí</asp:ListItem>
                        <asp:ListItem>Học tập</asp:ListItem>
                        <asp:ListItem>Mục đích khác</asp:ListItem>
                    </asp:CheckBoxList>
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
