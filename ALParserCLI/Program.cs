using ALObjectParser.Library;
using System.Text.Json;
using System.Linq;

string path = args.FirstOrDefault(a => a.StartsWith("--path="))?.Split("=")[1] ?? ".";
string query = args.FirstOrDefault(a => a.StartsWith("--query="))?.Split("=")[1] ?? "";

var objects = ALObjectReaderNew.ParseFolder(path);

var results = objects
    .SelectMany(obj => obj.Methods ?? new List<ALObjectParser.Library.Models.ALMethod>())
    .Where(method => method.Name.Contains(query, System.StringComparison.OrdinalIgnoreCase))
    .Select(m => new {
        Object = m.Parent?.Name,
        Method = m.Name,
        m.Summary
    });

Console.WriteLine(JsonSerializer.Serialize(results));
