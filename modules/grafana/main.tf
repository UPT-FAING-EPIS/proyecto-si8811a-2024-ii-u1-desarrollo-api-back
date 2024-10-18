# modules/grafana/main.tf

resource "grafana_cloud_stack" "my_stack" {
  name        = "hc2020067571"
  slug        = "hc2020067571"
  region_slug = "us"
}

resource "grafana_data_source" "cloudwatch" {
  type = "cloudwatch"
  name = "AWS CloudWatch"
  
  json_data {
    default_region = "us-east-1"
    auth_type      = "credentials"
  }
}

resource "grafana_data_source" "mongodb" {
  type = "mongodb-atlas"
  name = "MongoDB Atlas"
  
  json_data {
    atlas_public_key  = var.mongodb_atlas_public_key
    atlas_private_key = var.mongodb_atlas_private_key
    org_id            = var.mongodb_atlas_org_id
  }
}

resource "grafana_dashboard" "aws_resources" {
  config_json = file("${path.module}/dashboards/aws_resources.json")
}

resource "grafana_dashboard" "mongodb_metrics" {
  config_json = file("${path.module}/dashboards/mongodb_metrics.json")
}

resource "grafana_dashboard" "applications" {
  config_json = file("${path.module}/dashboards/applications.json")
}
