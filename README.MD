# To Test

    1. install nodejs on the runner (on your computer if you make a try on it)
    2. perform "npm i" to install packages
    3. perform a dotnet run on the project folder


if all work well, you have to get the following result :

`
info: System.Net.Http.HttpClient.IHttpClientService.ClientHandler[101]
      Received HTTP response headers after 452.3111ms - 200
info: System.Net.Http.HttpClient.IHttpClientService.LogicalHandler[101]
      End processing HTTP request after 480.2497ms - 200
{"almanac":{"factMap":{},"factResultsCache":{},"allowUndefinedFacts":false,"events":{"success":[{"type":"fouledOut","params":{"message":"Player has fouled out!"}}],"failure":[]},"ruleResults":["{\"conditions\":{\"priority\":1,\"any\":[{\"priority\":1,\"all\":[{\"operator\":\"equal\",\"value\":40,\"fact\":\"gameDuration\",\"factResult\":40,\"result\":true},{\"operator\":\"greaterThanInclusive\",\"value\":5,\"fact\":\"personalFoulCount\",\"factResult\":6,\"result\":true}]},{\"priority\":1,\"all\":[{\"operator\":\"equal\",\"value\":48,\"fact\":\"gameDuration\",\"factResult\":40,\"result\":false},{\"operator\":\"greaterThanInclusive\",\"value\":6,\"fact\":\"personalFoulCount\",\"factResult\":6,\"result\":true}]}]},\"event\":{\"type\":\"fouledOut\",\"params\":{\"message\":\"Player has fouled out!\"}},\"priority\":1,\"result\":true}"]},"results":["{\"conditions\":{\"priority\":1,\"any\":[{\"priority\":1,\"all\":[{\"operator\":\"equal\",\"value\":40,\"fact\":\"gameDuration\",\"factResult\":40,\"result\":true},{\"operator\":\"greaterThanInclusive\",\"value\":5,\"fact\":\"personalFoulCount\",\"factResult\":6,\"result\":true}]},{\"priority\":1,\"all\":[{\"operator\":\"equal\",\"value\":48,\"fact\":\"gameDuration\",\"factResult\":40,\"result\":false},{\"operator\":\"greaterThanInclusive\",\"value\":6,\"fact\":\"personalFoulCount\",\"factResult\":6,\"result\":true}]}]},\"event\":{\"type\":\"fouledOut\",\"params\":{\"message\":\"Player has fouled out!\"}},\"priority\":1,\"result\":true}"],"failureResults":[],"events":[{"type":"fouledOut","params":{"message":"Player has fouled out!"}}],"failureEvents":[]}
The program '[20864] net-node-interop.dll' has exited with code 0 (0x0).
`