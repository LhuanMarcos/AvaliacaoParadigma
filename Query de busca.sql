SELECT 
    c.id,
    c."Nome",
    c."Salario",
    d."Nome" AS departamento
FROM public."Colaborador" c
JOIN public."Departamento" d
    ON d.id = c."DeptID"
WHERE c."Salario" = (
    SELECT MAX(c2."Salario")
    FROM public."Colaborador" c2
    WHERE c2."DeptID" = c."DeptID"
);