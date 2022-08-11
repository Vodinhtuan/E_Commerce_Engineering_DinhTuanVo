<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loaihang.aspx.cs" Inherits="BAN_HANG.loaihang" EnableEventValidation="False" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            DANH SÁCH LOẠI HÀNG
        </div>
        <asp:DataList ID="dl_dulieu" runat="server" RepeatColumns="2">
            <ItemTemplate>
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl='<%# "~/images/"+ Eval("HINH") %>' CommandArgument='<%# Eval("MALOAI") %>' width="100px" OnClick="ImageButton1_Click"/>
                <asp:LinkButton ID="LinkButton1" runat="server" Text='<%# Eval("TENLOAI") %>' CommandArgument='<%# Eval("MALOAI") %>' OnClick="LinkButton1_Click"></asp:LinkButton>
            </ItemTemplate>
        </asp:DataList>
    </form>
</body>
</html>
