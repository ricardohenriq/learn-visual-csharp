# Com o "MySql Command Line Client" aberto: Cole o COMANDO ABAIXO e Tecle ENTER
# mysql -u root -p
# source C:/Users/Henrique/Documents/Visual Studio 2015/Projects/LoginUsuarios/ScriptsDB/CreateDB.sql;

CREATE DATABASE agenda CHARACTER SET utf8 COLLATE utf8_general_ci;

USE agenda;

CREATE USER 'agendaadmin' IDENTIFIED BY 'agendaadmin';
GRANT ALL PRIVILEGES ON *.* TO 'agendaadmin'@'%' IDENTIFIED BY 'agendaadmin';
GRANT ALL PRIVILEGES ON *.* TO 'agendaadmin'@'localhost' IDENTIFIED BY 'agendaadmin';
FLUSH PRIVILEGES;

CREATE TABLE usuarios(
	id INT AUTO_INCREMENT PRIMARY KEY,
	nome VARCHAR(100),
	login VARCHAR(50),
	senha VARCHAR(50),
	status CHAR(1)
);