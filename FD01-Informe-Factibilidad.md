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
 

</center>
<div style="page-break-after: always; visibility: hidden">\pagebreak</div>

**Sistema *"Infraestructura Tecnológica para el Evento Juegos Florales de la Universidad Privada de Tacna"***

Informe de Factibilidad

Versión *{1.0}*

|CONTROL DE VERSIONES||||||
| :-: | :- | :- | :- | :- | :- |
|Versión|Hecha por|Revisada por|Aprobada por|Fecha|Motivo|
|1\.0|MPV|ELV|ARV|24/08/2024|Versión Original|

<div style="page-break-after: always; visibility: hidden">\pagebreak</div>

# **INDICE GENERAL**

[1. Descripción del Proyecto](#_Toc52661346)

[2. Riesgos](#_Toc52661347)

[3. Análisis de la Situación actual](#_Toc52661348)

[4. Estudio de Factibilidad](#_Toc52661349)

[4.1 Factibilidad Técnica](#_Toc52661350)

[4.2 Factibilidad económica](#_Toc52661351)

[4.3 Factibilidad Operativa](#_Toc52661352)

[4.4 Factibilidad Legal](#_Toc52661353)

[4.5 Factibilidad Social](#_Toc52661354)

[4.6 Factibilidad Ambiental](#_Toc52661355)

[5. Análisis Financiero](#_Toc52661356)

[6. Conclusiones](#_Toc52661357)


<div style="page-break-after: always; visibility: hidden">\pagebreak</div>

**<u>Informe de Factibilidad</u>**

1. <span id="_Toc52661346" class="anchor"></span>**Descripción del Proyecto**

1.1. Nombre del proyecto
   
    "Infraestructura Tecnológica para el Evento Juegos Florales de la Universidad Privada de Tacna"
    
1.2. Duración del proyecto

    Empieza el 13 de agosto y termina el 13 diciembre

1.3. Descripción

    -El proyecto "Infraestructura Tecnológica para el Evento Juegos Florales de la Universidad Privada de Tacna" se centra en el desarrollo de una serie de aplicaciones web y móviles diseñadas para apoyar las actividades del día festivo de los Juegos Florales en la Universidad Privada de Tacna. Estas aplicaciones tienen como objetivo facilitar la organización, gestión y participación en los eventos del día, brindando una experiencia interactiva y moderna para los usuarios.

    -En este informe, se detallan los costos asociados a los servicios utilizados para la infraestructura del proyecto, tales como AWS, MongoDB, entre otros. Además, se analizan los gastos adicionales vinculados al despliegue y mantenimiento de la infraestructura, asegurando una solución escalable y eficiente para el evento.

1.4. Objetivos

1.4.1 Objetivo general
   
    -Implementar una infraestructura tecnológica eficiente para soportar las aplicaciones web y móviles del proyecto "Infraestructura Tecnológica para el Evento Juegos Florales de la Universidad Privada de Tacna", optimizando la gestión y experiencia del evento en la Universidad Privada de Tacna.

1.4.2 Objetivos Específicos
            
    -Configurar y gestionar servicios en AWS para garantizar una infraestructura escalable y confiable.
    -Utilizar MongoDB como base de datos para almacenar y administrar la información del evento de manera eficiente.
    -Integrar Docker para estandarizar el entorno de desarrollo y despliegue.
    -Optimizar los costos relacionados con los servicios de infraestructura, asegurando la sostenibilidad del proyecto.
    -Garantizar la seguridad y disponibilidad de los datos durante todo el evento.
    

<div style="page-break-after: always; visibility: hidden">\pagebreak</div>

2. <span id="_Toc52661347" class="anchor"></span>**Riesgos**

        -Retrasos en el Cronograma: Los retrasos en el desarrollo, pruebas o implementación podrían afectar la fecha de finalización del proyecto, especialmente si dependen de factores externos como la disponibilidad de hardware o la integración con sistemas existentes.
      
        -Definición Inadecuada de Requisitos: Cambios en los requisitos durante el desarrollo podrían llevar a la necesidad de rediseñar partes del sistema, afectando el alcance y el tiempo del proyecto.  
   
<div style="page-break-after: always; visibility: hidden">\pagebreak</div>

3. <span id="_Toc52661348" class="anchor"></span>**Análisis de la Situación actual**

    3.1. Planteamiento del problema

        Actualmente, la Universidad Privada de Tacna enfrenta diversas dificultades para gestionar de manera eficiente eventos importantes como los Juegos Florales. La ausencia de una infraestructura tecnológica adecuada limita la capacidad de organización, lo que genera problemas en la administración de actividades, participantes y recursos. Estas deficiencias afectan directamente la calidad y eficiencia del evento.

        Además, no existe una plataforma digital centralizada que permita conectar de manera interactiva a los participantes con las actividades del evento. Esto reduce las posibilidades de interacción y dificulta el acceso a información en tiempo real, afectando tanto la experiencia de los usuarios como la imagen general del evento.

        Por otro lado, los procesos manuales predominantes, como la inscripción y el seguimiento de participantes, son propensos a errores y generan retrasos innecesarios. Esto no solo aumenta la carga administrativa, sino que también limita la capacidad de escalar el evento en caso de un mayor número de participantes.

        Finalmente, la falta de herramientas para recopilar y analizar datos impide realizar un diagnóstico adecuado sobre el desempeño del evento. Esto limita la posibilidad de implementar mejoras basadas en información objetiva, afectando la organización de ediciones futuras. Estas problemáticas resaltan la necesidad urgente de adoptar una solución tecnológica moderna, escalable y eficiente.


    3.2. Consideraciones de hardware y software

        Para el proyecto "Infraestructura Tecnológica para el Evento Juegos Florales de la Universidad Privada de Tacna", es fundamental garantizar que la infraestructura tecnológica cuente con los recursos necesarios tanto en hardware como en software para su correcto desarrollo, implementación y operación.

      Hardware

        Infraestructura en la Nube (AWS):

        Instancias EC2:

        Tipo:
          *t2.micro para pruebas, entornos de desarrollo y ambientes de staging.
          *t3.medium o superior para producción, ajustando según la carga esperada y los picos de tráfico.
        Almacenamiento: 
          *30 GB de EBS mínimo para cada instancia, con capacidad de escalar según necesidades de almacenamiento.
          *Utilización de EBS con IOPS optimizadas para bases de datos críticas o alto rendimiento en producción, si fuera necesario.
        S3 Buckets: 
          *Espacio suficiente para alojar archivos estáticos de las aplicaciones web y móviles, como imágenes, videos, y otros recursos estáticos.
          *Configuración de políticas de seguridad para restringir el acceso a recursos críticos y evitar accesos no autorizados.
        MongoDB Atlas: 
          *Cluster básico con réplica para pruebas y desarrollo.
          *Cluster escalable para producción, con capacidad de autoescalado horizontal en función de la demanda.
          *Configuración de backups automáticos y monitoreo de métricas clave como latencia, uso de CPU y almacenamiento.
        Sistema de Monitoreo:
          *Integración de herramientas como CloudWatch para supervisar el rendimiento de los servicios en tiempo real.
          *Grafana para dashboards personalizados y análisis de métricas clave del sistema.

        Dispositivos del Usuario Final:

        Móviles: 
          *Compatibilidad con Android 8.0/iOS 12 o superior.
          *Aplicaciones optimizadas para pantallas táctiles de 5 pulgadas o más.
          *Uso eficiente de recursos para dispositivos de gama media y baja.
        Escritorio: 
          *PCs con navegadores modernos (Chrome, Firefox, Edge).
          *Mínimo 4 GB de RAM y procesadores equivalentes a Intel i3 o superior.
          *Resolución de pantalla mínima de 1366x768 para una experiencia de usuario óptima.

      Software

        Herramientas para Desarrollo e Implementación:

        Terraform (versión 1.0 o superior):
          *Para la gestión de infraestructura como código, incluyendo la configuración de entornos necesarios para el backend de la aplicación móvil.
        Docker:
          *Para contenerización del backend y del servidor de APIs que las aplicaciones Flutter consumirán.
        Visual Studio Code:
          *Editor principal para el desarrollo de las aplicaciones web (React) y móviles (Flutter).
          *Complementos recomendados para Flutter:
            *Dart y Flutter extensions para soporte de sintaxis, autocompletado y depuración.
        Flutter SDK:
          *Descarga e instalación del SDK de Flutter (versión 3.0 o superior) para compatibilidad con las últimas herramientas y dispositivos.
          *Uso de herramientas de línea de comandos como flutter doctor para verificar el entorno de desarrollo.
        Android Studio y Xcode:
          *Android Studio: Para emuladores de Android y manejo del SDK de Android.
          *Xcode: Obligatorio para la compilación y pruebas en dispositivos iOS.
        AWS CLI:
          *Gestión de servicios en AWS desde la línea de comandos para facilitar el despliegue de recursos de backend requeridos por las aplicaciones móviles.

        Infraestructura en la Nube:

        Proveedores de Terraform:

          *HashiCorp AWS Provider (~> 4.0) para configurar servicios en AWS.
          *MongoDB Atlas Provider (~> 1.0) para gestionar bases de datos en MongoDB Atlas.
        Servicios relacionados con Flutter:

        *Configuración de Amazon S3 o CloudFront para alojar archivos de recursos necesarios para la app.
        Tecnologías para Aplicaciones:

        React:
          *Desarrollo de la aplicación web para complementar la experiencia del evento.
        Flutter:

        *Compatibilidad multiplataforma para Android e iOS.
        *Diseño centrado en widgets reutilizables para garantizar una interfaz coherente y responsiva.
        *Integración con paquetes esenciales como:
          *http o dio para llamadas a APIs REST.
          *provider o riverpod para manejo del estado.
          *flutter_secure_storage para almacenar credenciales de forma segura.

        MongoDB:

          *Base de datos utilizada para gestionar la información del evento, como el registro de usuarios, resultados y recursos compartidos.
          *Integración a través de una API backend que exponga los datos necesarios para la aplicación móvil.

<div style="page-break-after: always; visibility: hidden">\pagebreak</div>

4. <span id="_Toc52661349" class="anchor"></span>**Estudio de
    Factibilidad**

        El Estudio de Factibilidad tiene como objetivo evaluar la viabilidad del proyecto "Infraestructura Tecnológica para el Evento Juegos Florales" de la Universidad Privada de Tacna, asegurando que la infraestructura y las aplicaciones propuestas sean capaces de satisfacer las necesidades del evento de manera efectiva, eficiente y sostenible. A través de este estudio, se busca identificar los riesgos potenciales, los recursos necesarios y los costos asociados, con el fin de asegurar una implementación exitosa.

    4.1. <span id="_Toc52661350" class="anchor"></span>Factibilidad Técnica

      Evaluación del Hardware

        Dispositivos del Usuario Final:

        Los usuarios (estudiantes, docentes y administradores) podrán acceder a las aplicaciones del proyecto "Juegos Florales" desde dispositivos móviles modernos (Android 8.0/iOS 12 o superior) o computadoras de escritorio con navegadores actualizados (Chrome, Firefox, Edge).
   
        Infraestructura en la Nube (AWS):

        Se utilizarán instancias EC2 de tipo t2.micro para el entorno de desarrollo y t3.medium para producción, con discos EBS de 30 GB para garantizar el rendimiento y almacenamiento necesario. Además, los S3 Buckets soportarán la distribución de contenido estático como aplicaciones React y Flutter.
   
        Bases de Datos:

        MongoDB Atlas proporcionará clústeres escalables con configuración básica para desarrollo y robustez para producción, permitiendo un manejo eficiente de los datos del evento.
   
      Evaluación del Software

        Sistemas Operativos:

        Las instancias EC2 en AWS utilizarán distribuciones Linux (Ubuntu o Amazon Linux 2) por su compatibilidad y rendimiento. Para el desarrollo local, se emplearán entornos compatibles con Windows, macOS o Linux.

        Frameworks y Herramientas:

        React para la aplicación web, facilitando una experiencia interactiva y moderna.
        Flutter para el desarrollo de la aplicación móvil, asegurando compatibilidad multiplataforma.
        Docker para la contenerización y estandarización del entorno de desarrollo y despliegue.
        Terraform para la creación y gestión de la infraestructura como código, garantizando replicabilidad y control.
          
        Monitoreo y Visualización:

        Grafana será utilizado para monitorear el rendimiento de los servicios en tiempo real, asegurando una operación óptima durante el evento.

      Infraestructura de Red

        Conectividad a Internet:

        La infraestructura de AWS cuenta con conectividad robusta y escalable, asegurando alta disponibilidad y estabilidad para manejar múltiples usuarios simultáneamente.

        Configuración de Red Virtual:

        Se implementarán VPCs (Virtual Private Clouds) en AWS para segmentar los recursos, con subredes públicas para los servicios de front-end y subredes privadas para bases de datos y servicios críticos.

      Dominio y Gestión de Recursos

        Gestión Centralizada:

        El proyecto utilizará los servicios de IAM (Identity and Access Management) de AWS para gestionar usuarios y permisos de manera segura.
          
        Dominio Institucional:

        Se integrará un dominio personalizado para facilitar el acceso a las aplicaciones del evento, mejorando la profesionalidad y accesibilidad.


    4.2. <span id="_Toc52661351" class="anchor"></span>Factibilidad Económica

      4.2.1. Costos Generales

        Los costos generales son todos los gastos realizados en accesorios y material de oficina y de uso diario, necesarios para los procesos, tales como, papeles, plumas, cartuchos de impresora, marcadores, computadora etc.
        
      tabla de costos.
   
   |Material|Cantidad|Costo Unitario (S/)|
   | :-: | :- | :- |
   |LAPTOP INTEL CORE I7 3.4 GHZ MONITOR 27'' RAM 16GB DISCO DURO 1TB + SSD 480GB|1|2900.00||
   |Toshiba Canvio Basics HDTB520XK3AA - Disco duro externo portátil (2 TB), color negro|1|262.00||
   |Cooler Laptop|1|60||
   |Total||3,222.00|


      4.2.2. Costos operativos durante el desarrollo 
        
      Evaluar costos necesarios para la operatividad de las actividades de la empresa durante el periodo en el que se realizara el proyecto. Los costos de operación pueden ser renta de oficina, agua, luz, teléfono, etc.
   
   |Concepto|Costo|
   | :-: | :- |
   |Viáticos|500.00||
   |Total|500.00|

      4.2.3. Costos del ambiente

      Evaluar si se cuenta con los requerimientos técnicos para la implantación del software como el dominio, infraestructura de red, acceso a internet, etc.
   
        
| Concepto                                      | Costo (S/) | Descripción                                                                                                                                              |
|-----------------------------------------------|------------|----------------------------------------------------------------------------------------------------------------------------------------------------------|
| **Servicio VPS (Nube)**                      | 27.65 USD (aprox. S/. 101.23) | Provisión de servidores virtuales privados en la nube, utilizados para el alojamiento de la infraestructura de backend, incluyendo API Gateway y recursos de Docker. Este servicio asegura la disponibilidad, escalabilidad y rendimiento de los recursos necesarios para ejecutar las aplicaciones backend.               |
| **Servicio Grafana Cloud**                    | 19 USD (aprox. S/. 69.72) | Servicio de monitoreo en la nube a través de Grafana, utilizado para visualizar las métricas y logs en tiempo real de la infraestructura. Grafana ayuda a observar el rendimiento y la salud de los servicios desplegados, como el API Gateway, recursos de Docker y base de datos MongoDB. |
| **Almacenamiento en S3 (Flutter & React Frontend)** | 1 USD (aprox. S/. 3.67)   | Almacenamiento de los archivos estáticos de las aplicaciones frontend (Flutter y React) en los buckets de Amazon S3. Este servicio proporciona una solución escalable para alojar los archivos como imágenes, scripts y otros recursos necesarios para la ejecución de las aplicaciones en los dispositivos de los usuarios. |
| **MongoDB Atlas (Cluster y base de datos)**   | 57 USD (aprox. S/. 209.79) | Base de datos NoSQL gestionada en la nube para almacenar y gestionar datos del proyecto. MongoDB Atlas permite manejar configuraciones y usuarios de manera eficiente, con la flexibilidad de escalado automático y respaldos. El costo de 0.08 USD por hora de funcionamiento del clúster se traduce en un costo mensual. |
| **Total**                                    | **S/. 384.41** |                                                                                                                                                          |





      4.2.4. Costos de personal

      Aquí se incluyen los gastos generados por el recurso humano que se necesita para el desarrollo del sistema únicamente.

      No se considerará personal para la operación y funcionamiento del sistema.

      Incluir tabla que muestra los gastos correspondientes al personal.

      Indicar organización y roles. Indicar horario de trabajo del personal.
   
   |Rol|Personas|Salario Mensual|Horas Mensuales|
   | :-: | :- | :- | :- |
   |Desarrollador|4|1000|60|
   |Gerente de Proyecto|1|1200|60|

      4.2.5.  Costos totales del desarrollo del sistema

   
   |Concepto|Costo Total (S/)|
   | :-: | :- |
   |Costos Generales|3,222.00|
   |Costos Operativos durante el Desarrollo|500.00|
   |Costos del Ambiente|384.00|
   |Costos del Personal|6,000.00|
   |Total|10,172.00|

      4.3. <span id="_Toc52661352" class="anchor"></span>Factibilidad Operativa

        Optimización de Recursos: La herramienta proporcionará datos detallados sobre el uso de la infraestructura tecnológica (red, servidores, equipos), permitiendo una distribución eficiente de los recursos disponibles. Esto facilitará decisiones informadas sobre el mantenimiento, actualización o redistribución de la infraestructura tecnológica.

        Mejora en la Toma de Decisiones: Con información precisa y actualizada sobre el desempeño de los componentes tecnológicos (servidores, redes, equipos), los administradores podrán tomar decisiones estratégicas que mejoren la eficiencia operativa de la infraestructura, asegurando que se mantenga a la vanguardia y funcione de manera óptima.

        Facilidad de Uso e Integración: La herramienta está diseñada para integrarse de manera sencilla con la infraestructura tecnológica existente, lo que facilitará su adopción sin grandes complicaciones ni impacto en las operaciones diarias. Esto optimiza el tiempo y recursos invertidos en la capacitación del personal encargado de su uso.
   
    4.4. <span id="_Toc52661353" class="anchor"></span>Factibilidad Legal

        Protección de Datos Personales: La recopilación de datos sobre el rendimiento de la infraestructura tecnológica debe cumplir con las normativas de protección de datos personales en Perú, como la Ley N° 29733. Es fundamental que los datos recogidos no contengan información sensible o personal, y que sean utilizados exclusivamente para fines de análisis y mejora de la infraestructura tecnológica.

        Licenciamiento de Software: Las herramientas y bibliotecas utilizadas para el monitoreo de la infraestructura tecnológica, como Python psutil, deben cumplir con las licencias de uso correspondientes. Es vital asegurar que el software no infrinja derechos de propiedad intelectual y que se utilice dentro de los límites legales establecidos.

    4.5. <span id="_Toc52661354" class="anchor"></span>Factibilidad Social 

        Aceptación del Proyecto: La comunidad universitaria (estudiantes, docentes y personal administrativo) se beneficiará de una infraestructura tecnológica más robusta y eficiente, lo que contribuirá a mejorar el rendimiento académico y operativo. La aceptación del proyecto será favorable si se comunica correctamente cómo la optimización de los recursos tecnológicos impactará positivamente en el ambiente de trabajo.

        Impacto en los Usuarios: Mejorar la infraestructura tecnológica permitirá a los estudiantes y docentes disfrutar de equipos y sistemas más rápidos y estables, lo que contribuirá a una mejor experiencia de enseñanza y aprendizaje. Además, el personal técnico podrá anticipar problemas y optimizar el mantenimiento preventivo, reduciendo tiempos de inactividad.

        Capacitación y Adaptación: Para garantizar el éxito de la implementación de nuevas herramientas o actualizaciones en la infraestructura tecnológica, se llevará a cabo un programa de capacitación para el personal de TI. Esto asegurará que el equipo pueda administrar y operar eficazmente las mejoras sin interrumpir las actividades cotidianas.


    4.6. <span id="_Toc52661355" class="anchor"></span>Factibilidad Ambiental

      Uso de Recursos: El uso de software basado en Python y herramientas digitales no representa una carga significativa sobre los recursos físicos. Además, el proyecto se implementará utilizando la infraestructura existente de la universidad, minimizando la necesidad de nuevas adquisiciones que impacten negativamente en el medio ambiente.

      Eficiencia Energética: El monitoreo continuo de la infraestructura tecnológica permitirá identificar áreas de mejora en el consumo de energía. Optimizar el uso de servidores, equipos y redes reducirá el consumo energético y contribuirá a los objetivos de sostenibilidad de la universidad, alineándose con las mejores prácticas medioambientales.



<div style="page-break-after: always; visibility: hidden">\pagebreak</div>

# 5. Análisis Financiero

El análisis financiero del proyecto tiene como objetivo evaluar los ingresos y egresos relacionados con la mejora de la infraestructura tecnológica de la universidad, con el fin de determinar la viabilidad económica de la inversión.

## 5.1. Justificación de la Inversión
La inversión se justifica por los beneficios que aportará en la optimización de la infraestructura tecnológica, que se traducirá en:

**Beneficios tangibles**:

-Reducción de costos operativos.

-Mejora en la eficiencia de la infraestructura tecnológica.

-Optimización del uso de recursos tecnológicos (servidores, redes, equipos).

**Beneficios intangibles**:

-Toma de decisiones informadas para la actualización y mantenimiento de la infraestructura.

-Reducción de tiempos de inactividad de la infraestructura tecnológica.

## 5.1.2. Criterios de Inversión
Costo de inversión del proyecto: 10,172.00
Tasa de descuento : 9%

**Egresos** (gastos operacionales como parte del funcionamiento del software en la puesta en produccion)

|Gasto|Cantidad|Costo Unitario (S/)|
   | - | :- | :- |
   |Viáticos|1|300||
   |Movilidad del equipo de trabajo|1|200||
   |Total||3,222.00|
   
**Ingreso anual y beneficios del sistema**

|Gasto|Cantidad|Costo Unitario (S/)|
   | - | :- | :- |
   |Reducción en pérdidas|50%|2000||
   |Mejora del sistema|50%|2000||
   |Total||4000|
   
  **Flujo de caja**
  
  |Periodo|Ingreso|Egreso|Flujo efectivo
   | -: | :-: | :-: | :-:
   |0|||-10 172|
   |1|4000|500|3500|
   |3|4000|500|3500
   |4|4000|500|3500
   |5|4000|500|3500
 

### 5.1.2.1. Relación Beneficio/Costo (B/C)


B/C = 1.34

**Interpretación**: Dado que el B/C es mayor a 1 (1.34), el proyecto es financieramente viable y debería aceptarse y por cada unidad monetaria invertida, se espera obtener aproximadamente 0.34 unidades monetarias de beneficio.

### 5.1.2.2. Valor Actual Neto (VAN)


- **Tasa de descuento (r)**: 9%
- **Inversión inicial**: S/ 10,172
- **Flujos de caja proyectados**: S/ 3500 anuales por 5 años.
VAN = S/. 13,613.78 - S/ 10,172
VAN = S/. 3,441.78


**Interpretación**: El VAN es positivo (S/. 3,441.78), lo que indica que el proyecto generará un valor adicional neto sobre la inversión inicial, por lo que es viable.

### 5.1.2.3. Tasa Interna de Retorno (TIR)

TIR = 21%

**Interpretación**: Dado que la TIR (21%) es mayor que la tasa de descuento asumida (10%), el proyecto es rentable.

---
# 6. Conclusiones

La propuesta de mejora de la infraestructura tecnológica de la universidad es viable desde todos los aspectos analizados: operativos, legales, sociales, ambientales y financieros. La inversión inicial se justifica por los beneficios tangibles e intangibles que aportará a la universidad, como la optimización de los recursos, la mejora en la eficiencia del rendimiento de los equipos y una reducción significativa de los costos operativos a largo plazo. Además, el impacto ambiental es mínimo, y el proyecto cumple con las normativas legales. La implementación de esta herramienta mejorará notablemente la calidad del servicio tecnológico que se ofrece a la comunidad universitaria.
