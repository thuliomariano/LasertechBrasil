create database lasertechBrasil;

use lasertechbrasil;

drop table arm;

create table arm(
 idArm int primary key identity,
 patrimonio varchar(40),
 versaoDeHardwarePc varchar(80),
 versaoDeSoftwarePc varchar(10),
 serialIris varchar(16),
 SerialColibri varchar(16),
 windowsCe varchar(16),
 bootloader varchar(16),
 softwareTrufix varchar(100),
 softwareToradex varchar(50),
 patrimonioPcAtualizado varchar(40),
 versaoDeHardwareAtualizadoPc varchar(80),
 versaoDeSoftwareAtualizadoPc varchar(10),
 windowsCeAtualizado varchar(16),
 bootLoaderAtualizado varchar(16),
 softwareTrufixAtualizado varchar(100),
 softwareToradexAtualizado varchar(50),
 dataDeEntrada datetime,
 dataDesaida datetime
 );

 select * from arm;
 select * from arm where idarm = 1;