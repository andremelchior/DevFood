CREATE DATABASE devfood;

drop database devfood;

USE devfood;

CREATE TABLE Funcionario(
	cod_funcionario bigint not null auto_increment,
	nome varchar(45) not null,
    email varchar(100) not null,
    cargo varchar(50) not null,
    cpf bigint not null,
    senha varchar(12) not null,
    CONSTRAINT pk_codFuncionario PRIMARY KEY(cod_funcionario),
    CONSTRAINT un_CPF UNIQUE(cpf)
);

CREATE TABLE Pedido(
	cod_pedido bigint not null auto_increment,
	cod_prato bigint,
    numero_mesa int not null,
    taxa_servico int,
    taxa_couvert int,
    subtotal decimal(10,2) not null,
    total decimal(10,2),
    CONSTRAINT pk_codPedido PRIMARY KEY(cod_pedido),
    CONSTRAINT fk_codPrato FOREIGN KEY(cod_prato) REFERENCES Prato(cod_prato)
);

CREATE TABLE Prato(
	cod_prato bigint not null,
    nome varchar(40) not null,
    descricao varchar(50) not null,
    CONSTRAINT pk_codPrato PRIMARY KEY(cod_prato)
);

INSERT INTO Funcionario VALUES(default, "admin", "admin@gmail.com", "administrador", 123456, 123);

show tables;

SELECT * FROM funcionario;