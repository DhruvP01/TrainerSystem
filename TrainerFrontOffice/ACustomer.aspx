<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="ACustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerNo" runat="server" Text="Customer No"></asp:Label>
            <asp:TextBox ID="txtCustomerNo" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </div>
        <p>
            <asp:Label ID="lblCustomerName" runat="server" Text="Customer Name"></asp:Label>
            <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblCustomerAddress" runat="server" Text="Customer Address"></asp:Label>
        <asp:TextBox ID="txtCustomerAddress" runat="server"></asp:TextBox>
        <asp:Label ID="lblCustomerTown" runat="server" Text="Customer Town"></asp:Label>
        <asp:TextBox ID="txtCustomerTown" runat="server"></asp:TextBox>
        </p><p>
            <asp:Label ID="lblPostcode" runat="server" Text="Customer Postcode"></asp:Label>
            <asp:TextBox ID="txtPostcode" runat="server"></asp:TextBox>
        </p><p>
        <asp:Label ID="lblCustomerTelephone" runat="server" Text="Customer Telephone"></asp:Label>
        <asp:TextBox ID="txtCustomerTelephone" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCustomerEmail" runat="server" Text="Customer Email"></asp:Label>
            <asp:TextBox ID="txtCustomerEmail" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblDateAdded" runat="server" Text="Date Added"></asp:Label>
            <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
        </p>
        <asp:CheckBox ID="CheckBoxActive" runat="server" Text="Active" />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
