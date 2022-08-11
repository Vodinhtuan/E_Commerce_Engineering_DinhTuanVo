<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="chitiet.aspx.cs" Inherits="QLTHIETBI.chitiet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <table style="width:100%;">
                <tr>
                    <td rowspan="5">
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/images/"+ Eval("HINHANH") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("TENTHIETBI") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("MOTA") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Đơn giá:
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("DONGIA") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Số lượng:
                        <asp:TextBox ID="TextBox1" runat="server" Text="1" TextMode="Number"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Mua" OnClick="Button1_Click" CommandArgument='<%# Eval("MATHIETBI") %>' />
                        <asp:Button ID="Button2" runat="server" Text="Giỏ hàng" OnClick="Button2_Click" />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
    <asp:Label ID="Label4" runat="server" Text="" ForeColor="Red"></asp:Label>
</asp:Content>
