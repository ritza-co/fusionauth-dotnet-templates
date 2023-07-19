# FusionAuth Templates for .NET
Quickly create new secured .NET applications with FusionAuth Templates, using the .NET CLI or Visual Studio. The new applications are pre-configured to use FusionAuth for authentication and authorization. Only standard .NET libraries are used for authentication and authorization.

Currently, the following .NET templates are implemented:

* FusionAuth Blazor Server Application
* FusionAuth MVC Application
* FusionAuth Web API Application

## Requirements

* A FusionAuth installation. You can [install FusionAuth locally, or sign up for a hosted account](https://fusionauth.io/docs/v1/tech/installation-guide/).
* .NET Core 7.0 SDK or higher.
* Visual Studio 2022 for Mac, version 17.6 and above (Optional) 
* Visual Studio 2022 for Windows, version 17.6 and above (Optional) 

## Installing the Templates

FusionAuth .NET Templates are available on [NuGet](https://www.nuget.org/packages/FusionAuth.Templates/). You can install them by running the following command in your terminal:

```bash
dotnet new install FusionAuth.Templates::1.0.0
```

When installed successfully, the templates will be available in the .NET CLI and Visual Studio. The installation is the same for both Windows and macOS.

## Using the Templates

### .NET CLI

To create a new project from a template, run the following command:

```bash
dotnet new [template-name] [options]
```

Where `[template-name]` is the name of the template you want to use from one of the following:

- `fusionauthblazorserver` - Creates a new Blazor Server application with FusionAuth authentication and authorization.
- `fusionauthmvcwebapp` - Creates a new MVC application with FusionAuth authentication and authorization.
- `fusionauthwebapi` - Creates a new Web API application with FusionAuth authentication and authorization.

The `[options]` are used to provide your FusionAuth URL and FusionAuth Application ClientID. The following options are available:

- `--issuer`. The fully qualified URL to your FusionAuth server. The default value is `http://localhost:9011`.
- `--client-id`. The [client id](/docs/v1/tech/core-concepts/applications) associated with your application. The default value is `3c219e58-ed0e-4b18-ad48-f4f92793ae32`.

### Visual Studio for Mac

FusionAuth .NET Templates requires Visual Studio for Mac version 17.6 or higher. 

To create a new project from a template, first create or open a Solution. Then select `File > New Project`. In the `New Project` dialog, select `Custom` from the left-hand menu.Then select the FusionAuth template you want to use and  click `Continue`. Fill in the required information, including the fully qualified URL to your FusionAuth server FusionAuth and your FusionAuth Application ClientID and click `Continue`.

Set the project name, and click `Create`.

### Visual Studio for Windows

FusionAuth .NET Templates requires Visual Studio for Windows version 17.6 or higher. 

To create a new project from a template, first create or open a Solution. Then select `File > New Project`. In the `New Project` dialog, select `FusionAuth` from the project types dropdown. Then select the FusionAuth template you want to use. Fill in the required information, including the fully qualified URL to your FusionAuth server FusionAuth and your FusionAuth Application ClientID and click `Continue`.

Set the project name, and click `Create`.

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