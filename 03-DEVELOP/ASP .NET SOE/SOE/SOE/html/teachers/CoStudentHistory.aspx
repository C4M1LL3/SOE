<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CoStudentHistory.aspx.cs" Inherits="SOE.html.teachers.CoStudentHistory" %>

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
    <link
      rel="shortcut icon"
      href="../../assets/images/Montaña login (1).png"
    />
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
                <li class="nav__li"> <a href="CoCourse.aspx" class="nav__link"> Conusltar cursos </a> </li>
                <li class="nav__li"> <a href="note.aspx" class="nav__link"> Notas </a> </li>
                <li class="nav__li"> <a href="CoTimetable.aspx" class="nav__link"> Consultar horarios </a> </li>
                <li class="nav__li"> <a href="student_history.aspx" class="nav__link"> Observador </a> </li>
            </ul>
        </nav>
      </div>
      <div class="inicio">
        <a href="homet.aspx" class="header__link--s">
          <img
            src="../../assets/images/Montaña login (1).png"
            alt="Logo SOE"
            class="header__img"
          />
        </a>
      </div>
      <header class="header"></header>
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
              <asp:Image
                ID="Image1"
                runat="server"
                CssClass="hac__img hac__img--sp"
              />
            </div>
            <asp:Label
              ID="Label1"
              runat="server"
              Text=""
              CssClass="hac__title"
            ></asp:Label>
            <asp:Label
              ID="Label2"
              runat="server"
              Text=""
              CssClass="hac__title"
            ></asp:Label>
            <asp:Label
              ID="Label3"
              runat="server"
              Text=""
              CssClass="hac__title"
            ></asp:Label>
            <asp:Label
              ID="Label4"
              runat="server"
              Text=""
              CssClass="hac__title"
            ></asp:Label>
            <asp:Label
              ID="Label5"
              runat="server"
              Text=""
              CssClass="hac__email"
            ></asp:Label>
            <asp:Button
              ID="Button1"
              runat="server"
              Text="Gestionar perfil"
              cssclass="hac__button"
              OnClick="Button2_Click"
            />
          </div>
          <div class="hac__down">
            <asp:Button
              ID="Button3"
              runat="server"
              Text="Cerrar sesión"
              cssclass="hac__button"
              OnClick="Button1_Click"
            />
          </div>
        </div>
      </div>
      <main>
        <div class="conterPerfil">
          <div class="contener__busqueda">
            <asp:TextBox
              ID="TextBox9"
              runat="server"
              CssClass="busqueda__input"
              placeholder="Ingresa el nombre del estudiante"
            ></asp:TextBox>
            <asp:Button
              ID="Button2"
              runat="server"
              OnClick="Button3_Click"
              Text="Buscar"
              CssClass="cambiar"
            />
            <asp:Label
              ID="Label14"
              runat="server"
              Text=""
              CssClass="help__link"
            ></asp:Label>
          </div>
          <div class="enrollment__cont">
            <div class="enrollment__header">
              <div class="hac__cont--img">
                <asp:Image
                  ID="Image4"
                  runat="server"
                  CssClass="image__profile"
                />
              </div>
              <div>
                <asp:Label
                  ID="Label6"
                  runat="server"
                  Text=""
                  CssClass="name__profile"
                ></asp:Label>
                <asp:Label
                  ID="Label7"
                  runat="server"
                  Text=""
                  CssClass="name__profile"
                ></asp:Label>
                <asp:Label
                  ID="Label8"
                  runat="server"
                  Text=""
                  CssClass="name__profile"
                ></asp:Label>
                <asp:Label
                  ID="Label9"
                  runat="server"
                  Text=""
                  CssClass="name__profile"
                ></asp:Label>
              </div>
            </div>
            <div class="enrollment__main">
              <div class="enrollment__campt">
                <p class="enrollment__title">Numero de documento:</p>
                <div class="enr__cont">
                  <asp:Label
                    ID="Label10"
                    runat="server"
                    Text=""
                    CssClass="enrollment__camp"
                  ></asp:Label>
                  <asp:Label
                    ID="Label11"
                    runat="server"
                    Text=""
                    CssClass="enrollment__camp"
                  ></asp:Label>
                </div>
              </div>
              <div class="enrollment__campt">
                <p class="enrollment__title">Fecha de nacimiento:</p>
                <div class="enr__cont">
                  <asp:Label
                    ID="Label12"
                    runat="server"
                    Text=""
                    CssClass="enrollment__camp"
                  ></asp:Label>
                </div>
              </div>
              <div class="enrollment__campt">
                <p class="enrollment__title">Lugar de nacimiento:</p>
                <div class="enr__cont">
                  <asp:Label
                    ID="Label13"
                    runat="server"
                    Text=""
                    CssClass="enrollment__camp"
                  ></asp:Label>
                </div>
              </div>
              <div class="enrollment__campt">
                <p class="enrollment__title">Curso:</p>
                <div class="enr__cont">
                  <asp:Label
                    ID="Label15"
                    runat="server"
                    Text=""
                    CssClass="enrollment__camp"
                  ></asp:Label>
                </div>
              </div>
              <div class="enrollment__campt">
                <p class="enrollment__title">Año en curso:</p>
                <div class="enr__cont">
                  <asp:Label
                    ID="Label16"
                    runat="server"
                    Text=""
                    CssClass="enrollment__camp"
                  ></asp:Label>
                </div>
              </div>
              <div class="enrollment__campt">
                <p class="enrollment__title">Número de ciclo:</p>
                <div class="enr__cont">
                  <asp:Label
                    ID="Label17"
                    runat="server"
                    Text=""
                    CssClass="enrollment__camp"
                  ></asp:Label>
                </div>
              </div>
              <div class="enrollment__campt">
                <p class="enrollment__title">Colegio:</p>
                <div class="enr__cont">
                  <asp:Label
                    ID="Label18"
                    runat="server"
                    Text="Colegio ciudadela educativa de Bosa"
                    CssClass="enrollment__camp"
                  ></asp:Label>
                </div>
              </div>
              <div class="enrollment__campt">
                <p class="enrollment__title">Nombre director de curso:</p>
                <div class="enr__cont">
                  <asp:Label
                    ID="Label19"
                    runat="server"
                    Text=""
                    CssClass="enrollment__camp"
                  ></asp:Label>
                  <asp:Label
                    ID="Label20"
                    runat="server"
                    Text=""
                    CssClass="enrollment__camp"
                  ></asp:Label>
                  <asp:Label
                    ID="Label21"
                    runat="server"
                    Text=""
                    CssClass="enrollment__camp"
                  ></asp:Label>
                  <asp:Label
                    ID="Label22"
                    runat="server"
                    Text=""
                    CssClass="enrollment__camp"
                  ></asp:Label>
                </div>
              </div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="newss" GridLines="None"> 
            <Columns>
                <asp:BoundField DataField="id" HeaderText="Id" />
                <asp:BoundField DataField="notation_date" HeaderText="Fecha"/>
                <asp:BoundField DataField="notation" HeaderText="Anotación"/>
            </Columns>
            </asp:GridView>
            </div>
          </div>
        </div>
      </main>
      <footer class="footer">
        <div class="footer__conter">
          <div class="footer__element">
            <div class="footer__contact">
              <h2 class="footer__title">Contactanos</h2>
              <p class="footer__text">
                <i class="fas fa-mobile-alt"></i> +57 314 3988982
              </p>
              <p class="footer__text">
                <i class="fas fa-envelope"></i> c4m1ll32@gmail.com
              </p>
            </div>
            <div class="footer__log">
              <img
                src="../../assets/images/photo_2021-05-28_15-44-17.jpg"
                alt=""
                class="footer__imglog"
              />
            </div>
          </div>
          <div class="footer__element footer__element--sp">
            <div class="footer__contact">
              <h2 class="footer__title">Nuestro objetivo</h2>
              <p class="footer__text footer__text--sp">
                Brindar un servicio de manejo de datos para la institución
                educativa Ciudadela Educativa de Bosa, el cual facilite la
                gestión, recolección y organización de datos de forma dinámica,
                a través de una plataforma web privada para los integrantes de
                una institución, ya sean estudiantes, profesores y directivos.
              </p>
            </div>
          </div>
          <div class="footer__element footer__element--sp2">
            <div class="footer__contact">
              <h2 class="footer__title">Nuestro equipo</h2>
              <div class="footer__equipo">
                <img
                  src="../../assets/images/Jairo.jpeg"
                  alt="Imagen Jairo"
                  class="footer__imgeq"
                />
                <p class="footer__text">Jairo Styp Rodriguez Patiño</p>
              </div>
              <div class="footer__equipo">
                <img
                  src="../../assets/images/mercado.jpg"
                  alt=""
                  class="footer__imgeq"
                />
                <p class="footer__text">Juan David Mercadoo Torres</p>
              </div>
              <div class="footer__equipo">
                <img
                  src="../../assets/images/camilo.jpg"
                  alt=""
                  class="footer__imgeq"
                />
                <p class="footer__text">Juan Camilo Rojas Rojas</p>
              </div>
              <div class="footer__equipo">
                <img
                  src="../../assets/images/justin.jpg"
                  alt=""
                  class="footer__imgeq"
                />
                <p class="footer__text">Justin Jarno Garzon Cardenas</p>
              </div>
            </div>
          </div>

        </div>
      </footer>

      <script src="../../js/app.js"></script>
    </form>
  </body>
</html>
