<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgNotaTrim.aspx.cs" Inherits="SOE.html.teachers.AgNotaTrim" %>

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
    <link rel="shortcut icon" href="../../assets/images/Montaña login (1).png">
    <title>SOE</title>
</head>
<body>
    <div class="log">
    <form id="form1" runat="server" class="form">
        <h1 class="form__text">Registrar notas</h1>
        <div>
            <div class="form_cont">
                <asp:Label ID="Label2" runat="server" Text="Número de documento del estudiante" CssClass="label"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" placeholder="Ingresa el número de documento del estudiante" CssClass="input"></asp:TextBox>
                <asp:Label ID="Label3" runat="server" Text="Id materia" CssClass="label"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" placeholder="Ingresa el id de la materia" CssClass="input"></asp:TextBox>
                <asp:Label ID="Label4" runat="server" Text="Número de trimestre" CssClass="label"></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                </asp:DropDownList>
                <asp:Label ID="Label5" runat="server" Text="70%" CssClass="label"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server" placeholder="Ingresa el 70% de la nota" CssClass="input"></asp:TextBox>
                <asp:Label ID="Label6" runat="server" Text="20%" CssClass="label"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server" placeholder="Ingresa el 20% de la nota" CssClass="input"></asp:TextBox>
                <asp:Label ID="Label7" runat="server" Text="10%" CssClass="label"></asp:Label>
                <asp:TextBox ID="TextBox5" runat="server" placeholder="Ingresa el 10% de la nota" CssClass="input"></asp:TextBox>
                <asp:Label ID="Label8" runat="server" Text="Nota final" CssClass="label"></asp:Label>
                <asp:TextBox ID="TextBox6" runat="server" placeholder="Ingresa la nota final" CssClass="input"></asp:TextBox>
                <asp:Label ID="Label1" CssClass="help__link" runat="server" Text="" ></asp:Label>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar" CssClass="button" />
            </div>
        </div>
    </form>
    </div>
</body>
</html>
