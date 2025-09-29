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
USE escola_db;
SELECT alu.Nome as Aluno, ale.Nome as Alergia FROM aluno_alergia a
INNER JOIN alergia ale ON ale.Id = a.IdAlergia
INNER JOIN aluno alu ON alu.Id = a.IdAluno;

-- ### FUNÇÕES DE AGREGAÇÃO E AGRUPAMENTO ### -- 
USE lojadb_exemplo;
-- Todos os pedidos
SELECT * FROM pedidos;
-- Contagem de pedidos
SELECT COUNT(*) FROM pedidos;
-- Contagem de pedidos com clients diferentes
SELECT COUNT(DISTINCT ClienteID) FROM pedidos;
-- Ids de clientes diferentes 
SELECT DISTINCT ClienteID FROM pedidos;
-- Traz o primeiro Id a qantidade de pedidos sendo a informação errada
SELECT ClienteID, COUNT(*) FROM pedidos;
-- Traz o primeiro Id a qantidade de pedidos com o agrupamento por ID correto
SELECT ClienteID, COUNT(ClienteID) FROM pedidos GROUP BY ClienteID;

-- Todos os itenspedidos
SELECT * FROM itenspedido;

-- Exemplo de um Ralatorio de faturamento
SELECT 
SUM(Quantidade * PrecoUnit) as 'Valor Total',
ROUND(AVG(Quantidade * PrecoUnit), 2) AS 'Ticket Médio',
MAX(Quantidade * PrecoUnit) AS 'Ticket Máximo',
MIN(Quantidade * PrecoUnit) AS 'Ticket Mínimo',
GROUP_CONCAT(PedidoId)
FROM itenspedido;

-- SELECT BOLADÃO EXEMPLO
SELECT
ip.ProdutoId, p.Nome,
SUM(ip.Quantidade * ip.PrecoUnit) AS 'Valor Total',
ROUND(AVG(ip.Quantidade * ip.PrecoUnit), 2) AS TicketMedio, 
COUNT(ip.PedidoId) AS 'Quantidade Pedidos'
FROM ItensPedido ip
JOIN produtos p USING(ProdutoId)
-- WHERE
GROUP BY ip.ProdutoId
-- HAVING TicketMedio > 1500
ORDER BY TicketMedio DESC
LIMIT 3;








































