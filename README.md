Weather Twenty One
-------------------



## C# Hot Reload - Android

1. Switch the `WeatherTwentyOne.csproj` to be `<TargetFramework>net6.0-android</TargetFramework>` (note the non-plural.. I didn't test the plural TargetFrameworks plural yet, not sure if it matters).
2. Create an `Android\AndroidEnvironment.txt` file in the project folder, and add this to the `WeatherTwentyOne.csproj`:
```
<ItemGroup>
  <AndroidEnvironment Include="Android\AndroidEnvironment.xt" />
</ItemGroup>
```
3. In the `Android\AndroidEnvironment.txt` file, add line with the contents: `DOTNET_MODIFIABLE_ASSEMBLIES=Debug`
4. In the `WeatherTwentyOne.csproj` add the property:
```
<PropertyGroup>
  <AndroidUseInterpreter>True</AndroidUseInterpreter>
</PropertyGroup>
```
