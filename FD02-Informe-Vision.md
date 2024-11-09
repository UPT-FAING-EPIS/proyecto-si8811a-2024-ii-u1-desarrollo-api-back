<center>

![./media/logo-upt.png](./media/logo-upt.png)

**UNIVERSIDAD PRIVADA DE TACNA**

**FACULTAD DE INGENIERÍA**

**Escuela Profesional de Ingeniería de Sistemas**

**Proyecto: ""**

**Curso:** 

**Docente:** Mag. Patrick Cuadros Quiroga

**Integrantes:**


- Apaza Ccalle, Albert Kenyi (2021071075)  
- Huallpa Maron, Jesús Antonio (2021071085)  

**Tacna – Perú**

**2024**

</center>

---

# Documento de Visión

**Sistema:** *""*

**Versión:** 1.0

| Versión | Hecha por | Revisada por | Aprobada por | Fecha       | Motivo            |
|:-------:|:---------:|:------------:|:------------:|:-----------:|:------------------:|
| 1.0     | Huallpa     | ELV          | ARV          | 24/08/2024  | Versión Original   |

---

### Índice General

1. [Introducción](#1-introducción)  
    1.1 [Propósito del Documento](#11-propósito-del-documento)  
    1.2 [Audiencia Objetivo](#12-audiencia-objetivo)  
2. [Descripción General del Proyecto](#2-descripción-general-del-proyecto)  
    2.1 [Resumen del Proyecto](#21-resumen-del-proyecto)  
    2.2 [Contexto y Necesidad](#22-contexto-y-necesidad)  
3. [Objetivos del Proyecto](#3-objetivos-del-proyecto)  
    3.1 [Objetivo General](#31-objetivo-general)  
    3.2 [Objetivos Específicos](#32-objetivos-específicos)  
4. [Alcance](#4-alcance)  
    4.1 [En el Alcance](#41-en-el-alcance)  
    4.2 [Fuera del Alcance](#42-fuera-del-alcance)  
5. [Casos de Uso](#5-casos-de-uso)  
6. [Factores Críticos de Éxito](#6-factores-críticos-de-éxito)  
7. [Restricciones y Suposiciones](#7-restricciones-y-suposiciones)  
    7.1 [Restricciones](#71-restricciones)  
    7.2 [Suposiciones](#72-suposiciones)  
8. [Riesgos](#8-riesgos)  
9. [Aprobación y Revisión](#9-aprobación-y-revisión)  
10. [Anexos](#10-anexos)  

---

## 1. Introducción

### 1.1 Propósito del Documento
Describir la visión general del proyecto de infraestructura en AWS, que servirá para establecer el alcance, los objetivos y las expectativas en torno a su implementación y uso. Este documento también ayudará a alinear al equipo y a los interesados en los resultados esperados.

### 1.2 Audiencia Objetivo
Este documento está dirigido a los miembros del equipo de desarrollo, administración de sistemas, y a los interesados clave en el proyecto, incluyendo la gerencia de TI y los patrocinadores del proyecto.

---

## 2. Descripción General del Proyecto

### 2.1 Resumen del Proyecto
El proyecto de Infraestructura en AWS con Terraform tiene como objetivo implementar una arquitectura en la nube utilizando AWS y Terraform para gestionar servicios como MongoDB Atlas, Grafana, y aplicaciones web (React y Flutter). Esta infraestructura proporcionará un entorno escalable, seguro y eficiente para las aplicaciones de la Universidad Privada de Tacna.

### 2.2 Contexto y Necesidad
Actualmente, los recursos de infraestructura son limitados y difíciles de gestionar manualmente. Este proyecto aborda la necesidad de una solución automatizada y escalable en la nube, que permita gestionar eficientemente la infraestructura y reducir los tiempos de despliegue, configuración y mantenimiento.

---

## 3. Objetivos del Proyecto

### 3.1 Objetivo General
Establecer una infraestructura en la nube escalable y administrable con AWS y Terraform, que soporte las aplicaciones y servicios de la universidad.

### 3.2 Objetivos Específicos
- Automatizar la configuración y gestión de recursos en AWS con Terraform.
- Implementar servicios de monitoreo y gestión como MongoDB Atlas y Grafana.
- Facilitar el despliegue de aplicaciones web y móviles a través de S3 y otros recursos de AWS.
- Mejorar la eficiencia operativa mediante un sistema centralizado y replicable para la infraestructura en la nube.

---

## 4. Alcance

### 4.1 En el Alcance
- Implementación de instancias de AWS EC2 para contenedores de Docker.
- Configuración de bases de datos en MongoDB Atlas.
- Despliegue de aplicaciones web y móviles en buckets de S3.
- Implementación de un sistema de monitoreo con Grafana.
- Automatización de procesos de infraestructura con Terraform.

### 4.2 Fuera del Alcance
- Desarrollo de nuevas aplicaciones (este proyecto se centra en infraestructura).
- Gestión de usuarios finales de las aplicaciones.
- Procesos de soporte post-producción.

---

## 5. Casos de Uso

### Caso de Uso 1: Despliegue de Aplicaciones
**Descripción**: Automatizar el despliegue de las aplicaciones React y Flutter en la infraestructura de AWS.

### Caso de Uso 2: Monitoreo de Recursos
**Descripción**: Proporcionar monitoreo en tiempo real de la infraestructura y aplicaciones mediante Grafana y sus integraciones.

### Caso de Uso 3: Gestión de Bases de Datos
**Descripción**: Permitir la creación y gestión de bases de datos en MongoDB Atlas para aplicaciones de la universidad.

---

## 6. Factores Críticos de Éxito

- **Escalabilidad**: La infraestructura debe ser capaz de escalar horizontalmente para manejar picos de tráfico.
- **Automatización**: El uso de Terraform debe reducir significativamente el tiempo y esfuerzo manual necesario para implementar la infraestructura.
- **Seguridad**: Los recursos y datos deben estar protegidos conforme a las mejores prácticas de seguridad de AWS y MongoDB.
- **Costo-Eficiencia**: La infraestructura debe optimizar el uso de recursos para mantener los costos dentro del presupuesto aprobado.

---

## 7. Restricciones y Suposiciones

### 7.1 Restricciones
- Limitaciones de presupuesto y tiempo.
- Dependencia de permisos y accesos en AWS y MongoDB Atlas.

### 7.2 Suposiciones
- Los recursos en AWS serán suficientes para cumplir con los requerimientos de rendimiento.
- Los servicios de Terraform serán compatibles con los servicios requeridos en AWS y MongoDB Atlas.

---

## 8. Riesgos

- **Riesgo de Seguridad**: Los datos almacenados en la nube pueden ser vulnerables a accesos no autorizados.
- **Sobrecarga de Costos**: Uso inesperado de recursos en AWS puede generar costos adicionales.
- **Problemas de Compatibilidad**: Posibles incompatibilidades entre versiones de Terraform y módulos de AWS.

---

## 9. Aprobación y Revisión

**Aprobado por:** Mag. Patrick Cuadros Quiroga  
**Revisión Final:** Fecha de revisión final  
**Revisado por:** Equipo de Ingeniería de Sistemas  

---

## 10. Anexos

- **Diagrama de Arquitectura**
- **Lista de Requerimientos Técnicos**

---
