<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnSupplier.aspx.cs" Inherits="AnSupplier" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="lblSupplierNo" runat="server" Text="SupplierNo"></asp:Label>
            <asp:TextBox ID="txtSupplierNo" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <asp:Label ID="lblSupplierName" runat="server" Text="SupplierName"></asp:Label>
        <asp:TextBox ID="txtSupplierName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblSupplierID" runat="server" Text="SupplierID"></asp:Label>
            <asp:TextBox ID="txtSupplierID" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblDateAdded" runat="server" Text="DateAdded"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
        <p>
            <asp:CheckBox ID="Active" runat="server" />
        </p>
        <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="ok" Width="47px" />
            <asp:Button ID="btncancel" runat="server" Text="cancel" />
        </p>
    </form>
</body>
</html>
