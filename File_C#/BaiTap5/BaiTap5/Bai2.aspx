<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bai2.aspx.cs" Inherits="BaiTap5.Bai2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        td{
            border: 1px solid grey;
        }
        th,td{
            text-align: center;
        }
        table{
            width: 400px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width: 400px;">
            <thead>
                <tr>
                    <th>Thăm dò ý kiến</th>
                </tr>
            </thead>
            <tr>
                <td>Họ và tên</td>
                <td><input type="text" name="name" /></td>
                <td>
                    
                        <input type="radio" name="sex"  id="nam" /><label for="nam">Nam</label>
                        <input type="radio" name="sex"  id="nu" /><label for="nu">Nữ</label>
                    
                </td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2" style="text-align: left;">
                    <h4>Bạn dùng Internet để làm gì?</h4>
                    <input id="Checkbox1" type="checkbox" /><label for="Checkbox1">Tin tức</label><br />
                    <input id="Checkbox2" type="checkbox" /><label for="Checkbox2">Học tập</label><br />
                    <input id="Checkbox3" type="checkbox" /><label for="Checkbox3">Muc đích khác</label><br />
                    <input id="Checkbox4" type="checkbox" /><label for="Checkbox4">Giải trí</label><br />
                </td>
                
            </tr>
            <tr>
               <td colspan="4"> 
                   <asp:Button ID="Button1" runat="server" Text="Chọn" />
                   <asp:Button ID="Button2" runat="server" Text="Hủy" />
               </td>
            </tr>
        </table>
    </form>
</body>
</html>
