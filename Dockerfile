FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS builder
WORKDIR /app


COPY ./src ./
RUN dotnet publish -c Release -o /app/out API/AT.DynamicAssessment.Api/AT.DynamicAssessment.Api.csproj

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine

WORKDIR /app
COPY --from=builder /app/out .
ENTRYPOINT ["dotnet", "AT.DynamicAssessment.Api.dll"]
