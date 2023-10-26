using System.Text;
using Jering.Javascript.NodeJS;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

var services = new ServiceCollection();
services.AddNodeJS();
services.AddLogging((ILoggingBuilder loggingBuilder) =>
{
  loggingBuilder.AddConsole();
});
ServiceProvider serviceProvider = services.BuildServiceProvider();
INodeJSService nodeJSService = serviceProvider.GetRequiredService<INodeJSService>();

var rules = @"[{
  ""conditions"": {
    ""any"": [
      {
        ""all"": [
          {
            ""fact"": ""gameDuration"",
            ""operator"": ""equal"",
            ""value"": 40
          },
          {
            ""fact"": ""personalFoulCount"",
            ""operator"": ""greaterThanInclusive"",
            ""value"": 5
          }
        ]
      },
      {
        ""all"": [
          {
            ""fact"": ""gameDuration"",
            ""operator"": ""equal"",
            ""value"": 48
          },
          {
            ""fact"": ""personalFoulCount"",
            ""operator"": ""greaterThanInclusive"",
            ""value"": 6
          }
        ]
      }
    ]
  },
  ""event"": {
    ""type"": ""fouledOut"",
    ""params"": {
      ""message"": ""Player has fouled out!""
    }
  }
}]";

var facts = @"{
  ""personalFoulCount"": 6,
  ""gameDuration"": 40
}";
Console.WriteLine($"rules = {rules}");

EngineResult? result = await nodeJSService.InvokeFromFileAsync<EngineResult>("engine.js", "getEngineResult", args: new[] { Utf16ToUtf8(rules), Utf16ToUtf8(facts) });
Console.WriteLine(result?.Result);

static string Utf16ToUtf8(string utf16String)
{
  // Get UTF16 bytes and convert UTF16 bytes to UTF8 bytes
  byte[] utf16Bytes = Encoding.Unicode.GetBytes(utf16String);
  byte[] utf8Bytes = Encoding.Convert(Encoding.Unicode, Encoding.UTF8, utf16Bytes);

  // Return UTF8 bytes as ANSI string
  return Encoding.Default.GetString(utf8Bytes);
}