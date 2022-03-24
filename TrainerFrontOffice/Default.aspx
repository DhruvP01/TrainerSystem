<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 129px;
            height: 83px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblWickedTrainers" runat="server" style="font-weight: 700; font-size: xx-large; color: #FF9933" Text="Wicked Trainers"></asp:Label>
            <img alt="" class="auto-style1" src="Images/Logo.jpg" /></div>
        <asp:ListBox ID="lstCustomers" runat="server" Height="258px" Width="352px" style="font-weight: 700; color: #000000"></asp:ListBox>
        <p>
            <asp:Label ID="lblEnterPostcode" runat="server" Text="Please Enter Customer Post Code" style="font-weight: 700"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtEnterPostcode" runat="server" Width="195px"></asp:TextBox>
        </p>
        <asp:Button ID="btnApply" runat="server" Text="Apply" OnClick="btnApply_Click" style="font-weight: 700" />
        <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" OnClick="btnDisplayAll_Click" style="font-weight: 700" />
        <asp:Label ID="lblError" runat="server" style="font-weight: 700"></asp:Label>
        <p>
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" style="font-weight: 700" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" style="font-weight: 700" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" style="font-weight: 700" />
        </p>
    </form>
</body>
</html>
