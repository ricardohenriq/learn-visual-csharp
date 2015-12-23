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

CREATE TABLE enderecos(
	id INT AUTO_INCREMENT PRIMARY KEY,
	usuario_id INT NOT NULL,
	rua VARCHAR(100),
	quadra VARCHAR(100),
	lote VARCHAR(100),
	bairro VARCHAR(100),
	CEP CHAR(8),
	complemento VARCHAR(100),
	ponto_referencia VARCHAR(100),
	FOREIGN KEY usuario_key (usuario_id) REFERENCES usuarios(id)
);

CREATE TABLE fornecedors(
	id INT AUTO_INCREMENT PRIMARY KEY,
	CNPJ CHAR(14),
	nome_fantasia VARCHAR(100),
	razao_social VARCHAR(100),
	descricao VARCHAR(100)
);