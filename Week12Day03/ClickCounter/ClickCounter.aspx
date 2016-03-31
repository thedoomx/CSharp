<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClickCounter.aspx.cs" Inherits="ClickCounter.ClickCounter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="welcomeLbl" runat="server" Text="Welcome"></asp:Label>
    
        <br />
        <asp:Button ID="btnClicker" runat="server" Text="Click" OnClick="btnClicker_Click" />
        <br />
        <asp:Label ID="SessionClicks" runat="server" Text="Session clicks: "></asp:Label>
        <asp:Label ID="lblSession" runat="server" Text="0"></asp:Label>
        <br />
        <asp:Label ID="lblApplication" runat="server" Text="Application clicks: "></asp:Label>
    
        <asp:Label ID="lblTotalClicks" runat="server" Text="0"></asp:Label>
        <br />
    
    </div>
        <asp:Label ID="lblCurrentUser" runat="server" Text="Current user: "></asp:Label>
        <asp:Label ID="lblUserClicks" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
