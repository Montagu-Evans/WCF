<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Death_Client.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl" runat="server" Text="List contains following names so far: Giorgio, Gunnel, David, Bård, Ove, Maria, Angus, Red, André, Kitty, Richard, Mohammed"></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="txtBox" runat="server"></asp:TextBox>
            <asp:Button ID="btn_search" runat="server" Text="Search" OnClick="btn_search_Click" />
            <asp:Label ID="lbl_result" runat="server" Text=""></asp:Label>

        </div>
    </form>
</body>
</html>
