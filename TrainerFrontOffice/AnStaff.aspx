<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnStaff.aspx.cs" Inherits="AnStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffNo" runat="server" style="z-index: 1; left: 49px; top: 37px; position: absolute; right: 1388px;" Text="StaffNo"></asp:Label>
        <p>
            <asp:TextBox ID="txtStaffNo" runat="server" style="z-index: 1; left: 142px; top: 40px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 142px; top: 88px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtAdress" runat="server" style="z-index: 1; left: 139px; top: 133px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 49px; top: 86px; position: absolute" Text="PostCode"></asp:Label>
        <asp:Label ID="lblAdress" runat="server" style="z-index: 1; left: 49px; top: 133px; position: absolute" Text="Address"></asp:Label>
        <asp:Label ID="lblTown" runat="server" style="z-index: 1; left: 48px; top: 182px; position: absolute" Text="Town"></asp:Label>
        <asp:Label runat="server" style="z-index: 1; left: 44px; top: 270px; position: absolute" Text="Label"></asp:Label>
        <asp:DropDownList ID="ddlTown" runat="server" style="z-index: 1; left: 137px; top: 184px; position: absolute">
        </asp:DropDownList>
        <asp:CheckBox ID="Active" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" style="z-index: 1; left: 43px; top: 223px; position: absolute" Text="Active" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 41px; top: 314px; position: absolute; right: 1436px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 119px; top: 314px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
