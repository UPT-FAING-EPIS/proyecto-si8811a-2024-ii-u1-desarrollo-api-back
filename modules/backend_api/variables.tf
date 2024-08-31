variable "lambda_function_name" {
  description = "Name of the Lambda function for the backend API"
  type        = string
}

variable "api_gateway_name" {
  description = "Name of the API Gateway"
  type        = string
}

variable "environment" {
  description = "Deployment environment"
  type        = string
}