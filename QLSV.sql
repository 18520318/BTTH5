create database QLSV
use QLSV

create table SV
(
	sv_name nvarchar(50),
	sv_id varchar(10) not null primary key,
	sv_class varchar(8),
	sv_dob date,
	sv_gender int,
	areacode varchar(3),
	sv_phone int,
	sv_mail varchar(50)
)

select * from SV
delete from SV
