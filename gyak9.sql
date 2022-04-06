
declare
    type rek_type is record(f1 integer default 10, f2 vzoli.osztaly%ROWTYPE);
    rec rek_type;
    type tab_type is table of integer index by binary_integer;
    type rek_type2 is record(f1 integer, f2 tab_type);
    rec2 rek_type2;
    rec_oszt vzoli.osztaly%ROWTYPE;
begin
    rec_oszt.onev := 'SALES';
    dbms_output.put_line(rec.f1);
    
    select * into rec.f2 from vzoli.osztaly where oazon = 10;
    dbms_output.put_line(rec.f2.telephely);
    
    rec2.f2(1) := 100;
    rec2.f2(2) := 200;
    rec2.f2(3) := 300;
    for i in rec2.f2.first .. rec2.f2.last loop
        dbms_output.put_line(rec2.f2(i));
    end loop;
end;


    


/*
accept v1 number format '99' prompt 'adja meg';
accept v2 date format 'yyyy.mm.dd' default '1982.01.01' prompt 'Dátum:';

set verify on
set serveroutput on;

declare
    v_osszeg number;
begin
    select sum(fizetes) into v_osszeg from vzoli.dolgozo where oazon = &v1 and belepes < to_date('&v2');
    dbms_output.put_line(v_osszeg);
end;
*/

/*
declare
    type rektip is record (m1 integer, m2 varchar(10));
    rec rektip;
begin
    rec.m1 := 1;
    rec.m2 := 'Bubu';
    dbms_output.put_line(rec.m2);
end;
*/















