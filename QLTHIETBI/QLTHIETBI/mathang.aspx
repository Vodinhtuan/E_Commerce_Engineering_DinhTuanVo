<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="mathang.aspx.cs" Inherits="QLTHIETBI.mathang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server" Width="100%" RepeatColumns="3" CssClass="main">
        <ItemTemplate>
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl='<%# "~/images/"+Eval("HINHANH") %>'
                CommandArgument='<%# Eval("MATHIETBI") %>' OnClick="ImageButton1_Click" Width="100%"/>
            <asp:LinkButton ID="LinkButton1" runat="server" Text='<%# Eval("TENTHIETBI")%>'
                CommandArgument='<%# Eval("MATHIETBI") %>' OnClick="LinkButton1_Click"></asp:LinkButton><br />
            Đơn giá: <asp:Label ID="Label1" runat="server" Text='<%# Eval("DONGIA") %>'></asp:Label>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
