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
        <input type="text" name="code" id="code"/><br/><br/>
        <input type="button" id="btnGetShipper" value="Get Shipper"/><br/><br/>
        
        EDIT SHIPPER DATA<br />
        <label for="id">Shipper Id:</label><br/>
        <input type="text" name="id" id="id"/><br/><br/>
        Company name: <br/>
        <input type="text" id="companyName"/><br/><br/>
        Phone:<br/>
        <input type="text" id="phone" /><br/><br/>
        <input type="button" value="Save" id="btnSave"/>
    </div>
    </form>
</body>
</html>
