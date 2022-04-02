<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgEnrollmentt.aspx.cs" Inherits="SOE.html.executive.AgEnrollmentt" %>

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
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin="" />
    <link
      href="https://fonts.googleapis.com/css2?family=Poppins&family=Roboto&display=swap"
      rel="stylesheet"
    />
    <link rel="stylesheet" href="../../css/styles.css" />
    <link rel="shortcut icon" href="../../assets/images/Montaña login (1).png"/>
    <title>SOE</title>
</head>
<body>
    <div class="log">
    <form id="form1" runat="server" class="form">
        <h1 class="form__text">Registrar Matricula</h1>
        <div>
            <div class="form_cont">
                <asp:Label ID="Label2" runat="server" Text="Número de documento del estudiante" CssClass="label"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" placeholder="Ingresa el número de documento del estudiante" CssClass="input"></asp:TextBox>
                <asp:Label ID="Label3" runat="server" Text="Id eps" CssClass="label"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" placeholder="Ingresa id de la eps" CssClass="input"></asp:TextBox>
                <asp:Label ID="Label4" runat="server" Text="Dirección" CssClass="label"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server" placeholder="Ingresa la dirección del estudiante" CssClass="input"></asp:TextBox>
                <asp:Label ID="Label7" runat="server" Text="Numero de casa o apartamento" CssClass="label"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server" placeholder="Ingresa el número de la casa o apartamento" CssClass="input"></asp:TextBox>
                <asp:Label ID="Label6" runat="server" Text="Estado" CssClass="label"></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>0</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                </asp:DropDownList>
                <asp:Label ID="Label1" runat="server" Text="Número de documento del padre del estudiante" CssClass="label"></asp:Label>
                <asp:TextBox ID="TextBox5" runat="server" placeholder="Ingresa el número de documento del padre del estudiante" CssClass="input"></asp:TextBox>
                <asp:Label ID="Label8" runat="server" Text="Número de documento de la madre del estudiante" CssClass="label"></asp:Label>
                <asp:TextBox ID="TextBox6" runat="server" placeholder="Ingresa el número de documento de la madre del estudiante" CssClass="input"></asp:TextBox>
                <asp:Label ID="Label9" runat="server" Text="Número de documento del tutor del estudiante" CssClass="label"></asp:Label>
                <asp:TextBox ID="TextBox7" runat="server" placeholder="Ingresa el número de documento del tutor del estudiante" CssClass="input"></asp:TextBox>
                <asp:Label ID="Label5" runat="server" Text="" CssClass="help__link"></asp:Label>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar" CssClass="button" />
            </div>
        </div>
    </form>
    </div>
</body>
</html>
