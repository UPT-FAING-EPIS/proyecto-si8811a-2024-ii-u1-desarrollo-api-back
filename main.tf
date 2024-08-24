terraform {
  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "~> 3.0"
    }
  }
}

provider "azurerm" {
  features {}
}

# Grupo de recursos
resource "azurerm_resource_group" "rg" {
  name     = "#{RESOURCE_GROUP_NAME}"
  location = "#{AZURE_REGION}"
}

# Container Registry para APIs
resource "azurerm_container_registry" "acr" {
  name                = "#{API_ACR_NAME}"
  resource_group_name = azurerm_resource_group.rg.name
  location            = azurerm_resource_group.rg.location
  sku                 = "Basic"
  admin_enabled       = true
}

# Plan de App Service para APIs
resource "azurerm_service_plan" "asp" {
  name                = "#{API_APP_SERVICE_PLAN_NAME}"
  location            = azurerm_resource_group.rg.location
  resource_group_name = azurerm_resource_group.rg.name
  os_type             = "Linux"
  sku_name            = "B1"
}

# Primera API como contenedor
resource "azurerm_linux_web_app" "api1" {
  name                = "#{API1_APP_NAME}"
  location            = azurerm_resource_group.rg.location
  resource_group_name = azurerm_resource_group.rg.name
  service_plan_id     = azurerm_service_plan.asp.id

  site_config {
    always_on = true
    application_stack {
      docker_image     = "#{API1_DOCKER_IMAGE}"
      docker_image_tag = "#{API1_DOCKER_IMAGE_TAG}"
    }
  }

  app_settings = {
    "WEBSITES_ENABLE_APP_SERVICE_STORAGE" = "false"
    "DOCKER_REGISTRY_SERVER_URL"          = "https://#{API_ACR_NAME}.azurecr.io"
    "DOCKER_REGISTRY_SERVER_USERNAME"     = azurerm_container_registry.acr.admin_username
    "DOCKER_REGISTRY_SERVER_PASSWORD"     = azurerm_container_registry.acr.admin_password
    "MONGODB_CONNECTION_STRING"           = azurerm_cosmosdb_account.db.primary_key
  }
}

# Segunda API como contenedor
resource "azurerm_linux_web_app" "api2" {
  name                = "#{API2_APP_NAME}"
  location            = azurerm_resource_group.rg.location
  resource_group_name = azurerm_resource_group.rg.name
  service_plan_id     = azurerm_service_plan.asp.id

  site_config {
    always_on = true
    application_stack {
      docker_image     = "#{API2_DOCKER_IMAGE}"
      docker_image_tag = "#{API2_DOCKER_IMAGE_TAG}"
    }
  }

  app_settings = {
    "WEBSITES_ENABLE_APP_SERVICE_STORAGE" = "false"
    "DOCKER_REGISTRY_SERVER_URL"          = "https://#{API_ACR_NAME}.azurecr.io"
    "DOCKER_REGISTRY_SERVER_USERNAME"     = azurerm_container_registry.acr.admin_username
    "DOCKER_REGISTRY_SERVER_PASSWORD"     = azurerm_container_registry.acr.admin_password
    "MONGODB_CONNECTION_STRING"           = azurerm_cosmosdb_account.db2.primary_key
  }
}

# Primera cuenta de Cosmos DB
resource "azurerm_cosmosdb_account" "db" {
  name                = "#{COSMOSDB_ACCOUNT_NAME_1}"
  location            = azurerm_resource_group.rg.location
  resource_group_name = azurerm_resource_group.rg.name
  offer_type          = "Standard"
  kind                = "MongoDB"

  capabilities {
    name = "EnableMongo"
  }

  consistency_policy {
    consistency_level       = "Session"
    max_interval_in_seconds = 5
    max_staleness_prefix    = 100
  }

  geo_location {
    location          = azurerm_resource_group.rg.location
    failover_priority = 0
  }
}

# Primera base de datos MongoDB
resource "azurerm_cosmosdb_mongo_database" "mongodb" {
  name                = "#{MONGODB_NAME_1}"
  resource_group_name = azurerm_resource_group.rg.name
  account_name        = azurerm_cosmosdb_account.db.name
}

# Segunda cuenta de Cosmos DB
resource "azurerm_cosmosdb_account" "db2" {
  name                = "#{COSMOSDB_ACCOUNT_NAME_2}"
  location            = azurerm_resource_group.rg.location
  resource_group_name = azurerm_resource_group.rg.name
  offer_type          = "Standard"
  kind                = "MongoDB"

  capabilities {
    name = "EnableMongo"
  }

  consistency_policy {
    consistency_level       = "Session"
    max_interval_in_seconds = 5
    max_staleness_prefix    = 100
  }

  geo_location {
    location          = azurerm_resource_group.rg.location
    failover_priority = 0
  }
}

# Segunda base de datos MongoDB
resource "azurerm_cosmosdb_mongo_database" "mongodb2" {
  name                = "#{MONGODB_NAME_2}"
  resource_group_name = azurerm_resource_group.rg.name
  account_name        = azurerm_cosmosdb_account.db2.name
}

# Azure Container Registry para el frontend
resource "azurerm_container_registry" "acr_frontend" {
  name                = "#{FRONTEND_ACR_NAME}"
  resource_group_name = azurerm_resource_group.rg.name
  location            = azurerm_resource_group.rg.location
  sku                 = "Basic"
  admin_enabled       = true
}

# Plan de App Service para el frontend
resource "azurerm_service_plan" "asp_frontend" {
  name                = "#{FRONTEND_APP_SERVICE_PLAN_NAME}"
  location            = azurerm_resource_group.rg.location
  resource_group_name = azurerm_resource_group.rg.name
  os_type             = "Linux"
  sku_name            = "B1"
}

# App Service para el frontend React
resource "azurerm_linux_web_app" "frontend" {
  name                = "#{FRONTEND_APP_NAME}"
  location            = azurerm_resource_group.rg.location
  resource_group_name = azurerm_resource_group.rg.name
  service_plan_id     = azurerm_service_plan.asp_frontend.id

  site_config {
    always_on = true
    application_stack {
      docker_image     = "#{FRONTEND_DOCKER_IMAGE}"
      docker_image_tag = "#{FRONTEND_DOCKER_IMAGE_TAG}"
    }
  }

  app_settings = {
    "WEBSITES_ENABLE_APP_SERVICE_STORAGE" = "false"
    "DOCKER_REGISTRY_SERVER_URL"          = "https://#{FRONTEND_ACR_NAME}.azurecr.io"
    "DOCKER_REGISTRY_SERVER_USERNAME"     = azurerm_container_registry.acr_frontend.admin_username
    "DOCKER_REGISTRY_SERVER_PASSWORD"     = azurerm_container_registry.acr_frontend.admin_password
    "REACT_APP_API1_URL"                  = "https://${azurerm_linux_web_app.api1.default_hostname}"
    "REACT_APP_API2_URL"                  = "https://${azurerm_linux_web_app.api2.default_hostname}"
  }
}

# Outputs
output "api1_url" {
  value = "https://${azurerm_linux_web_app.api1.default_hostname}"
}

output "api2_url" {
  value = "https://${azurerm_linux_web_app.api2.default_hostname}"
}

output "frontend_url" {
  value = "https://${azurerm_linux_web_app.frontend.default_hostname}"
}

output "cosmosdb_connection_string1" {
  value     = azurerm_cosmosdb_account.db.primary_key
  sensitive = true
}

output "cosmosdb_connection_string2" {
  value     = azurerm_cosmosdb_account.db2.primary_key
  sensitive = true
}