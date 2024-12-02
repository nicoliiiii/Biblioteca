drop database bibliotecaescola;
CREATE DATABASE bibliotecaescola;
use bibliotecaescola;
CREATE TABLE autores (
  AutorId int(11) primary key auto_increment,
  NomeAutor varchar(65) NOT NULL
);

CREATE TABLE livros (
  LivroId int(11) primary key auto_increment,
  TituloLivro varchar(60) NOT NULL,
  AutorId int ,
  Genero varchar(45) NOT NULL,
  Classificacao int(11) NOT NULL,
  NumPag int(11) NOT NULL,
  AnoPubli int(11) NOT NULL,
  Disponivel tinyint(1) NOT NULL,
  constraint FK_AUTORES FOREIGN KEY (AutorId) REFERENCES autores(AutorId)
);

CREATE TABLE USUARIOS (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    LOGIN VARCHAR(60) NOT NULL,
    SENHA VARCHAR(120) NOT NULL
);

INSERT INTO USUARIOS (LOGIN, SENHA) VALUES ('ADMIN','ADMIN');

