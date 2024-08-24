[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/vK6WBQ1t)
[![Open in Codespaces](https://classroom.github.com/assets/launch-codespace-2972f46106e565e64193e422d61a12cf1da4916b45550586e14ef0a7c637dd04.svg)](https://classroom.github.com/open-in-codespaces?assignment_repo_id=15560937)

###Este archivo main.tf incluye:
Configuración del proveedor Azure.
Un grupo de recursos.
Dos APIs como contenedores con sus respectivos App Services y Container Registry.
Dos bases de datos MongoDB en Cosmos DB.
Un frontend React como contenedor con su propio App Service y Container Registry.
Outputs para las URLs de las APIs y el frontend, así como las cadenas de conexión de las bases de datos.

###Los placeholders que necesitas reemplazar son:
#{RESOURCE_GROUP_NAME}
#{AZURE_REGION}
#{API_ACR_NAME}
#{API_APP_SERVICE_PLAN_NAME}
#{API1_APP_NAME}
#{API1_DOCKER_IMAGE}
#{API1_DOCKER_IMAGE_TAG}
#{API2_APP_NAME}
#{API2_DOCKER_IMAGE}
#{API2_DOCKER_IMAGE_TAG}
#{COSMOSDB_ACCOUNT_NAME_1}
#{MONGODB_NAME_1}
#{COSMOSDB_ACCOUNT_NAME_2}
#{MONGODB_NAME_2}
#{FRONTEND_ACR_NAME}
#{FRONTEND_APP_SERVICE_PLAN_NAME}
#{FRONTEND_APP_NAME}
#{FRONTEND_DOCKER_IMAGE}
#{FRONTEND_DOCKER_IMAGE_TAG}
Asegúrate de que todos los nombres de recursos sean únicos en Azure, especialmente para los Container Registries, App Services y cuentas de Cosmos DB.