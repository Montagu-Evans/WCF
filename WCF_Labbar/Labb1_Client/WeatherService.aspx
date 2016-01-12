<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WeatherService.aspx.cs" Inherits="Labb1_Client.WeatherService" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btn_showWeather" runat="server" Text="Show weather: " />
        <asp:Label ID="label_result" runat="server" Text="Result"></asp:Label>
    </div>
    </form>
</body>
</html>
