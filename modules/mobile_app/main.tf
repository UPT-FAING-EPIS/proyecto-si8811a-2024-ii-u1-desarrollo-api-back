resource "aws_s3_bucket" "flutter_app_bucket" {
  bucket = var.app_bucket_name
}

resource "aws_s3_bucket_website_configuration" "flutter_app_website" {
  bucket = aws_s3_bucket.flutter_app_bucket.id

  index_document {
    suffix = "index.html"
  }

  error_document {
    key = "index.html"
  }
}
