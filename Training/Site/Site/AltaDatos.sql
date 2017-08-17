select * from Products;
insert into ProductImage values ('Espada profesional marca Allstar FIE', 'C:\Users\Salesforce Academy\Desktop\Site\Site\Site',1,3)
insert into ProductImage values ('Florete profesional marca Allstar FIE', 'C:\Users\Salesforce Academy\Desktop\Site\Site\Site\florete.jpg',1,4)
insert into ProductImage values ('Sable profesional marca Allstar FIE', 'C:\Users\Salesforce Academy\Desktop\Site\Site\Site\sable.jpg',1,5)


insert into ProductImage values ('Espada de entrenamiento marca convencional', 'C:\Users\Salesforce Academy\Desktop\Site\Site\Site\EspadaChina.jpg',1,6)
insert into ProductImage values ('Florete de entrenamiento marca convencional', 'C:\Users\Salesforce Academy\Desktop\Site\Site\Site\FloreteChino.jpg',1,7)
insert into ProductImage values ('Sable de entrenamiento marca convencional', 'C:\Users\Salesforce Academy\Desktop\Site\Site\Site\SableChino.jpg',1,8)


insert into ProductImage values ('Tenis marca Adidas version Londres', 'C:\Users\Salesforce Academy\Desktop\Site\Site\Site\tenis.jpg',1,9)
insert into ProductImage values ('Tenis marca Adidas version Atenas', 'C:\Users\Salesforce Academy\Desktop\Site\Site\Site\TenisAtenas.jpg',1,10)

update ProductImage
Set ImgURL= 'C:\Users\Salesforce Academy\Desktop\Site\Site\Site\espada.jpg'
where id=1


insert into Category values ('Armas','Todo tipo de armas',1);
insert into Category values ('Tenis','Todo tipo de Tenis',1);


insert into Products Values ('Espada Allstar','marca allstar fie', 'X0001', 1500, 'esp', 1,1)

insert into Products Values ('Florete Allstar','marca allstar fie', 'X0002', 1400,' flo', 1,1) 

insert into Products Values ('Sable Allstar','marca allstar fie', 'X0003', 1300, 'sa', 1,1)

insert into Products Values ('Espada convencional','marca china', 'X0004', 1500, 'espc',1,1)

insert into Products Values ('Florete convencional','marca china', 'X0005', 1400, 'floc',1,1)

insert into Products Values ('Sable convencional','marca china', 'X0006', 1300, 'sac', 1,1)

insert into Products Values ('Tenis Lodres', 'marca Adidas', 'X0007', $3000,'telo',2,1)

insert into Products values('Tenis Atenas', 'marca Nike', 'X0008', 2400, 'teat', 2,1);
