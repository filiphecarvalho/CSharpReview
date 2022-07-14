/*
 A) Faça uma consulta SQL que retorne a soma dos salários dos funcionários agrupados por empresa.
 */

SELECT
    E.NOME as Empresa,
    F.Nome as Funcionario,
    SUM(COALESCE(F.Salario, 0)) AS Salario
FROM Funcionario F
    INNER JOIN Empresa E ON (
        E.CodigoEmpresa = F.CodigoEmpresa
    )
GROUP BY F.CodigoEmpresa
ORDER BY 1, 2, 3


/*
  B) Faça uma consulta SQL que retorne o nome das empresas que possuem mais de 30 funcionários.
  */

SELECT 
   E.Nome as Empresa,
    COUNT(F.CodigoEmpresa) as Funcionarios
FROM Funcionario F
    INNER JOIN Empresa E ON (
        E.CodigoEmpresa = F.CodigoEmpresa
    )
GROUP BY E.Nome
HAVING COUNT(F.CodigoEmpresa) > 30
ORDER BY F.Nome


/*
C) Faça uma consulta SQL que retorne o nome do funcionário, o código e a descrição do centro de custos e o código e a descrição do seu cargo.
*/

SELECT 
  F.Nome as Funcionario,
  C.Descricao as CentroCusto,
  C.CodigoCentroCusto as CodigoCentroCusto,
  D.Descricao as Cargo,
  D.CodigoCargo as CodigoCargo
FROM Funcionario F
    INNER JOIN CentroDeCustos C ON (
        C.Codigo = F.CodigoCentroCusto
    )
    INNER JOIN Cargo D ON  (
        D.Codigo = F.CodigoCargo
    )
ORDER BY 1, 2, 3, 4, 5, 6

/*
D) Faça uma consulta SQL que retorne todos os funcionários que não possuem dependentes.
*/

SELECT 
  F.*
FROM Funcionario F
WHERE
  EXISTS (
    SELECT D.Codigo FROM Dependente D WHERE D.CodigoFuncionario = F.CodigoFuncionario AND D.CodigoEmpresa = F.CodigoEmpresa
  )
