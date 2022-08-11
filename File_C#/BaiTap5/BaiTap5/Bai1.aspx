<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bai1.aspx.cs" Inherits="BaiTap5.Bai1" %>

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
        <div>
            <table style="border: 1px solid grey;" class="table">
                <thead>
                    <tr>
                        <th> Đóng góp ý kiến </th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                    <td>Họ và tên</td>
                    <td><input type="text" name="name" style="width: 100%;" /></td>
                    
                </tr>
                <tr>
                    <td>Nội dung góp ý</td>
                    <td><textarea name="your_comment"></textarea></td>
                </tr>
                <tr>
                    <td colspan="5">
                        <asp:Button ID="Button1" runat="server" Text="Góp ý" />
                        <asp:Button ID="Button2" runat="server" Text="Hủy" />
                    </td>
                    
                </tr>
                </tbody>
            </table>

        </div>
    </form>
</body>
</html>
