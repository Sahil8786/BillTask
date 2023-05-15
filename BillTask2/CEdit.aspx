<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CEdit.aspx.cs" Inherits="BillTask2.CEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label><asp:TextBox ID="txtname" runat="server"></asp:TextBox><br />
            &nbsp;
            <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label><asp:TextBox ID="txtemail" runat="server"></asp:TextBox><br />
            &nbsp;
            <asp:Label ID="Label3" runat="server" Text="Contact"></asp:Label><asp:TextBox ID="txtcontact" runat="server"></asp:TextBox><br />
            &nbsp;
            <asp:Button ID="Button1" runat="server" CssClass="btn btn-outline-secondary" Text="Submit" OnClick="Button1_Click" /> 
            <asp:Button ID="Button2" runat="server" Text="Delete" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
