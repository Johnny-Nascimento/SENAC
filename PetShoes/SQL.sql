CREATE DATABASE petshoes;
use petshoes;
CREATE TABLE ANIMAIS (
    id_animal INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    idade_estimada INT,
    porte int NOT NULL,
    raca VARCHAR(100),
    sexo int NOT NULL,
    castrado BOOLEAN NOT NULL,
    vacinado BOOLEAN NOT NULL,
    temperamento TEXT,
    observacoes_medicas TEXT,
    status_adocao int NOT NULL,
    data_cadastro TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);


INSERT INTO animais 
VALUES
(1, 'Max', 3, 2, 'SRD', 1, 1, 1, 'Muito calmo, adora crianças e passeios curtos', 'Nenhuma relevante', 3, NOW()),
(2, 'Luna', 1, 1, 'Chihuahua', 2, 1, 1, 'Muito energética, ideal para casas com espaço.', 'Precisa de ração hipoalergênica', 2, NOW()),
(3, 'Thor', 5, 3, 'Pastor Alemão', 1, 1, 1, 'Muito protetor, ideal para crianças.', 'Saúde perfeita', 1, NOW());

SELECT id_animal, nome, idade_estimada, porte, raca, sexo, castrado, vacinado, temperamento, observacoes_medicas, status_adocao, data_cadastro FROM animais;

SELECT * FROM animais;