﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OEdit.aspx.cs" Inherits="BillTask2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <center>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList><br />
            <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList><br />
            <asp:Label ID="Label1" runat="server" Text="Quantity"></asp:Label><asp:TextBox ID="txtquan" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" /><asp:Button ID="Button2" runat="server" Text="Delete" OnClick="Button2_Click1" />
        </div>
    </form>
    </center>
</body>
</html>
