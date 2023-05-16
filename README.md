# Full Text Search API

This is a simple .NET API that implements a full-text search on name and email. This depends upon a simple array of test data in json format which includes these properties. The test data is hardcoded into the api but persistent storage could easily be implemented. The API runs on port 5288 and the Vue.js application is hardcoded to query this endpoint.

## Prerequisites

1. [.NET Core 7.0](https://dotnet.microsoft.com/download) or later
2. An IDE like [Visual Studio](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)

## Running the API

1. Clone the repository to your local machine.

2. Navigate to the project directory cd SearchApi/SearchApi

3. Run the following command to restore the necessary packages:

```
dotnet restore
```

4. To start the API, run the following command:

```
dotnet run
```

The API should start and be listening on `http://localhost:5288`.

The swagger end point is here `http://localhost:5288/swagger/index.html`.

## Testing the API

You can test the API using Swagger (by default), Postman, or by running the provided Vue.js frontend application.

The Vue.js app is located here: https://github.com/richard-smith-67/searchapiapp

## Connecting to the Vue.js Frontend

The Vue.js app is hardcoded to query `http://localhost:5288`, but this can be modified manually in SearchComponent.vue if necessary. If you need to change the port that the API is listening on, make sure to update the Vue.js application accordingly. 

For details on how to run the Vue.js application, refer to its respective README file.
