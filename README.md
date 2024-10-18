[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/vK6WBQ1t)
[![Open in Codespaces](https://classroom.github.com/assets/launch-codespace-2972f46106e565e64193e422d61a12cf1da4916b45550586e14ef0a7c637dd04.svg)](https://classroom.github.com/open-in-codespaces?assignment_repo_id=15560937)

# Terraform Infrastructure as Code for Multi-Component Application

Este proyecto utiliza Terraform para desplegar una infraestructura escalable en AWS que soporta una aplicación con componentes móviles (Flutter), web (React) y un backend API.

## Estructura del Proyecto

```mermaid
graph TD
    A[project] --> B[main.tf]
    A --> C[variables.tf]
    A --> D[outputs.tf]
    A --> E[modules]
    E --> F[mobile_app]
    E --> G[web_app]
    E --> H[docker_host]
    E --> I[mongodb]
    E --> J[grafana]

