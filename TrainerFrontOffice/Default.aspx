<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomers" runat="server" Height="258px" Width="352px"></asp:ListBox>
        <p>
            <asp:Label ID="lblEnterPostcode" runat="server" Text="Please Enter Customer Post Code"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtEnterPostcode" runat="server" Width="195px"></asp:TextBox>
        </p>
        <asp:Button ID="btnApply" runat="server" Text="Apply" />
        <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" />
        <p>
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" />
        </p>
    </form>
</body>
</html>
