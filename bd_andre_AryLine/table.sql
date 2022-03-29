create database bd_andre_airline;

use bd_andre_airline;

CREATE TABLE tb_aeronaves(
id NVARCHAR(10) NOT NULL,
nome NVARCHAR(100) NOT NULL,
capacidade  INT NOT NULL
CONSTRAINT PK_id_aeronaves PRIMARY KEY (id)
)
GO

CREATE TABLE tb_endereco(
id INT NOT NULL, 
pais NVARCHAR(100) NOT NULL,
cep NVARCHAR(10) NOT NULL,
cidade NVARCHAR(100) NOT NULL,
estado NVARCHAR(100) NOT NULL,
logradouro NVARCHAR(100) NOT NULL,
bairro NVARCHAR(100) NOT NULL,
complemento NVARCHAR(50) NOT NULL,
numero NVARCHAR(10) NOT NULL
CONSTRAINT PK_id_endereco PRIMARY KEY (id)
)
GO

CREATE TABLE tb_aeroporto(
sigla NVARCHAR(100) NOT NULL,
nome NVARCHAR(100) NOT NULL,
endereco INT NOT NULL,
CONSTRAINT PK_sigla_aeroporto PRIMARY KEY (sigla),
CONSTRAINT FK_endereco_aeroporto FOREIGN KEY (endereco) REFERENCES tb_endereco(id)
)
GO

CREATE TABLE tb_passageiro(
cpf NVARCHAR(11) NOT NULL,
nome NVARCHAR(100) NOT NULL,
email NVARCHAR(100) NOT NULL,
telefone NVARCHAR(11) NOT NULL,
data_nascimento DATETIME NOT NULL,
endereco INT,
CONSTRAINT PK_cpf_passageiro PRIMARY KEY (cpf),
CONSTRAINT fk_endereco_passageiro FOREIGN KEY (endereco) REFERENCES tb_endereco(id) 
)
GO

CREATE TABLE tb_voo(
id int not null,
destino NVARCHAR(100) NOT NULL,
origem NVARCHAR(100) NOT NULL,
aeronave NVARCHAR(10) NOT NULL,
horario_embarque DATETIME NOT NULL,
horario_desembarque DATETIME NOT NULL,
passageiro NVARCHAR(11) NOT NULL
CONSTRAINT PK_id_voo PRIMARY KEY (id),
CONSTRAINT FK_aeroporto_destino FOREIGN KEY (destino) REFERENCES tb_aeroporto(sigla),
CONSTRAINT FK_aeroporto_origem FOREIGN KEY (origem) REFERENCES tb_aeroporto(sigla),
CONSTRAINT FK_voo_passageiro FOREIGN KEY (passageiro) REFERENCES tb_passageiro(cpf)
)
GO

select * from tb_passageiro
select * from tb_endereco
drop database tb_endereco

