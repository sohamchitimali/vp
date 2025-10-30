<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="Linq.Employees" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Employees</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true" />
        </div>
    </form>
</body>
</html>