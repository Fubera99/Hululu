/*
select lpad(' ', 2*(level-1)) || dnev, dkod, fonoke, foglalkozas, level
from vzoli.dolgozo
start with foglalkozas='MANAGER'
connect by prior dkod=fonoke;

select lpad(' ', 2*(level-1)) || dnev, dkod, fonoke, foglalkozas, level
from vzoli.dolgozo
start with foglalkozas='MANAGER'
connect by prior fonoke=dkod;

select * from vzoli.dolgozo;
*/

--create table vagyonok as select * from nikovits.vagyonok;

--select * from vagyonok;

/*
select sum(vagyon) -- lpad(' ', 2*(LEVEL-1)) || nev, apja, vagyon
from vagyonok
where level = 3
start with nev = 'KAIN'
connect by prior nev = apja;

select lpad(' ', 4*(level-1)) || nev as nev, apja, vagyon
from vagyonok
where nev like '%%'
start with nev = 'ABEL'
connect by prior nev = apja;
*/

select lpad(' ', 4*(level-1)) || nev as nev, apja, vagyon
from vagyonok
--where nev like '%%'
start with nev = 'ABEL'
connect by prior nev = apja and prior nev like '%A%';

select lpad(' ', 4*(level-1)) || nev as nev, apja, vagyon
from vagyonok
where nev like '%%'
start with nev = 'ABEL'
connect by prior nev = apja and nev like '%A%';













