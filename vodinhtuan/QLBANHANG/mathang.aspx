<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="mathang.aspx.cs" Inherits="QLBANHANG.mathang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .image{
            width:30%;
        }
    </style>
    <asp:DataList ID="DataList1" runat="server" Width="100%" RepeatColumns="2" CssClass="main">
        <ItemTemplate>
            <asp:ImageButton ID="ImageButton1" CssClass="image"  runat="server" ImageUrl='<%# "~/images/"+Eval("HINHANH") %>'
                CommandArgument='<%# Eval("MAHANG") %>' OnClick="ImageButton1_Click" Width="30%"/>
            <asp:LinkButton ID="LinkButton1" runat="server" Text='<%# Eval("TENHANG")%>'
                CommandArgument='<%# Eval("MAHANG") %>' OnClick="LinkButton1_Click" ></asp:LinkButton><br />
            Đơn giá: <asp:Label ID="Label1" runat="server" Text='<%# Eval("DONGIA") %>'></asp:Label>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
