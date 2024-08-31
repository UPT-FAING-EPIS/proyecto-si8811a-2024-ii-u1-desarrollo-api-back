output "flutter_app_storage_account_name" {
  description = "The name of the storage account hosting the Flutter app"
  value       = module.mobile_app.storage_account_name
}

output "flutter_app_cdn_endpoint" {
  description = "The CDN endpoint for the Flutter app"
  value       = module.mobile_app.cdn_endpoint
}

output "react_app_storage_account_name" {
  description = "The name of the storage account hosting the React app"
  value       = module.web_app.storage_account_name
}

output "react_app_cdn_endpoint" {
  description = "The CDN endpoint for the React app"
  value       = module.web_app.cdn_endpoint
}

output "backend_acr_login_server" {
  description = "The login server of the ACR for the backend API"
  value       = module.backend_api.acr_login_server
}

output "backend_aks_cluster_name" {
  description = "The name of the AKS cluster running the backend API"
  value       = module.backend_api.aks_cluster_name
}

output "grafana_id" {
  value = module.grafana.grafana_id
}

output "grafana_endpoint" {
  value = module.grafana.grafana_endpoint
}

output "mongodb_connection_string" {
  value     = module.mongodb.connection_string
  sensitive = true
}