# Full Text Search API

This is a simple .NET API that implements a full-text search. It's designed to work with a Vue.js frontend application. The API runs on port 5288 and the Vue.js application is hardcoded to query this endpoint.

## Prerequisites

1. [.NET Core 5.0](https://dotnet.microsoft.com/download) or later
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

## Connecting to the Vue.js Frontend

Ensure that the Vue.js application is configured to query the API at `http://localhost:5288`. If you need to change the port that the API is listening on, make sure to update the Vue.js application accordingly. 

For details on how to run the Vue.js application, refer to its respective README file.

## Contributing

Contributions are welcome. Please fork the repository and create a pull request with your changes.

## License

This project is licensed under the MIT License. See the LICENSE file for details.
