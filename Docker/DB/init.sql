CREATE TABLE IF NOT EXISTS usuarios(
    id_usuario SERIAL PRIMARY KEY,
    Nombre VARCHAR(40)
);
CREATE TABLE IF NOT EXISTS conversaciones(
    id_conversacion SERIAL PRIMARY KEY,
    dir VARCHAR(100),
    date_creation TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    date_lastMessage TIMESTAMP
);
CREATE TABLE IF NOT EXISTS memorias(
    id_memoria SERIAL PRIMARY KEY,
    dir VARCHAR(100),
    id_conversacion INT,
    FOREIGN KEY (id_conversacion) REFERENCES conversaciones(id_conversacion)
);
CREATE TABLE IF NOT EXISTS acciones(
    id_accion SERIAL PRIMARY KEY,
    id_usuario,
    id_conversacion,
    FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario),
    FOREIGN KEY (id_conversacion) REFERENCES conversaciones(id_conversacion),
    tipo VARCHAR(20),
    success BOOLEAN,
    time_response INTERVAL,
    fecha_hora TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);