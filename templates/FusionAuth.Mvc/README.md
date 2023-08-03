# FusionAuth .NET MVC Web Application Template Project

This .NET MVC Web Application project is set up to use [FusionAuth](https://fusionauth.io) as an OAuth 2.0 and OpenID Connect authentication provider.

## FusionAuth Setup

To use this project with FusionAuth, you will need to setup a FusionAuth application with the following settings:

- The OAuth Authorization Grant Types should be `Authorization Code` and `Refresh Token`.
- PKCE (Proof Key for Code Exchange) is required.
- JWT (JSON Web Token) must be enabled, using a newly generated asymmetric key pair (RSA).


To help you set a valid application up, we have created a .NET FusionAuth set up script, available on [github](https://github.com/FusionAuth/fusionauth-example-client-libraries/tree/main/dotnet).

Follow the instructions in the Github repo to set up FusionAuth for your project.

Note that it is likely that the port settings for the `Authorized URL` and `Logout URL` will need to be changed in the setup script to match the port your project is running on.

## Links

Keep up to date with .NET FusionAuth client libraries and templates at check out the [FusionAuth for .NET guide](https://fusionauth.io/docs/v1/tech/client-libraries/netcore).