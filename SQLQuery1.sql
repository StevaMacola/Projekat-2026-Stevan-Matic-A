create database ProjekatStevanMatic2026
use ProjekatStevanMatic2026

create table Korisnik(
korisnik_id int primary key Identity(1,1),
ime nvarchar(20),
pass nvarchar(20)
)

create table Klijent(
klijent_ID int primary key Identity(1,1),
Ime nvarchar(20),
Prezime nvarchar(20),
Ulica nvarchar(20),
Broj int,
Opšitna nvarchar(20),
Grad nvarchar(20),
Mobilni nvarchar(20),
datum_upisa DATE
)


create table Relacije(
relacije_ID int primary key Identity(1,1),
od nvarchar(20),
do nvarchar(20),
rastojanje int,
doplata int
)

create table Usluge(
usluga_id int primary key Identity(1,1),
Vrsta_usluge nvarchar(20),
Trajanje int,
cena int
)

create table BAZA(
baza_ID int primary key Identity(1,1),
klijent_id int foreign key references Klijent(klijent_id),
relacije_id int foreign key references Relacije(relacije_id),
termini_id int  foreign key references Termini(termini_id),
usluga_id int  foreign key references Usluge(usluga_id),
Datum_pocetka DATE,
Vreme_pocetka nvarchar(20),
statu_s nvarchar(20),
Napomena nvarchar(20)
)

insert into Korisnik values('Slavica', 'Lavica123')
select * from Korisnik
