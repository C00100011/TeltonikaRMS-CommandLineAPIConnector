# Teltonika RMS API for C# .NET
TeltonikaRMSAPI for C# .NET, easily consume Teltonika's RMS Service in your code.

## Installation
Import package into you project by executing the following command
`dotnet add PROJECT package TeltonikaRMSAPI --version 1.0.0`

## Usage
1. Initialize the libary with `var client = new TeltonikaRMSAPI.Devices();`
2. Get your token (which you can get from Teltonika's RMS Site)
3. Initialize your token in the `client` with `client.token = "your token";`
4. Make use of the services within `client`

All methods can be consumed as async.

## Author
Gideon van de Laar
