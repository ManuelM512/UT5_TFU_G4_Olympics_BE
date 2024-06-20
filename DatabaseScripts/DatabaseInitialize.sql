CREATE DATABASE OlympicsDB;

USE OlympicsDB;

-- Create the Juez table
CREATE TABLE Juez (
    identificador INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL,
    nacionalidad VARCHAR(255) NOT NULL
);

-- Create the Competencia table
CREATE TABLE Competencia (
    identificador VARCHAR(255) PRIMARY KEY,
    modalidad VARCHAR(255) NOT NULL,
    categoria VARCHAR(255) NOT NULL
);

-- Create the Competidor table
CREATE TABLE Competidor (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL,
    sexo VARCHAR(50) NOT NULL,
    nacionalidad VARCHAR(255) NOT NULL,
    edad INT NOT NULL,
    descripcion_id INT NOT NULL,
    FOREIGN KEY (descripcion_id) REFERENCES DatosCompetidor(id)
);

CREATE TABLE DatosCompetidor (
    id INT AUTO_INCREMENT PRIMARY KEY,
    descripcion VARCHAR(255) NOT NULL
);

-- Create the Actuacion table
CREATE TABLE Actuacion (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL,
    competidor_id INT,
    competencia_id VARCHAR(255),
    FOREIGN KEY (competidor_id) REFERENCES Competidor(id),
    FOREIGN KEY (competencia_id) REFERENCES Competencia(identificador)
);

-- Create the PistaNatacion table
CREATE TABLE PistaNatacion (
    id INT AUTO_INCREMENT PRIMARY KEY,
    actuacion_id INT,
    tiempo FLOAT,
    dificultad FLOAT,
    tecnica FLOAT,
    FOREIGN KEY (actuacion_id) REFERENCES Actuacion(id)
);

-- Create the Halterofilia table
CREATE TABLE Halterofilia (
    id INT AUTO_INCREMENT PRIMARY KEY,
    actuacion_id INT,
    arrancada FLOAT,
    dos_tiempos FLOAT,
    peso FLOAT,
    FOREIGN KEY (actuacion_id) REFERENCES Actuacion(id)
);

-- Create the Esgrima table
CREATE TABLE Esgrima (
    id INT AUTO_INCREMENT PRIMARY KEY,
    actuacion_id INT,
    toque FLOAT,
    derecho_ataque FLOAT,
    prioridad FLOAT,
    asalto INT,
    combate INT,
    FOREIGN KEY (actuacion_id) REFERENCES Actuacion(id)
);

-- Create the Surf table
CREATE TABLE Surf (
    id INT AUTO_INCREMENT PRIMARY KEY,
    actuacion_id INT,
    seleccion_ola FLOAT,
    maniobras FLOAT,
    altura_amplitud FLOAT,
    variedad FLOAT,
    potencia_radicalidad FLOAT,
    progresion FLOAT,
    FOREIGN KEY (actuacion_id) REFERENCES Actuacion(id)
);

-- Create the Kitesurf table
CREATE TABLE Kitesurf (
    id INT AUTO_INCREMENT PRIMARY KEY,
    actuacion_id INT,
    tecnica FLOAT,
    dificultad FLOAT,
    altura_amplitud FLOAT,
    variedad FLOAT,
    impresionGeneral FLOAT,
    FOREIGN KEY (actuacion_id) REFERENCES Actuacion(id)
);

-- Create the GimnasiaClavados table
CREATE TABLE GimnasiaClavados (
    id INT AUTO_INCREMENT PRIMARY KEY,
    actuacion_id INT,
    dificultad FLOAT,
    ejecucion FLOAT,
    FOREIGN KEY (actuacion_id) REFERENCES Actuacion(id)
);

-- Create the intermediate table for the many-to-many relationship between Competencia and Juez
CREATE TABLE Competencia_Juez (
    competencia_id VARCHAR(255),
    juez_id INT,
    PRIMARY KEY (competencia_id, juez_id),
    FOREIGN KEY (competencia_id) REFERENCES Competencia(identificador),
    FOREIGN KEY (juez_id) REFERENCES Juez(identificador)
);

-- Create the intermediate table for the many-to-many relationship between Competencia and Competidor
CREATE TABLE Competencia_Competidor (
    competencia_id VARCHAR(255),
    competidor_id INT,
    PRIMARY KEY (competencia_id, competidor_id),
    FOREIGN KEY (competencia_id) REFERENCES Competencia(identificador),
    FOREIGN KEY (competidor_id) REFERENCES Competidor(id)
);
