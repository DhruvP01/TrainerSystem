<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDefault.aspx.cs" Inherits="StaffDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaff" runat="server" style="z-index: 1; left: 34px; top: 18px; position: absolute; height: 209px; width: 240px"></asp:ListBox>
        <asp:Label ID="lblEnterPostCode" runat="server" style="z-index: 1; left: 43px; top: 259px; position: absolute" Text="Please Enter a Post Code"></asp:Label>
        <asp:TextBox ID="txtEnterPostCode" runat="server" style="z-index: 1; left: 43px; top: 296px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 41px; top: 352px; position: absolute" Text="Apply" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; top: 351px; position: absolute; left: 128px" Text="Display All" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 39px; top: 420px; position: absolute; width: 48px" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 120px; top: 420px; position: absolute; width: 45px" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 193px; top: 420px; position: absolute" Text="Delete" />
    </form>
</body>
</html>
