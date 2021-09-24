create database dbinterart;

use dbinterart;

create table tbCli(
cliNome varchar(50) not null,
cliCPF char(14) primary key,
cliNasc char(10) not null,
cliEmail varchar(50) not null unique,
cliEnd varchar(55) not null
);

create table tbfunc(
funcCod int primary key,
funcNome varchar(50) not null,
funcCPF char(14) unique not null,
funcRG char(12) not null,
funcNasc char(10) not null,
funcEnd varchar(55) not null,
funcCel char(15) not null unique,
funcEmail varchar(50) not null unique,
funcCarg varchar(20) not null
);

create table tbjogo(
gameCod int primary key,
gameNome varchar(50) not null,
gameVer varchar(10) default("1"),
gameDev varchar(20) not null,
gameGen varchar(15) not null,
gameAge varchar(15) not null,
gameYear int(4) not null,
gameSinop varchar(150) not null
);