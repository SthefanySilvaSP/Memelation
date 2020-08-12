create database lndb;
use lndb;

create table tb_lista_negra (
	id_lista_negra		int primary key auto_increment,
    nm_pessoa			varchar(100),
    ds_motivo			varchar(200),
    dt_inclusao			datetime
);

create table tb_lista_fofa (
	id_lista_fofa			int primary key auto_increment,
    nm_fofura				varchar(100) not null,
    ds_porque				varchar(200) not null,
    bt_colocaria_potinho	bool,
    dt_niver				date not null
);



insert into tb_lista_negra (nm_pessoa, ds_motivo, dt_inclusao)
					values ('Jennifer Aniston', 'Me abandonou quando fiquei famoso', '2020-01-01');
                    
alter table tb_lista_negra 
        add ds_local varchar(100) default 'Outro';
        
        
select * from tb_lista_negra;
select * from tb_lista_fofa;
                    
