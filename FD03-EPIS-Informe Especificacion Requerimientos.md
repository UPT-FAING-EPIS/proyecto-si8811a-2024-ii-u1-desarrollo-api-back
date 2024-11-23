<center>

![Logo de Mi Empresa](./media/logo-upt.png)
![Logo de mi Cliente](./media/logo-cliente.png)

# UNIVERSIDAD PRIVADA DE TACNA  
## FACULTAD DE INGENIERÍA  
### Escuela Profesional de Ingeniería de Sistemas

**Proyecto *"Infraestructura Tecnológica para el Evento Juegos Florales de la Universidad Privada de Tacna"***

Curso: Tópicos de Base de Datos Avanzados

Docente: Mag. Patrick Cuadros Quiroga

**Integrantes:**


- Apaza Ccalle, Albert Kenyi (2021071075)

- Huallpa Maron, Jesús Antonio (2021071085)

**Tacna – Perú**  
***2024***

</center>

---

**Sistema *"Infraestructura Tecnológica para el Evento Juegos Florales de la Universidad Privada de Tacna"***

**Documento de Especificación de Requerimientos de Software**

Versión *{1.0}*

---

## CONTROL DE VERSIONES

| Versión | Hecha por | Revisada por | Aprobada por | Fecha      | Motivo           |
| :-----: | --------- | ------------ | ------------ | ---------- | ---------------- |
| 1.0     | RCG       | AAC          | AAC          | 18/11/2024 | Versión Original |
---

# INDICE GENERAL

1. [INTRODUCCION](#INTRODUCCION)  
   - I. Generalidades de la Empresa  
     - 1. Nombre de la Empresa
     - 2. Visión
     - 3. Misión
     - 4. Organigrama
   - II. Visionamiento de la Empresa  
     - 1. Descripción del Problema
     - 2. Objetivos de Negocios
     - 3. Objetivos de Diseño
     - 4. Alcance del proyecto
     - 5. Viabilidad del Sistema
     - 6. Información obtenida del Levantamiento de Información
   - III. Análisis de Procesos  
     - a) Diagrama del Proceso Actual – Diagrama de actividades
     - b) Diagrama del Proceso Propuesto – Diagrama de actividades Inicial
   - IV. Especificación de Requerimientos de Software  
     - a) Cuadro de Requerimientos funcionales
     - b) Cuadro de Requerimientos No funcionales
     - d) Reglas de Negocio
   - V. Fase de Desarrollo  
     - 1. Perfiles de Usuario
     - 2. Modelo Conceptual  
       - a) Diagrama de Paquetes
       - b) Diagrama de Casos de Uso
       - c) Escenarios de Caso de Uso (narrativa)
     - 3. Modelo Lógico  
       - a) Análisis de Objetos
       - b) Diagrama de Actividades con objetos
       - c) Diagrama de Secuencia
       - d) Diagrama de Clases

2. [CONCLUSIONES](#CONCLUSIONES)
3. [RECOMENDACIONES](#RECOMENDACIONES)
4. [BIBLIOGRAFÍA](#BIBLIOGRAFIA)
5. [WEBGRAFÍA](#WEBGRAFIA)

---

## I. Introducción <a id="introducción"></a>

    El presente documento describe los requerimientos de infraestructura tecnológica para el proyecto "Infraestructura Tecnológica para el Evento Juegos Florales de la Universidad Privada de Tacna". El objetivo principal de este proyecto es diseñar y desplegar una infraestructura robusta y escalable que permita la correcta ejecución de las actividades del evento Juegos Florales, utilizando tecnologías de vanguardia.

    Este proyecto se enfoca en la creación de una infraestructura tecnológica que optimice la gestión del evento mediante el uso de servicios en la nube, como AWS (Amazon Web Services), y herramientas especializadas para la automatización, monitoreo y gestión de datos. El uso de plataformas como Terraform, MongoDB Atlas y Grafana contribuirá a mejorar la disponibilidad, seguridad y eficiencia de la infraestructura necesaria para soportar los requerimientos del evento, proporcionando un entorno ágil y confiable.

    El documento tiene como propósito definir y detallar los requerimientos técnicos de la infraestructura del sistema, estableciendo claramente los recursos y servicios que serán necesarios para el funcionamiento eficiente y seguro del evento. Además, aborda las características y condiciones de la infraestructura que deben cumplir para satisfacer las necesidades de los usuarios, alineando las expectativas del equipo de desarrollo, los organizadores del evento y los involucrados en la toma de decisiones.


### I. Generalidades de la Empresa

### 1. Nombre de la Empresa

Universidad Privada de Tacna

### 2. Visión

La visión de la Universidad Privada de Tacna es ser una universidad líder en el sur del Perú, comprometida con la innovación tecnológica y el desarrollo académico. A través de la incorporación de tecnologías avanzadas, busca mejorar la experiencia de sus estudiantes y fortalecer su posición en el ámbito educativo regional y nacional.

### 3. Misión

La misión de la Universidad Privada de Tacna es formar profesionales altamente capacitados en diversas especialidades, promoviendo la investigación, la innovación y la calidad educativa. Se enfoca en ofrecer una formación integral que prepare a sus estudiantes para enfrentar los desafíos del mundo laboral globalizado, a través del uso de tecnologías de vanguardia.

### 4. Organigrama

![Logo de Mi Empresa](./media/organigrama2.png)

### II. Visionamiento de la Empresa

#### 1. Descripción del Problema

La gestión del evento Juegos Florales de la Universidad Privada de Tacna enfrenta diversos problemas logísticos y tecnológicos que impactan directamente en la organización y la experiencia de los participantes:

    Falta de infraestructura tecnológica eficiente: Actualmente, el evento no cuenta con un sistema centralizado para gestionar las actividades, los registros de los participantes ni la administración de los recursos durante el evento. Esto genera dificultades en la coordinación de las diferentes áreas involucradas, lo que puede llevar a retrasos y errores en la ejecución de las actividades.

    Falta de escalabilidad y flexibilidad: La infraestructura actual no está diseñada para soportar un número creciente de usuarios o la cantidad de datos generados durante el evento. En eventos de gran escala, como los Juegos Florales, esto puede generar problemas de rendimiento, saturación de servidores y caídas del sistema, lo que afecta la disponibilidad y la experiencia de los participantes.

    Monitoreo inadecuado del rendimiento: No existe una plataforma de monitoreo que permita supervisar en tiempo real el estado de los servicios tecnológicos, lo que dificulta la identificación rápida de problemas. Esto lleva a que cualquier falla o incidente se detecte tarde, lo que aumenta los tiempos de respuesta y puede afectar la continuidad del evento.

    Dificultades en la administración de los datos: La gestión de la información generada durante el evento, como las inscripciones, los resultados y las interacciones de los participantes, es manual y dispersa. Esto no solo aumenta el riesgo de errores, sino que también dificulta la toma de decisiones en tiempo real debido a la falta de una base de datos centralizada y actualizada.

    Riesgos de seguridad: La infraestructura actual no cuenta con medidas de seguridad avanzadas, lo que pone en riesgo la integridad de los datos personales de los participantes y la estabilidad de los sistemas utilizados durante el evento. La falta de políticas de seguridad adecuadas también podría exponer la infraestructura a amenazas cibernéticas.


#### 2. Objetivos de Negocios

    Optimizar la gestión del evento: Mejorar la eficiencia operativa mediante la automatización de procesos, como el registro de participantes, la asignación de recursos y la gestión de actividades, reduciendo el tiempo y esfuerzo dedicados a tareas manuales y aumentando la productividad.

    Asegurar la escalabilidad del sistema: Implementar una infraestructura tecnológica que pueda adaptarse al crecimiento del número de usuarios, participantes y datos generados durante el evento, garantizando una experiencia fluida sin interrupciones ni caídas del sistema.

    Monitorear el rendimiento en tiempo real: Establecer un sistema de monitoreo en tiempo real para supervisar la disponibilidad y el estado de los servicios y aplicaciones utilizadas en el evento, permitiendo detectar y resolver problemas antes de que afecten la experiencia de los participantes.

    Mejorar la seguridad de la infraestructura: Implementar medidas de seguridad robustas para proteger los datos de los participantes y la integridad de los sistemas, reduciendo riesgos de pérdida de información o ciberataques durante el evento.

    Reducir costos operativos: Minimizar los costos asociados con la gestión manual y las intervenciones reactivas mediante la automatización, optimización de recursos y el uso de soluciones tecnológicas que permitan un mantenimiento preventivo y una mayor eficiencia operativa.

    Fortalecer la experiencia de los participantes: Garantizar una plataforma accesible, ágil y sin interrupciones para los asistentes y organizadores del evento, mejorando la interacción de los usuarios y asegurando una experiencia más satisfactoria y profesional.


#### 3. Objetivos de Diseño

    Automatización de procesos: Diseñar un sistema que permita la automatización de tareas críticas como el registro de participantes, la asignación de recursos, y la actualización de información durante el evento. Esto garantizará una ejecución más eficiente, reduciendo errores humanos y mejorando la rapidez de la toma de decisiones.

    Interfaz intuitiva y fácil de usar: Crear una interfaz de usuario sencilla, interactiva e intuitiva que permita a los organizadores y participantes interactuar con el sistema de manera eficiente, sin necesidad de contar con conocimientos técnicos avanzados, mejorando la experiencia de usuario.

    Monitoreo y visualización en tiempo real: Incorporar herramientas de visualización que permitan a los organizadores y administradores monitorear el estado del evento en tiempo real, desde el registro de participantes hasta el rendimiento de las aplicaciones utilizadas, facilitando la toma de decisiones rápidas ante cualquier inconveniente.

    Escalabilidad y flexibilidad del sistema: Diseñar una infraestructura que sea capaz de adaptarse a cambios inesperados en la cantidad de usuarios o en la cantidad de datos procesados durante el evento, permitiendo que el sistema se expanda o reduzca según sea necesario sin comprometer el rendimiento.

    Seguridad y protección de datos: Implementar medidas de seguridad avanzadas en el diseño del sistema para proteger la información personal de los participantes y asegurar la integridad de los datos gestionados durante el evento, garantizando el cumplimiento de normativas de privacidad y seguridad.

    Accesibilidad y disponibilidad: Asegurar que el sistema sea accesible desde cualquier dispositivo conectado a Internet y que funcione sin interrupciones, permitiendo a los organizadores y participantes acceder a la plataforma en cualquier momento y desde cualquier lugar, garantizando la disponibilidad de los servicios durante todo el evento.


#### 4. Alcance del proyecto

Inclusiones:

    Automatización de registros y gestión de participantes: El sistema incluirá la automatización del proceso de inscripción de los participantes en el evento, así como la gestión de la información personal, asegurando que los datos sean procesados de manera eficiente y sin errores manuales. También permitirá la actualización en tiempo real de los registros.

    Monitoreo en tiempo real del evento: Se implementará un sistema de monitoreo en tiempo real que rastreará el estado de las aplicaciones utilizadas en el evento, incluyendo plataformas de registro, acceso de los participantes y las herramientas de evaluación. Esto garantizará que cualquier fallo o inconveniente pueda ser detectado y solucionado de manera proactiva antes de que afecte el desarrollo del evento.

    Dashboard interactivo para organizadores: El sistema incluirá un dashboard interactivo y fácil de usar que permitirá a los organizadores visualizar el estado general del evento, incluyendo el número de participantes registrados, el rendimiento de las aplicaciones y los recursos utilizados. Este dashboard permitirá tomar decisiones rápidas basadas en datos en tiempo real.

    Generación de reportes detallados y exportables: Se habilitará una funcionalidad que permita generar reportes detallados sobre el evento, que incluirán métricas clave, como la cantidad de participantes, el uso de recursos, las incidencias registradas y otros aspectos importantes. Estos reportes podrán ser exportados en formatos estándar como PDF o Excel para su análisis y archivo.

    Escalabilidad y flexibilidad en la infraestructura: El sistema se diseñará de manera que pueda escalar según el número de participantes y la carga de trabajo durante el evento, garantizando que se mantenga el rendimiento adecuado incluso en momentos de alta demanda.

Exclusiones:

    Gestión de eventos fuera del ámbito de los Juegos Florales: El sistema no se extenderá a la gestión de otros eventos organizados por la universidad, ni gestionará eventos fuera del marco del Juegos Florales, como actividades académicas o administrativas.

    Soporte de plataformas de comunicación externas: El sistema no incluirá soporte para plataformas de comunicación externa como correo electrónico, mensajería o redes sociales, ya que estos canales estarán gestionados por otros sistemas y no son parte de la infraestructura del evento.

    Gestión de equipos tecnológicos no asociados al evento: El proyecto se centrará exclusivamente en la infraestructura tecnológica utilizada para la organización del evento Juegos Florales, por lo que no se incluirán la gestión ni el monitoreo de equipos fuera de este contexto (por ejemplo, equipos de la universidad no involucrados directamente en el evento).

#### 5. Viabilidad del Sistema

##### 5.1. Viabilidad Técnica

Hardware Disponible

    Equipos de desarrollo: Se dispone de los equipos necesarios para el desarrollo y pruebas del sistema de infraestructura tecnológica. Los requisitos técnicos básicos incluyen:
        Procesador: Intel Core i5 o superior, que garantiza un rendimiento adecuado para ejecutar las herramientas de desarrollo y las aplicaciones necesarias.
        Memoria RAM: Entre 8 GB y 16 GB DDR4, suficiente para realizar múltiples tareas y mantener una respuesta rápida en las aplicaciones.
        Almacenamiento: Disco SSD con capacidad mínima de 256 GB, para asegurar tiempos de carga rápidos y una mayor durabilidad en los equipos utilizados.
        Conectividad: Equipos con acceso a internet de alta velocidad para asegurar la carga y el acceso a los servicios en la nube sin interrupciones.

Software Disponible

    Plataformas en la nube y herramientas de desarrollo:
        AWS (Amazon Web Services): Utilización de AWS para el alojamiento de la infraestructura del evento, con servicios como EC2 para servidores virtuales, S3 para almacenamiento y RDS para bases de datos, permitiendo una implementación escalable y eficiente.
        Terraform: Herramienta para automatizar la infraestructura como código (IaC), que garantiza una configuración coherente y repetible del entorno, permitiendo la creación, modificación y destrucción de recursos de manera eficiente.
        MongoDB Atlas: Plataforma para bases de datos en la nube que se utilizará para almacenar los datos relacionados con los registros de los participantes y las actividades del evento, garantizando escalabilidad y disponibilidad.
        Grafana: Herramienta de monitoreo y visualización que permitirá el análisis en tiempo real del estado de las aplicaciones y sistemas utilizados durante el evento, con la capacidad de generar dashboards personalizables.

Infraestructura de Red

    Conectividad confiable: Se requiere una conexión a Internet estable y de alta velocidad para la gestión de la infraestructura en la nube, asegurando que todas las aplicaciones funcionen de manera continua y sin interrupciones durante el evento.
    Red de alta capacidad: Equipos de red como switches y routers de última generación serán utilizados para garantizar un flujo de datos eficiente y sin cuellos de botella, incluso con un gran volumen de usuarios conectados simultáneamente.

Automatización y Configuración

    Automatización con Terraform: El uso de Terraform permitirá gestionar el entorno de infraestructura como código (IaC), haciendo posible la configuración automatizada de recursos en AWS y evitando errores humanos. Esto también acelera el proceso de despliegue, ya que se puede replicar el mismo entorno en diferentes fases del proyecto (desarrollo, pruebas y producción).
    Automatización de procesos con Python y HCL2: Se utilizarán scripts escritos en Python y HCL2 para automatizar tareas específicas dentro de la infraestructura, como la configuración de recursos en la nube y la recolección de métricas de rendimiento. Esto permitirá la gestión eficiente de la infraestructura sin intervención manual constante, optimizando los tiempos de respuesta y reduciendo el riesgo de errores.

##### 5.2. Viabilidad Económica

El análisis de costos totaliza los recursos necesarios para el desarrollo e implementación del sistema, considerando los siguientes conceptos:

| **Concepto** | **Costo Total (S/.)** |
|--------------|-----------------------|
| **Costos Generales** | 3,222.00 |
| **Costos Operativos durante el Desarrollo** | 500.00 |
| **Costos del Ambiente** | 450.00 |
| **Costos del Personal** | 6,000.00 |
| **Total** | 10,172.00 |

Este presupuesto permite cubrir todos los aspectos esenciales del proyecto, asegurando una relación costo-beneficio favorable y sostenibilidad a largo plazo.

##### 5.3. Viabilidad Operativa

**Factibilidad Operativa**

    Optimización de Recursos: El sistema propuesto permitirá a la universidad maximizar la utilización de la infraestructura tecnológica disponible, proporcionando información detallada sobre el desempeño y el uso de recursos clave, como el servidor, bases de datos, y el tráfico de red. Esta visibilidad permitirá una planificación más precisa del mantenimiento y la redistribución de los recursos, asegurando que se utilicen de manera eficiente durante el evento.

    Mejora en la Toma de Decisiones: Al ofrecer datos en tiempo real sobre el rendimiento de los sistemas, la plataforma facilitará a los administradores del evento tomar decisiones informadas. Esto incluye la gestión del ancho de banda, la asignación de recursos según las necesidades del evento y la prevención de posibles cuellos de botella o fallos. La disponibilidad de información precisa permitirá a los responsables adaptarse rápidamente a cualquier cambio en las condiciones operativas.

    Facilidad de Uso e Integración: El sistema se diseñará con una interfaz fácil de usar que requerirá una mínima curva de aprendizaje para el personal técnico y organizador. Además, la solución será compatible con las plataformas tecnológicas existentes de la universidad, garantizando que la implementación no interrumpa las operaciones cotidianas. Su capacidad de integración asegurará que el sistema funcione sin problemas dentro del entorno tecnológico actual, lo que facilitará su adopción y uso por parte de los administradores y técnicos.

#### 6. Información obtenida del levantamiento de información

Durante el levantamiento de información para el desarrollo del sistema, se identificaron los siguientes aspectos clave:

**Necesidades de los Técnicos de Soporte:**

- Requieren una herramienta centralizada para monitorear el estado de la red en tiempo real, con alertas automáticas que les permitan identificar problemas antes de que afecten a los usuarios.

**Requerimientos de los Administradores:**

- Necesitan reportes claros y personalizados sobre el rendimiento de la red para tomar decisiones informadas y planificar mantenimientos o actualizaciones futuras.

Esta información valida la necesidad del sistema como una solución integral para optimizar el rendimiento y la gestión de la red en los laboratorios de la universidad.


### III. Análisis de Procesos

- Diagrama del Proceso Actual – Diagrama de actividades

  ![Diagrama](./media/diagrama_actual.png)
  
- Diagrama del Proceso Propuesto – Diagrama de actividades Inicial

  ![Diagrama_propuesto](./media/diagrama_propuesto.png)

### IV. Especificación de Requerimientos de Software

1. Cuadro de Requerimientos funcionales

|  ID   | Descripción                                                                                                     | Prioridad |
| :---: | :-------------------------------------------------------------------------------------------------------------- | :-------: |
| RF-01 | Monitorear el estado de la infraestructura tecnológica (servidores, red, almacenamiento, etc.) en tiempo real.    |   Alta    |
| RF-02 | Configurar y desplegar automáticamente los recursos tecnológicos mediante herramientas de automatización (Terraform). |   Alta    |
| RF-03 | Garantizar la disponibilidad y escalabilidad de la infraestructura mediante el uso de servicios en la nube (AWS). |   Alta    |
| RF-04 | Implementar un sistema de almacenamiento seguro y escalable para almacenar logs, datos históricos y métricas.    |   Alta    |
| RF-05 | Realizar pruebas de carga y rendimiento de la infraestructura para asegurar la capacidad durante el evento.       |   Alta    |
| RF-06 | Implementar una red de monitoreo que detecte fallos o problemas en la infraestructura tecnológica y genere alertas. |   Alta    |
| RF-07 | Configurar el sistema de infraestructura para que pueda integrarse con otras plataformas de la universidad, como la gestión de eventos y bases de datos de usuarios. |  Media    |

2. Cuadro de Requerimientos No funcionales


|  ID   | Descripción                                                                                                     | Prioridad |
| :---: | :-------------------------------------------------------------------------------------------------------------- | :-------: |
| RNF-01 | El sistema de infraestructura debe ser compatible con sistemas operativos Linux y Windows para la gestión de servidores. |   Alta    |
| RNF-02 | La plataforma debe ser accesible desde cualquier dispositivo con conexión a Internet (navegador web moderno).    |   Alta    |
| RNF-03 | La infraestructura debe garantizar la seguridad de los datos mediante protocolos de encriptación y autenticación. |   Alta    |
| RNF-04 | La infraestructura debe ser escalable y permitir el incremento de recursos en caso de aumento de usuarios o demanda durante el evento. |   Alta    |
| RNF-05 | La solución debe ofrecer redundancia y alta disponibilidad para los servicios críticos, con un tiempo de inactividad menor al 1%. |   Alta    |
| RNF-06 | Los servidores y servicios en la nube deben contar con sistemas de respaldo y recuperación ante fallos automáticos. |   Alta    |
| RNF-07 | La infraestructura debe consumir recursos mínimos de CPU y RAM para optimizar el rendimiento de las aplicaciones y servicios del evento. |  Media    |

3. Reglas de Negocio

|  ID   | Descripción                                                                                                     | Prioridad |
| :---: | :-------------------------------------------------------------------------------------------------------------- | :-------: |
| RN-01 | Solo el personal autorizado podrá acceder a la infraestructura tecnológica mediante credenciales seguras.         |   Alta    |
| RN-02 | Los datos transmitidos y almacenados deben ser cifrados para garantizar su confidencialidad y protección.         |   Alta    |
| RN-03 | Los recursos tecnológicos deben ser escalables y configurables para adaptarse a diferentes fases del evento (planificación, ejecución, análisis post-evento). |   Alta    |
| RN-04 | La infraestructura debe integrarse con otras plataformas tecnológicas de la universidad, garantizando una transferencia segura de datos. |   Media   |
| RN-05 | La infraestructura debe permitir una recuperación rápida ante fallos, con un tiempo máximo de inactividad de 15 minutos. |   Alta    |
| RN-06 | Los informes de la infraestructura, como el estado de los servidores y la red, deben ser generados automáticamente para evaluación periódica. |   Alta    |
| RN-07 | La infraestructura debe contar con un sistema de alertas basado en métricas de rendimiento y disponibilidad.      |   Alta    |
| RN-08 | La infraestructura debe ser compatible con servicios de nube como AWS para escalar automáticamente según la demanda. |   Alta    |
| RN-09 | El sistema debe incluir la capacidad de realizar pruebas de carga en la infraestructura antes del evento para garantizar su estabilidad. |   Media   |



### V. Fase de Desarrollo

1. **Perfiles de Usuario**

**Administrador**

**Descripción:**
El Administrador es el responsable de la supervisión y gestión general del evento. Es quien coordina y organiza todos los aspectos logísticos, asegurando que el evento se lleve a cabo sin contratiempos.

**Responsabilidades:**
- Coordinar y gestionar todos los aspectos logísticos del evento.
- Supervisar el correcto desarrollo de las actividades programadas.
- Resolver problemas operativos y logísticos durante el evento.

**Interacciones con el Sistema:**
- Accede a la plataforma de gestión para supervisar el avance del evento.
- Visualiza las métricas e informes relacionados con la logística y el desarrollo del evento.

---

**Estudiante**

**Descripción:**
El Estudiante es el participante final del evento. Se registra, asiste y utiliza los recursos tecnológicos proporcionados durante el evento.

**Responsabilidades:**
- Registrarse para participar en el evento.
- Utilizar los recursos tecnológicos proporcionados para las actividades del evento.
- Participar activamente en las sesiones y actividades programadas.

**Interacciones con el Sistema:**
- Registra su participación en el evento a través de la plataforma.
- Utiliza la plataforma para acceder a materiales, conferencias y actividades programadas.

---

**Bienestar Universitario**

**Descripción:**
El área de Bienestar Universitario es la encargada de organizar y coordinar los eventos culturales y académicos de la universidad. Se asegura de que el evento se desarrolle de acuerdo con la planificación y que los estudiantes participen activamente.

**Responsabilidades:**
- Organizar y coordinar todas las actividades del evento.
- Promover la participación estudiantil.
- Asegurar la logística del evento y el bienestar de los participantes.

**Interacciones con el Sistema:**
- Utiliza la plataforma para gestionar la inscripción y participación de los estudiantes.
- Supervisa la logística y las actividades del evento a través de la plataforma.

---

2. **Modelo Conceptual**
   - Diagrama de Paquetes  
     ![paquete](./media/diagrama_paquete.png)
   - Diagrama de Casos de Uso  
     ![caso](./media/diagrama_caso_uso.png)

---

**Caso de Uso: Coordinar Logística del Evento (CU01)**

**Actores:** Administrador, Bienestar Universitario  
**Descripción:** Permitir a los actores coordinar y gestionar todos los aspectos logísticos del evento, como la programación de actividades y la gestión de inscripciones.  
**Precondiciones:** El evento debe estar en proceso de organización y los actores deben tener acceso al sistema de gestión.

| **Caso de Uso**  | Coordinar Logística del Evento (CU01)                                                                                       |
|-------------------|----------------------------------------------------------------------------------------------------------------------------|
| **Actores**       | Administrador, Bienestar Universitario                                                                                     |
| **Descripción**   | Gestionar y coordinar todos los aspectos logísticos del evento, asegurando que las actividades programadas se realicen de manera efectiva. |
| **Precondiciones**| El evento debe estar en proceso de organización y los actores deben contar con credenciales para acceder al sistema.       |
| **Flujo Normal**  |                                                                                                                            |
| **Acción del Actor**                                             | **Curso del Sistema**                                                                                   |
| 1. Inicia sesión en el sistema de gestión del evento.              | 2. Accede al panel de control de la logística del evento.                                                |
| 3. Revisa y actualiza el calendario de actividades.               | 4. Muestra las actividades programadas, incluyendo la duración y los recursos necesarios.               |
| 5. Coordina la asignación de recursos y espacios.                 | 6. Actualiza la plataforma con cambios logísticos según sea necesario.                                  |

---

**Caso de Uso: Participar en el Evento (CU02)**

**Actores:** Estudiante  
**Descripción:** Permitir al estudiante registrarse e interactuar con los recursos proporcionados para participar en el evento.  
**Precondiciones:** El evento debe estar abierto para la inscripción y el estudiante debe estar registrado en la plataforma.

| **Caso de Uso**  | Participar en el Evento (CU02)                                                                                              |
|-------------------|----------------------------------------------------------------------------------------------------------------------------|
| **Actores**       | Estudiante                                                                                                                |
| **Descripción**   | Permitir al estudiante registrarse y participar activamente en las actividades del evento.                                 |
| **Precondiciones**| El estudiante debe estar registrado en la plataforma y tener acceso a los recursos proporcionados.                         |
| **Flujo Normal**  |                                                                                                                            |
| **Acción del Actor**                                             | **Curso del Sistema**                                                                                   |
| 1. Accede a la plataforma de inscripción del evento.              | 2. Completa su registro y recibe confirmación.                                                            |
| 3. Participa en las actividades programadas.                      | 4. Visualiza los recursos disponibles y accede a las conferencias o materiales.                          |
| 5. Asiste a las sesiones o actividades programadas.               | 6. Interactúa con otros participantes y los recursos del evento.                                         |

---

**Caso de Uso: Supervisar el Evento (CU03)**

**Actores:** Bienestar Universitario  
**Descripción:** Permitir a Bienestar Universitario supervisar el evento, asegurando que las actividades se desarrollen según lo planeado y que la participación estudiantil sea adecuada.  
**Precondiciones:** El evento debe estar en marcha y Bienestar Universitario debe tener acceso a las métricas y registros del evento.

| **Caso de Uso**  | Supervisar el Evento (CU03)                                                                                               |
|-------------------|----------------------------------------------------------------------------------------------------------------------------|
| **Actores**       | Bienestar Universitario                                                                                                   |
| **Descripción**   | Supervisar y gestionar el evento en tiempo real, asegurando que todo el desarrollo del evento se realice sin inconvenientes.|
| **Precondiciones**| El evento debe estar en curso y Bienestar Universitario debe tener acceso al sistema.                                      |
| **Flujo Normal**  |                                                                                                                            |
| **Acción del Actor**                                             | **Curso del Sistema**                                                                                   |
| 1. Inicia sesión en el sistema de supervisión del evento.          | 2. Visualiza el estado general del evento, incluyendo la participación de los estudiantes.               |
| 3. Revisa las métricas de actividad y asistencia.                 | 4. Ajusta los aspectos logísticos si es necesario.                                                        |
| 5. Realiza ajustes o intervenciones durante el evento.            | 6. Asegura la correcta ejecución de las actividades.                                                     |
3. Modelo Lógico
   - Análisis de Objetos
     
     **Entidades**
     
     ![entidad](./media/entidades.png)

     **Frontera**
     
     ![frontera](./media/frontera.png)

     **Control**
     
     ![entidad](./media/control.png)
     
   - Diagrama de Actividades con objetos
     
     **Diagrama de actividades: Monitorear estado de red (CU01)**

     ![CU01](./media/cu1.png)

     **Diagrama de actividades: Generar Reportes de Uso (CU02)**
  
     ![CU02](./media/cu2.png)

     **Diagrama de actividades: Configurar Dashboard (CU03)**
  
     ![CU03](./media/cu3.png)

     **Diagrama de actividades: Exportar Datos (CU04)**
     
     ![CU04](./media/cu4.png)
   
   - Diagrama de Secuencia

     **Diagrama de secuencia: Monitorear estado de red (CU01)**
  
     ![sec_CU04](./media/secu_cu1.png)
  
     **Diagrama de secuencia: Generar Reportes de Uso (CU02)**
  
     ![sec_CU04](./media/secu_cu2.png)
     
     **Diagrama de secuencia: Configurar Dashboard (CU03)**
  
     ![sec_CU04](./media/secu_cu3.png)
     
     **Diagrama de secuencia: Exportar Datos (CU04)**

     ![sec_CU04](./media/secu_cu4.png)
     
   - Diagrama de Clases

     ![diagram_clase](./media/diagrama_clase.png)

---

# CONCLUSIONES

El análisis realizado demuestra que el proyecto de infraestructura tecnológica para el evento Juegos Florales de la Universidad Privada de Tacna es completamente viable desde las perspectivas técnica, económica, operativa, legal y social. La infraestructura existente en la universidad es suficiente para soportar la implementación del sistema, y los beneficios esperados, tanto operativos como económicos, superan ampliamente los costos asociados. La infraestructura tecnológica propuesta garantizará un soporte adecuado para las actividades del evento, asegurando una experiencia fluida tanto para los participantes como para los organizadores.

Además, la implementación de la infraestructura tecnológica mejorará la calidad del evento, proporcionando recursos confiables para la realización de las actividades académicas, culturales y artísticas. Esto no solo permitirá una experiencia más enriquecedora para los estudiantes, sino también para el público y los asistentes. El sistema propuesto optimizará la logística, el acceso a la información y la gestión de recursos, facilitando la organización y el desarrollo eficiente del evento.

El cumplimiento con las normativas legales, como la Ley N° 29733 de Protección de Datos Personales, garantiza que la información recolectada durante el evento se maneje de manera segura y respetuosa con la privacidad de los participantes. Este cumplimiento refuerza el aspecto ético y la confiabilidad del proyecto. Asimismo, el enfoque tecnológico contribuirá a los objetivos de sostenibilidad de la universidad al promover el uso responsable de los recursos tecnológicos y optimizar el consumo energético durante el evento.

En resumen, este proyecto no solo resuelve las necesidades tecnológicas actuales del evento Juegos Florales, sino que también sienta las bases para la mejora continua en la organización de futuros eventos en la universidad. Su diseño escalable y flexible asegura que pueda adaptarse a las crecientes demandas tecnológicas de la universidad, posicionándola como un referente en la gestión eficiente de eventos académicos y culturales.



---

# RECOMENDACIONES

Monitoreo Continuo de la Infraestructura Tecnológica: Es fundamental realizar un monitoreo constante de la infraestructura tecnológica durante el evento para detectar posibles fallos o problemas de conexión. Se recomienda que el equipo de soporte técnico esté disponible en tiempo real para atender cualquier inconveniente y asegurar que los recursos tecnológicos funcionen de manera óptima durante toda la duración del evento.

Capacitación del Personal Técnico: Para garantizar un funcionamiento eficiente de la infraestructura tecnológica durante los Juegos Florales, es recomendable proporcionar capacitación especializada al personal técnico que se encargará de la gestión y mantenimiento de los equipos. Esto permitirá una respuesta rápida ante cualquier contingencia y optimizará el uso de los recursos disponibles.

Pruebas Previas al Evento: Se sugiere realizar pruebas exhaustivas de la infraestructura tecnológica al menos una semana antes del evento. Esto incluye pruebas de redes, equipos de sonido, sistemas de proyección, y otros recursos tecnológicos. Estas pruebas permitirán identificar y corregir posibles fallos antes de que el evento comience, asegurando su éxito.

Optimización de la Gestión de Recursos: Para maximizar la eficiencia, es recomendable implementar una herramienta de gestión de recursos en tiempo real que permita a los organizadores controlar la asignación de equipos, espacios y servicios de manera efectiva. Esto ayudará a evitar conflictos logísticos y asegurará que los recursos sean utilizados de manera adecuada durante el evento.

Planificación de la Sostenibilidad: Se debe considerar el impacto ambiental del evento y optimizar el consumo de energía de los equipos tecnológicos. Se recomienda la utilización de equipos de bajo consumo energético y la implementación de políticas para minimizar el desperdicio de recursos durante el evento, alineándose con los objetivos de sostenibilidad de la universidad.

Mejorar la Infraestructura a Largo Plazo: Dado que el evento Juegos Florales se llevará a cabo de manera anual, se recomienda considerar una actualización periódica de la infraestructura tecnológica para mantenerla al día con los avances en tecnología. Además, es importante invertir en soluciones escalables que puedan adaptarse a las necesidades crecientes de la universidad y el evento en el futuro.

Retroalimentación Post-Evento: Para garantizar mejoras en la infraestructura tecnológica para eventos futuros, se recomienda realizar encuestas de satisfacción entre los participantes, organizadores y personal técnico. Recoger retroalimentación sobre la experiencia tecnológica permitirá identificar áreas de mejora y aplicar ajustes antes del próximo evento.

---

# BIBLIOGRAFÍA

Fuentes bibliográficas utilizadas en el desarrollo del documento.

---

# WEBGRAFÍA

Listado de referencias web consultadas.