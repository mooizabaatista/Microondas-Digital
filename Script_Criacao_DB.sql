-- Cria��o da base de dados
CREATE DATABASE Microondas;

-- Sele��o da base de dados
USE Microondas;

-- Cria��o da tabela ProgramasPersonalizados
CREATE TABLE ProgramasPersonalizados (
    Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL, 
    Nome VARCHAR(100) NOT NULL,
    Alimento VARCHAR(100) NOT NULL,
    Tempo INT NOT NULL,
    Potencia INT NOT NULL,
    Instrucoes VARCHAR(600) NULL,
    CaractereAquecimento CHAR(1) NOT NULL
);