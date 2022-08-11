<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bai01_Amthanh.aspx.cs" Inherits="Bai06.Bai01_Amthanh" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <bgsound src="địa chỉ file âm thanh" id="bgTest" loop="infinite">
                <embed src="Địa chỉ file" id="wavTest" hidden="false" height="20" width="150"
                    autostart="false" type="audio/wav" loop="true"></embed> 
                        <OBJECT ID="MediaPlayer" WIDTH="192" HEIGHT="190" CLASSID="CLSID:22D6F312-B0F6-11D0-94AB-0080C74C7E95"
                STANDBY="Loading Windows Media Player components..." TYPE="application/x-oleobject">
                <PARAM NAME="FileName" VALUE="nhac.wma">
                <PARAM name="autostart" VALUE="false">
                <PARAM name="ShowControls" VALUE="true">
                <param name="ShowStatusBar" value="false">
                <PARAM name="ShowDisplay" VALUE="false">
                EMBED TYPE="application/x-mplayer2"   SRC="nhac.wma" NAME="MediaPlayer"
                    WIDTH="192" HEIGHT="190" ShowControls="1" ShowStatusBar="0" ShowDisplay="0" autostart="0">
            </EMBED>
            </OBJECT>

        </div>
    </form>
</body>
</html>
