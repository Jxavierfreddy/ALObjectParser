<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net7.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
    <LangVersion>latest</LangVersion>
  </PropertyGroup>

  <ItemGroup>
    <Compile Include="..\ALObjectParser\**\*.cs" Exclude="..\ALObjectParser\**\bin\**;..\ALObjectParser\**\obj\**" />
  </ItemGroup>

</Project>
