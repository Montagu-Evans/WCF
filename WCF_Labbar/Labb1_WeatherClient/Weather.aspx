<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Weather.aspx.cs" Inherits="Labb1_WeatherClient.Weather" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btn_showWeather" runat="server" Text="Predict weather condition" />
        <asp:Label ID="labelResult" runat="server" Text="Result"></asp:Label>
    </div>
    </form>
</body>
</html>
