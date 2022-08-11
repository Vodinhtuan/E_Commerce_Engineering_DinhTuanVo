<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .myCalendar {  
            background-color: #f2f2f2;  
            width: 80%;
            margin: auto;
            border:10px solid #4CCAEF !important;
            border-top:0px !important;
        }  
        .myCalendar a {  
            text-decoration: none;
        }  
        .myCalendar .myCalendarTitle {  
            font-weight: bold;  
            height:40px;line-height:40px;
            background-color:#4CCAEF;
            color:#ffffff;
        }
        .myCalendar th.myCalendarDayHeader{
            height:25px;
            border-bottom: outset 2px #fbfbfb; 
            border-right: outset 2px #fbfbfb; 
        }
        .myCalendar td.myCalendarDay {  
            border: outset 2px #fbfbfb;
        }
        .myCalendar td.myCalendarDay:nth-child(7) a{
            color: black !important;
            background-color: yellowgreen !important;
        }
        .myCalendar td.myCalendarDay:nth-child(1) a{
            color: black !important;
            background-color: yellowgreen;
        }
        .myCalendar .myCalendarDayHeader a, .myCalendar .myCalendarDay a, .myCalendar .myCalendarSelector a, .myCalendar .myCalendarNextPrev a {  
            display: block;  
            line-height: 30px;  
        }  
        .myCalendar .myCalendarToday{
            background-color: blue;
        }

        .myCalendar .myCalendarToday a{
            color: white !important;
        }
        .myCalendar .myCalendarDay a:hover, .myCalendar .myCalendarSelector a:hover {  
            background-color: #25bae5;  
        }



        .text-form p{
            color: red;
        }

        .TextBoxASP{
            width: 30%;
            padding: 0.3rem;
            border-radius: 0.5rem;
            /*background-color: slategray;*/
            border-color: transparent;
            border: 1px solid black;
        }

        #panelID{
            margin-top: 3%;
            width: 50%;
        }

        .DropDown-QT{
            display: block;
            width: 12%;
            text-align: center;
        }

        .btn{
            margin-top: 3%;
        }

        .btnSubmit{
            display: block;
            padding: 0.8rem 3rem;
            font-weight: bold;
            color: black;
            border-radius: 0.5rem;
        }

        .imgChim{
            width: 80%;
            display: block;
            height: 40vh;
            margin: auto;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="width: 100%; height: 100vh;">
        <div style="width:80%; margin: auto; height: 70vh;">
            <%-- Phần Calendar và image --%>
            <div class="left" style="width: 30%; float: left;">
                <div>
                    <asp:Calendar ID="Calendar2" runat="server" Font-Size="15px" Font-Names="tahoma" CellPadding="0" SelectMonthText=">>" SelectWeekText=">" NextMonthText=">" PrevMonthText="<" CssClass="myCalendar">
                        <OtherMonthDayStyle ForeColor="#0066ff"/>
                        <DayStyle CssClass="myCalendarDay" ForeColor="#663300"/>
                        <DayHeaderStyle CssClass="myCalendarDayHeader" ForeColor="#2d3338" />
                        <SelectedDayStyle Font-Bold="True" Font-Size="12px" CssClass="myCalendarSelector" />
                        <TodayDayStyle CssClass="myCalendarToday" />
                        <SelectorStyle CssClass="myCalendarSelector" />
                        <NextPrevStyle CssClass="myCalendarNextPrev" />
                        <TitleStyle CssClass="myCalendarTitle" />
                    </asp:Calendar>
                </div>
                <div>
                    <img src="chim.jpg" class="imgChim"/>
                </div>
            </div>


            <%-- Phần Form điền thông tin --%>
            <div class="right" style="width: 60%; float: left;">
                <div class="text-form">
                    <p>Mã Sinh Viên : </p>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="TextBoxASP"></asp:TextBox>
                </div>

                <div class="text-form">
                    <p>Họ và Tên : </p>
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="TextBoxASP"></asp:TextBox>
                </div>

                <div class="text-form">
                    <p>Ngày Sinh : </p>
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="TextBoxASP"></asp:TextBox>
                </div>

                <div class="text-form" id="panelID">
                    <asp:Panel ID="Panel1" runat="server" GroupingText="Giới Tính" CssClass="panelGT">
                        Nam<asp:RadioButton ID="RadioButton1" GroupName="GT" runat="server" />
                        Nữ<asp:RadioButton ID="RadioButton2" GroupName="GT" runat="server" />
                    </asp:Panel>
                </div>

                <div class="text-form">
                    <p>Quốc Tịch : </p>
                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="DropDown-QT">
                        <asp:ListItem>Việt Nam</asp:ListItem>
                        <asp:ListItem>Việt Nam</asp:ListItem>
                        <asp:ListItem>Việt Nam</asp:ListItem>
                        <asp:ListItem>Việt Nam</asp:ListItem>
                        <asp:ListItem>Việt Nam</asp:ListItem>
                    </asp:DropDownList>
                </div>

                 <div class="text-form">
                    <p>Sở Thích : </p>
                     <asp:CheckBox ID="CheckBox1" runat="server" />Đọc Sách
                     <asp:CheckBox ID="CheckBox2" runat="server" />Đi Du Lịch
                     <asp:CheckBox ID="CheckBox3" runat="server" />Chơi Thể Thao
                     <asp:CheckBox ID="CheckBox4" runat="server" />Khác
                </div>
                 <div class="text-form">
                    <p>Hình ảnh </p>
                     <asp:FileUpload ID="FileUpload1" runat="server" Width="50%" Font-Size="20px"/>
                </div>
                <div class="btn">
                    <asp:Button ID="Button1" runat="server" Text="OK" CssClass="btnSubmit"/>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
