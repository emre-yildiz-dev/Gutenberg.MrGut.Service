FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/GutenBerg.MrGut.Web.Host/GutenBerg.MrGut.Web.Host.csproj", "src/GutenBerg.MrGut.Web.Host/"]
COPY ["src/GutenBerg.MrGut.Web.Core/GutenBerg.MrGut.Web.Core.csproj", "src/GutenBerg.MrGut.Web.Core/"]
COPY ["src/GutenBerg.MrGut.Application/GutenBerg.MrGut.Application.csproj", "src/GutenBerg.MrGut.Application/"]
COPY ["src/GutenBerg.MrGut.Core/GutenBerg.MrGut.Core.csproj", "src/GutenBerg.MrGut.Core/"]
COPY ["src/GutenBerg.MrGut.EntityFrameworkCore/GutenBerg.MrGut.EntityFrameworkCore.csproj", "src/GutenBerg.MrGut.EntityFrameworkCore/"]
WORKDIR "/src/src/GutenBerg.MrGut.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/GutenBerg.MrGut.Web.Host", "src/GutenBerg.MrGut.Web.Host"]
COPY ["src/GutenBerg.MrGut.Web.Core", "src/GutenBerg.MrGut.Web.Core"]
COPY ["src/GutenBerg.MrGut.Application", "src/GutenBerg.MrGut.Application"]
COPY ["src/GutenBerg.MrGut.Core", "src/GutenBerg.MrGut.Core"]
COPY ["src/GutenBerg.MrGut.EntityFrameworkCore", "src/GutenBerg.MrGut.EntityFrameworkCore"]
WORKDIR "/src/src/GutenBerg.MrGut.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "GutenBerg.MrGut.Web.Host.dll"]
