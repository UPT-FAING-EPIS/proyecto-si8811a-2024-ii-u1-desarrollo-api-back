# modules/grafana/main.tf

resource "grafana_cloud_stack" "my_stack" {
  name        = "hc2020067571"
  slug        = "hc2020067571"
  region_slug = "us"
}
