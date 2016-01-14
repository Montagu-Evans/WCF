<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GetNameDay_Client.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtBox" runat="server"></asp:TextBox>
        <asp:Button ID="btn_result" runat="server" Text="Search date" OnClick="btn_result_Click" />
        <asp:Label ID="lbl_result" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
