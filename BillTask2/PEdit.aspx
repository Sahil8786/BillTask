<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PEdit.aspx.cs" Inherits="BillTask2.PEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <center>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label><asp:TextBox ID="txtname" runat="server"></asp:TextBox><br /><br />
             <asp:Label ID="Label2" runat="server" Text="Category"></asp:Label>&nbsp;<asp:TextBox ID="txtcategory" runat="server"></asp:TextBox><br /><br />&nbsp;
             <asp:Label ID="Label3" runat="server" Text="Price"></asp:Label><asp:TextBox ID="txtPrice" runat="server"></asp:TextBox><br /><br />&nbsp;
             <asp:Label ID="Label4" runat="server" Text="Brand"></asp:Label><asp:TextBox ID="txtbrand" runat="server"></asp:TextBox><br /><br />&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /><asp:Button ID="Button2" runat="server" Text="Delete" OnClick="Button2_Click" />
        </div>
    </form>
    </center>
</body>
</html>
