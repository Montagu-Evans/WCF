<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SubtractTwoNumbers_Client.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtBoxOne" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtBoxTwo" runat="server"></asp:TextBox>
        <asp:Button ID="btn_showResult" runat="server" Text="Show result" OnClick="btn_showResult_Click" />
        <asp:Label ID="lbl_result" runat="server" Text="Result: "></asp:Label>
    </div>
    </form>
</body>
</html>
