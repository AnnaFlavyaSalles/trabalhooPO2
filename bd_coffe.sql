create database coffee_store_bd;
use coffee_store_bd;

create table Funcionario (
id_fun int primary key auto_increment,
nome_fun varchar(300)not null,
email_fun varchar(300)not null,
cpf_fun varchar(20)not null,
rg_fun varchar(20)not null,
data_nascimento_fun date not null,
telefone_fun varchar(20) not null,
estado_civil_fun varchar(50) not null,
endereco_fun varchar(250) not null,
estado_fun varchar(100) not null,
cidade_fun varchar(100) not null,
funcao_fun varchar(150) not null,
salario_fun double not null
);

create table Empresa (
id_emp int primary key auto_increment,
cnpj_emp varchar(40)not null,
razao_social_emp varchar(100)not null,
nome_fantasia_emp varchar(300)not null,
situacao_cadastral_emp varchar(100)not null,
regime_tributario_emp varchar(100)not null,
data_inicio_atividade_emp date not null,
capital_social_emp double not null,
telefone_emp varchar(20) not null,
cpf_proprietario_emp varchar(20)not null,
nome_proprietario_emp varchar(300)not null,
endereco_emp varchar(250) not null,
estado_emp varchar(100) not null,
cidade_emp varchar(100) not null,
cep_emp varchar(15) not null,
numero_emp int not null,
porte_empresa varchar(40) not null
);





