<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DeathOfJanuary_Client.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Search dates between 1-13...
        </div>
        <div>
            <asp:TextBox ID="txtBoxOfDeath" runat="server"></asp:TextBox>
            <asp:Button ID="btn_search" runat="server" Text="Search" OnClick="btn_search_Click" />
            <asp:Label ID="lbl_result" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
