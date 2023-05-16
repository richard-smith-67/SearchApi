# Full Text Search API

This is a simple .NET API that implements a full-text search on name and email. This is based on a simple array of test data in json format which includes these properties. The test data is hardcoded into the api but could easily be swapped out for a real persistent storage.  It's designed to work with a Vue.js frontend application. The API runs on port 5288 and the Vue.js application is hardcoded to query this endpoint.

## Prerequisites

1. [.NET Core 7.0](https://dotnet.microsoft.com/download) or later
2. An IDE like [Visual Studio](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)

## Running the API

1. Clone the repository to your local machine.

2. Navigate to the root directory of the project in the terminal.

3. Run the following command to restore the necessary packages:

```
dotnet restore
```

4. To start the API, run the following command:

```
dotnet run
```

The API should start and be listening on `http://localhost:5288`.

## Testing the API

You can test the API using a tool such as Postman or by running the provided Vue.js frontend application.

The Vue.js app is located here: https://github.com/richard-smith-67/searchapiapp

## Connecting to the Vue.js Frontend

Ensure that the Vue.js application is configured to query the API at `http://localhost:5288`. The endpoint can be found in SearchComponent.vue. If you need to change the port that the API is listening on, make sure to update the Vue.js application accordingly. 

For details on how to run the Vue.js application, refer to its respective README file.
