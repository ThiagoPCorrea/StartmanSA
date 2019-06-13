--Criacao das tabelas

Create table materiaprima(
	ID int not null identity,
	Nome varchar(300) not null,
	QuantidadeEstoque bigint not null,
	QuantidadeEstoqueMax bigint not null,
);

Create table logs(
	ID int not null identity,
	Encarregado varchar(100) not null,
	TipodeOperacao varchar(50) not null,
	MateriaPrima varchar(300) not null,
	QuantidadeAlterada bigint not null,
	DiaAlteracao datetime not null);


-- Constraints
alter table materiaprima add constraint PK_MATERIAPRIMA primary key(ID);
alter table logs add constraint PK_LOGS primary key(ID);


-- Inserts
insert into materiaprima(Nome,QuantidadeEstoque,QuantidadeEstoqueMax)
values	('Alumínio', 3500, 5000),
		('Plástico', 5000, 5000),
		('Ferro', 4500,5000),
		('Cobre', 1250,5000),
		('Aço',500,5000);

-- Triggers
Create trigger trgUplog
on materiaprima
after update
as
begin
	if (select QuantidadeEstoque from inserted) > (select QuantidadeEstoque from deleted)
		begin
			insert into logs(Encarregado,MateriaPrima,TipodeOperacao,QuantidadeAlterada,DiaAlteracao)
			values ('Encarregado1',(select Nome from inserted),'Reposição',
					((select QuantidadeEstoque from inserted) -  (select QuantidadeEstoque from deleted)),
					GETDATE());
		end
	else
		begin
			insert into logs(Encarregado,MateriaPrima,TipodeOperacao,QuantidadeAlterada,DiaAlteracao)
			values ('Encarregado2',(select Nome from inserted),'Retirada',
					((select QuantidadeEstoque from deleted) -  (select QuantidadeEstoque from inserted)),
					GETDATE());
		end	
end

