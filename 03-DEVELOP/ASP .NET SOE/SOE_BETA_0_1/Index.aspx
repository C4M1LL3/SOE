<!DOCTYPE html>
<html lang="es">
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
    <link rel="stylesheet" href="css/styles.css" />
    <link rel="shortcut icon" href="assets/images/Montaña login (1).png">
    <title>SOE</title>
  </head>
  <body>
    <header class="header">
      <a href="../../Index.aspx" class="header__link--s">
        <img
        src="../../assets/images/Montaña login (1).png"
        alt="Logo SOE"
        class="header__img"
      />
      </a>
      <a href="html/informacion/informacion.aspx" class="header__link"> <h1 class="header__text">Información</h1> </a>
    </header>
    <main class="main">
      <div class="login">
        <div class="login__cont login__cont--student">
          <a href="html/student/login.html" class="login__link">
            <div class="login__hover">
              <h1 class="login__text">Estudiante</h1>
            </div>
          </a>
        </div>
        <div class="login__cont login__cont--teacher">
          <a href="html/teacher/login.html" class="login__link">
            <div class="login__hover">
              <h1 class="login__text">Profesor</h1>
            </div>
          </a>
        </div>
        <div class="login__cont login__cont--executive">
          <a href="html/executive/login.html" class="login__link">
            <div class="login__hover">
              <h1 class="login__text">Directivo</h1>
            </div>
          </a>
        </div>
      </div>
    </main>
  </body>
</html>
