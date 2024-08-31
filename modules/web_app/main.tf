variable "resource_group_name" {
  description = "The name of the resource group"
  type        = string
}

variable "location" {
  description = "The Azure region to deploy resources"
  type        = string
}

variable "app_bucket_name" {
  description = "The name of the storage account for the React app"
  type        = string
}


resource "azurerm_storage_account" "react_app" {
  name                     = var.app_bucket_name
  resource_group_name      = var.resource_group_name
  location                 = var.location
  account_tier             = "Standard"
  account_replication_type = "LRS"
  enable_https_traffic_only = true

  static_website {
    index_document = "index.html"
  }
}

resource "azurerm_cdn_profile" "react_app" {
  name                = "${var.app_bucket_name}-cdnprofile"
  location            = var.location
  resource_group_name = var.resource_group_name
  sku                 = "Standard_Microsoft"
}

resource "azurerm_cdn_endpoint" "react_app" {
  name                = "${var.app_bucket_name}-cdnendpoint"
  profile_name        = azurerm_cdn_profile.react_app.name
  location            = var.location
  resource_group_name = var.resource_group_name

  origin {
    name      = "react-app-origin"
    host_name = azurerm_storage_account.react_app.primary_web_host
  }
}