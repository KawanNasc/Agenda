create database agenda;
use agenda;

create table tbcontato (
	codcontato int not null primary key auto_increment,
    nome varchar(100),
    telefone char(14),
    celular char(15),
    email varchar(100)
);

insert into tbcontato (nome, telefone, celular, email) values('Samara Ferreira', '(11) 5555-4444', '(11) 97777-8888', 'samara.ferreira27@gmail.com');

select * from tbcontato;
SELECT codcontato AS 'Código', nome AS 'Nome', telefone AS 'Telefone', celular AS 'Tel. Celular', email AS 'E-Mail' FROM tbcontato WHERE nome LIKE '%s%';

/* -------------------- */

create table tblogin (
	email varchar(30) not null primary key,
    senha varchar(30) not null
);

insert into tblogin (email, senha) values ('adm', '123');
	
select * from tblogin;