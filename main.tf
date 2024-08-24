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
  name     = "api-resources"
  location = "East US"
}

# Plan de App Service
resource "azurerm_service_plan" "asp" {
  name                = "api-appserviceplan"
  location            = azurerm_resource_group.rg.location
  resource_group_name = azurerm_resource_group.rg.name
  os_type             = "Linux"
  sku_name            = "F1"  # Plan gratuito
}

# App Service para la API donde name sea único
resource "azurerm_linux_web_app" "api" {
  name                = "my-netcore-api-CL"  
  location            = azurerm_resource_group.rg.location
  resource_group_name = azurerm_resource_group.rg.name
  service_plan_id     = azurerm_service_plan.asp.id

  site_config {
    application_stack {
      dotnet_version = "6.0"
    }
    always_on = false
  }

  app_settings = {
    "WEBSITES_ENABLE_APP_SERVICE_STORAGE" = "false"
    "ASPNETCORE_ENVIRONMENT"              = "Production"
    "MONGODB_CONNECTION_STRING" = azurerm_cosmosdb_account.db.primary_key
    }
}

# Cuenta de Cosmos DB donde name debe ser globalmente unico
resource "azurerm_cosmosdb_account" "db" {
  name                = "my-cosmosdb-account-cl-unique"
  location            = azurerm_resource_group.rg.location
  resource_group_name = azurerm_resource_group.rg.name
  offer_type          = "Standard"
  kind                = "MongoDB"

  automatic_failover_enabled = false

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

# Base de datos MongoDB
resource "azurerm_cosmosdb_mongo_database" "mongodb" {
  name                = "myDatabase"
  resource_group_name = azurerm_resource_group.rg.name
  account_name        = azurerm_cosmosdb_account.db.name
}

# Colección MongoDB
resource "azurerm_cosmosdb_mongo_collection" "collection" {
  name                = "myCollection"
  resource_group_name = azurerm_resource_group.rg.name
  account_name        = azurerm_cosmosdb_account.db.name
  database_name       = azurerm_cosmosdb_mongo_database.mongodb.name

  index {
    keys   = ["_id"]
    unique = true
  }
}

# Outputs
output "webapp_url" {
  value = azurerm_linux_web_app.api.default_hostname
}

output "cosmosdb_connection_string" {
  value     = azurerm_cosmosdb_account.db.connection_strings[0]
  sensitive = true
}