FROM mcr.microsoft.com/dotnet/core/sdk:3.1.101 AS build
WORKDIR /app
EXPOSE 5000
EXPOSE 5001

WORKDIR /app/Zenxu.Data
COPY Zenxu.Data/*csproj .

COPY Zenxu.Data/ .

WORKDIR /app/zenxu
COPY zenxu/*csproj .
RUN dotnet restore

COPY zenxu/ .

RUN dotnet publish -c Release -o out


#Build runtime image
FROM mcr.microsoft.com/dotnet/core/sdk:3.1.101
WORKDIR /app
COPY --from=build /app/zenxu/out .
ENTRYPOINT [ "dotnet", "zenxu.dll" ]