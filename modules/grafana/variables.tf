variable "ami_id" {
  description = "AMI ID for Grafana server"
  type        = string
}

variable "instance_type" {
  description = "Instance type for Grafana server"
  type        = string
  default     = "t2.micro"
}

variable "key_name" {
  description = "Key pair name for SSH access"
  type        = string
}

variable "environment" {
  description = "Deployment environment"
  type        = string
}