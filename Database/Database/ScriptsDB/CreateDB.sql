# Com o "MySql Command Line Client" aberto: Cole o COMANDO ABAIXO e Tecle ENTER
# mysql -u root -p
# source C:/Users/Henrique/Documents/Visual Studio 2015/Projects/Database/Database/ScriptsDB/CreateDB.sql;

CREATE DATABASE dotnet CHARACTER SET utf8 COLLATE utf8_general_ci;

USE dotnet;

CREATE USER 'dotnetadmin' IDENTIFIED BY 'dotnetadmin';
GRANT ALL PRIVILEGES ON *.* TO 'dotnetadmin'@'%' IDENTIFIED BY 'dotnetadmin';
GRANT ALL PRIVILEGES ON *.* TO 'dotnetadmin'@'localhost' IDENTIFIED BY 'dotnetadmin';
FLUSH PRIVILEGES;

create table dotnet_user(
	id INT AUTO_INCREMENT PRIMARY KEY,
	name VARCHAR(50),
	age INT
);