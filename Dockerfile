FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

COPY . ./

RUN dotnet publish ./DotNet.DockerAction/DotNet.DockerAction.csproj -c Release -o out --no-self-contained

FROM mcr.microsoft.com/dotnet/sdk:8.0

COPY --from=build /out .

ENTRYPOINT [ "dotnet", "/DotNet.DockerAction.dll" ]