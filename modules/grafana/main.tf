terraform {
  required_providers {
    grafana = {
      source  = "grafana/grafana"
      version = "~> 1.28.0"
    }
  }
}

# Crear la carpeta para todos los dashboards
resource "grafana_folder" "monitoreo_topicos" {
  title = "monitoreo-topicos"
}

# Dashboard para Docker Host
resource "grafana_dashboard" "docker_host_dashboard" {
  config_json = file("C:/Users/HP/Music/proyecto-si8811a-2024-ii-u1-automatizado-huallpa_apaza/terraform/modules/grafana/docker_host_dashboard.json")
  folder      = grafana_folder.monitoreo_topicos.id
}

# Dashboard para Grafana Interno
resource "grafana_dashboard" "grafana_internal_dashboard" {
  config_json = file("C:/Users/HP/Music/proyecto-si8811a-2024-ii-u1-automatizado-huallpa_apaza/terraform/modules/grafana/grafana_internal_dashboard.json")
  folder      = grafana_folder.monitoreo_topicos.id
}

# Dashboard para Mobile App (Flutter)
resource "grafana_dashboard" "mobile_app_dashboard" {
  config_json = file("C:/Users/HP/Music/proyecto-si8811a-2024-ii-u1-automatizado-huallpa_apaza/terraform/modules/grafana/mobile_app_dashboard.json")  
  folder      = grafana_folder.monitoreo_topicos.id
}




# Recurso de Grafana para configurar MongoDB como fuente de datos
resource "grafana_data_source" "mongodb" {
  name       = "MongoDB Atlas"
  type       = "mongodb"
  url        = "mongodb+srv://${var.mongodb_username}:${var.mongodb_password}@${var.mongodb_cluster_name}.mongodb.net/${var.mongodb_database_name}"
  is_default = false

  json_data {
    auth_type                = "basic"
    database                 = var.mongodb_database_name
    tls_auth                 = true
    tls_auth_with_ca_cert    = false
  }
}

# Dashboard para MongoDB
resource "grafana_dashboard" "mongodb_dashboard" {
  config_json = file("C:/Users/HP/Music/proyecto-si8811a-2024-ii-u1-automatizado-huallpa_apaza/terraform/modules/grafana/mongodb_dashboard.json")  
  folder      = grafana_folder.monitoreo_topicos.id
}

# Dashboard para Web App (React)
resource "grafana_dashboard" "web_app_dashboard" {
  config_json = file("C:/Users/HP/Music/proyecto-si8811a-2024-ii-u1-automatizado-huallpa_apaza/terraform/modules/grafana/web_app_dashboard.json")
  folder      = grafana_folder.monitoreo_topicos.id
}
