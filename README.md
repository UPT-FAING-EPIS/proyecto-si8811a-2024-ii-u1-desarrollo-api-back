# Aplicación de Información para los Juegos Florales UPT

## 📚 Descripción de la Aplicación

Esta aplicación está diseñada para proporcionar información detallada sobre los Juegos Florales organizados por la Universidad Privada de Tacna (UPT). Los Juegos Florales son una celebración del talento artístico y cultural de los estudiantes de la UPT, promoviendo la creatividad y el trabajo en equipo.

## 📊 Ejemplos de Uso del Método POST

### Envío de Datos de Equipos

Para registrar un nuevo equipo en la aplicación, utiliza el siguiente formato JSON:

```json
POST /api/equipos
{
  "nombre": "Equipo A",
  "detalle": "Detalles del equipo A",
  "participantes": []
}
