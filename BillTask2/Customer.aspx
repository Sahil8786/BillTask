<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="BillTask2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a class="btn btn-primary btn-lg" href="Customer.aspx" >Customer</a><a class="btn btn-primary btn-lg" href="Product.aspx" >Product</a><a class="btn btn-primary btn-lg" href="Order.aspx" >Order</a>
            <h2>Customer List</h2>
            <a class="btn btn-primary btn-lg" href="CreateCustomer.aspx" >New Customer</a>
            <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateSelectButton="True"></asp:GridView>

        </div>
    </form>
</body>
</html>
