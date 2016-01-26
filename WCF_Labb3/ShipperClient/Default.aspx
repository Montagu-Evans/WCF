<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ShipperClient.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>EDIT SHIPPER INFORMATION</h1>
        <label for="code">Enter Shipper Code:</label> <br/>
        <asp:TextBox ID="txtBoxOne" runat="server"></asp:TextBox>
        <br/>
        <asp:Button ID="btn_GetShipper" runat="server" OnClick="btn_GetShipper_Click" Text="Get Shipper" />
        <br/><br/>
        
        EDIT SHIPPER DATA<br />
        <label for="id">Shipper Id:</label><br/>
        <asp:TextBox ID="TxtBoxTwo" runat="server"></asp:TextBox>
        <br/><br/>
        Company name: <br/>
        <asp:TextBox ID="txtBoxThree" runat="server"></asp:TextBox>
        <br/><br/>
        Phone:<br/>
        <asp:TextBox ID="txtBoxFour" runat="server"></asp:TextBox>
        <br/>
        &nbsp;<asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" />
    </div>
    </form>
</body>
</html>
