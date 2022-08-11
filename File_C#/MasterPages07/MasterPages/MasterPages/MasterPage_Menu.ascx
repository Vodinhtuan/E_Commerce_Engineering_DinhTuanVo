<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MasterPage_Menu.ascx.cs" Inherits="MasterPages.MasterPage_Menu" %>

<style>
    div.menu{
        background:cornflowerblue;

    }
    li.menu_li{
        list-style:none;
        padding:5px 0;
    }
    a.menu_a{
        color:white;
        text-decoration:none;
    }
    a.menu_a:hover{
        color:red;
    }
</style>
<div class="menu">
    <ul class="menu_ul">
        <li class="menu_li"><a class="menu_a" href="#">Giới thiệu</a></li>
        <li class="menu_li"><a class="menu_a" href="#">Đào tạo</a></li>
        <li class="menu_li"><a class="menu_a" href="#">Giảng viên</a></li>
        <li class="menu_li"><a class="menu_a" href="#">Thông tin</a></li>
        <li class="menu_li"><a class="menu_a" href="#">Nghiên cứu khoa học</a></li>
        <li class="menu_li"><a class="menu_a" href="#">Quan hệ hợp tác</a></li>
        <li class="menu_li"><a class="menu_a" href="#">Hoạt động ngoại khoá</a></li>
        <li class="menu_li"><a class="menu_a" href="#">Nghề nghiệp</a></li>
        <li class="menu_li"><a class="menu_a" href="#">Bộ sưu tập ảnh</a></li>


    </ul>
</div>