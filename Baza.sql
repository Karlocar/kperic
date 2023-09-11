create database instagramwp1;

use instagramwp1;
drop table osoba;


create table osoba
(
sifra int not null primary key identity (1,1),
ime varchar (25) not null,
prezime varchar (25) not null,
datumrodenja datetime,
korisnickoime varchar (50),
lozinka varchar (60),
slika varchar (100)
);

select * from osoba;

insert into osoba (ime,prezime)
values ('Marko','Markovic'),
('Petar','Petric'),
('Ivan','Ivanic');