CREATE FUNCTION getNthHighestSalary(@N INT) RETURNS INT AS
BEGIN
    RETURN (
        select salary
        from
        (
            select distinct salary 
            from employee
            order by salary desc
            offset @N-1 row
            fetch next 1 row only
        )as tmp
    );
END