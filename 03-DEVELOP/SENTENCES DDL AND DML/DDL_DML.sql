create schema soe;
SET search_path = soe;
create table rol
(
    name_rol varchar(100) not null,
    constraint pk_rol primary key (name_rol)

);
create table system_user
(
    id                  serial,
    login               varchar(100) not null,
    password            varchar(100) not null,
    institutional_email varchar(100) not null,
    image_url           varchar(255),
    constraint pk_user primary key (id),
    constraint uk_user unique (login, institutional_email)

);
create table rol_user
(
    id serial not null,
    name_rol varchar(100) not null,
    user_id  int4         not null,
    constraint pk_rol_user primary key (id),
    constraint fk_ros_rous foreign key (name_rol) references rol (name_rol),
    constraint fk_user_rous foreign key (user_id) references system_user (id)
);
create table type_document
(
    id              serial       not null,
    abbreviation    varchar(50)  not null,
    document_name   varchar(100) not null,
    document_status varchar(40)  not null,
    constraint pk_type_document primary key (id),
    constraint uk_tipe_document unique (abbreviation, document_name)
);
create table person
(
    id               serial       not null,
    document_number  int         not null,
    type_document_id int         not null,
    first_name       varchar(100) not null,
    second_name      varchar(100),
    first_last_name  varchar(100) not null,
    second_last_name varchar(100),
    user_id          int,
    constraint pk_person primary key (id),
    constraint uk_person unique (document_number, type_document_id, user_id),
    constraint fk_tido_user foreign key (type_document_id) references type_document (id),
    constraint fk_user_person foreign key (user_id) references system_user (id)
);
create table father
(
    id             serial not null,
    person_id      int   not null,
    number_father  bigint,
    address_father varchar(100),
    constraint pk_father primary key (id),
    constraint uk_father unique (person_id),
    constraint fk_pers_fath foreign key (person_id) references person (id)
);
create table mother
(
    id             serial not null,
    person_id      int   not null,
    number_mother  bigint,
    address_mother varchar(100),
    constraint pk_mother primary key (id),
    constraint uk_mother unique (person_id),
    constraint fk_pers_moth foreign key (person_id) references person (id)
);
create table tutor
(
    id            serial       not null,
    person_id     int         not null,
    number_tutor  bigint         not null,
    address_tutor varchar(100) not null,
    constraint pk_tutor primary key (id),
    constraint uk_tutor unique (person_id),
    constraint fk_pers_tuto foreign key (person_id) references person (id)
);
create table working_day
(
    name_working_day varchar(50) NOT NULL,
    CONSTRAINT pk_working_day PRIMARY KEY (name_working_day)
);
create table subject
(
    name_subject varchar(100) NOT NULL,
    CONSTRAINT pk_subject PRIMARY KEY (name_subject)
);
create table matter
(
    id           serial       not null,
    name_matter  varchar(50)  not null,
    name_subject varchar(100) not null,
    constraint pk_matter primary key (id),
    constraint uk_matter unique (name_matter, name_subject),
    constraint fk_sub_matter foreign key (name_subject) references subject (name_subject)
);

create table teacher
(
    id               serial      not null,
    person_id        int        not null,
    name_working_day varchar(50) not null,
    matter_id        int        not null,
    constraint pk_teacher primary key (id),
    constraint uk_teacher unique (person_id, name_working_day, matter_id),
    constraint fk_woda_teacher foreign key (name_working_day) references working_day (name_working_day),
    constraint fk_per_teach foreign key (person_id) references person (id),
    constraint fk_matt_teacher foreign key (matter_id) references matter (id)
);
create table secretary
(
    id               serial      NOT NULL,
    person_id        int         NOT NULL,
    name_working_day varchar(50) NOT NULL,
    CONSTRAINT pk_secretary PRIMARY KEY (id),
    CONSTRAINT uk_person_id UNIQUE (person_id),
    CONSTRAINT uk_name_working_day UNIQUE (name_working_day),
    CONSTRAINT fk_woda_secre FOREIGN KEY (name_working_day) REFERENCES working_day (name_working_day),
    CONSTRAINT fk_per_secre FOREIGN KEY (person_id) REFERENCES person (id)
);
create table cycle
(
    number_cycle int NOT NULL,
    CONSTRAINT pk_cycle PRIMARY KEY (number_cycle)
);
create table coordinator
(
    id           serial NOT NULL,
    person_id    int    NOT NULL,
    number_cycle int    NOT NULL,
    CONSTRAINT pk_coordinator PRIMARY KEY (id),
    CONSTRAINT uk_cor_person_id UNIQUE (person_id),
    CONSTRAINT uk_number_cycle UNIQUE (number_cycle),
    CONSTRAINT fk_per_coor FOREIGN KEY (person_id) REFERENCES person (id),
    CONSTRAINT fk_cycl_coor FOREIGN KEY (number_cycle) REFERENCES cycle (number_cycle)
);
create table current_year
(
    number_year int NOT NULL,
    CONSTRAINT pk_current_year PRIMARY KEY (number_year)
);

create table course
(
    id            serial not null,
    number_course int   not null,
    number_year   int   not null,
    number_cycle  int   not null,
    teacher_id    int   not null,
    constraint pk_course primary key (id),
    constraint uk_course unique (number_course, number_year, number_cycle, teacher_id),
    constraint fk_crye_course foreign key (number_year) references current_year (number_year),
    constraint fk_cyc_course foreign key (number_cycle) references cycle (number_cycle),
    constraint fk_tea_cour foreign key (teacher_id) references teacher (id)
);
create table timetable
(
    id                serial       NOT NULL,
    archive_timetable varchar(255) NOT NULL,
    course_id         int          NOT NULL,
    CONSTRAINT pk_timetable PRIMARY KEY (id),
    CONSTRAINT uk_course_id UNIQUE (course_id),
    CONSTRAINT fk_cour_tita FOREIGN KEY (course_id) REFERENCES course (id)
);
create table student
(
    id          serial       not null,
    person_id   int         not null,
    birth_date  date         not null,
    birth_place varchar(100) not null,
    course_id   int         not null,
    constraint pk_student primary key (id),
    constraint uk_student unique (person_id, course_id),
    constraint fk_pers_student foreign key (person_id) references person (id),
    constraint fk_cour_student foreign key (course_id) references course (id)
);
create table student_history
(
    id            serial       NOT NULL,
    student_id    int          NOT NULL,
    CONSTRAINT pk_student_history PRIMARY KEY (id),
    CONSTRAINT uk_stud_student_id UNIQUE (student_id),
    CONSTRAINT fk_stud_history FOREIGN KEY (student_id) REFERENCES student (id)
);
CREATE TABLE annotation(
    id serial,
    notation VARCHAR (500),
    notation_date DATE,
    constraint pk_annotation PRIMARY KEY (id)
);
CREATE TABLE student_history_annotation(
    id serial,
    student_history_id INT,
    annotation_id INT,
    constraint pk_student_history_annotation PRIMARY KEY (id),
    constraint uk_student_history_annotation UNIQUE (student_history_id, annotation_id )  
);
create table eps
(
    id       serial       NOT NULL,
    name_eps varchar(100) NOT NULL,
    CONSTRAINT pk_eps PRIMARY KEY (id),
    CONSTRAINT uk_name_eps UNIQUE (name_eps)
);
create table enrollment
(
    id          serial       not null,
    student_id  int        not null,
    id_eps      int,
    address     varchar(250) not null,
    home_number int,
    state       int,
    father_id   int         not null,
    mother_id   int         not null,
    tutor_id    int          not null,
    constraint pk_enrollment primary key (id),
    constraint uk_enrollment unique (student_id, id_eps),
    constraint fk_stud_enro foreign key (student_id) references student (id),
    constraint fk_eps_enro foreign key (id_eps) references eps (id),
    constraint fk_fath_enro foreign key (father_id) references father (id),
    constraint fk_moth_enro foreign key (mother_id) references mother (id),
    constraint fk_tutor_enro foreign key (tutor_id) references tutor (id)
);
create table quarter
(
    number_quarter int NOT NULL,
    CONSTRAINT pk_quarter PRIMARY KEY (number_quarter)
);
create table final_quarterly_grade
(
    id                 serial NOT NULL,
    student_id         int    NOT NULL,
    matter_id          int    NOT NULL,
    number_quarter     int    NOT NULL,
    seventy_percentage int,
    twenty_percentage  int,
    ten_percentage     int,
    final_grade        int,
    CONSTRAINT pk_final_quarterly_grade PRIMARY KEY (id),
    CONSTRAINT uk_final_quarterly_grade UNIQUE (student_id, matter_id, number_quarter),
    CONSTRAINT fk_quar_final_grade FOREIGN KEY (number_quarter) REFERENCES quarter (number_quarter),
    CONSTRAINT fk_matt_fiqugra FOREIGN KEY (matter_id) REFERENCES matter (id),
    CONSTRAINT fk_stud_fiqugra FOREIGN KEY (student_id) REFERENCES student (id)
);
create table annual_final_grade
(
    id                       serial not null,
    final_quarterly_grade_id int   not null,
    annual_final_grade       int   not null,
    constraint pk_annual_final_grade primary key (id),
    constraint uk_annual_final_grade unique (final_quarterly_grade_id),
    constraint fk_finquar_finannual foreign key (final_quarterly_grade_id) references final_quarterly_grade (id)
);
create table news (
 id serial,
 id_user int4 NOT NULL ,
 text varchar(225)NOT NULL ,
 image varbinary(2000)NOT NULL ,
 constraint pk_news primary key (id),
 CONSTRAINT fk_news_user foreign key (id_user) references system_user(id),
 constraint uk_news_user unique (id)
);

SET search_path = soe;
insert into type_document (abbreviation, document_name, document_status)
    values
        ('CC', 'Cedula', 'Activo'),
        ('TI', 'Tarjeta de identidad', 'Activo'),
        ('CE', 'Cedula de extranjeria', 'Activo');

insert into system_user (login, password, institutional_email)
    values 
        ('100234595', 'juanito123', 'juancarlosromeroramirez@gmail.com'),
        ('102505056', 'luisillo25', 'luistorresrojas@gmail.com'),
        ('103265844', 'eljuanpa', 'juanpatorres@gmail.com'),
        ('102351132', 'contraseña', 'Miguelito12gmail.com'),
        ('102121562', '1546458', 'mariaantonietatercera@gmail.com'),
        ('57988215', '$sd81568', 'luzcrist85gmail.com'),
        ('84563215', 'cesar123', 'cesargordillo895@gmail.com'),
        ('75652165', 'mari852562w', 'maritza@gmail.com'),
        ('65188922', 'charm586', 'yeimilegizamon@gmail.com'),
        ('64685268', '2gm3945', 'dermin654@gmail.com'),
        ('65464656', 'nurisita12345', 'nury56482@gmail.com'),
        ('54664562', '12345', 'jasoncast52@gmail.com'),
        ('16565456', 'hist546asdsz', 'alcirarodr@gmail.com'),
        ('45465546', 'pepitopepe', 'pepepepe2@gmail.com'),
        ('56484651', 'luc568', 'lucasdetodo@gmail.com'),
        ('54652815', 'te123', 'andresss@gmail.com'),
        ('15646822', 'elhugo25', 'hugo25@gmail.com'),
        ('15645623', 'incorrecta', 'martaluciacaldas54@gmail.com');


insert into rol (name_rol)
    values
        ('Estudiante'),
        ('Profesor'),
        ('Cordinador'),
        ('Secretario');


insert into current_year (number_year)
    values
        ('2021'),
        ('2022');

insert into cycle (number_cycle)
    values 
        ('1'),
        ('2'),
        ('3'),
        ('4'),
        ('5');

insert into subject (name_subject)
    values 
        ('Ciencias naturales y educacion ambiental'),
        ('Ciencias sociales'),
        ('Educacion artistica y cultural'),
        ('Etica y valores humanos'),
        ('Educacion fisica'),
        ('Educacion religiosa'),
        ('humanidades, lengua castellana e idiomas extranjeros'),
        ('Matematicas'),
        ('Tecnologia e informatica');

insert into working_day (name_working_day)
    values 
        ('Mañana'),
        ('Tarde'),
        ('Mixta');

insert into eps (name_eps)
    values
        ('Salud total'),
        ('Compensar'),
        ('Sanitas'),
        ('Sura'),
        ('Famisanar'),
        ('Cruz blanca'),
        ('Coomeva'),
        ('Suramericana');

insert into quarter (number_quarter)
    values
        ('1'),
        ('2'),
        ('3');

insert into person (document_number, type_document_id, first_name, second_name, first_last_name, second_last_name, user_id)
    values 
        ('100234595','2', 'Juan', 'Carlos', 'Romero', 'Ramirez', '1'),
        ('102505056', '2', 'Luis', NULL, 'Torres', 'Rojas', '2'),
        ('103265844', '2', 'Juan', 'Pablo', 'Castillo', 'Torres', '3'),
        ('102351132', '2', 'Miguel', 'David', 'Castiblanco', 'Garzon', '4'),
        ('102121562', '2', 'Maria', 'Antonieta', 'Ramirez', 'Montenegro', '5'),
        ('57988215', '1', 'Luz', 'Cristina', 'Rodriguez', 'Perez', '6'),
        ('84563215', '1', 'Cesar', NULL, 'Hernan', 'Gordillo', '7'),
        ('75652165', '1', 'Maritza', 'Lorena', 'Saldarriaga', 'Torres', '8'),
        ('65188922', '1', 'Yeimi', 'Rocio', 'Legizamon', 'Castillo', '9'),
        ('64685268', '3', 'Fermin', 'Ensciso', 'Schurman', 'Smith', '10'),
        ('65464656', '1', 'Nury', 'Johanna', 'Pacaciro', 'Veles', '11'),
        ('54664562', '1', 'Jason', NULL, 'Castillo', NULL, '12'),
        ('16565456', '1', 'Alcira', NULL, 'Torres', 'Rodriguez', '13'),
        ('45465546', '1', 'Pepe', 'Carlos', 'Perez', 'Pelaes', '14'),
        ('56484651', '1', 'Lucas', 'Steven', 'Romero', 'Caldas', '15'),
        ('54652815', '1', 'Andres', 'Erik', 'Torres', 'Hernando', '16'),
        ('15646822', '1', 'Hugo', 'Ivan', 'Alarcon', 'Valdes', '17'),
        ('15645623', '1', 'Marta', 'Andrea', 'Peña', 'Nieto', '18'),
        ('54621352', '1', 'Emma', 'Elena', 'Rojas', 'Mercado', NULL),
        ('86542315', '1', 'Alba', NULL, 'Ramirez', 'Ramirez', NULL),
        ('87123598', '1', 'Camila', 'Fernanda', 'Ochoa', 'Niño', NULL),
        ('58945322', '1', 'Lida', 'Marcela', 'Rincon', 'Lopez', NULL),
        ('84965284', '1', 'Natalia', NULL, 'Ruiz', 'Rodriguez', NULL),
        ('54621654', '1', 'Lucas', NULL, 'Castillo', 'Sarmiento', NULL),
        ('85645266', '1', 'Pablo', 'Andres', 'Escobar', 'Castillo', NULL),
        ('98654523', '1', 'David', 'Andres', 'Alarcon', 'Gordillo', NULL),
        ('85655235', '1', 'Enrique', NULL, 'Iglesias', 'Castillo', NULL),
        ('56514264', '1', 'Jhon', 'Fredy', 'Ramos', 'Novoa', NULL),
        ('48492645', '3', 'Maria', 'Angela', 'Fernandez', 'Torres', NULL),
        ('54652852', '1', 'Tomas', NULL, 'Perez', 'Castillo', NULL);

insert into matter (name_matter, name_subject)
    values
        ('Ciencias', 'Ciencias naturales y educacion ambiental'),
        ('Biologia', 'Ciencias naturales y educacion ambiental'),
        ('Quimica', 'Ciencias naturales y educacion ambiental'),
        ('Fisica', 'Ciencias naturales y educacion ambiental'),
        ('Sociales', 'Ciencias sociales'),
        ('Economia', 'Ciencias sociales'),
        ('Danzas', 'Educacion artistica y cultural'),
        ('Artes', 'Educacion artistica y cultural'),
        ('Musica', 'Educacion artistica y cultural'),
        ('Etica', 'Etica y valores humanos'),
        ('Educacion fisica', 'Educacion fisica'),
        ('Religion', 'Educacion religiosa'),
        ('Español', 'humanidades, lengua castellana e idiomas extranjeros'),
        ('Ingles', 'humanidades, lengua castellana e idiomas extranjeros'),
        ('Matematicas', 'Matematicas'),
        ('Tecnologia e informatica', 'Tecnologia e informatica');

insert into teacher (person_id, name_working_day, matter_id)
    values 
        ('6', 'Mañana', '1'),
        ('7', 'Mañana', '2'),
        ('8', 'Mañana', '7'),
        ('9', 'Mañana', '4'),
        ('10', 'Tarde', '8');

insert into course (number_course, number_year, number_cycle, teacher_id)
    values
        ('803', '2021', '4', '1'),
        ('1001', '2021', '5', '2'),
        ('1103', '2021', '5', '3'),
        ('1104', '2021', '5', '4'),
        ('905', '2021', '4', '5');
insert into student (person_id, birth_date, birth_place, course_id)
    values
        ('1', '07/10/2007', 'Bogota', '1' ),
        ('2', '01/12/2005', 'Bucaramanga', '2'),
        ('3', '05/07/2004', 'Bogota', '3'),
        ('4', '10/12/2005', 'Medellin', '4'),
        ('5', '11/06/2007', 'Bogota', '5');

insert into coordinator (person_id, number_cycle)
    values
        ('11', '5'),
        ('12', '4'),
        ('13', '3'),
        ('14', '2'),
        ('15', '1');

insert into secretary (person_id, name_working_day)
    values
        ('16', 'Mañana'),
        ('17', 'Tarde'),
        ('18', 'Mixta');

insert into father (person_id, number_father, address_father)
    values
        ('24', '3145695214', 'Calle 48 sur #87b'),
        ('25', '3156842540', 'Calle 20 sur #50'),
        ('26', '3203256200', 'Calle 52 sur #23-98'),
        ('27', '3142506654', 'Carrera 25 #50-20'),
        ('28', NULL, 'Calle 94d 35');

insert into mother (person_id, number_mother, address_mother)
    values
        ('19', '3101919192', 'Calle 48 sur #87b'),
        ('20', '3155552655', 'Calle 20 sur #50'),
        ('21', '3159525482', 'Calle 52 sur #23-98'),
        ('22', '3102654822', 'Calle 11 sur #20d casa 102'),
        ('23', '3215685282', 'Calle 11 sur #20d casa 122');

insert into tutor (person_id, number_tutor, address_tutor)
    values
        ('29', '3173520203', 'Calle 80 # 70b'),
        ('30', '3204505032', 'Carrera 21 #70'),
        ('21', '3159525482', 'Calle 52 sur #23-98'),
        ('22', '3102654822', 'Calle 11 sur #20d casa 102'),
        ('27', '3142506654', 'Carrera 25 #50-20');
insert into student_history (student_id)
    values
        ('1'),
        ('2'),
        ('3'),
        ('4'),
        ('5');
insert into annotation (notation, notation_date) 
    values 
        ('El estudiante se porto bien en clase', '20/07/2021'),
        ('El estudiante se porto mal en clase', '20/08/2021'),
        ('El estudiante se porto bien en clase', '11/07/2021'),
        ('El estudiante se porto bien en clase', '15/08/2021'),
        ('El estudiante reprobo 7 materias, se recomienda seguimiento', '25/07/2021'),
        ('El estudiante evadio clase para jugara football y rompio un vidrio', '26/08/2021');
insert into student_history_annotation (student_history_id, annotation_id)
    values 
        ('1', '1'),
        ('2', '3'),
        ('3', '4'),
        ('4', '2'),
        ('5', '5'),
        ('5', '6');
insert into timetable (archive_timetable, course_id)
    values
        ('pdf', '1'),
        ('pdf', '2'),
        ('pdf', '3'),
        ('pdf', '4'),
        ('pdf', '5');

insert into enrollment (student_id, id_eps, address, home_number, state, father_id, mother_id, tutor_id)
    values
        ('1', '1', 'Calle 48 sur #87b', NULL, '1', '1', '1', '1'),
        ('2', '1', 'Calle 20 sur #50', NULL, '1', '2', '2', '2'),
        ('3', '4', 'Calle 52 sur #23-98', NULL, '1', '3', '3', '3'),
        ('4', '2', 'Calle 11 sur #20d', '102', '1', '5', '4', '4'),
        ('5', '5', 'Carrera 25 #50-20', NULL, '1', '4', '5', '5');

insert into final_quarterly_grade (student_id, matter_id, number_quarter, seventy_percentage, twenty_percentage, ten_percentage, final_grade)
    values
        ('1', '3', '1', '40', '35', '50', '40'),
        ('2', '2', '1', '31', '30', '40', '32'),
        ('3', '4', '1', '50', '50', '50', '50'),
        ('4', '5', '1', '42', '25', '50', '39'),
        ('5', '2', '1', '10', '10', '10', '10');

insert into annual_final_grade (final_quarterly_grade_id, annual_final_grade)
    values
        ('1', '40'),
        ('2', '32'),
        ('3', '50'),
        ('4', '39'),
        ('5', '10');

insert into rol_user (name_rol, user_id)
    values
        ('Estudiante', '1'),
        ('Estudiante', '2'),
        ('Estudiante', '3'),
        ('Estudiante', '4'),
        ('Estudiante', '5'),
        ('Profesor', '6'),
        ('Profesor', '7'),
        ('Profesor', '8'),
        ('Profesor', '9'),
        ('Profesor', '10'),
        ('Cordinador', '11'),
        ('Cordinador', '12'),
        ('Cordinador', '13'),
        ('Cordinador', '14'),
        ('Cordinador', '15'),
        ('Secretario', '16'),
        ('Secretario', '17'),
        ('Secretario', '18');
        

SET search_path = soe;

--¿Se desea saber que materia dicta el profesor con cedula 75652165 y cual es su nombre?

select p.document_number, p.first_name, p.first_last_name, m.name_matter
    from teacher t
        inner join person p on p.id = t.person_id
        inner join matter m on m.id = t.matter_id
    where p.document_number = 75652165;
  
--¿Se desea saber que coordinador dirige el ciclo 5? mostrando su tipo de documento, numero de documento y nombres

select ty.abbreviation, p.document_number, p.first_name, p.first_last_name, cy.number_cycle
    from  coordinator co
        inner join cycle cy on cy.number_cycle = co.number_cycle
        inner join person p on p.id = co.person_id
        inner join type_document ty on ty.id = p.type_document_id
    where cy.number_cycle = 5;

--¿Se desea conocer que profesor tiene cedula de extranjeria y que materia dicta? 

select td.abbreviation, p.document_number, p.first_name, p.first_last_name, m.name_matter
    from teacher t
        inner join person p on p.id = t.person_id
        inner join type_document td on td.id = p.type_document_id 
        inner join matter m on m.id = t.matter_id
    where td.abbreviation = 'CE';

--¿Se desea saber que estudiente cuenta con la eps Compensar?
select p.document_number, p.first_name, p.first_last_name, ep.name_eps
    from enrollment enr 
        inner join student s on s.id = enr.student_id
        inner join eps ep on ep.id = enr.id_eps
        inner join person p on p.id = s.person_id
    where ep.name_eps = 'Compensar';

--¿Cual es el 10% de nota del estudiante con numero de documento 102505056, en que materia y en que trimestre se encuentra?

select p.document_number, p.first_name, p.first_last_name, m.name_matter, fqg.ten_percentage, qu.number_quarter
    from final_quarterly_grade fqg
        inner join quarter qu on qu.number_quarter = fqg.number_quarter
        inner join matter m on m.id = fqg.matter_id
        inner join student st on st.id = fqg.student_id
        inner join person p on p.id = st.person_id
    where p.document_number = 102505056;

--Se desea conocer las anotaciones del observador del estudiante identificado con numero 102121562 y en que fecha se realizo dicha anotaciòn

select p.document_number, p.first_name, p.first_last_name, a.notation, a.notation_date
    from student_history_annotation sha
        inner join  annotation a on a.id = sha.annotation_id
        inner join student_history sh on sh.id = sha.student_history_id
        inner join student s on s.id = sh.student_id
        inner join person p on p.id = s.person_id
    where p.document_number = 102121562;

--¿En que area esta la materia ingles?
select su.name_subject, m.name_matter
    from matter m
        inner join  subject su on su.name_subject = m.name_subject
    where m.name_matter = 'Ingles';

--¿Cuales son los datos del estudiante con numero de documento 103265844?

select td.abbreviation, p.document_number, p.first_name, p.first_last_name
    from student s 
        inner join person p on p.id = s.person_id
        inner join type_document td on td.id = p.type_document_id
    where p.document_number = 103265844;

--¿Cual es la nota final del trimestre del estudiante con numero de documento 102121562?

select p.document_number, p.first_name, p.first_last_name, m.name_matter, fqg.final_grade
    from final_quarterly_grade fqg
        inner join quarter qu on qu.number_quarter = fqg.number_quarter
        inner join matter m on m.id = fqg.matter_id
        inner join student st on st.id = fqg.student_id
        inner join person p on p.id = st.person_id
    where p.document_number = 102121562;

--¿Cual es el horario del curso 1104?

select c.number_course, tt.archive_timetable 
    from timetable tt
        inner join course c on c.id = tt.course_id
    where c.number_course = 1104;
