<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="envioemail.aspx.vb" Inherits="proyectos_varios.envioemail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Envió de email</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="eMail destino: "></asp:Label>
            <asp:TextBox ID="TextBox_destino" runat="server"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="Titulo: "></asp:Label>
            <asp:TextBox ID="TextBox_titulo" runat="server"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="Contenido: "></asp:Label>
            <asp:TextBox ID="TextBox_contenido" runat="server" TextMode="MultiLine"></asp:TextBox>
            <br />
            <asp:Button ID="Button_enviar" runat="server" Text="Enviar" OnClick="Button_enviar_Click" />
        </div>
    </form>
</body>
</html>
