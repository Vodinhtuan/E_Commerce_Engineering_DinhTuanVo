<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bai3.aspx.cs" Inherits="BaiTap5.Bai3" %>

<!DOCTYPE html>

<html xmlns="http://https://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
            background-image: url(Images/anhdep.jpg);
            background-repeat: no-repeat;
            background-size: cover;
        }
        img{
            width: 200px;
            height: 100px;
        }
        dt{
            font-weight: 800;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Danh bạ Website</h1>
        <dl>
          <dt>Tin tuc</dt>
          <dd><a href="https://www.vnexpress.net">Express Việt Nam</a></dd>
          <dd><a href="https://www.tuoitre.com.vn">Báo tuổi trẻ</a></dd>
        </dl>
        <dl>
          <dt>Giải trí</dt>
          <dd><a href="https://www.nhacso.net">Nhạc So Online</a></dd>
          <dd><a href="https://www.ngoisao.net">Ngôi Sao Net</a></dd>
        </dl>
        <dl>
          <dt>Liên kết quảng cáo</dt>
          <dd>
              <a style="display: inline-block; margin-right: 10px;" href="https://www.echip.com.vn"><img src="Images/anhdepS.jpg" /></a>
              <a href="https://www.vietnamnet.vn"><img src="Images/anhdep.jpg" /></a>
          </dd>
          
        </dl>

        
    </form>
     Liên hệ : <a  href="mailto:tienit0105@gmail.com">Mail</a>
</body>
</html>
