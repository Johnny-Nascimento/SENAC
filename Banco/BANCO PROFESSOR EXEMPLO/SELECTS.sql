-- Clientes
SELECT * FROM clientes;
SELECT * FROM clientes WHERE Estado = 'SC';

SELECT * FROM clientes WHERE Estado = 'SC' AND Cidade = 'Florianópolis';
SELECT * FROM clientes WHERE Estado = 'PR' AND Cidade = 'Florianópolis';

SELECT * FROM clientes WHERE Estado = 'PR' OR Cidade = 'Florianópolis';

SELECT * FROM clientes WHERE NOT Cidade = 'Florianópolis';

-- Igual WHERE = 'Ana Souza'
SELECT * FROM clientes WHERE Nome LIKE 'Ana Souza';

-- Deve trazer todas as Ana + qualquer coisa
SELECT * FROM clientes WHERE Nome LIKE 'Ana%';

-- Deve trazer todos os An + qualquer coisa
SELECT * FROM clientes WHERE Nome LIKE 'An%';

-- Não deve trazer nenhum nome começado por An
SELECT * FROM clientes WHERE Nome NOT LIKE 'An%';

-- Deve trazer todos os qualquer coisa + Souza
SELECT * FROM clientes WHERE Nome LIKE '%Souza';

-- Deve trazer todos os qualquer coisa + Souza + qualquer coisa
SELECT * FROM clientes WHERE Nome LIKE '%Souza%';

-- Deve trazer todos os An + qualquer coisa que não são Ana
SELECT * FROM clientes WHERE Nome LIKE 'An%' AND Nome NOT LIKE 'Ana%';

-- #######################################################################
-- Produtos
-- ORDER BY DESC por padrão, ordena decrescente
SELECT * FROM produtos;

-- Ordena crescente
SELECT * FROM produtos ORDER BY Preco ASC; 

-- #######################################################################
-- Pedidos
SELECT * FROM pedidos;

-- Inner Join ou Join, objetivo trazer a interceção dos dados
-- Todos os pedidos com todos os clientes que tenham pedidos.
SELECT * FROM pedidos p
INNER JOIN clientes c ON c.ClienteID = p.ClienteID;

-- Left Join
SELECT * FROM pedidos p
LEFT JOIN clientes c ON c.ClienteID = p.ClienteID;

-- Right Join
SELECT * FROM pedidos p
RIGHT JOIN clientes c ON c.ClienteID = p.ClienteID;

-- Full alter join
SELECT * FROM pedidos p
LEFT JOIN clientes c ON c.ClienteID = p.ClienteID
UNION
SELECT * FROM pedidos p
RIGHT JOIN clientes c ON c.ClienteID = p.ClienteID;

-- joins
SELECT alu.Nome as Aluno, ale.Nome as Alergia FROM aluno_alergia a
INNER JOIN alergia ale ON ale.Id = a.IdAlergia
INNER JOIN aluno alu ON alu.Id = a.IdAluno;

