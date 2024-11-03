# Aplicación de Información para los Juegos Florales UPT

## 📚 Descripción
Esta aplicación está diseñada para proporcionar información detallada sobre los Juegos Florales organizados por la Universidad Privada de Tacna (UPT). Los Juegos Florales son una celebración del talento artístico y cultural de los estudiantes de la UPT, promoviendo la creatividad y el trabajo en equipo.

La aplicación está empaquetada como una imagen Docker disponible en Docker Hub.

## 🚀 Despliegue de la Aplicación
La aplicación se encuentra disponible como una imagen Docker en Docker Hub bajo el nombre `josueamayatorres/api_florales`.

### Pasos para desplegar la aplicación:

#### 1. Obtener la imagen desde Docker Hub:
Para obtener la última versión de la imagen, ejecuta el siguiente comando:

```bash
docker pull josueamayatorres/api_florales:v1
```

#### 2. Ejecutar el contenedor con Docker:
La aplicación requiere una cadena de conexión a MongoDB que debe ser proporcionada como una variable de entorno. Para ejecutar el contenedor, debes pasar esta variable usando el flag -e junto con el puerto en el que deseas exponer la aplicación.

```bash
docker run -e MONGO_CONNECTION_STRING="mongodb+srv://<usuario>:<contraseña>@cluster0.mongodb.net/<nombre_base_datos>?retryWrites=true&w=majority" -p 8080:8080 josueamayatorres/api_florales:v1
```
MONGO_CONNECTION_STRING: Debes reemplazar <usuario>, <contraseña>, y <nombre_base_datos> con tus credenciales y nombre de base de datos correctos para MongoDB.
-p 8080:8080: Esto mapea el puerto 8080 del contenedor al puerto 8080 en tu máquina local. Puedes cambiarlo si es necesario.
Este comando ejecutará la aplicación y conectará a MongoDB usando la cadena de conexión proporcionada.

#### 3. Acceder a la aplicación:
Una vez que el contenedor esté corriendo, puedes acceder a la aplicación desde tu navegador web en:

```text
http://localhost:8080
```

## 🛠️ Requisitos
Tener instalado Docker en tu máquina.
Tener acceso a una base de datos MongoDB (puedes usar MongoDB Atlas o una instancia local).
