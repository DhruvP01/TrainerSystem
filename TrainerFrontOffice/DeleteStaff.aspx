<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteStaff.aspx.cs" Inherits="DeleteStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 61px; top: 65px; position: absolute" Text="Are you sure you want to delete this staff member"></asp:Label>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 153px; top: 115px; position: absolute; width: 48px" Text="No" />
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 78px; top: 114px; position: absolute; width: 42px" Text="Yes" />
    </form>
</body>
</html>
