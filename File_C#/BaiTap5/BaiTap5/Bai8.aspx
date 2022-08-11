<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bai8.aspx.cs" Inherits="BaiTap5.Bai8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .actionButtonGroup{
            display: flex;
            justify-content: center;
        }
        .actionButtonGroup button, .actionButtonGroup input{
            display: inline-block;
            margin: 20px;
        }
        .ImagePlaceholder{
            min-height: 200px;
            min-width: 400px;
        }
        .header{
            height: 50px;
            background-color: gray;
            color: white;
            text-align: center;
            line-height: 50px;
        }
        .wrapper{
            display: flex;
            justify-content: space-around;
        }
        .left{
            width: fit-content;
            display: flex;
            flex-direction: column;
            justify-content: space-around;
        }
        
        .fieldSection{
            display: flex;
           
            width: 100%;
            margin-bottom: 20px;
        }
        label{
            width: 35%;
        }
        .fieldSection .login-form{
             width: 100%;
        }

        .fieldSection .login-form div:first-child {
            margin-bottom: 10px;
        }
        .fieldSection .login-form div{
            display: flex;
            width: 100%;
            

        }
        .fieldSection .login-form div:last-child{
            justify-content: flex-end;
        }
        img{
            max-width: 400px;
            max-height: 200px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1 class="header">Nhân viên</h1>
        <div class="wrapper">

            <div class="left">
            <section class="fieldSection">
                <label for="name">Tên nhân viên</label>
                <asp:TextBox ID="name" runat="server"></asp:TextBox>
            </section>
            
            <section class="fieldSection">
                <label for="birthday">Ngày Sinh</label>
                <div style="width: 65%;"><asp:TextBox ID="birthday" runat="server"></asp:TextBox> <span>(NgNg/TT/NNNN)</span></div>
            </section>

            <section class="fieldSection">
                <label for="address">Địa chỉ</label>
                <asp:TextBox ID="address" runat="server"></asp:TextBox> 
            </section>

            <section class="fieldSection">
                <label for="role">Chức vụ</label>
                <asp:DropDownList ID="role" runat="server">
                    <asp:ListItem> Giám đốc</asp:ListItem>
                    <asp:ListItem>Thư kí</asp:ListItem>
                    <asp:ListItem>Chủ tịch</asp:ListItem>
                    <asp:ListItem>Nhân Viên</asp:ListItem>
                </asp:DropDownList>
            </section>

            <section class="fieldSection">
                <div class="login-form">
                    <div>
                        <label for="username">
                           tên đăng nhập
                        </label>
                        <asp:TextBox ID="username" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Button ID="search" CssClass="btn btn-secondary" runat="server" Text="Tìm kiếm" />
                        <asp:Button ID="showList" CssClass="btn btn-secondary" runat="server" Text="Liệt kê" />
                    </div>
                </div>
            </section>

            <section class="fieldSection">
                <label for="password">Mật khẩu</label>
                <asp:TextBox ID="password" runat="server"></asp:TextBox>
            </section>

            <section class="fieldSection">
                <label for="repeatPassword">Nhập lại mật khâủ</label>
                <asp:TextBox ID="repeatPassword" runat="server"></asp:TextBox> 
            </section>
            
        </div>
        <div class="right">
            <h4>Ảnh</h4>
            <div class="ImagePlaceholder">
                <img src="Images/anhdep.jpg" id="image" />
            </div>
            <input id="imageInput" type="file" accept="image/*"  />
        </div>

        </div>

        <div class="actionButtonGroup">
            <asp:Button ID="Button1" runat="server" Text="Tạo mới" />
            <asp:Button ID="Button2" runat="server" Text="Thay đổi" />
            <asp:Button ID="Button3" runat="server" Text="Xóa" />
            <asp:Button ID="Button4" runat="server" Text="Nhập lại" />
        </div>
    </form>

    <script>
        document.querySelector("#imageInput").addEventListener("change", (ev) => {
            let fileReader = new FileReader();

            fileReader.onload = function (ev) {
                let base64Image = ev.target.result;
                document.querySelector("#image").src = base64Image;
            }

            fileReader.readAsDataURL(ev.target.files[0]);

        })
    </script>
</body>
</html>
