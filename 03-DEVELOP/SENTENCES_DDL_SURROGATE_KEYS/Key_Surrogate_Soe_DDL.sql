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
    name_rol varchar(100) not null,
    user_id  int4         not null,
    constraint pk_rol_user primary key (name_rol, user_id),
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
    document_number  int4         not null,
    type_document_id int4         not null,
    first_name       varchar(100) not null,
    second_name      varchar(100),
    first_last_name  varchar(100) not null,
    second_last_name varchar(100),
    user_id          int4,
    constraint pk_person primary key (id),
    constraint uk_person unique (document_number, type_document_id, user_id),
    constraint fk_tido_user foreign key (type_document_id) references type_document (id),
    constraint fk_user_person foreign key (user_id) references system_user (id)
);
create table father
(
    id             serial not null,
    person_id      int4   not null,
    number_father  int4,
    address_father varchar(100),
    constraint pk_father primary key (id),
    constraint uk_father unique (person_id, number_father),
    constraint fk_pers_fath foreign key (person_id) references person (id)
);
create table mother
(
    id             serial not null,
    person_id      int4   not null,
    number_mother  int4,
    address_mother varchar(100),
    constraint pk_mother primary key (id),
    constraint uk_mother unique (person_id, number_mother),
    constraint fk_pers_moth foreign key (person_id) references person (id)
);
create table tutor
(
    id            serial       not null,
    person_id     int4         not null,
    number_tutor  int4         not null,
    address_tutor varchar(100) not null,
    constraint pk_tutor primary key (id),
    constraint uk_tutor unique (person_id, number_tutor),
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
    person_id        int4        not null,
    name_working_day varchar(50) not null,
    matter_id        int4        not null,
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
    number_course int4   not null,
    number_year   int4   not null,
    number_cycle  int4   not null,
    teacher_id    int4   not null,
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
    person_id   int4         not null,
    birth_date  date         not null,
    birth_place varchar(100) not null,
    course_id   int4         not null,
    constraint pk_student primary key (id),
    constraint uk_student unique (person_id, course_id),
    constraint fk_pers_student foreign key (person_id) references person (id),
    constraint fk_cour_student foreign key (course_id) references course (id)
);
create table student_history
(
    id            serial       NOT NULL,
    student_id    int          NOT NULL,
    notation      varchar(500) NOT NULL,
    notation_date date         NOT NULL,
    CONSTRAINT pk_student_history PRIMARY KEY (id),
    CONSTRAINT uk_stud_student_id UNIQUE (student_id),
    CONSTRAINT fk_stud_history FOREIGN KEY (student_id) REFERENCES student (id)
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
    student_id  int4         not null,
    id_eps      int4,
    address     varchar(250) not null,
    home_number int4,
    state       int4,
    father_id   int4         not null,
    mother_id   int4         not null,
    tutor_id    int          not null,
    constraint pk_enrollment primary key (id),
    constraint uk_enrollment unique (student_id, id_eps, father_id, mother_id, tutor_id),
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
    final_quarterly_grade_id int4   not null,
    annual_final_grade       int4   not null,
    constraint pk_annual_final_grade primary key (id),
    constraint uk_annual_final_grade unique (final_quarterly_grade_id),
    constraint fk_finquar_finannual foreign key (final_quarterly_grade_id) references final_quarterly_grade (id)
);