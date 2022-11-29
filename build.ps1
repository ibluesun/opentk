# Install .NET Core (https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-install-script)

[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12;

&(
    [scriptblock]::Create((Invoke-WebRequest -useb 'https://dot.net/v1/dotnet-install.ps1'))
) -Channel 6.0

$env:PATH += ";%LOCALAPPDATA%\Microsoft\dotnet"
dotnet tool restore
dotnet paket restore
dotnet fake run build.fsx $args