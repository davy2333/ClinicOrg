# CHANGELOG

## [v1.0.0] - 2024-10-04
### Added
- Conexión a la base de datos.
- Clases de las tablas de la base de datos.
- Clase `PacienteDatos` para manejar procedimientos almacenados.
- Métodos para obtener, guardar, editar y eliminar registros.

## Commits Detallados:

### Primer commit - Conexión con la base de datos
**Descripción**: 
- Se estableció la conexión a la base de datos en el archivo `appsettings.json`.
- Se agregó la clase `Conexion` para gestionar la interacción con la base de datos.

**Rama**: `development`

### Segundo commit - Clases de las tablas de la base de datos
**Descripción**:
- Se crearon las clases que representan las tablas de la base de datos para gestionar columnas y registros.

**Rama**: `development`

### Tercer commit - Clase PacienteDatos
**Descripción**:
- Se implementó la clase `PacienteDatos`, que maneja los procedimientos almacenados como `guardar`, `editar`, `eliminar` y `obtener`.

**Rama**: `feature/sp`

### Cuarto commit - Método obtener
**Descripción**:
- Se agregó el método para obtener registros por ID mediante un procedimiento almacenado.

**Rama**: `feature/sp`

### Quinto commit - Métodos de guardar, editar y eliminar
**Descripción**:
- Se añadieron los métodos para guardar, editar y eliminar datos de la base de datos.

**Rama**: `feature/sp`

---

### Notas:
- Esta versión incluye la implementación básica de funcionalidades críticas para el manejo de los datos de los pacientes en la clínica.
- Próximas versiones podrían incluir mejoras en la interfaz de usuario y nuevas funcionalidades.
