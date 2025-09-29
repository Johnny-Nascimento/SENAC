-- 1. Frequência Geral dos Alunos por Turma e Disciplina (com presença e falta).
-- Presença
SELECT 
COUNT(aa.IdAluno) as 'Quantidade de alunos',
GROUP_CONCAT(aa.IdAluno) 'Ids alunos',
d.Nome,
t.Nome,
t.Serie,
HorarioAgendamentoAula 
FROM aula_aluno aa
JOIN aula a ON a.Id = aa.IdAula
JOIN disciplina d ON d.Id = a.IdDisciplina
JOIN turma t ON t.Id = a.IdTurma
WHERE aa.Presenca = 'Presença'
GROUP BY d.Id, t.Id
ORDER BY d.Nome, t.Serie;

-- Falta
SELECT 
aa.IdAula,
COUNT(aa.IdAluno) as `Quantidade de alunos`,
GROUP_CONCAT(aa.IdAluno) 'Ids alunos',
d.Nome,
t.Nome,
t.Serie,
HorarioAgendamentoAula 
FROM aula_aluno aa
JOIN aula a ON a.Id = aa.IdAula
JOIN disciplina d ON d.Id = a.IdDisciplina
JOIN turma t ON t.Id = a.IdTurma
WHERE aa.Presenca = 'Falta'
GROUP BY d.Id, t.Id
ORDER BY `Quantidade de alunos` DESC;

-- 2. Ranking de alunos por média de notas por disciplina.
SELECT a.Id, a.Nome, ROUND(AVG(Nota)) as Media, COUNT(Nota) FROM aula_avaliacao
JOIN aluno a ON IdAluno = a.Id
GROUP BY IdAluno
ORDER BY Media DESC
LIMIT 10;

-- 3. Relatório de uso de equipamentos por sala (com checagem de em uso ou não).
SELECT * FROM sala_equipamento
JOIN equipamento e ON IdSala = e.Id
WHERE EmUso = TRUE;

SELECT * FROM sala_equipamento
JOIN equipamento e ON IdSala = e.Id
WHERE EmUso = FALSE;

-- 4. Relatório por Professor Sala de aula numero de turmas disciplina.
SELECT f.Nome Professor, s.Nome Sala, COUNT(IdTurma) 'Quantidade de Turmas', d.Nome FROM aula
JOIN turma t ON t.Id = IdTurma
JOIN funcionario f ON f.Id = IdFuncionario
JOIN sala s ON s.Id = IdSala
JOIN disciplina d ON IdDisciplina = d.Id
WHERE f.Cargo = 'Professor'
GROUP BY IdTurma, IdSala;

-- 5. Contato de emergencia, relatrorio com aluno responsaveis numeros de contato necessidades especiais e alergias.
-- view
CREATE VIEW v_informacoes_saude AS 
SELECT aluno.Id, aluno.Nome, 
	   GROUP_CONCAT(DISTINCT alergia.Nome SEPARATOR ' | ') Alergia,
       GROUP_CONCAT(DISTINCT aluno_alergia.Laudo SEPARATOR ' | ') Laudo, GROUP_CONCAT(DISTINCT aluno_alergia.Observacao SEPARATOR ' | ') 'Observação', 
       GROUP_CONCAT(DISTINCT responsavel.Nome SEPARATOR ' | ') Responsavel, GROUP_CONCAT(DISTINCT responsavel.Telefone SEPARATOR ' | ') Contato
FROM aluno_alergia
JOIN aluno ON aluno.Id = aluno_alergia.IdAluno
JOIN aluno_responsavel ON aluno_responsavel.IdAluno = aluno.Id
JOIN responsavel ON responsavel.Id = aluno_responsavel.IdResponsavel
JOIN alergia ON alergia.Id = aluno_alergia.IdAlergia
GROUP BY aluno.Id
ORDER BY aluno.Nome;

-- view
SELECT * FROM v_informacoes_saude;

-- Explain
SELECT * FROM sala;
-- 100 ROWS
EXPLAIN SELECT * FROM sala WHERE Nome = 'Sala 101' AND Andar = 1;

-- Com index
SELECT * FROM sala WHERE Andar = 1;
CREATE INDEX sala_index ON sala (Andar);
-- 26 ROWS
EXPLAIN SELECT * FROM sala WHERE Nome = 'Sala 101' AND Andar = 1;

CREATE INDEX nome_responsavel_index ON responsavel (Nome);
DROP INDEX nome_responsavel_index ON responsavel;
CREATE INDEX nome_CPF_responsavel_index ON responsavel (Nome, CPF);
EXPLAIN SELECT * FROM responsavel WHERE Nome = "João" AND CPF = '10110110111';

