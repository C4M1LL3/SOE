<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgUser.aspx.cs" Inherits="SOE.html.executive.AgUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <script
      src="https://kit.fontawesome.com/6015db8334.js"
      crossorigin="anonymous"
    ></script>
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
    <link
      href="https://fonts.googleapis.com/css2?family=Poppins&family=Roboto&display=swap"
      rel="stylesheet"
    />
    <link rel="stylesheet" href="../../css/styles.css" />
    <link rel="shortcut icon" href="../../assets/images/Montaña login (1).png">
    <title>SOE</title>
</head>
<body>
    <div class="log">
    <form id="form1" runat="server" class="form">
        <h1 class="form__text">Registrar usuario</h1>
        <div>
            <div class="form_cont">
                <asp:Label ID="Label2" runat="server" Text="Número de documento" CssClass="label"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" placeholder="Ingresa el número de documento" CssClass="input"></asp:TextBox>
                <asp:Label ID="Label3" runat="server" Text="Contraseña" CssClass="label"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" placeholder="Ingresa la contraseña" CssClass="input" TextMode="Password"></asp:TextBox>
                <asp:Label ID="Label4" runat="server" Text="Correo institucional" CssClass="label"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server" placeholder="Ingresa el correo institucional" CssClass="input"></asp:TextBox>
                <asp:Label ID="Label5" runat="server" Text="Imagen" CssClass="label"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server" placeholder="Ingresa la imagen" CssClass="input"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar" CssClass="button" />
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </div>
            <div class="form_cont">
                <asp:Label ID="Label6" runat="server" Text="Rol de usuario" CssClass="label"></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>directivo</asp:ListItem>
                    <asp:ListItem>profesor</asp:ListItem>
                    <asp:ListItem>estudiante</asp:ListItem>
                </asp:DropDownList>
                <asp:Button ID="Button2" runat="server" Text="Agregar" OnClick="Button2_Click" CssClass="button" />
            </div>
            <div class="form_cont">
                <asp:Label ID="Label7" runat="server" Text="Número de documento" CssClass="label"></asp:Label>
                <asp:TextBox ID="TextBox5" runat="server" placeholder="Ingresa el número de documento" CssClass="input"></asp:TextBox>
                <asp:Label ID="Label12" runat="server" Text="Tipo de ducumento" CssClass="label"></asp:Label>
                <asp:DropDownList ID="DropDownList2" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                </asp:DropDownList>
                <asp:Label ID="Label8" runat="server" Text="Primer nombre" CssClass="label"></asp:Label>
                <asp:TextBox ID="TextBox6" runat="server" placeholder="Ingresa tu primer nombre" CssClass="input"></asp:TextBox>
                <asp:Label ID="Label9" runat="server" Text="Segundo nombre" CssClass="label"></asp:Label>
                <asp:TextBox ID="TextBox7" runat="server" placeholder="Ingresa tu primersegundo nombre" CssClass="input"></asp:TextBox>
                <asp:Label ID="Label10" runat="server" Text="Primer apellido" CssClass="label"></asp:Label>
                <asp:TextBox ID="TextBox8" runat="server" placeholder="Ingresa tu primer apellido" CssClass="input"></asp:TextBox>
                <asp:Label ID="Label11" runat="server" Text="Segundo apellido" CssClass="label"></asp:Label>
                <asp:TextBox ID="TextBox9" runat="server" placeholder="Ingresa tu segundo apellido" CssClass="input"></asp:TextBox>
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Agregar" CssClass="button"/>
            </div>
        </div>
    </form>
    </div>
</body>
</html>
