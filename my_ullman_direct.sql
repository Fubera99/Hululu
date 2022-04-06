select *
from vzoli.dolgozo join vzoli.osztaly on(vzoli.dolgozo.oazon = vzoli.osztaly.oazon);

select *
from vzoli.dolgozo left outer join vzoli.osztaly on(vzoli.dolgozo.oazon = vzoli.osztaly.oazon);

select *
from vzoli.dolgozo right outer join vzoli.osztaly on(vzoli.dolgozo.oazon = vzoli.osztaly.oazon);

select dnev, onev
from vzoli.dolgozo full outer join vzoli.osztaly on(vzoli.dolgozo.oazon = vzoli.osztaly.oazon);

select min(fizetes + NVL(jutalek, 0)) from vzoli.dolgozo;

select fizetes from vzoli.dolgozo
minus
select d2.fizetes
from vzoli.dolgozo d1, vzoli.dolgozo d2
where d1.fizetes < d2.fizetes;

select dnev, fizetes
from vzoli.dolgozo
where fizetes = (select min(fizetes) from vzoli.dolgozo);

select *
from
    (select dnev, fizetes
    from vzoli.dolgozo
    order by fizetes)
where rownum <= 3;








