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
docker run -d -e MONGO_CONNECTION_STRING="mongodb+srv://<usuario>:<contraseña>@cluster0.ip0qn.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0" -p 8080:8080 josueamayatorres/api_florales:v1
```
MONGO_CONNECTION_STRING: Debes reemplazar el texto , usuario y contraseña , con tus credenciales correctos para MongoDB ; en caso de usar un '@' en la contraseña debes declararlo como '%40'.  
La zona de  
```bash
'cluster0.ip0qn.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0'
```
Debe ir la conexion al Cluster de ___Atlas___ , si es una instancia privada seria el ___DNS/IP___  
-p 8080:8080: Esto mapea el puerto 8080 del contenedor al puerto 8080 en tu máquina local (El puerto por defecto de la app es 8080).  
Este comando ejecutará la aplicación y conectará a MongoDB usando la cadena de conexión proporcionada.  
___POR SI AUN NO ENTIENDE LA WAWITA AQUI TIENES UN EJEMPLO :___

```bash
docker run -d -e MONGO_CONNECTION_STRING="mongodb+srv://HELBERT:AYNOPUEDOCAMBIARUNALINEA%40@cluster0.ip0qn.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0" -p 8080:8080 josueamayatorres/api_florales:v1
```
En este ejemplo el usuario seria HELBERT y la contraseña seria 'AYNOPUEDOCAMBIARUNALINEA@'.  
#### 3. Acceder a la aplicación:
Una vez que el contenedor esté corriendo, puedes acceder a la aplicación desde tu navegador web en:

```text
http://localhost:8080
```

## 🛠️ Requisitos
Tener instalado Docker en tu máquina.
Tener acceso a una base de datos MongoDB (puedes usar MongoDB Atlas o una instancia local).
