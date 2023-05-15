<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="BillTask2.Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a class="btn btn-primary btn-lg" href="CreateCustomer.aspx" >New Product</a>
            <h2>Product List</h2>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView>
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        </div>
    </form>
</body>
</html>
