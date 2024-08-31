terraform {
  required_providers {
    aws = {
      source  = "hashicorp/aws"
      version = "~> 4.0"
    }
  }
}

provider "aws" {
  region = var.aws_region
}


module "grafana" {
  source = "./modules/grafana"
  
  ami_id      = var.grafana_ami_id
  instance_type = var.grafana_instance_type
  key_name    = var.grafana_key_name
  environment = var.environment
}

module "mongodb" {
  source = "./modules/mongodb"
  
  project_name  = var.mongodb_project_name
  atlas_org_id  = var.mongodb_atlas_org_id
  cluster_name  = var.mongodb_cluster_name
  region        = var.aws_region
  db_username   = var.mongodb_username
  db_password   = var.mongodb_password
  database_name = var.mongodb_database_name
}

module "web_app" {
  source = "./modules/web_app"
  
  app_bucket_name = var.react_app_bucket_name
  environment     = var.environment
}

module "mobile_app" {
  source = "./modules/mobile_app"
  
  app_bucket_name = var.flutter_app_bucket_name
  environment     = var.environment
}

module "backend_api" {
  source = "./modules/backend_api"
  
  api_gateway_name = var.api_gateway_name
  lambda_function_name = var.lambda_function_name
  environment     = var.environment
}
