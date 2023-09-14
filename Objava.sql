create table objava 


(
	sifra int not null primary key identity (1,1),
	naslov varchar (50) not null,
	opis varchar (250) not null,
	vrijemeizrade datetime,
	ipadresa varchar (20),
	osoba int,
	slika varchar
);

insert into objava (naslov, opis)
values ('London','Engleska'),
		('Madrid','Spanjolska'),
		('Bec','Austrija');
