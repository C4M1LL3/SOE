﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgTimetable.aspx.cs" Inherits="SOE.html.executive.AgTimetable" %>

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
        <h1 class="form__text">Registrar horarios</h1>
        <div>
            <div class="form_cont">
                <asp:Label ID="Label2" runat="server" Text="Archivo" CssClass="label"></asp:Label>
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <asp:Label ID="Label3" runat="server" Text="Id curso" CssClass="label"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" placeholder="Ingresa el id del curso" CssClass="input"></asp:TextBox>
                <asp:Label ID="Label1" CssClass="help__link" runat="server" Text="" ></asp:Label>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar" CssClass="button" />
            </div>
        </div>
    </form>
    </div>
</body>
</html>
