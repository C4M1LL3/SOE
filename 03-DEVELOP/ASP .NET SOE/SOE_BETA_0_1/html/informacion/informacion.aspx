<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="informacion.aspx.cs" Inherits="SOE_BETA_0_1.html.informacion.informacion" %>

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
    <link rel="stylesheet" href="../../css/styles.css" />
    <link rel="shortcut icon" href="../../assets/images/Montaña login (1).png">
    <title>SOE</title>
<body>
    <header class="header">
      <a href="../../Index.aspx" class="header__link--s">
        <img
        src="../../assets/images/Montaña login (1).png"
        alt="Logo SOE"
        class="header__img"
      />
      </a>
      </header>
      <main>
          <div class="carrusel">
            <div class="carrusels">
              <input type="radio" name="radio-btn" class="carrusels__radio carrusels__radio--1" id="radio1">
              <input type="radio" name="radio-btn" class="carrusels__radio carrusels__radio--2" id="radio2">
              <input type="radio" name="radio-btn" class="carrusels__radio carrusels__radio--3" id="radio3">
              <input type="radio" name="radio-btn" class="carrusels__radio carrusels__radio--4" id="radio4">

                <div class="carrusel__c carrusel__c--first">
                    <div class="carrusel__target carrusel__target--1" id="carrusel__item--1"> <a href="matricula.aspx" class="carrusel__link"> <img src="../../assets/images/Matriculas SOE.png" alt="Matriculas" class="carrusel__img"> </a> </div>
                </div>
                <div class="carrusel__c">
                  <div class="carrusel__target carrusel__target--2 " id="carrusel__item--2"> <a href="https://www.un.org/es/observances/water-day " class="carrusel__link" target="_blank"> <img src="../../assets/images/Dia del agua Soe.png" alt="Dia del agua" class="carrusel__img"> </a>  </div>
                </div>
                <div class="carrusel__c">
                    <div class="carrusel__target carrusel__target--3" id="carrusel__item--3"> <a href="https://resultados.icfes.gov.co/login" class="carrusel__link" target="_blank"> <img src="../../assets/images/Noticia 3 SOE.png" alt="Icfes" class="carrusel__img"> </a> </div>
                </div>
                <div class="carrusel__c">
                    <div class="carrusel__target carrusel__target--4" id="carrusel__item--4"> <a href="http://ciudadelaemf.blogspot.com/" class="carrusel__link" target="_blank"> <img src="../../assets/images/Noticia4.png" alt="Media" class="carrusel__img"> </a> </div>
                </div>
            </div>
            <div class="carrusels__manual">
              <label for="radio1" class="carrusels__label"></label>
              <label for="radio2" class="carrusels__label"></label>
              <label for="radio3" class="carrusels__label"></label>
              <label for="radio4" class="carrusels__label"></label>
            </div>
          </div>

          <div style="height: 150px; overflow: hidden;" class="wave"><svg viewBox="0 0 500 150" preserveAspectRatio="none" style="height: 100%; width: 100%;"><path d="M-1.97,68.59 C176.35,-75.47 319.13,193.92 500.00,49.98 L500.00,150.00 L0.00,150.00 Z" style="stroke: none; fill: rgb(31, 31, 31);"></path></svg></div>

          <div class="inform">
            <div class="inform__header">
              <img src="../../assets/images/escudo decolegio.png" alt="Escudo del colegio" class="inform__escud">
              <h1 class="inform__title"> Colegio ciudadela educativa de Bosa </h1>
            </div>
            <div class="inform__main">
              <p class="inform__p">
                El colegio Ciudadela Educativa de Bosa, es una institución de carácter oficial ubicada en la localidad séptima de la ciudad de Bogotá; que ofrece los niveles de formación del preescolar, básica y media con énfasis en TIC, propendiendo por una formación integral, inclusiva y transformadora de la problemática social, económica, política y ambiental que contribuye al plan de desarrollo de la nación.
              </p>
              <img src="../../assets/images/undraw_book_lover_re_rwjy.svg" alt="expreción" class="inform__imginf">
            </div>
          </div>
          <div class="contactinf">
            <div class="contactinf__imgage">
              <img src="../../assets/images/undraw_begin_chat_re_v0lw.svg" alt="" class="contactinf__img">
            </div>
            <div class="contactinf__content">
              <div class="cantactinf__div cantactinf__div--dirrec">
                <h3 class="cantactinf__text"> Dirección </h3>
                <p class="contactinf__p"> Cl. 52 Sur #97C - 35, Bogotá </p>
              </div>
              <div class="cantactinf__div cantactinf__div--contact">
                <h3 class="cantactinf__text"> Contacto </h3>
                <p class="contactinf__p"> colciudadelabosa@educacionbogota.edu.co </p>
              </div>
            </div>
          </div>
      </main>

      <footer class="footer">
        <div class="footer__conter">
          <div class="footer__element">
            <div class="footer__contact">
              <h2 class="footer__title"> Contactanos </h2>
              <p class="footer__text"> <i class="fas fa-mobile-alt"></i> +57 314 3988982 </p>
              <p class="footer__text"> <i class="fas fa-envelope"></i> c4m1ll32@gmail.com </p>
            </div>
            <div class="footer__log">
              <img src="../../assets/images/photo_2021-05-28_15-44-17.jpg" alt="" class="footer__imglog">
            </div>
          </div>
          <div class="footer__element footer__element--sp">
            <div class="footer__contact">
              <h2 class="footer__title"> Nuestro objetivo </h2>
              <p class="footer__text footer__text--sp"> Brindar un servicio de manejo de datos para la institución
                educativa Ciudadela Educativa de Bosa, el cual facilite la
                gestión, recolección y organización de datos de forma
                dinámica, a través de una plataforma web privada para los
                integrantes de una institución, ya sean estudiantes,
                profesores y directivos. </p>
            </div>
          </div>
          <div class="footer__element footer__element--sp2">
            <div class="footer__contact">
              <h2 class="footer__title"> Nuestro equipo </h2>
              <div class="footer__equipo">
                <img src="" alt="" class="footer__imgeq">
                <p class="footer__text"> Jairo Styp Rodriguez Patiño </p>
              </div>
              <div class="footer__equipo">
                <img src="" alt="" class="footer__imgeq">
                <p class="footer__text"> Juan David Mercadoo Torres </p>
              </div>
              <div class="footer__equipo">
                <img src="../../assets/images/camilo.jpg" alt="" class="footer__imgeq">
                <p class="footer__text"> Juan Camilo Rojas Rojas </p>
              </div>
                            <div class="footer__equipo">
                <img src="" alt="" class="footer__imgeq">
                <p class="footer__text"> Justin Jarno Garzon Cardenas </p>
              </div>
            </div>
          </div>
        </div>
      </footer>

</body>
</html>