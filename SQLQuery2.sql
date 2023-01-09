create database lostfound

use lostfound

 create table govn (
 namegov varchar   (50) primary key not null,
deliveredplace varchar (50)  not null,
 )


create table personn (
id varchar(50) not null primary key ,
name varchar (50) not null ,
email nvarchar (50),
password varchar (50) ,
address varchar (50) ,
pesron_gov varchar(50)
,

mobilenumber varchar(20) not null )

create table found  (
code int not null primary key ,
id_lost varchar(50) not null foreign key references personn (id),
foundplace  varchar (25) ,
day  varchar(5)  not null,
month varchar(5) not null,
year  varchar(6) not null,
price varchar(5) not null ,
gov_found varchar(50) foreign key  references govn (namegov),
 gov_dellivered varchar(50) foreign key references govn (namegov),
kind varchar (25) )
select*from personn
insert into found values(1,'1123','12 ain shams st','12','2','2020','10','cairo','cairo',' pasport')
insert into found values(2,'31190564','13 el nozha st','1','4','2020','20','cairo','Aswan',' id')



insert into govn values( 'Alexandria','23 mohamed aly st')
insert into govn values( 'Aswan','25  kornesh el nile st')
insert into govn values( 'Asyut',' 26 talaat moahmoud st')
insert into govn values( 'Beheira',' 11 mahmoud el najjar st')
insert into govn values( 'Beni Suef','safia saglol st')
insert into govn values( 'Cairo','12 talaat harb st ')
insert into govn values( 'Dakahlia','1 sleem basha st')
insert into govn values( 'Damietta',' 3 el tahrir st')
insert into govn values( 'Faiyum','15 kaream foad st')
insert into govn values( 'Gharbia','15 kaream foad st ')
insert into govn values( 'Giza','12 talaat st')
insert into govn values( 'Ismailia',' el horia st')
insert into govn values( 'Kafr El Sheikh',' 23 el mohands st')
insert into govn values( 'Luxor',' 16 el nile st')
insert into govn values( 'Matruh','12 alexandria st')
insert into govn values( 'Minya','12 mohamed mahmoud st')
insert into govn values( 'Monufia','14 rashad  st')
insert into govn values( 'New Valley','  12mahmoud abass st')
insert into govn values( 'North Sinai',' 13 kaream el gendy st ')
insert into govn values( 'Port Said','16 saed mahmoud st')
insert into govn values( 'Qalyubia',' 18 sayd hamada  st')
insert into govn values( 'Qena',' 25 el tahrir st')
insert into govn values( 'Red Sea','el hegaz st')
insert into govn values( 'Sharqia',' 13 makram st')
insert into govn values( 'Sohag',' 23kornesh el nile st')
insert into govn values( 'South Sinai',' abu bakr el sedek st')
insert into govn values( 'Suez','el sabah square ')

