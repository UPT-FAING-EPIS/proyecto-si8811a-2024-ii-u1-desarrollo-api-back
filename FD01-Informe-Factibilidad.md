<center>

![./media/logo-upt.png](./media/logo-upt.png)

**UNIVERSIDAD PRIVADA DE TACNA**

**FACULTAD DE INGENIERIA**

**Escuela Profesional de Ingeniería de Sistemas**

**Proyecto *"Juegos Florales - Tópicos de Base de Datos Avanzados"***

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

**Sistema *"Juegos Florales - Tópicos de Base de Datos Avanzados"***

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
   
    "Juegos Florales - Tópicos de Base de Datos Avanzados"
    
1.2. Duración del proyecto

    Empieza el 13 de agosto y termina el 13 diciembre

1.3. Descripción

    -El proyecto "Juegos Florales - Tópicos de Base de Datos Avanzados" se centra en el desarrollo de una serie de aplicaciones web y móviles diseñadas para apoyar las actividades del día festivo de los Juegos Florales en la Universidad Privada de Tacna. Estas aplicaciones tienen como objetivo facilitar la organización, gestión y participación en los eventos del día, brindando una experiencia interactiva y moderna para los usuarios.

    -En este informe, se detallan los costos asociados a los servicios utilizados para la infraestructura del proyecto, tales como AWS, MongoDB, entre otros. Además, se analizan los gastos adicionales vinculados al despliegue y mantenimiento de la infraestructura, asegurando una solución escalable y eficiente para el evento.

1.4. Objetivos

1.4.1 Objetivo general
   
    -Implementar una infraestructura tecnológica eficiente para soportar las aplicaciones web y móviles del proyecto "Juegos Florales", optimizando la gestión y experiencia del evento en la Universidad Privada de Tacna.

1.4.2 Objetivos Específicos
            
    -Diseñar e implementar aplicaciones web y móviles utilizando React y Flutter para facilitar la interacción y participación en el evento.
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

   Para el proyecto "Juegos Florales - Tópicos de Base de Datos Avanzados", es fundamental garantizar que la infraestructura tecnológica cuente con los recursos necesarios tanto en hardware como en software para su correcto desarrollo, implementación y operación.

Hardware
Infraestructura en la Nube (AWS):

Instancias EC2:
Tipo: t2.micro para pruebas y entornos de desarrollo.
Tipo: t3.medium o superior para producción, dependiendo de la carga esperada.
Almacenamiento: 30 GB de EBS mínimo para cada instancia.
S3 Buckets: Espacio suficiente para alojar archivos de aplicaciones web y móviles.
MongoDB Atlas: Cluster básico para desarrollo y cluster escalable para producción.
Dispositivos del Usuario Final:

Móviles: Compatibilidad con Android 8.0/iOS 12 o superior.
Escritorio: PCs con navegadores modernos (Chrome, Firefox, Edge) y al menos 4 GB de RAM.
Software
Herramientas para Desarrollo e Implementación:

Terraform (versión 1.0 o superior) para la gestión de infraestructura como código.
Docker para contenerización de las aplicaciones.
Visual Studio Code para la codificación de aplicaciones web (React) y móviles (Flutter).
Infraestructura en la Nube:

AWS CLI para gestionar servicios en AWS desde la línea de comandos.
Proveedores de Terraform:
HashiCorp AWS Provider (~> 4.0).
MongoDB Atlas Provider (~> 1.0).
Tecnologías para Aplicaciones:

React para el desarrollo de la aplicación web.
Flutter para la aplicación móvil, asegurando compatibilidad multiplataforma.
MongoDB como base de datos para el almacenamiento y gestión de datos.

<div style="page-break-after: always; visibility: hidden">\pagebreak</div>

4. <span id="_Toc52661349" class="anchor"></span>**Estudio de
    Factibilidad**

    Describir los resultados que esperan alcanzar del estudio de factibilidad, las actividades que se realizaron para preparar la evaluación de factibilidad y por quien fue aprobado.

    4.1. <span id="_Toc52661350" class="anchor"></span>Factibilidad Técnica

        Evaluación del Hardware
         Dispositivos del Usuario Final:
          -Los usuarios (estudiantes, docentes y administradores) podrán acceder a las aplicaciones del proyecto "Juegos Florales" desde dispositivos móviles modernos (Android 8.0/iOS 12 o superior) o computadoras de escritorio con navegadores actualizados (Chrome, Firefox, Edge).
   
         Infraestructura en la Nube (AWS):
          -Se utilizarán instancias EC2 de tipo t2.micro para el entorno de desarrollo y t3.medium para producción, con discos EBS de 30 GB para garantizar el rendimiento y almacenamiento necesario. Además, los S3 Buckets soportarán la distribución de contenido estático como aplicaciones React y Flutter.
   
        Bases de Datos:
          -MongoDB Atlas proporcionará clústeres escalables con configuración básica para desarrollo y robustez para producción, permitiendo un manejo eficiente de los datos del evento.
   
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

   El propósito del estudio de viabilidad económica, es determinar los beneficios económicos del proyecto o sistema propuesto para la organización, en contraposición con los costos.
        Como se mencionó anteriormente en el estudio de factibilidad técnica wvaluar si la institución (departamento de TI) cuenta con las herramientas necesarias para la implantación del sistema y evaluar si la propuesta requiere o no de una inversión inicial en infraestructura informática.
        Se plantearán los costos del proyecto.
        Costeo del Proyecto: Consiste en estimar los costos de los recursos Humanos, materiales o consumibles y/o máquinas) directos para completar las actividades del proyecto}.*

   Definir los siguientes costos:

      4.2.1. Costos Generales

      Los costos generales son todos los gastos realizados en accesorios y material de oficina y de uso diario, necesarios para los procesos, tales como, papeles, plumas, cartuchos de impresora, marcadores, computadora etc. Colocar tabla de costos.
   
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
   
   |Concepto|Costo|
   | :-: | :- |
   |Servicio VPS (Nube)|350.00||
   |Software de Diagramas y Arquitectura del Proyecto|100.00|
   |Total|450.00|

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

      {Totalizar costos y realizar resumen de costo final del proyecto y la forma de pago.
   
   |Concepto|Costo Total (S/)|
   | :-: | :- |
   |Costos Generales|3,222.00|
   |Costos Operativos durante el Desarrollo|500.00|
   |Costos del Ambiente|450.00|
   |Costos del Personal|6,000.00|
   |Total|10,172.00|

      4.3. <span id="_Toc52661352" class="anchor"></span>Factibilidad Operativa

         -Optimización de Recursos: La herramienta ayudará a optimizar la utilización de los recursos tecnológicos al proporcionar datos detallados sobre el uso del hardware y la red. Esta información permitirá a la universidad tomar decisiones informadas sobre el mantenimiento, la actualización o la redistribución de equipos y recursos.
         -Mejora en la Toma de Decisiones: Al disponer de información precisa y actualizada sobre el desempeño de la infraestructura tecnológica, los administradores podrán tomar decisiones basadas en datos para mejorar la eficiencia operativa y la calidad del servicio ofrecido a los estudiantes y personal académico.
         -Facilidad de Uso e Integración: La herramienta está diseñada para ser fácil de usar e integrarse con los sistemas existentes, lo que reduce la curva de aprendizaje para el personal y minimiza el impacto en las operaciones diarias.
   
    4.4. <span id="_Toc52661353" class="anchor"></span>Factibilidad Legal

         -Protección de Datos Personales: La recopilación y análisis de datos debe cumplir con las leyes de protección de datos personales en Perú, como la Ley de Protección de Datos Personales (Ley N° 29733). La herramienta debe garantizar que cualquier dato personal recogido sea anonimizado y utilizado exclusivamente con fines académicos y de mejora del desempeño de los equipos.
         -Licenciamiento de Software: El uso de la biblioteca Python psutil y cualquier otro software o herramienta debe estar conforme a sus respectivas licencias de uso. Se debe asegurar que no haya violación de derechos de propiedad intelectual en el desarrollo y aplicación de la herramienta.

    4.5. <span id="_Toc52661354" class="anchor"></span>Factibilidad Social 

         -Aceptación del Proyecto: La herramienta de monitoreo proporcionará beneficios claros para la comunidad universitaria al mejorar el rendimiento de las computadoras en los laboratorios, optimizando los recursos y asegurando que los equipos estén disponibles y operativos para los estudiantes y profesores. La aceptación del proyecto entre los usuarios será positiva si se comunica adecuadamente el propósito y los beneficios del proyecto.
         -Impacto en los Usuarios: Los estudiantes y docentes se beneficiarán de un entorno de aprendizaje más eficiente, con equipos que funcionan de manera óptima. Además, el personal de TI podrá responder proactivamente a problemas antes de que se conviertan en fallas significativas, lo que reducirá los tiempos de inactividad y mejorará la satisfacción del usuario.
         -Capacitación y Adaptación: Para asegurar la adopción efectiva del proyecto, se deben realizar capacitaciones para el personal de TI y otros usuarios relevantes sobre el uso de la herramienta y la interpretación de los datos generados. Esto ayudará a minimizar cualquier resistencia al cambio y facilitará una transición fluida.


    4.6. <span id="_Toc52661355" class="anchor"></span>Factibilidad Ambiental

         -Uso de Recursos: La herramienta hace uso de software basado en Python y otras herramientas digitales, lo que no requiere recursos físicos adicionales significativos que impacten negativamente en el medio ambiente. Además, la implementación se realiza en la infraestructura existente de la universidad, minimizando la necesidad de recursos adicionales.
         -Eficiencia Energética: La herramienta está diseñada para identificar patrones de uso y consumo de recursos como energía y datos, permitiendo así una optimización del consumo de energía de las computadoras. Al monitorizar el rendimiento y la eficiencia de los equipos, se pueden identificar oportunidades para reducir el consumo energético, lo que contribuye a los objetivos de sostenibilidad de la universidad.   

<div style="page-break-after: always; visibility: hidden">\pagebreak</div>

# 5. Análisis Financiero

El plan financiero se ocupa del análisis de ingresos y gastos asociados a cada proyecto, desde el punto de vista del instante temporal en que se producen. Su misión fundamental es detectar situaciones financieramente inadecuadas. Se tiene que estimar financieramente el resultado del proyecto.

## 5.1. Justificación de la Inversión
La inversión en este proyecto se justifica con base en los siguientes beneficios

**Beneficios tangibles**:

-Reducción de costos operativos
-Mejora en la eficiencia del área bajo estudio
-Optimización del uso de recursos

**Beneficios intangibles**:

-Toma de decisiones más informada

## 5.1.2. Criterios de Inversión

### 5.1.2.1. Relación Beneficio/Costo (B/C)

En base a los costos y beneficios identificados, se evalúa si es factible el desarrollo del proyecto. Si se presentan varias alternativas de solución, se evaluará cada una de ellas para determinar la mejor solución desde el punto de vista del retorno de la inversión.

La fórmula para calcular el B/C es:

\[
B/C = \frac{\text{Beneficios totales}}{\text{Costos totales}}
\]

- **Beneficios Totales**: S/ 12,000
- **Costos Totales**: S/ 10,172

\[
B/C = \frac{12,000}{10,172} = 1.18
\]

**Interpretación**: Dado que el B/C es mayor a 1 (1.18), el proyecto es financieramente viable y debería aceptarse.

### 5.1.2.2. Valor Actual Neto (VAN)

El VAN es el valor presente de los flujos de caja futuros generados por el proyecto, descontados al presente. Se calcula de la siguiente manera:

\[
VAN = \sum \frac{\text{Flujo de Caja}}{(1 + r)^t} - \text{Inversión Inicial}
\]

- **Tasa de descuento (r)**: 10%
- **Inversión inicial**: S/ 10,172
- **Flujos de caja proyectados**: S/ 4,000 anuales por 4 años.

\[
VAN = \frac{4000}{(1 + 0.10)^1} + \frac{4000}{(1 + 0.10)^2} + \frac{4000}{(1 + 0.10)^3} + \frac{4000}{(1 + 0.10)^4} - 10,172
\]

Calculando:

\[
VAN = \frac{4000}{1.10} + \frac{4000}{1.21} + \frac{4000}{1.331} + \frac{4000}{1.4641} - 10,172
\]
\[
VAN = 3636.36 + 3305.79 + 3006.77 + 2732.39 - 10,172
\]
\[
VAN = 12,681.31 - 10,172 = 2,509.31
\]

**Interpretación**: El VAN es positivo (S/ 2,509.31), lo que indica que el proyecto generará un valor adicional neto sobre la inversión inicial, por lo que es viable.

### 5.1.2.3. Tasa Interna de Retorno (TIR)

La TIR es la tasa porcentual que indica la rentabilidad promedio anual que genera el capital invertido en el proyecto. Se calcula resolviendo la siguiente ecuación:

\[
0 = \sum \frac{4000}{(1 + TIR)^t} - 10,172
\]

Usando una aproximación iterativa, se obtiene que la TIR es aproximadamente del 18%.

**Interpretación**: Dado que la TIR (18%) es mayor que la tasa de descuento asumida (10%), el proyecto es rentable.

---
# 6. Conclusiones

El proyecto es completamente viable, dado que la infraestructura de la UPT permite su implementación sin requerir grandes inversiones adicionales, y los costos previstos son justificados por los beneficios que ofrecerá. Entre estos beneficios destacan una gestión más eficiente de los recursos tecnológicos, optimización del rendimiento de los equipos, reducción de costos operativos a largo plazo y un mantenimiento preventivo más eficaz. Además, el sistema cumple con las normativas legales, asegurando un impacto positivo en la comunidad universitaria, mejorando la calidad del servicio tecnológico, y manteniendo un impacto ambiental mínimo.
