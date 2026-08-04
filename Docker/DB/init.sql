CREATE TABLE IF NOT EXISTS usuarios(
    id_usuario SERIAL PRIMARY KEY,
    Nombre VARCHAR(40) NOT NULL
);
CREATE TABLE IF NOT EXISTS conversaciones(
    id_conversacion SERIAL PRIMARY KEY,
    dir VARCHAR(100) NOT NULL,
    date_creation TIMESTAMP DEFAULT CURRENT_TIMESTAMP NOT NULL,
    date_last_message TIMESTAMP NULL
);
CREATE TABLE IF NOT EXISTS memorias(
    id_memoria SERIAL PRIMARY KEY,
    dir VARCHAR(100) NOT NULL,
    id_conversacion INT NOT NULL,
    FOREIGN KEY (id_conversacion) REFERENCES conversaciones(id_conversacion)
);
CREATE TABLE IF NOT EXISTS acciones(
    id_accion SERIAL PRIMARY KEY,
    id_usuario INT NOT NULL,
    id_conversacion INT NOT NULL,
    FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario),
    FOREIGN KEY (id_conversacion) REFERENCES conversaciones(id_conversacion),
    tipo VARCHAR(20) NOT NULL,
    success BOOLEAN NOT NULL,
    time_response INTERVAL NOT NULL,
    fecha_hora TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);
CREATE TABLE IF NOT EXISTS mensajes(
    id_mensaje SERIAL PRIMARY KEY,
    id_conversacion INT NOT NULL,
    FOREIGN KEY (id_conversacion) REFERENCES conversaciones(id_conversacion),
    id_usuario int NOT NULL,
    FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario),
    contenido TEXT NOT NULL,
    success BOOLEAN NOT NULL,
    fecha_hora TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);
CREATE TABLE IF NOT EXISTS modelosIA(
    id_ia SERIAL PRIMARY KEY,
    nombre VARCHAR(40) NOT NULL,
    activo BOOLEAN NOT NULL
);