<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="pageDANHSACHSANPHAM.aspx.cs" Inherits="NGUYENQUOCTUAN_1340_IS385AIS_DOANCANHAN.pageDANHSACHSANPHAM" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server">
    
    
        <ItemTemplate>
            <div id ="dsCho">
                <a style="text-decoration: none" href='pageCHITIETSANPHAM.aspx?IDSP=<%# Eval("IDSANPHAM") %>'>

                <img id ="imgDS" src ='IMAGES\<%# Eval("HINHANH") %>' />
                 
                <br />
                <p id ="titleDS"><%# Eval("TENSANPHAM") %></p> 
                </a>
                <p id="giaDS" ><%# Eval("DONGIA") %>đ </p>
            </div>
        </ItemTemplate>
    
    </asp:DataList>
</asp:Content>
