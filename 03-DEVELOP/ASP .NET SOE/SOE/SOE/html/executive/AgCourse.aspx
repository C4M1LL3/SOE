<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgCourse.aspx.cs" Inherits="SOE.html.executive.AgCourse" %>

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
        <h1 class="form__text">Registrar Curso </h1>
        <div>
            <div class="form_cont">
                <asp:Label ID="Label2" runat="server" Text="Número de curso" CssClass="label"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" placeholder="Ingresa el número de curso" CssClass="input"></asp:TextBox>
                <asp:Label ID="Label3" runat="server" Text="Año en curso" CssClass="label"></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>2022</asp:ListItem>
                    <asp:ListItem>2023</asp:ListItem>
                    <asp:ListItem>2024</asp:ListItem>
                    <asp:ListItem>2025</asp:ListItem>
                    <asp:ListItem>2026</asp:ListItem>
                    <asp:ListItem>2027</asp:ListItem>
                    <asp:ListItem>2028</asp:ListItem>
                    <asp:ListItem>2029</asp:ListItem>
                    <asp:ListItem>2030</asp:ListItem>
                    <asp:ListItem>2031</asp:ListItem>
                    <asp:ListItem>2032</asp:ListItem>
                </asp:DropDownList>
                <asp:Label ID="Label4" runat="server" Text="Número de ciclo" CssClass="label"></asp:Label>
                <asp:DropDownList ID="DropDownList2" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                </asp:DropDownList>
                <asp:Label ID="Label5" runat="server" Text="Id del profesor" CssClass="label"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" placeholder="Ingresa el id del profesor" CssClass="input"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar" CssClass="button" />
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </form>
    </div>
</body>
</html>
