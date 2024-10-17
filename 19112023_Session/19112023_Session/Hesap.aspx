<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hesap.aspx.cs" Inherits="_19112023_Session.Hesap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Üyelik Bilgileri Sayfası</h1>
            <hr />
            <asp:Label ID="lblKullanici" runat="server"></asp:Label><asp:Button ID="btnLogOut" runat="server" Text="Çıkış Yap" OnClick="btnLogOut_Click" />
        </div>
    </form>
</body>
</html>
