<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AddTwoNumbers_Client.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="txtBoxOne" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtBoxTwo" runat="server"></asp:TextBox>
        <asp:Button ID="btn_result" runat="server" Text="Result: " OnClick="btn_result_Click" />
        <asp:Label ID="lbl_result" runat="server"></asp:Label>

    <div>
    
    </div>
    </form>
</body>
</html>
