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
        <asp:Label ID="lblStaffNo" runat="server" style="z-index: 1; left: 53px; top: 30px; position: absolute" Text="StaffNo"></asp:Label>
        <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 52px; top: 66px; position: absolute" Text="PostCode"></asp:Label>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 55px; top: 102px; position: absolute" Text="Address"></asp:Label>
        <asp:Label ID="lblTown" runat="server" style="z-index: 1; left: 56px; top: 135px; position: absolute" Text="Town"></asp:Label>
        <asp:TextBox ID="txtStaffNo" runat="server" style="z-index: 1; left: 143px; top: 28px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 141px; top: 63px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 138px; top: 101px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 54px; top: 169px; position: absolute" Text="Date Added"></asp:Label>
        <asp:CheckBox ID="CheckBox1" runat="server" style="z-index: 1; left: 54px; top: 215px; position: absolute" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 57px; top: 257px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 52px; top: 295px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 146px; top: 292px; position: absolute" Text="Cancel" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 369px; top: 28px; position: absolute" Text="Find" />
        <p>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 137px; top: 167px; position: absolute"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtTown" runat="server" style="z-index: 1; left: 135px; top: 136px; position: absolute"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
