<%@ Page Language="C#" AutoEventWireup="true" CodeFile="q2.aspx.cs" Inherits="q2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
<asp:TextBox id="productc" runat="server"></asp:TextBox>
            <asp:Label  runat="server" Text="Product"></asp:Label><br />
            <asp:TextBox id="picture" runat="server"></asp:TextBox>
            <asp:Label  runat="server" Text="Picture"></asp:Label><br />
<asp:TextBox id="price" runat="server"></asp:TextBox>
            <asp:Label  runat="server" Text="Price"></asp:Label><br />
<asp:TextBox id="supplier" runat="server"></asp:TextBox>
            <asp:Label  runat="server" Text="Supplier"></asp:Label><br />
<asp:Button OnClick="Button1_Click" runat="server" Text="Open table" />

        </div>
    </form>
</body>
</html>

