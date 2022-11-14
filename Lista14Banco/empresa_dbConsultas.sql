create database empresa_db2;

CREATE TABLE departamento (
	idDepartamento INT NOT NULL IDENTITY  primary key,
	nome VARCHAR(45) NOT NULL,
	localizacao VARCHAR(45) NOT NULL,
	orcamento VARCHAR(45) NOT NULL,
	
);




CREATE TABLE empregado (
	idEmpregado INT NOT NULL IDENTITY primary key,
	nome VARCHAR(45) NOT NULL,
	idGerente int not null IDENTITY references empregado,
	funcao VARCHAR(45) NOT NULL,
	idDepartamento int not null REFERENCES departamento,
	dataAdmissao date NOT NULL,
	salario float(4) not null,
	comissao float(4),

);

INSERT INTO Departamento VALUES('Banco de Dados','Porto Alegre','2346');
INSERT INTO Departamento VALUES('Balconistas','Pelotas','10000');
INSERT INTO Departamento VALUES('Inteligência Artific','Pelotas','333');
INSERT INTO Departamento VALUES('Compiladores','Novo Hamburgo','5050');
INSERT INTO Departamento VALUES('Redes','Taquara','12122');

INSERT INTO Empregado VALUES('Mariewa',NULL,'Gerente','1','2000-04-05','2300','0');
INSERT INTO Empregado VALUES('Zico','1','Operário','1','1999-08-13','100','0');
INSERT INTO Empregado VALUES('Lula',NULL,'Presidente','5','1950-01-01','10000','0');
INSERT INTO Empregado VALUES('Luana Pyovany',NULL,'Gerente','2','1998-06-23','2300','0');
INSERT INTO Empregado VALUES('Vera Fixer','5','Balconista','2','1999-05-05','3300','0');
INSERT INTO Empregado VALUES('Daniela Schicarelli',NULL,'Gerente','3','1999-10-10','2300','0');
INSERT INTO Empregado VALUES('Luize Altenhofen',NULL,'Gerente','4','1999-04-26','2300','0');
INSERT INTO Empregado VALUES('Helo Pinheiro',NULL,'Gerente','5','1997-09-25','2300','0');
INSERT INTO Empregado VALUES('Pelé','1','Operário','1','2000-09-09','100',NULL);
INSERT INTO Empregado VALUES('Romário','1','Operário','5','2001-12-25','100','0');
INSERT INTO Empregado VALUES('Malu Mader','5','Balconista','2','2001-10-20','3400','0');
INSERT INTO Empregado VALUES('Antônio Fagundes','7','Vendedor','3','2002-12-22','5000','10');



select * from empregado
where salario < 1000 or salario > 3500

select * from empregado
where salario >= 3400 and salario <= 4000

select * from empregado
where (salario >= 3400 and salario <= 4000) or  funcao = 'balconista'

select Lower (nome)  from empregado

select Upper (nome)  from empregado

select SUBSTRING(nome,1,5) from empregado

select sum(salario) from empregado

select min(salario) from empregado

select max(salario) from empregado

select sum(salario) / count(salario) from empregado

select sum(comissao) / count(salario) from empregado

select  avg(comissao)from empregado
group by idEmpregado







select empregado.nome, empregado.funcao
from empregado, departamento
where departamento.orcamento >= 10000 and 
		departamento.idDepartamento = empregado.idDepartamento


select empregado.nome, empregado.funcao
from departamento
inner join empregado
on departamento.orcamento >= 10000 and 
		departamento.idDepartamento = empregado.idDepartamento


select empregado.nome, empregado.funcao, departamento.nome
from departamento
inner join empregado
on departamento.idDepartamento = empregado.idEmpregado

select * from empregado



select a.idDepartamento, a.nome, a.funcao, b.nome 'chefe'
from empregado a, empregado b
where a.idGerente = b.idEmpregado

INSERT INTO Departamento (idDepartamento, nome, localizacao, orcamento) VALUES ('70','PRODUCAO','RIO DE JANEIRO','1200');

UPDATE Empregado 
SET Empregado.salario = Empregado.salario* 1.2 
WHERE Empregado.salario< 1000;

DELETE FROM Empregado
WHERE Empregado.salario >= 5000;


select empregado.nome, empregado.funcao,departamento.nome,departamento.orcamento
from empregado, departamento
where departamento.orcamento = 5050

select * from departamento
select * from empregado

select empregado.nome,empregado.salario
from departamento
inner join empregado
on (empregado.idEmpregado = departamento.idDepartamento) and empregado.salario > 3001



