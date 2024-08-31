resource "aws_instance" "grafana_server" {
  ami           = var.ami_id
  instance_type = var.instance_type
  key_name      = var.key_name

  tags = {
    Name = "grafana-server"
    Environment = var.environment
  }

  user_data = <<-EOF
              #!/bin/bash
              sudo apt-get update
              sudo apt-get install -y apt-transport-https software-properties-common
              sudo add-apt-repository "deb https://packages.grafana.com/oss/deb stable main"
              wget -q -O - https://packages.grafana.com/gpg.key | sudo apt-key add -
              sudo apt-get update
              sudo apt-get install -y grafana
              sudo systemctl enable grafana-server
              sudo systemctl start grafana-server
              EOF
}

resource "aws_security_group" "grafana_sg" {
  name        = "grafana-security-group"
  description = "Security group for Grafana server"

  ingress {
    from_port   = 3000
    to_port     = 3000
    protocol    = "tcp"
    cidr_blocks = ["0.0.0.0/0"]
  }

  egress {
    from_port   = 0
    to_port     = 0
    protocol    = "-1"
    cidr_blocks = ["0.0.0.0/0"]
  }

  tags = {
    Name = "grafana-sg"
    Environment = var.environment
  }
}