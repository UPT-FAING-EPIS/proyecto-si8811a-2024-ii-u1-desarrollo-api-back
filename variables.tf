variable "resource_group_name" {
  description = "The name of the resource group"
  type        = string
}

variable "location" {
  description = "The Azure region to deploy resources"
  type        = string
}



variable "flutter_app_storage_account_name" {
  description = "The name of the storage account for the Flutter app"
  type        = string
  default     = "myflutterappsa"
}

variable "react_app_storage_account_name" {
  description = "The name of the storage account for the React app"
  type        = string
  default     = "myreactappsa"
}

variable "acr_name" {
  description = "The name of the Azure Container Registry"
  type        = string
  default     = "mybackendacr"
}

variable "aks_cluster_name" {
  description = "The name of the AKS cluster"
  type        = string
  default     = "mybackendaks"
}

variable "subnet_id" {
  description = "The ID of the subnet for the AKS cluster"
  type        = string
}

variable "backend_node_count" {
  description = "The number of nodes in the AKS cluster"
  type        = number
  default     = 1
}


