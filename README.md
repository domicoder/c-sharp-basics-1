# Assignment - C# Basics

## Instructions

-   We are using Visual Studio Code to develop this project.
-   We are using .NET Core 8.0 SDK.
-   We are using C# 8.0 language.
-   We are using the latest version of Visual Studio Code.

## Instalation

-   Install Visual Studio Code
-   Install .NET Core SDK 8.0
-   Install C# 8.0 language
-   Install the latest version of Visual Studio Code

#### Windows

-   Download the .NET SDK installer from the [.NET download page](https://dotnet.microsoft.com/download).
-   Verify Installation.

```powershell
dotnet --version
```

#### MacOS

```bash
brew install --cask dotnet-sdk8-0
```

#### Linux

```bash
sudo apt-get update
sudo apt-get install -y apt-transport-https
sudo apt-get update
sudo apt-get install -y dotnet-sdk-8.0
```

## Start project

```bash
# build first
dotnet build

# run
dotnet run

# Publish the project
dotnet publish -c Release -o ./publish
```

## Exercise 1

-   Make a program that allows to capture your First Name, Last Name, Age, and create 3 constants with values of 50,
    33.2, "Alpha Prime" and display it by screen
