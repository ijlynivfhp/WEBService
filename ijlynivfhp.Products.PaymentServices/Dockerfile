#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["ijlynivfhp.Products.PaymentServices/ijlynivfhp.Projects.PaymentServices.csproj", "ijlynivfhp.Products.PaymentServices/"]
COPY ["ijlynivfhp.Projects.Cores/ijlynivfhp.Projects.Cores.csproj", "ijlynivfhp.Projects.Cores/"]
COPY ["ijlynivfhp.Projects.Commons/ijlynivfhp.Projects.Commons.csproj", "ijlynivfhp.Projects.Commons/"]
RUN dotnet restore "ijlynivfhp.Products.PaymentServices/ijlynivfhp.Projects.PaymentServices.csproj"
COPY . .
WORKDIR "/src/ijlynivfhp.Products.PaymentServices"
RUN dotnet build "ijlynivfhp.Projects.PaymentServices.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ijlynivfhp.Projects.PaymentServices.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ijlynivfhp.Projects.PaymentServices.dll"]