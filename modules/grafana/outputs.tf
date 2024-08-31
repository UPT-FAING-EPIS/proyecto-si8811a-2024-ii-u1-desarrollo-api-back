output "grafana_public_ip" {
  value = aws_instance.grafana_server.public_ip
}

output "grafana_url" {
  value = "http://${aws_instance.grafana_server.public_ip}:3000"
}