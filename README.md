# Number Tool Kit ➕➖➗
A .NET CLI tool that displays detailed information about a given number.

## Features
- Terminal UI with Spectre.Console
- Analyze numeric properties

## Dependencies:
- .NET 9 SDK
- git (for cloning the repository)

## How to use:
### Quick Start:
Clone the repository with this command:
`git clone https://github.com/terra2o/ntk`
Enter the project folder.
`cd ntk`
Run it with:
`dotnet run`

### Install as a global tool:
`dotnet pack -c Release` when you're in the project folder. (e.g. user/ntk/)
This will create a `bin/Release/` folder inside the project with a `.nupkg` inside it.
Install that with this command:
`dotnet tool install NumberToolKit -g --add-source bin/Release`

## TODO
- [ ] More information for the entered number.
- [x] Spectre.Console OR terminal.GUI GUI.

## Contribution
Pull requests are welcome ❤❤.
