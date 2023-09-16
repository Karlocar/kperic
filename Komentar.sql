create table komentar




(
	sifra int not null primary key identity (1,1),
	vrijemekomentara datetime  ,
	opis varchar (250) ,
	objava int,
	osoba varchar (250) not null
);

insert into komentar( osoba)
values 
('Marko Markovic'),
('Petar Petric'),
('Ivan Ivanic');
