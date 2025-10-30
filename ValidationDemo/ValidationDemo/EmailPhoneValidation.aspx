<%@ Page Language="C#" AutoEventWireup="true" %>
<script runat="server">
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
            lblResult.Text = "Validation Successful";
        else
            lblResult.Text = "";
    }
</script>

<html>
<body>
    <form runat="server">
        Email:
        <asp:TextBox ID="txtEmail" runat="server" />
        <asp:RegularExpressionValidator 
            ControlToValidate="txtEmail"
            ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$"
            ErrorMessage="Invalid email!" runat="server" />
        <br />

        Phone:
        <asp:TextBox ID="txtPhone" runat="server" />
        <asp:RegularExpressionValidator 
            ControlToValidate="txtPhone"
            ValidationExpression="^\d{10}$"
            ErrorMessage="Invalid phone!" runat="server" />
        <br />

        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        <br />
        <asp:Label ID="lblResult" runat="server" />
    </form>
</body>
</html>
