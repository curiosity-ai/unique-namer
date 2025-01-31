# UniqueNamer

![NuGet - Version](https://img.shields.io/nuget/v/UniqueNamer?label=version&color=blue)

![cover](images/cover.png)

UniqueNamer is a C# library for generating unique and memorable names (e.g., `talented-toucan`, `naughty-watermelon`). These names are ideal for naming temporary directories, user session IDs, gamer tags, project names, process names, or submitted jobs.

The library is inspired by [aziele/unique-namer](https://github.com/aziele/unique-namer), originally developed by Andrzej Zielezinski. UniqueNamer expands on the concept, offering customizable name generation with a wide variety of thematic categories.

## Features

- Over 17 million unique names
- Nearly infinite unique identifiers with suffix options
- 22 predefined categories
- Customizable output style and formatting

## Installation

UniqueNamer is available as a [NuGet package](https://www.nuget.org/packages/UniqueNamer/). You can install it using the NuGet Package Manager:

```powershell
Install-Package UniqueNamer
```

Or via the .NET CLI:

```bash
dotnet add package UniqueNamer
```

## Usage

### Generating Names

The `Generate` method returns a unique and randomly generated name consisting of an adjective and a noun.

```csharp
using UniqueNamer;

string name = UniqueNamer.Generate(new[] { Categories.Animals });
Console.WriteLine(name); // Example: 'blushy-cyclist'
```

### Customizing Names

#### Choosing Categories

The `Generate` method allows specifying categories to influence the type of generated names:

```csharp
string name = UniqueNamer.Generate(new[] { Categories.Astronomy });
Console.WriteLine(name); // Example: 'crazy-supernova'
```

To select multiple categories:

```csharp
string name = UniqueNamer.Generate(new[] { Categories.Physics, Categories.Biology });
Console.WriteLine(name); // Example: 'pink-bacteria'
```

#### Adding a Unique Suffix

The `suffixLength` parameter adds a random alphanumeric suffix to create a unique identifier:

```csharp
string name = UniqueNamer.Generate(new[] { Categories.History }, suffixLength: 3);
Console.WriteLine(name); // Example: 'annoying-cleopatra-9a1'
```

#### Customizing Separators

Change the separator between name components:

```csharp
string name = UniqueNamer.Generate(new[] { Categories.Sports }, separator: "_");
Console.WriteLine(name); // Example: 'savage_judo'
```

#### Formatting Styles

The `Style` enum lets you choose different text case formats:

```csharp
string name = UniqueNamer.Generate(new[] { Categories.Food }, style: Style.UPPERCASE);
Console.WriteLine(name); // Example: 'DAMAGED-ELECTRON'

string nameTitle = UniqueNamer.Generate(new[] { Categories.Music }, separator: " ", style: Style.TitleCase);
Console.WriteLine(nameTitle); // Example: 'Lazy Unicorn'
```

## Categories

UniqueNamer provides predefined categories to tailor generated names. Some available categories include:

- `Animals`
- `Art`
- `Astronomy`
- `Biology`
- `Chemistry`
- `ComputerScience`
- `Economy`
- `Food`
- `Geography`
- `History`
- `Literature`
- `Math`
- `Medicine`
- `Microbiology`
- `MolecularBiology`
- `Music`
- `Physics`
- `Plants`
- `Scientists`
- `Sports`
- `Technology`

## License

This project is licensed under the MIT License.