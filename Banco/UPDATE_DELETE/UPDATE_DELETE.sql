USE kauetrack;

SELECT * FROM kauetrack.colaborador;

-- UPDATE

-- Altera todos os cpfs para 123456789
UPDATE colaborador SET CPF = '123456789';

-- Altera todos os cpfs para 123456789 e telefones para 47123456789
UPDATE colaborador SET CPF = '123456789', telefone = '47123456789';

-- Alteração linha especifica id 1 de CPF para 123456789
UPDATE colaborador SET CPF = '123456789' WHERE id = 1;

-- Alteração linha especifica id 1 de CPF para 123456789 e telefone para 47123456789
UPDATE colaborador SET CPF = '123456789', telefone = '47123456789' WHERE id = 1;

-- ############
UPDATE colaborador SET departamento_id = 2, nome = 'Colaborador Da Silva' WHERE id = 1;
UPDATE colaborador SET nome = 'Colaborador Dos Santos' WHERE id = 2;

-- DELETE
DELETE FROM viagem_colaborador where viagem_id = 1 AND colaborador_id = 1;