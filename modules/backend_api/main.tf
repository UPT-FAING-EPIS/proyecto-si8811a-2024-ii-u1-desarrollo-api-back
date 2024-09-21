resource "aws_apigatewayv2_api" "backend_api" {
  name          = var.api_gateway_name
  protocol_type = "HTTP"
}

resource "aws_apigatewayv2_stage" "backend_api" {
  api_id = aws_apigatewayv2_api.backend_api.id
  name   = "$default"
  auto_deploy = true
}

resource "aws_apigatewayv2_route" "backend_api" {
  api_id    = aws_apigatewayv2_api.backend_api.id
  route_key = "ANY /{proxy+}"
  target    = "integrations/${aws_apigatewayv2_integration.backend_api.id}"
}

resource "aws_apigatewayv2_integration" "backend_api" {
  api_id           = aws_apigatewayv2_api.backend_api.id
  integration_type = "HTTP_PROXY"
  
  integration_uri  = "https://your-backend-url.com"
  integration_method = "ANY"  # or specific HTTP method
}