<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="CollegeRegistrationApp.Registration" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Student Registration</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Registration</h2>

        <p>
            <asp:Label ID="lblName" runat="server" Text="Name:" />
            <asp:TextBox ID="txtName" runat="server" />
        </p>

        <p>
            <asp:Label ID="lblEmail" runat="server" Text="Email:" />
            <asp:TextBox ID="txtEmail" runat="server" />
        </p>

        <p>
            <asp:Label ID="lblGender" runat="server" Text="Gender:" />
            <asp:RadioButtonList ID="rblGender" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
        </p>

        <p>
            <asp:Label ID="lblCountry" runat="server" Text="Country:" />
            <asp:DropDownList ID="ddlCountry" runat="server">
                <asp:ListItem>Select Country</asp:ListItem>
                <asp:ListItem>India</asp:ListItem>
                <asp:ListItem>USA</asp:ListItem>
                <asp:ListItem>UK</asp:ListItem>
            </asp:DropDownList>
        </p>

        <p>
            <asp:Button ID="btnRegister" runat="server" Text="Register" />
        </p>
    </form>
</body>
</html>
