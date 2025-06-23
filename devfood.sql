CREATE DATABASE devfood;

#drop database devfood;

USE devfood;

CREATE TABLE Funcionario(
	cod_funcionario bigint not null auto_increment,
	nome varchar(45) not null,
    email varchar(100) not null,
    cargo varchar(50) not null,
    cpf varchar(11) not null,
    senha varchar(255) not null,
    CONSTRAINT pk_codFuncionario PRIMARY KEY(cod_funcionario),
    CONSTRAINT un_CPF UNIQUE(cpf)
);

CREATE TABLE Mesa(
    cod_mesa bigint not null auto_increment,
    numero int not null,
    capacidade int,
    status_mesa enum('livre', 'ocupada', 'reservada') default 'livre',
    CONSTRAINT pk_cod_mesa PRIMARY KEY (cod_mesa),
	CONSTRAINT un_numMesa UNIQUE(numero),
    CONSTRAINT ch_statusMesa CHECK(status_mesa IN ('livre', 'ocupada', 'reservada'))
);

CREATE TABLE Categoria(
	cod_categoria bigint not null auto_increment,
	tipo_categoria enum('Entrada', 'Prato Principal', 'Sobremesa', 'Acompanhamento') not null,
	CONSTRAINT pk_codCategoria PRIMARY KEY(cod_categoria),
	CONSTRAINT un_tipoCategoria UNIQUE(tipo_categoria),
	CONSTRAINT ch_tipoCategoria CHECK(tipo_categoria IN ('Entrada', 'Prato Principal', 'Sobremesa', 'Acompanhamento'))
);

INSERT INTO Categoria (cod_categoria, tipo_categoria)
VALUES 
(default, "Entrada"),
(default, "Prato Principal"),
(default, "Sobremesa"),
(default, "Acompanhamento");

select * from categoria;

CREATE TABLE Prato(
	cod_prato bigint not null auto_increment,
    nome varchar(40) not null,
    descricao varchar(255) not null,
    preco decimal(10,2) not null,
    cod_categoria bigint default 2,
    CONSTRAINT pk_codPrato PRIMARY KEY(cod_prato),
	CONSTRAINT fk_codCategoria FOREIGN KEY (cod_categoria) REFERENCES Categoria(cod_categoria),
	CONSTRAINT un_nomePrato UNIQUE(nome)
);

CREATE TABLE Pedido(
	cod_pedido bigint not null auto_increment,
    cod_mesa bigint not null,
    cod_funcionario bigint, 
    taxa_servico decimal(5,2),
    taxa_couvert decimal(5,2),
    subtotal decimal(10,2) not null,
    total decimal(10,2),
    CONSTRAINT pk_codPedido PRIMARY KEY(cod_pedido),
	CONSTRAINT fk_codMesa FOREIGN KEY (cod_mesa) REFERENCES Mesa(cod_mesa),
    CONSTRAINT fk_codFunc FOREIGN KEY (cod_funcionario) REFERENCES Funcionario(cod_funcionario)
);

CREATE TABLE Pedido_Prato(
    cod_pedido bigint not null,
    cod_prato bigint not null,
    quantidade int not null,
    preco_unitario decimal(10,2) not null,
    CONSTRAINT pk_codPedidoPrato PRIMARY KEY (cod_pedido, cod_prato),
    CONSTRAINT fk_codPedido FOREIGN KEY (cod_pedido) REFERENCES Pedido(cod_pedido),
    CONSTRAINT fk_codPrato FOREIGN KEY (cod_prato) REFERENCES Prato(cod_prato)
);

select * from Pedido_Prato;

INSERT INTO Funcionario (cod_funcionario, nome, email, cargo, cpf, senha)
VALUES (default, "admin", "admin@gmail.com", "administrador", "123456", "123");

show tables;

SELECT * FROM funcionario;
SELECT * FROM prato;

#delete from prato;