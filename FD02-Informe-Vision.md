<center>

![./media/logo-upt.png](./media/logo-upt.png)

**UNIVERSIDAD PRIVADA DE TACNA**

**FACULTAD DE INGENIERIA**

**Escuela Profesional de Ingeniería de Sistemas**

**Proyecto *"Infraestructura Tecnológica para el Evento Juegos Florales de la Universidad Privada de Tacna"***

Curso: Tópicos de Base de Datos Avanzados

Docente: Mag. Patrick Cuadros Quiroga

Integrantes:


Apaza Ccalle, Albert Kenyi   (2021071075)  
  
 
Huallpa Maron, Jesus Antonio (2021071085) 

**Tacna – Perú**

2024
 

**  
**
</center>
<div style="page-break-after: always; visibility: hidden">\pagebreak</div>

**Sistema *"Infraestructura Tecnológica para el Evento Juegos Florales de la Universidad Privada de Tacna"***

**Versión:** 1.0

| Versión | Hecha por | Revisada por | Aprobada por | Fecha       | Motivo            |
|:-------:|:---------:|:------------:|:------------:|:-----------:|:------------------:|
| 1.0     | Huallpa     | ELV          | ARV          | 24/08/2024  | Versión Original   |

---

### **ÍNDICE GENERAL**

1. [Introducción](#introduccion)  
    1.1 [Propósito](#proposito)  
    1.2 [Alcance](#alcance)  
    1.3 [Definiciones, Siglas y Abreviaturas](#definiciones)  
    1.4 [Referencias](#referencias)  
    1.5 [Visión General](#vision-general)  
2. [Posicionamiento](#posicionamiento)  
    2.1 [Oportunidad de negocio](#oportunidad-de-negocio)  
    2.2 [Definición del problema](#definicion-del-problema)  
3. [Descripción de los interesados y usuarios](#descripcion-de-interesados)  
    3.1 [Resumen de los interesados](#resumen-interesados)  
    3.2 [Resumen de los usuarios](#resumen-usuarios)  
    3.3 [Entorno de usuario](#entorno-usuario)  
    3.4 [Perfiles de los interesados](#perfiles-interesados)  
    3.5 [Perfiles de los Usuarios](#perfiles-usuarios)  
    3.6 [Necesidades de los interesados y usuarios](#necesidades-interesados-usuarios)  
4. [Vista General del Producto](#vista-general-producto)  
    4.1 [Perspectiva del producto](#perspectiva-producto)  
    4.2 [Resumen de capacidades](#resumen-capacidades)  
    4.3 [Suposiciones y dependencias](#suposiciones-dependencias)  
    4.4 [Costos y precios](#costos-precios)  
    4.5 [Licenciamiento e instalación](#licenciamiento-instalacion)  
5. [Características del producto](#caracteristicas-producto)  
6. [Restricciones](#restricciones)  
7. [Rangos de calidad](#rangos-calidad)  
 

[8.	Precedencia y Prioridad](#_Toc52661353)

[9.	Otros requerimientos del producto](#_Toc52661354)

b) Estandares legales

c) Estandares de comunicación	](#_toc394513800)37

d) Estandaraes de cumplimiento de la plataforma	](#_toc394513800)42

e) Estandaraes de calidad y seguridad	](#_toc394513800)42

[CONCLUSIONES](#_Toc52661355)

[RECOMENDACIONES](#_Toc52661356)

[BIBLIOGRAFIA](#_Toc52661357)

[WEBGRAFIA](#_Toc52661358)


<div style="page-break-after: always; visibility: hidden">\pagebreak</div>

**<u>Informe de Visión</u>**


## 1. Introducción <span id="introduccion" class="anchor"></span>

    El presente documento describe la visión del proyecto "Infraestructura Tecnológica para el Evento Juegos Florales de la Universidad Privada de Tacna", cuyo objetivo principal es transformar la gestión del evento Juegos Florales mediante el uso de tecnologías avanzadas. Este proyecto propone la implementación de una infraestructura tecnológica moderna que hará uso de servicios de AWS (Amazon Web Services), así como herramientas especializadas como Terraform, MongoDB Atlas y Grafana, con el fin de optimizar los procesos de planificación, ejecución y monitoreo del evento.

    El enfoque de la solución es crear un entorno escalable, seguro y automatizado que permita agilizar y mejorar la organización del evento, asegurando una experiencia más eficiente y enriquecedora tanto para los participantes como para los organizadores. Con la implementación de esta infraestructura, se busca proporcionar un marco robusto que facilite la gestión de las operaciones en tiempo real, garantizando la disponibilidad y el rendimiento necesarios para eventos de gran escala.

    Este documento tiene como propósito principal alinear las expectativas de todos los interesados, el equipo técnico y los usuarios finales. Además, establece de manera clara los objetivos, el alcance y los resultados esperados del proyecto, proporcionando una guía fundamental para la implementación exitosa de la infraestructura tecnológica.

### 1.1 Propósito <span id="proposito" class="anchor"></span>

    El presente documento de visión tiene como objetivo principal definir los objetivos y el alcance del proyecto "Infraestructura Tecnológica para el Evento Juegos Florales de la Universidad Privada de Tacna". Su propósito es implementar una infraestructura tecnológica moderna basada en AWS (Amazon Web Services) y Terraform, con el fin de optimizar la gestión y ejecución del evento. Esta infraestructura proporcionará una solución escalable, automatizada y de alto rendimiento, garantizando una mayor eficiencia en todos los procesos involucrados.

    Este documento busca alinear las expectativas de los interesados, asegurando una comprensión común de los objetivos del proyecto. Asimismo, servirá como guía para el desarrollo técnico del sistema, permitiendo un enfoque claro y coherente en la implementación de la infraestructura tecnológica.

### 1.2 Alcance <span id="alcance" class="anchor"></span>

    Área de Implementación: Gestión integral de la infraestructura tecnológica para el evento Juegos Florales de la Universidad Privada de Tacna. Esto incluye la implementación, automatización y mantenimiento de los sistemas tecnológicos necesarios para garantizar el buen desarrollo del evento.

    Soluciones Propuestas:

    Automatización del despliegue: Implementación de herramientas como Terraform para automatizar la configuración y gestión de la infraestructura.
    Monitoreo en tiempo real: Uso de plataformas como Grafana para supervisar el rendimiento de la infraestructura y aplicaciones en tiempo real, asegurando su disponibilidad y fiabilidad.
    Administración de aplicaciones web y móviles: Desarrollo y gestión de aplicaciones para facilitar la interacción de los participantes y organizadores, con un enfoque en la escalabilidad y accesibilidad.

    Resultados Esperados:

    Optimización de la organización del evento mediante la automatización de procesos.
    Escalabilidad de los servicios para soportar un número creciente de usuarios y datos durante el evento.
    Mejora significativa en la experiencia de los usuarios, garantizando una plataforma robusta, ágil y accesible.

### 1.3 Definiciones, Siglas y Abreviaturas <span id="definiciones" class="anchor"></span>

    AWS: Amazon Web Services, plataforma en la nube que ofrece soluciones de infraestructura escalables y servicios de computación, almacenamiento y bases de datos.
    Terraform: Herramienta de infraestructura como código (IaC) que permite automatizar el despliegue y la gestión de recursos en la nube.
    MongoDB Atlas: Plataforma de base de datos NoSQL gestionada, basada en la nube, que permite la implementación y el escalado de bases de datos MongoDB.
    Grafana: Herramienta de análisis y monitoreo que proporciona visualizaciones en tiempo real sobre el rendimiento de la infraestructura y las aplicaciones.
    EC2: Amazon Elastic Compute Cloud, servicio de computación escalable que permite ejecutar servidores virtuales en la nube.
    S3: Amazon Simple Storage Service, servicio de almacenamiento de objetos en la nube para almacenar y recuperar cualquier cantidad de datos.

### 1.4 Referencias <span id="referencias" class="anchor"></span>

    Documentación de psutil: https://psutil.readthedocs.io
    Documentación oficial de psutil, una librería utilizada para la gestión y monitoreo de recursos del sistema en aplicaciones Python.

    Guías de Python: https://docs.python.org
    Guías oficiales de Python, proporcionando documentación detallada sobre las funcionalidades del lenguaje y sus módulos.

    Manual de la Universidad Privada de Tacna:
    Normas y permisos para el uso de laboratorios y equipos informáticos en la Universidad Privada de Tacna.

### 1.5 Visión General <span id="vision-general" class="anchor"></span>

    El proyecto implementará una solución tecnológica avanzada que incluye instancias EC2 de AWS, bases de datos en MongoDB Atlas y almacenamiento S3, proporcionando una infraestructura escalable, segura y de alto rendimiento para las aplicaciones web y móviles del evento. El sistema está diseñado para garantizar alta disponibilidad, monitoreo continuo y un despliegue automatizado utilizando herramientas como Terraform. Esto permitirá una gestión eficiente y confiable del evento, asegurando un funcionamiento continuo y la optimización de los recursos en tiempo real.

<div style="page-break-after: always; visibility: hidden">\pagebreak</div>

## 2. Posicionamiento <span id="posicionamiento" class="anchor"></span>

### 2.1 Oportunidad de negocio <span id="oportunidad-de-negocio" class="anchor"></span>

    El evento Juegos Florales actualmente no dispone de un sistema digital centralizado que facilite su gestión y organización. Este proyecto se presenta como una oportunidad para integrar una infraestructura tecnológica que permita automatizar los procesos asociados al evento, mejorando la eficiencia operativa y optimizando el flujo de trabajo. Al incorporar herramientas tecnológicas avanzadas, se busca no solo agilizar la planificación y ejecución del evento, sino también proporcionar una experiencia interactiva y dinámica para los participantes, elevando la calidad del evento y fortaleciendo su impacto.

### 2.2 Definición del problema <span id="definicion-del-problema" class="anchor"></span>

| **LA FALTA** | La falta de un sistema digital centralizado y eficiente para la organización del evento Juegos Florales. |
|--------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **LA NECESIDAD** |Se necesita una infraestructura tecnológica moderna y escalable que permita automatizar procesos, mejorar la gestión y facilitar la interacción entre los organizadores y participantes.|
| **EL PROBLEMA** | La organización del evento es compleja, manual y propensa a errores, lo que afecta la eficiencia, el monitoreo en tiempo real y la experiencia de los usuarios. |
| **LA SOLUCIÓN** | Implementar una infraestructura tecnológica basada en servicios de AWS, Terraform y herramientas como MongoDB Atlas y Grafana para automatizar procesos, proporcionar monitoreo continuo y garantizar la alta disponibilidad. |

<div style="page-break-after: always; visibility: hidden">\pagebreak</div>

## 3. Descripción de los interesados y usuarios <span id="descripcion-de-interesados" class="anchor"></span>

### 3.1 Resumen de los interesados <span id="resumen-interesados" class="anchor"></span>

| **Nombre**               | **Descripción**                                                      | **Responsabilidad**                                                                                  |
|--------------------------|----------------------------------------------------------------------|------------------------------------------------------------------------------------------------------|
| **Administrador**         | Responsable de la supervisión y gestión general del evento.           | Coordinar y gestionar todos los aspectos logísticos del evento, asegurando su correcto desarrollo.    |
| **Estudiante**            | Participante final del evento.                                        | Registrarse en el evento, participar activamente y utilizar los recursos tecnológicos proporcionados. |
| **Bienestar Universitario** | Área encargada de organizar y coordinar eventos culturales y académicos. | Supervisar y organizar el evento, promover la participación estudiantil y asegurar la logística.      |

### 3.2 Resumen de los usuarios <span id="resumen-usuarios" class="anchor"></span>

| **Nombre**               | **Descripción**                                                       | **Responsabilidad**                                                                 |
|--------------------------|-----------------------------------------------------------------------|-----------------------------------------------------------------------------------|
| **Bienestar Universitario** | Gestiona las inscripciones y el seguimiento de los estudiantes para el evento. | Supervisar la inscripción de los estudiantes en el evento y garantizar que reciban la información necesaria. |
| **Estudiantes**          | Participan en el evento y utilizan la plataforma para registrarse y recibir notificaciones. | Registrarse en el evento, recibir actualizaciones y participar activamente en el evento. |


### 3.3 Entorno de usuario <span id="entorno-usuario" class="anchor"></span>

    El entorno de usuario para el sistema "Infraestructura Tecnológica para el Evento Juegos Florales de la Universidad Privada de Tacna" está compuesto por una serie de dispositivos y plataformas tecnológicas que permitirán una interacción fluida entre los usuarios y los componentes del sistema. Este entorno debe estar diseñado para garantizar un acceso eficiente y seguro a las funcionalidades del sistema. 

### 3.4 Perfiles de los interesados <span id="perfiles-interesados" class="anchor"></span>

| **Perfil**               | **Descripción**                                                                 | **Tipo**           | **Responsabilidades**                                                      | **Criterios de éxito**                                                    |
|--------------------------|---------------------------------------------------------------------------------|--------------------|---------------------------------------------------------------------------|---------------------------------------------------------------------------|
| **Administrador**        | Responsable de la planificación, gestión y supervisión general de todos los aspectos del evento. | Administrador      | Coordinar las tareas del equipo, supervisar la implementación de tecnología y asegurar la eficiencia organizativa. | La correcta implementación de las tecnologías y satisfacción de los participantes. |
| **Estudiantes Participantes** | Usuarios finales que se registran para participar en el evento.                              | Usuario Final      | Registrarse en la plataforma, obtener información relevante del evento y recibir actualizaciones. | Acceso efectivo a la información y satisfacción con la experiencia del evento. |
| **Bienestar Universitario** | Área encargada de organizar y coordinar eventos dentro de la universidad.                          | Organizador        | Diseñar actividades, fomentar la participación estudiantil y garantizar el desarrollo óptimo del evento. | Desarrollo exitoso del evento y alta participación de los estudiantes.     |

### 3.5 Perfiles de los Usuarios <span id="perfiles-usuarios" class="anchor"></span>

| **Representante**          | **Descripción**                                                                 | **Tipo**          | **Responsabilidades**                                                   | **Criterios de éxito**                                              | **Implicación**                                      |
|----------------------------|---------------------------------------------------------------------------------|-------------------|-------------------------------------------------------------------------|--------------------------------------------------------------------|-----------------------------------------------------|
| **Bienestar Universitario** | Grupo responsable de gestionar las inscripciones y asegurar que los estudiantes reciban toda la información necesaria sobre el evento. | Administrador     | Gestionar inscripciones, coordinar la difusión de información sobre el evento. | Completar la inscripción de estudiantes y mantenerlos informados. | Asegurar el correcto flujo de información y participación. |
| **Estudiantes Participantes** | Usuarios finales que participarán activamente en el evento.                                | Usuario final     | Registrarse en el evento, acceder a detalles en la plataforma y recibir notificaciones. | Participar activamente en el evento y aprovechar las herramientas disponibles. | Participación constante y uso de los recursos proporcionados. |

### 3.6 Necesidades de los interesados y usuarios

| **Nro.** | **Requerimiento Funcional**           | **Descripción**                                                                 | **Prioridad** | **Inquietudes**                                                  | **Solución Propuesta**                                         |
|----------|---------------------------------------|---------------------------------------------------------------------------------|---------------|------------------------------------------------------------------|---------------------------------------------------------------|
| 1        | Disponibilidad de servidores          | Garantizar que los servidores estén operativos durante el evento.               | Alta          | Fallas en los servidores que interrumpan las actividades.        | Implementar servidores redundantes y realizar pruebas de carga. |
| 2        | Conexión estable a internet           | Asegurar una red estable y rápida para el acceso a la plataforma.               | Alta          | Caídas o lentitud en la conexión que afecten el rendimiento.     | Contratar proveedores confiables y configurar balanceo de carga. |
| 3        | Escalabilidad del sistema             | Permitir que la infraestructura soporte un número elevado de usuarios.          | Alta          | Que el sistema colapse por exceso de participantes simultáneos.  | Utilizar servicios en la nube con capacidad de escalado automático. |
| 4        | Monitoreo en tiempo real              | Supervisar el estado de los servidores y la red durante el evento.              | Media         | Dificultad para detectar y solucionar problemas rápidamente.     | Implementar herramientas de monitoreo como Zabbix o Grafana.   |
| 5        | Seguridad de la información           | Proteger los datos de los usuarios contra accesos no autorizados.               | Alta          | Vulnerabilidades que expongan información sensible.              | Configurar firewalls, cifrado de datos y auditorías de seguridad. |
| 6        | Respaldo y recuperación de datos      | Realizar copias de seguridad frecuentes de la información almacenada.           | Media         | Pérdida de datos por fallos en el sistema.                       | Implementar backups automáticos y plan de recuperación ante desastres. |

<div style="page-break-after: always; visibility: hidden">\pagebreak</div>

## 4. Vista General del Producto <span id="vista-general-producto" class="anchor"></span>

### 4.1 Perspectiva del producto <span id="perspectiva-producto" class="anchor"></span>

    El sistema de infraestructura tecnológica para el evento "Juegos Florales de la Universidad Privada de Tacna" ofrecerá una solución integral para la gestión, monitoreo y soporte de los recursos tecnológicos, como computadoras, proyectores, redes y sistemas de audio. Garantizará el correcto funcionamiento de los equipos antes y durante el evento, asegurando una experiencia fluida para organizadores y asistentes, y contribuyendo al éxito del evento mediante una infraestructura confiable y eficiente.

### 4.2 Resumen de capacidades <span id="resumen-capacidades" class="anchor"></span>

| **Beneficios para el bienestar universitario** | **Principales características** |
|-------------------------------------------------|---------------------------------|
| Mejora la experiencia de los asistentes y organizadores durante el evento. | Gestión centralizada de equipos y recursos tecnológicos. |
| Asegura la disponibilidad y correcto funcionamiento de los dispositivos tecnológicos en todo momento. | Monitoreo en tiempo real de equipos y sistemas tecnológicos. |
| Contribuye al éxito del evento, garantizando una experiencia tecnológica fluida. | Integración con plataformas de gestión del evento. |
| Facilita la resolución rápida de problemas tecnológicos, minimizando posibles fallos. | Soporte y mantenimiento proactivo de la infraestructura. |
| Optimiza el uso de los recursos tecnológicos disponibles durante el evento. | Planificación y coordinación de la infraestructura tecnológica previa al evento. |

### 4.3 Suposiciones y dependencias <span id="suposiciones-dependencias" class="anchor"></span>

    #### Suposiciones:

    - Se asume que los equipos tecnológicos proporcionados para el evento estarán en condiciones óptimas antes del inicio del evento.
    - Se supone que los organizadores del evento tendrán acceso a las plataformas de gestión y podrán integrarlas correctamente con la infraestructura tecnológica.
    - Se considera que se dispondrá de personal capacitado para gestionar y operar la infraestructura tecnológica durante el evento.

    #### Dependencias:

    - Dependencia de una conexión a internet estable para la operación de sistemas de monitoreo en tiempo real.
    - Dependencia de proveedores de equipos tecnológicos y servicios de soporte en caso de fallos o problemas durante el evento.
    - La integración exitosa con las plataformas de gestión del evento depende de la compatibilidad de los sistemas utilizados.

### 4.4 Costos y precios <span id="costos-precios" class="anchor"></span>

| **Concepto**  | **Costo Total (S/.)** |
|---------------|------------------------|
| **Costos Generales** | 3,222.00 |
| **Costos Operativos durante el Desarrollo** | 500.00 |
| **Costos del Ambiente** | 450.00 |
| **Costos de Personal** |  6,000.00 |
| **Total** | 10,172.00 |

### 4.5 Licenciamiento e instalación <span id="licenciamiento-instalacion" class="anchor"></span>

    **Licenciamiento**: El sistema de infraestructura tecnológica para el evento "Juegos Florales de la Universidad Privada de Tacna" será distribuido bajo una licencia propietaria para su uso exclusivo durante el evento, con acceso restringido a los recursos tecnológicos necesarios.

    **Instalación**: La instalación del sistema se llevará a cabo en los espacios asignados para el evento, incluidos los equipos tecnológicos y sistemas de monitoreo. El Área de TI de la universidad se encargará de la instalación y configuración, garantizando que todos los dispositivos, redes y sistemas de audio estén listos antes del evento, con soporte técnico disponible durante toda su duración.

<div style="page-break-after: always; visibility: hidden">\pagebreak</div>

## 5. Características del producto <span id="caracteristicas-producto" class="anchor"></span>

    Gestión centralizada de infraestructura: Control y monitoreo en tiempo real de los recursos tecnológicos implementados, asegurando la óptima funcionalidad de redes, sistemas audiovisuales, y estaciones de trabajo.

    Compatibilidad multiplataforma: Las soluciones desarrolladas incluyen aplicaciones web y móviles accesibles desde distintos dispositivos, facilitando la interacción y organización del evento.

    Escalabilidad y flexibilidad: Infraestructura diseñada para adaptarse al número de participantes y las demandas tecnológicas del evento sin comprometer el rendimiento.

    Automatización de procesos clave: Implementación de herramientas para la gestión automatizada de cronogramas, inscripción en actividades y generación de reportes.

    Soporte en tiempo real: Sistema integrado para el manejo y resolución ágil de problemas tecnológicos durante el evento, reduciendo tiempos de inactividad.

    Seguridad robusta: Protección de datos sensibles a través de protocolos avanzados de seguridad en toda la infraestructura tecnológica utilizada.

## 6. Restricciones <span id="restricciones" class="anchor"></span>

    Limitación de recursos económicos: El presupuesto asignado para la implementación de la infraestructura tecnológica es fijo, lo que restringe la adquisición de equipos y servicios de alta gama.

    Dependencia de conectividad: La funcionalidad del sistema depende de una conexión estable a internet, lo que podría verse afectado por factores externos como cortes de servicio.

    Tiempo de implementación: El cronograma del evento restringe el tiempo disponible para la planificación, instalación y prueba de la infraestructura tecnológica.

    Restricciones de espacio físico: La ubicación de los equipos y dispositivos debe adaptarse a los espacios asignados en las instalaciones de la universidad.

    Cumplimiento normativo: Es necesario garantizar que toda la infraestructura y los servicios utilizados cumplan con las normativas legales y políticas internas de la universidad.

    Capacitación del personal: La operación eficiente del sistema requiere que el equipo responsable reciba capacitación adecuada en un tiempo limitado.

## 7. Rangos de calidad <span id="rangos-calidad" class="anchor"></span>

    Disponibilidad: La infraestructura tecnológica garantizará un tiempo de actividad mínimo del 99.5% durante el evento, reduciendo al máximo interrupciones que puedan afectar las actividades programadas.

    Rendimiento: Los sistemas implementados deben ser capaces de soportar al menos 200 usuarios concurrentes en tiempo real, asegurando tiempos de respuesta inferiores a 2 segundos en las aplicaciones.

    Escalabilidad: El diseño de la infraestructura permitirá la adición de nuevos recursos tecnológicos con un impacto mínimo en el rendimiento general.

    Fiabilidad: Todos los equipos y sistemas estarán configurados para minimizar errores y fallos, con un margen de tolerancia al error menor al 1% durante el evento.

    Seguridad: Se garantizará la protección de los datos personales de los usuarios mediante el uso de protocolos encriptados (como HTTPS) y autenticación segura.

    Usabilidad: Las aplicaciones y dispositivos serán intuitivos, asegurando que los usuarios puedan interactuar sin requerir capacitación técnica avanzada.

## 8. Precedencia y Prioridad

    La tabla a continuación identifica los roles clave involucrados en el proyecto "Infraestructura Tecnológica para el Evento Juegos Florales de la Universidad Privada de Tacna" junto con los requerimientos funcionales específicos asociados. Cada rol tiene responsabilidades particulares para asegurar el correcto funcionamiento y la satisfacción de las necesidades del evento.

| **Roles**         | **Nro.** | **Requerimiento Funcional**          | **Descripción**                                     |
|--------------------|----------|---------------------------------------|-----------------------------------------------------|
| **Administrador**  | 1        | Gestión de usuarios                  | Permitir registrar, modificar y eliminar usuarios del sistema. |
| **Organizador**    | 2        | Creación de eventos                  | Facilitar la programación y personalización de los eventos del día festivo. |
| **Participante**   | 3        | Registro de participación            | Ofrecer un formulario para inscribirse en las actividades del evento. |
| **Soporte técnico**| 4        | Monitoreo en tiempo real             | Proveer herramientas para supervisar el estado de la infraestructura tecnológica. |
| **Visitante**      | 5        | Consulta de actividades              | Permitir a los asistentes ver el cronograma y detalles de los eventos. |                |


<div style="page-break-after: always; visibility: hidden">\pagebreak</div>

## 9. Otros requerimientos del producto

    1. **Requerimientos de Seguridad:**
    - Implementación de medidas para garantizar la protección de los datos de los usuarios.
    - Acceso controlado mediante roles y permisos para evitar alteraciones no autorizadas.
    - Certificación SSL para asegurar las comunicaciones.

    2. **Requerimientos de Mantenimiento:**
    - Documentación detallada del sistema para facilitar actualizaciones futuras.
    - Contrato de soporte técnico para la resolución de problemas y mantenimiento preventivo.
    - Herramientas para el monitoreo y la detección de fallos en tiempo real.

    3. **Requerimientos de Compatibilidad:**
    - Soporte para múltiples dispositivos y navegadores modernos.
    - Integración con las plataformas existentes de la universidad.
    - Uso de tecnologías estándar para garantizar la interoperabilidad.

    4. **Requerimientos de Escalabilidad:**
    - Diseño modular para permitir la expansión del sistema según las necesidades futuras.
    - Infraestructura en la nube que soporte un aumento en la demanda durante los eventos.

    5. **Requerimientos de Desempeño:**
    - Tiempo de respuesta inferior a 2 segundos para la mayoría de las operaciones.
    - Capacidad para manejar al menos 500 usuarios simultáneamente sin degradación del rendimiento.

    6. **Requerimientos Legales y Normativos:**
    - Cumplimiento con las leyes de protección de datos personales aplicables.
    - Alineación con las normativas de accesibilidad para garantizar inclusión.


<div style="page-break-after: always; visibility: hidden">\pagebreak</div>

## CONCLUSIONES

    El proyecto de infraestructura tecnológica para el evento "Juegos Florales de la Universidad Privada de Tacna" presenta una solución integral que optimiza la gestión y monitoreo de los recursos tecnológicos utilizados durante el evento. La implementación de un sistema robusto garantizará la disponibilidad continua de los equipos tecnológicos esenciales, mejorando la experiencia tanto para los organizadores como para los asistentes.

    Las herramientas y tecnologías seleccionadas han sido elegidas con el fin de asegurar una infraestructura escalable y confiable, capaz de adaptarse a las necesidades del evento. Asimismo, el enfoque en la integración de sistemas y la supervisión en tiempo real permitirá resolver problemas de manera eficiente, asegurando el éxito del evento desde el punto de vista tecnológico.

    En cuanto a los aspectos de seguridad y rendimiento, se ha considerado un diseño que optimiza tanto la protección de los datos como la capacidad de respuesta del sistema, garantizando una experiencia fluida y segura para todos los usuarios.

    Este enfoque no solo facilita la organización del evento, sino que también establece una base sólida para futuros eventos similares, asegurando la adaptabilidad y sostenibilidad de la infraestructura tecnológica.

<div style="page-break-after: always; visibility: hidden">\pagebreak</div>

## RECOMENDACIONES <span id="recomendaciones" class="anchor"></span>

    1. **Monitoreo continuo**: Se recomienda implementar herramientas de monitoreo en tiempo real que permitan detectar cualquier fallo en los sistemas tecnológicos antes de que afecte el desarrollo del evento. Esto asegurará que los equipos y redes funcionen sin interrupciones.

    2. **Capacitación al personal**: Es fundamental proporcionar formación al personal encargado del soporte técnico durante el evento. Esto les permitirá resolver problemas rápidamente y gestionar eficazmente los recursos tecnológicos disponibles.

    3. **Plan de contingencia**: Se sugiere desarrollar un plan de contingencia detallado que contemple situaciones imprevistas, como fallos en equipos, caídas de red o problemas con la infraestructura. Esto garantizará una respuesta ágil y eficiente ante cualquier incidente.

    4. **Escalabilidad**: Para futuros eventos de mayor envergadura, se recomienda diseñar la infraestructura tecnológica de manera escalable. Esto permitirá ampliar los recursos sin necesidad de una reestructuración significativa del sistema.

    5. **Revisión post-evento**: Tras la finalización del evento, es esencial realizar una revisión exhaustiva de la infraestructura tecnológica. Esto proporcionará información valiosa para mejorar la planificación y ejecución en eventos futuros.

<span id="_Toc52661357" class="anchor"></span>**BIBLIOGRAFIA**

<div style="page-break-after: always; visibility: hidden">\pagebreak</div>

<span id="_Toc52661358" class="anchor"></span>**WEBGRAFIA**

<div style="page-break-after: always; visibility: hidden">\pagebreak</div>

