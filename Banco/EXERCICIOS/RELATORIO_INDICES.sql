-- Analise os 5 relatórios, e insira índices para melhorar a performance.
-- O que deve ser entregue, código de criação dos índices, e um resumo exemplo
EXPLAIN SELECT 
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
-- aula_aluno ROWS = 100 FILTERED = 50
CREATE INDEX presenca_index ON aula_aluno (Presenca);
-- aula_aluno ROWS = 47 FILTERED = 100%
-- #####################################################

-- 2. Ranking de alunos por média de notas por disciplina.
EXPLAIN SELECT a.Id, a.Nome, ROUND(AVG(Nota)) as Media, COUNT(Nota) FROM aula_avaliacao
JOIN aluno a ON IdAluno = a.Id
JOIN turma t ON a.IdTurma = t.Id
WHERE t.Nome = '8E'
GROUP BY IdAluno
ORDER BY Media DESC
LIMIT 10;
-- turma ROWS 100 FILTERED = 10%
CREATE INDEX turma_index ON turma(Nome);
-- turma ROWS 1 FILTERED = 100%
-- #####################################################

-- 3. Relatório de uso de equipamentos por sala (com checagem de em uso ou não).
EXPLAIN SELECT * FROM sala_equipamento
JOIN equipamento e ON IdSala = e.Id
WHERE EmUso = TRUE AND e.Nome = 'Notebook';

-- IdSala ROWS = 100 FILTERED 10%
-- equipamento ROWS 100 FILTERED 10%
CREATE INDEX fkequipamento_index ON sala_equipamento(IdSala);
CREATE INDEX equipamento_index ON equipamento(Nome);
-- IdSala ROWS = 14 FILTERED 10%
-- equipamento ROWS 1 FILTERED 10%
-- #####################################################

-- 4. Relatório por Professor Sala de aula numero de turmas disciplina.
EXPLAIN SELECT f.Nome Professor, s.Nome Sala, COUNT(IdTurma) 'Quantidade de Turmas', d.Nome FROM aula
JOIN turma t ON t.Id = IdTurma
JOIN funcionario f ON f.Id = IdFuncionario
JOIN sala s ON s.Id = IdSala
JOIN disciplina d ON IdDisciplina = d.Id
WHERE f.Cargo = 'Professor'
GROUP BY IdTurma, IdSala;
-- cargo ROWS = 100 FILTERED 33.33%
CREATE INDEX funcionario_index ON funcionario(Cargo);
-- cargo ROWS = 1 FILTERED 34%
-- #####################################################

-- 5. Contato de emergencia, relatrorio com aluno responsaveis numeros de contato necessidades especiais e alergias.
EXPLAIN SELECT aluno.Id, aluno.Nome, 
	   GROUP_CONCAT(DISTINCT alergia.Nome SEPARATOR ' | ') Alergia,
       GROUP_CONCAT(DISTINCT aluno_alergia.Laudo SEPARATOR ' | ') Laudo, GROUP_CONCAT(DISTINCT aluno_alergia.Observacao SEPARATOR ' | ') 'Observação', 
       GROUP_CONCAT(DISTINCT responsavel.Nome SEPARATOR ' | ') Responsavel, GROUP_CONCAT(DISTINCT responsavel.Telefone SEPARATOR ' | ') Contato
FROM aluno_alergia
JOIN aluno ON aluno.Id = aluno_alergia.IdAluno
JOIN aluno_responsavel ON aluno_responsavel.IdAluno = aluno.Id
JOIN responsavel ON responsavel.Id = aluno_responsavel.IdResponsavel
JOIN alergia ON alergia.Id = aluno_alergia.IdAlergia
WHERE alergia.Nome = 'Avelã'
GROUP BY aluno.Id
ORDER BY aluno.Nome;
-- alergia ROWS = 99 FILTERED 10%
CREATE INDEX alergia_index ON alergia(Nome);
-- alergia ROWS = 3 FILTERED 100%