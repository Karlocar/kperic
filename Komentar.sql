create table komentar




(
	sifra int not null primary key identity (1,1),
	vrijemekomentara datetime  ,
	opis varchar (250) not null,
	objava int,
	osoba varchar (250) not null
);

insert into komentar( opis, osoba)
values 
('Priroda','Marko Markovic'),
('Plaza','Petar Petric'),
('Bozic','Ivan Ivanic');