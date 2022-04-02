﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homes.aspx.cs" Inherits="SOE.html.students.homes" %>

<!DOCTYPE html>
<html lang="es">
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
    <form id="form1" runat="server">
    <div id="sidebar" class="sidebar">
        <div class="sidebar__toggle">
            <i class="fas fa-bars sidebar__icon"></i>
        </div>
        <nav class="nav">
            <ul class="nav__ul">
                <li class="nav__li"> <a href="CoMatter.aspx" class="nav__link"> Consultar materias </a> </li>
                <li class="nav__li"> <a href="note.aspx" class="nav__link"> Conusltar notas </a> </li>
                <li class="nav__li"> <a href="CoEnrollment.aspx" class="nav__link"> Consultar matricula </a> </li>
                <li class="nav__li"> <a href="CoTimetable.aspx" class="nav__link"> Consultar horarios </a> </li>
                <li class="nav__li"> <a href="CoStudentHistory.aspx" class="nav__link"> Consultar observador </a> </li>
            </ul>
        </nav>
    </div>
    <div class="inicio">
          <a href="homes.aspx" class="header__link--s">
          <img
          src="../../assets/images/Montaña login (1).png"
          alt="Logo SOE"
          class="header__img"
        />
        </a>
    </div>
    <header class="header">
    </header>
    <div class="hac__header">
      <asp:Image ID="Image2" runat="server" CssClass="hac__img" />
      <div class="hac__toggle">
          <i class="fas fa-sort-down hac__icon"></i>
      </div>
  </div>
    <div id="hac" class="hac">
            <div class="hac__main">
            <div class="hac__top">
                <div class="hac__cont--img">
                    <asp:Image ID="Image1" runat="server" CssClass="hac__img hac__img--sp" />
                </div>
                <asp:Label ID="Label1" runat="server" Text="" CssClass="hac__title"></asp:Label>
                <asp:Label ID="Label2" runat="server" Text="" CssClass="hac__title"></asp:Label>
                <asp:Label ID="Label3" runat="server" Text="" CssClass="hac__title"></asp:Label>
                <asp:Label ID="Label4" runat="server" Text="" CssClass="hac__title"></asp:Label>
                <asp:Label ID="Label5" runat="server" Text="" CssClass="hac__email"></asp:Label>
                <asp:Button ID="Button2" runat="server" Text="Gestionar perfil" cssclass="hac__button" OnClick="Button2_Click"/>
            </div>
            <div class="hac__down">
                <asp:Button ID="Button1" runat="server" Text="Cerrar sesión" cssclass="hac__button" OnClick="Button1_Click"/>
            </div>
        </div>
    </div>

    <main class="main">
        <div class="carrusel">
            <div class="carrusels">
              <input type="radio" name="radio-btn" class="carrusels__radio carrusels__radio--1" id="radio1">
              <input type="radio" name="radio-btn" class="carrusels__radio carrusels__radio--2" id="radio2">
              <input type="radio" name="radio-btn" class="carrusels__radio carrusels__radio--3" id="radio3">
              <input type="radio" name="radio-btn" class="carrusels__radio carrusels__radio--4" id="radio4">

                <div class="carrusel__c carrusel__c--first">
                    <div class="carrusel__target carrusel__target--1" id="carrusel__item--1"> <a href="../../html/information/matricila.aspx" class="carrusel__link" target="_blank"> <img src="../../assets/images/Matriculas SOE.png" alt="Matriculas" class="carrusel__img"> </a> </div>
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

          <div class="news">
            <section class="publication">
              <h1 class="publication__title">
                Publicaciónes
              </h1>
              <div class="publication__cont">
                  <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="newss" GridLines="None"> 
            <Columns>
                <asp:BoundField DataField="id" HeaderText="Id" />
                <asp:BoundField DataField="first_name" HeaderText="Usuario"/>
                <asp:BoundField DataField="text" HeaderText="Anotación"/>
                
            </Columns>
            </asp:GridView>
              </div>
            </section>
            <div class="networks">
              <div class="networks__cont"> 
                <a href="https://www.facebook.com/pages/IED%20Ciudadela%20Educativa%20de%20Bosa/397210013707926" class="networks__link"> <i class="fab fa-facebook networks__i"></i> </a>
                <a href="https://www.youtube.com/channel/UCocZFTGF2fdIfugwHt_7AaQhttps://www.youtube.com/channel/UCocZFTGF2fdIfugwHt_7AaQ" class="networks__link"> <i class="fab fa-youtube networks__i"></i> </a> 
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
                <img src="../../assets/images/Jairo.jpeg" alt="Imagen Jairo" class="footer__imgeq">
                <p class="footer__text"> Jairo Styp Rodriguez Patiño </p>
              </div>
              <div class="footer__equipo">
                <img src="../../assets/images/mercado.jpg" alt="" class="footer__imgeq">
                <p class="footer__text"> Juan David Mercadoo Torres </p>
              </div>
              <div class="footer__equipo">
                <img src="../../assets/images/camilo.jpg" alt="" class="footer__imgeq">
                <p class="footer__text"> Juan Camilo Rojas Rojas </p>
              </div>
              <div class="footer__equipo">
                <img src="../../assets/images/justin.jpg" alt="" class="footer__imgeq">
                <p class="footer__text"> Justin Jarno Garzon Cardenas </p>
              </div>
            </div>
          </div>
        </div>
      </footer>

    <script src="../../js/app.js"></script>

  </form>
</body>
</html>