use sql10359214;

create table tb_lista_negra (
	id_lista_negra		int primary key auto_increment,
    nm_pessoa			varchar(100),
    ds_motivo			varchar(200),
    dt_inclusao			datetime
);

select * from tb_lista_negra;

insert into tb_lista_negra (nm_pessoa, ds_motivo, dt_inclusao)
					values ('Jennifer Aniston', 'Me abandonou quando fiquei famoso', '2020-01-01');
