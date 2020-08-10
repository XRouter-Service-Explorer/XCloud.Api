FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS base
WORKDIR /app
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build
WORKDIR /app

# Copy everything else and build
COPY . ./
RUN dotnet publish XCloud.Api -c Release -o XCloud.Api/out
# Build runtime image

FROM base AS final
COPY --from=build /app/XCloud.Api/out .


ENTRYPOINT ["dotnet", "XCloud.Api.dll"]