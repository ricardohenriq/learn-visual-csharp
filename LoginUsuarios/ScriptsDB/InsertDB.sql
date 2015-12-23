# Com o "MySql Command Line Client" aberto: Cole o COMANDO ABAIXO e Tecle ENTER
# mysql -u root -p
# source C:/Users/Henrique/Documents/Visual Studio 2015/Projects/LoginUsuarios/ScriptsDB/InsertDB.sql;

USE agenda;

INSERT INTO usuarios(nome, login, senha, status)
VALUES ('Nome Sobrenome 1', 'login1', 'senha1', 'A');

INSERT INTO usuarios(nome, login, senha, status)
VALUES ('Nome Sobrenome 2', 'login1', 'senha2', 'A');

INSERT INTO usuarios(nome, login, senha, status)
VALUES ('Nome Sobrenome 3', 'login1', 'senha3', 'A');

INSERT INTO usuarios(nome, login, senha, status)
VALUES ('Nome Sobrenome 4', 'login1', 'senha4', 'I');

INSERT INTO usuarios(nome, login, senha, status)
VALUES ('Nome Sobrenome 5', 'login1', 'senha5', 'I');

#-----------------------------------------------------------------------------------

INSERT INTO enderecos(usuario_id, rua, quadra, lote, bairro, CEP, complemento, ponto_referencia)
VALUES (1, 'Rua 1', 'Quadra 1', 'Lote 1', 'Bairro 1', '11111111', 'Complemento 1', 'Ponto de Referencia 1');

INSERT INTO enderecos(usuario_id, rua, quadra, lote, bairro, CEP, complemento, ponto_referencia)
VALUES (2, 'Rua 2', 'Quadra 2', 'Lote 2', 'Bairro 2', '22222222', 'Complemento 2', 'Ponto de Referencia 2');

INSERT INTO enderecos(usuario_id, rua, quadra, lote, bairro, CEP, complemento, ponto_referencia)
VALUES (3, 'Rua 3', 'Quadra 3', 'Lote 3', 'Bairro 3', '33333333', 'Complemento 3', 'Ponto de Referencia 3');

INSERT INTO enderecos(usuario_id, rua, quadra, lote, bairro, CEP, complemento, ponto_referencia)
VALUES (4, 'Rua 4', 'Quadra 4', 'Lote 4', 'Bairro 4', '44444444', 'Complemento 4', 'Ponto de Referencia 4');

INSERT INTO enderecos(usuario_id, rua, quadra, lote, bairro, CEP, complemento, ponto_referencia)
VALUES (5, 'Rua 5', 'Quadra 5', 'Lote 5', 'Bairro 5', '55555555', 'Complemento 5', 'Ponto de Referencia 5');

#-----------------------------------------------------------------------------------

INSERT INTO fornecedores(CNPJ, nome_fantasia, razao_social, descricao)
VALUES ('11111111111111', 'Nome Fantasia 1', 'Razao Social 1', 'Descricao 1');

INSERT INTO fornecedores(CNPJ, nome_fantasia, razao_social, descricao)
VALUES ('22222222222222', 'Nome Fantasia 2', 'Razao Social 2', 'Descricao 2');

INSERT INTO fornecedores(CNPJ, nome_fantasia, razao_social, descricao)
VALUES ('33333333333333', 'Nome Fantasia 3', 'Razao Social 3', 'Descricao 3');

INSERT INTO fornecedores(CNPJ, nome_fantasia, razao_social, descricao)
VALUES ('44444444444444', 'Nome Fantasia 4', 'Razao Social 4', 'Descricao 4');

INSERT INTO fornecedores(CNPJ, nome_fantasia, razao_social, descricao)
VALUES ('55555555555555', 'Nome Fantasia 5', 'Razao Social 5', 'Descricao 5');

INSERT INTO fornecedores(CNPJ, nome_fantasia, razao_social, descricao)
VALUES ('16666666666666', 'Nome Fantasia 6', 'Razao Social 6', 'Descricao 6');