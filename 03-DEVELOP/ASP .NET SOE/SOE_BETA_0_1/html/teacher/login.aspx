<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="SOE_BETA_0_1.html.teacher.login" %>

<!DOCTYPE html>
<html lang="en">
  <head>
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
      <form action="login.html " class="form">
        <h1 class="form__text">Bienvenido</h1>
        <div class="forml">
          <label for="target" class="label"> Numeró de documento </label>
          <input
            type="text"
            class="input"
            placeholder="Ingresa tu numeró de documento"
          />
          <label for="password" class="label"> contraseña </label>
          <input
            type="password"
            class="input"
            placeholder="Escribe tu contraseña"
          />
          <div class="btn">
            <button class="button">Ingresar</button>
          </div>
        </div>
        <div class="help">
          <a href="#" class="help__link"> ¿Olvidaste tu contrseña?</a>
        </div>
      </form>
    </div>
  </body>
</html>
