# Overview

The project is a game based on the popular franchise, Pokemon. The project involved using mechanics found in the actual Pokemon games. You can catch and sell Pokemon. You can complete the PokeDex and explore many wild areas.

# Building and Running
## Run Using Visual Studio
1. Clone or download this repository.

2. Navigate to the project folder.

3. Open the .sln solution file in Visual Studio.

4. Wait for NuGet packages to restore.

5. In Solution Explorer, right-click the main project and select Set as Startup Project.

6. Select the desired launch profile (HTTP or HTTPS).

7. Click the green Start button or press F5 to build and run the application.

## Building from source
You'll need the .NET 10 SDK for your platform [here](https://dotnet.microsoft.com/en-us/)

Open the terminal in the root of the project and type this in:

`dotnet run --project PokemonCatch/PokemonCatch.csproj`

You will see the address and port for the running application after it builds and starts to run. Open a browser and navigate to that address.
