create table Cviky (
CvikyId int auto_increment,
DruhCviku varchar(500),
CasCviku time,
DenCviku date
);

INSERT INTO `Cviky`( `DruhCviku`, `CasCviku`, `DenCviku`) VALUES ('Běhaní','14:56:59','2008-10-29');
INSERT INTO `Cviky`( `DruhCviku`, `CasCviku`, `DenCviku`) VALUES ('Posilování','14:56:59','2008-10-29');
INSERT INTO `Cviky`( `DruhCviku`, `CasCviku`, `DenCviku`) VALUES ('Hody','14:56:59','2008-10-29');
INSERT INTO `Cviky`( `DruhCviku`, `CasCviku`, `DenCviku`) VALUES ('Dřepy','14:56:59','2008-10-29');
INSERT INTO `Cviky`( `DruhCviku`, `CasCviku`, `DenCviku`) VALUES ('Kliky','14:56:59','2008-10-29');
INSERT INTO `Cviky`( `DruhCviku`, `CasCviku`, `DenCviku`) VALUES ('Kopy','14:56:59','2008-10-29');
INSERT INTO `Cviky`( `DruhCviku`, `CasCviku`, `DenCviku`) VALUES ('Techniky','14:56:59','2008-10-29');


select *from Cviky	