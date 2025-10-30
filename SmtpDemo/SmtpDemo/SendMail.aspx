<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendMail.aspx.cs" Inherits="SmtpDemo.SendMail" %>

<html>
<body>
    <form runat="server">
        <asp:Button ID="btnSend" runat="server" Text="Send Mail" OnClick="btnSend_Click" />
        <asp:Label ID="lblMsg" runat="server" />
    </form>
</body>
</html>
