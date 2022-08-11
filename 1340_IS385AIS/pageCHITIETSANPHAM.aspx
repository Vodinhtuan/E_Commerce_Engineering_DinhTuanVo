<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="pageCHITIETSANPHAM.aspx.cs" Inherits="NGUYENQUOCTUAN_1340_IS385AIS_DOANCANHAN.pageCHITIETSANPHAM" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="Repeater2" runat="server">
    
    
        <ItemTemplate>
            <a id="CTSP">
                <img id="hinhanhchitiet" src='IMAGES\<%# Eval("HINHANH") %>'/>
                <br />
                <p id="tenSPCT" ><%# Eval("TENSANPHAM") %></p>
                <br />
                   <p id="moTaCT" >Thông tin chi tiết: 
                       <br />
                       - <%# Eval("MOTA")%></p> 
                <br />
                    <p id="giaSP" >Giá: <%# Eval("DONGIA") %> đồng</p> 
                <br />
            </a>
        </ItemTemplate>
    
    
    </asp:Repeater>
    <asp:DropDownList ID="Dropdownlist1" runat="server" Height="32px" Width="105px"></asp:DropDownList>
    <asp:Button ID="Button" runat="server" Text="Thêm vào giỏ hàng" OnClick="Button_Click" Height="42px" Width="181px" />
</asp:Content>
