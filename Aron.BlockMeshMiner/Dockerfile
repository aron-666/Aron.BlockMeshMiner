# 使用較小的基礎映像
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY Aron.BlockMeshMiner.csproj .
RUN dotnet restore "Aron.BlockMeshMiner.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet publish "Aron.BlockMeshMiner.csproj" -c $BUILD_CONFIGURATION -o /app/publish --self-contained -r linux-x64

# 使用較小的運行時基礎映像
FROM debian:bullseye-20240722-slim AS final
EXPOSE 50004/tcp
ENV ASPNETCORE_HTTP_PORTS 50004
WORKDIR /app

RUN apt-get update -y
RUN apt-get install -y wget


RUN apt-get install -y --no-install-recommends \
    curl \
    net-tools \
    iputils-ping \
    ca-certificates \
    chromium \
    && rm -rf /var/lib/apt/lists/*

COPY --from=build /app/publish .
RUN chmod +x Aron.BlockMeshMiner

ENTRYPOINT ["./Aron.BlockMeshMiner"]
