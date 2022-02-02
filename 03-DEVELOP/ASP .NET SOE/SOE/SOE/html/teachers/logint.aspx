<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="logint.aspx.cs" Inherits="SOE.html.teachers.logint" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="es">
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
    <title>SOE</title>
  </head>
<body>
    <div class="log">
        <form id="form1" runat="server" class="form">
            <h1 class="form__text">Bienvenido</h1>
            <div class="form_cont">
              <label for="target" class="label"> Numeró de documento </label>
                <asp:TextBox ID="TextBox1" runat="server" placeholder="Ingresa tu número de documento"  CssClass="input"></asp:TextBox>
              <label for="password" class="label"> contraseña </label>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" placeholder="Ingresa tu contraseña" CssClass="input"></asp:TextBox>
                <asp:Label ID="Label1" CssClass="help__link" runat="server" Text="" ></asp:Label>
                <div class="btn">
                </div>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ingresar" CssClass="button" />
                </div>
                <div class="help">
                  <a href="#" class="help__link--sp"> ¿Olvidaste tu contraseña?</a>
                </div>
            </div>
        </form>
    </div>
</body>
</html>