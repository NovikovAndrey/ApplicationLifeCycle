<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PageLifeCycle.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Жизненый цикл страницы</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="TestButton" runat="server" Text="Test" OnClick="TestButton_Click"/>
        </div>
    </form>
</body>
</html>
