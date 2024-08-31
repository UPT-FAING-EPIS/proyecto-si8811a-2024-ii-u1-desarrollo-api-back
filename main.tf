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

resource "azurerm_resource_group" "main" {
  name     = var.resource_group_name
  location = var.location
}


module "mobile_app" {
  source         = "./modules/mobile_app"
  resource_group_name = azurerm_resource_group.main.name
  location       = var.location
  app_bucket_name = var.flutter_app_storage_account_name
}

module "web_app" {
  source         = "./modules/web_app"
  resource_group_name = azurerm_resource_group.main.name
  location       = var.location
  app_bucket_name = var.react_app_storage_account_name
}

module "backend_api" {
  source         = "./modules/backend_api"
  resource_group_name = azurerm_resource_group.main.name
  location       = var.location
  acr_name       = var.acr_name
  aks_cluster_name = var.aks_cluster_name
  subnet_id      = var.subnet_id
  node_count     = var.backend_node_count
}