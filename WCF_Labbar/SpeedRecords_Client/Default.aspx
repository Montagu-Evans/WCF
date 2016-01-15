<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SpeedRecords_Client.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Search specific year (e.g 1929..)
        </div>
    <div>
        <asp:TextBox ID="txtBox_speed" runat="server"></asp:TextBox>
        <asp:Button ID="btn_search" runat="server" Text="Search" OnClick="btn_search_Click" />
        <asp:Label ID="lbl_result" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
