<<<<<<< HEAD
using ALObjectParser.Library;
using System.Text.Json;
using System.Linq;
=======
<Project Sdk="Microsoft.NET.Sdk">
>>>>>>> 17e8402e293417c4e5d4fc948ef6ac3b25b49256

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net7.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
    <LangVersion>latest</LangVersion>
  </PropertyGroup>

  <ItemGroup>
    <!-- Include all .cs files under parent folder (ALObjectParser) recursively -->
    <Compile Include="..\**\*.cs" Exclude="**\bin\**;**\obj\**" />
  </ItemGroup>

<<<<<<< HEAD
var results = objects
    .SelectMany(obj => obj.Methods ?? new List<ALObjectParser.Library.Models.ALMethod>())
    .Where(method => method.Name.Contains(query, System.StringComparison.OrdinalIgnoreCase))
    .Select(m => new {
        Object = m.Parent?.Name,
        Method = m.Name,
        m.Summary
    });

Console.WriteLine(JsonSerializer.Serialize(results));
=======
</Project>
>>>>>>> 17e8402e293417c4e5d4fc948ef6ac3b25b49256
