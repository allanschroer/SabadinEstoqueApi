#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["SabadinEstoqueApi/SabadinEstoqueApi.csproj", "SabadinEstoqueApi/"]
COPY ["SabadinEstoqueApi.Aplicacao/SabadinEstoqueApi.Aplicacao.csproj", "SabadinEstoqueApi.Aplicacao/"]
COPY ["SabadinEstoqueApi.Dominio/SabadinEstoqueApi.Dominio.csproj", "SabadinEstoqueApi.Dominio/"]
COPY ["SabadinEstoqueApi.Infra/SabadinEstoqueApi.Infra.csproj", "SabadinEstoqueApi.Infra/"]
RUN dotnet restore "SabadinEstoqueApi/SabadinEstoqueApi.csproj"
COPY . .
WORKDIR "/src/SabadinEstoqueApi"
RUN dotnet build "SabadinEstoqueApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SabadinEstoqueApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SabadinEstoqueApi.dll"]