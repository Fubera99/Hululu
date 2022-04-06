create table dolg2 as select * from nikovits.dolgozo;
create table oszt2 as select * from nikovits.osztaly;

select * from dolg2
where dkod in (select fonoke from dolg2)
and fizetes = (
    select min(fizetes)
    from dolg2
    where dkod in (select fonoke from dolg2)
);

select minf, kategoria
from nikovits.fiz_kategoria, (
    select min(fizetes) minf
    from nikovits.dolgozo 
    where dkod in (
        select fonoke
        from nikovits.dolgozo
    )
) t
where t.minf between also and felso;

select nev, count(*), count(nev), count(distinct nev)
from nikovits.szeret
group by nev;

select count(distinct gyumolcs)
from nikovits.szeret;

select nev, count(distinct gyumolcs)
from nikovits.szeret
group by nev
having count(distinct gyumolcs) = (select count(distinct gyumolcs) from nikovits.szeret);


select * from (select distinct nev from nikovits.szeret), (select distinct gyumolcs from nikovits.szeret)
minus
select * from nikovits.szeret;

select nev from nikovits.szeret
minus
select distinct nev
from (select * from (select distinct nev from nikovits.szeret),(select distinct gyumolcs from nikovits.szeret)
minus
select * from nikovits.szeret);


select nev from nikovits.szeret where nev!='Micimackó'
minus
select nev
from (select * from (select distinct nev from nikovits.szeret),(select distinct gyumolcs from nikovits.szeret where nev='Micimackó')
minus
select * from nikovits.szeret);

create table gyak6 as select * from nikovits.osztaly;

select * from nikovits.dolgozo;

select * from gyak6;

create table projekt as select * from nikovits.projekt;
create table cikk as select * from nikovits.cikk;
create table szallit as select * from nikovits.szallit;
create table szallito as select * from nikovits.szallito;



select * from projekt;

SELECT object_name "TABLE", created FROM user_objects 
WHERE object_type='TABLE' AND object_name LIKE 'GYAK%'
ORDER BY object_name;

select *
from szallit natural join szallito natural join cikk natural join projekt;

















