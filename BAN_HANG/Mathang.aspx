<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mathang.aspx.cs" Inherits="BAN_HANG.Mathang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Danh sách mặt hàng
        </div>
        <AutoGenerateColumns=GridView ID="GridView1" runat="server" >
            <Columns>
                <asp:TemplateField HeaderText="Hình ảnh">
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" ImageUrl='%# "~/images/"+Eval("HINH") %>'/>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField Header Text="Tên hàng" DataField="TENHANG" />
                <asp:BoundField Header Text="Mô tả" DataField="MOTA" />
                <asp:BoundField Header Text="Đơn giá" DataField="DONGIA" />
                <asp:BoundField Header Text="Số lượng">
                    <TtemTemplate>
                        <asp:TextBox runat="server"></asp:TextBox>
                        <asp:Button runat="server" Text="Button" />
                    </TtemTemplate>
            </Columns>
    </form>
</body>
</html>
