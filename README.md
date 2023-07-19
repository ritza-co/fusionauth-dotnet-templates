# FusionAuth Templates for .NET
Quickly create new secured .NET applications with FusionAuth Templates, using the .NET CLI or Visual Studio. The new applications are pre-configured to use FusionAuth for authentication and authorization. Only standard .NET libraries are used for authentication and authorization.

## Requirements

* An FusionAuth installation. You can [install FusionAuth locally, or sign up for a hosted account](https://fusionauth.io/docs/v1/tech/installation-guide/).
* .NET Core 7.0 SDK or higher.
* Visual Studio 2022 for Mac, version 17.6 and above (Optional) 
* Visual Studio 2022 for Windows, version 17.6 and above (Optional) 

## Installing

FusionAuth Templates are available on [NuGet](https://www.nuget.org/packages/FusionAuth.Templates/). You can install them by running the following command in your terminal:

```bash
dotnet new install FusionAuth.Templates::1.0.0
```

When installed successfully, the templates will be available in the .NET CLI and Visual Studio. The installation is the same for both Windows and macOS.

## Usage

Currently, the following .NET templates are implemented:

* FusionAuth Blazor Server Application
* FusionAuth MVC Application
* FusionAuth Web API Application

### Building and Installing from source

To build and install the FusionAuth Templates from the source code, follow these steps:

1.[Clone](https://docs.github.com/en/repositories/creating-and-managing-repositories/cloning-a-repository) this repository onto your local machine.

2. Build a NuGet package by executing the following command in the root folder of the project:

   ```bash
   dotnet pack
   ```

   This will create a NuGet package in the `./bin/Debug/` folder.

3. Install the templates by running the following command:

   ```bash
   dotnet new install ./bin/Debug/FusionAuth.Templates.1.0.0.nupkg
   ```

## Uninstalling

You can uninstall the templates using the following command:

   ```bash
   dotnet new uninstall FusionAuth.Templates
   ```
You will need to restart Visual Studio for the changes to take effect.


## License

This project is licensed under the [Apache license](License.txt).