create database lasertechBrasil;

use lasertechbrasil;

drop table arm;

	create table arm(
	 idArm int primary key identity,
	 patrimonio varchar(50),
	 versaoDeHardwarePc varchar(80),
	 versaoDeSoftwarePc varchar(50),
	 mac varchar(70),
	 serialIris varchar(30),
	 SerialColibri varchar(50),
	 windowsCe varchar(30),
	 bootloader varchar(30),
	 softwareTrufix varchar(100),
	 softwareToradex varchar(50),
	 patrimonioPcAtualizado varchar(40),
	 versaoDeHardwareAtualizadoPc varchar(80),
	 versaoDeSoftwareAtualizadoPc varchar(50),
	 windowsCeAtualizado varchar(50),
	 bootLoaderAtualizado varchar(50),
	 softwareTrufixAtualizado varchar(100),
	 softwareToradexAtualizado varchar(50),
	 dataDeEntrada datetime,
	 dataDesaida datetime
	 );


 select * from arm where idarm = 1;

 drop table arm;