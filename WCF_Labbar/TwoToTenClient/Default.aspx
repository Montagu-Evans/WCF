<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TwoToTenClient.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="The description of my page" />
</head>
<body>
    <form id="form1" runat="server">
       <div>
            <asp:Label ID="lbl" runat="server" Text="Skriv in ett nummer mellan 1-13"></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="txtBox" runat="server"></asp:TextBox>
            <asp:Button ID="btn_search" runat="server" Text="Search" />
            <asp:Label ID="lbl_result" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
