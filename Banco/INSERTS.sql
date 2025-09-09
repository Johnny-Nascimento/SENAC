USE escola_db;
-- Exemplo
-- Alergia
-- INSERT INTO alergia -- * Sem especificar os campos vai assumir Id Nome automaticamente * 

INSERT INTO alergia (Id, Nome) VALUES
(400, 'Trigo');

INSERT INTO alergia (Id, Nome) VALUES
(null, 'Leite');

INSERT INTO alergia (Nome) VALUES
('Camarão'),
('Amendoim');

INSERT INTO alergia (Nome) VALUES
('Dipirona');

SELECT * FROM alergia;