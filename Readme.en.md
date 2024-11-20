![Total Visitors](https://komarev.com/ghpvc/?username=aron-666blockmeshminer&color=green)

[![en](https://img.shields.io/badge/lang-en-red.svg)](https://github.com/aron-666/Aron.BlockMeshMiner/blob/master/README.en.md)
[![中文](https://img.shields.io/badge/lang-中文-blue.svg)](https://github.com/aron-666/Aron.BlockMeshMiner)

# Aron.BlockMeshMiner
Written in .Net 8

## If you find it useful, support me by using my referral code: c7a6c248-f315-4401-acb1-163fe25a1375
[Register Now at app.blockmesh.xyz](https://app.blockmesh.xyz/register?invite_code=c7a6c248-f315-4401-acb1-163fe25a1375)


## Execution Screenshots
1. Login
![image](https://github.com/aron-666/Aron.BlockMeshMiner/blob/master/%E6%88%AA%E5%9C%96/%E5%BE%8C%E8%87%BA%E7%99%BB%E5%85%A5%E7%95%AB%E9%9D%A2.png?raw=true)

2. Mining Information
![image](https://github.com/aron-666/Aron.BlockMeshMiner/blob/master/%E6%88%AA%E5%9C%96/%E6%8C%96%E7%A4%A6%E7%95%AB%E9%9D%A2.png?raw=true)

## 1. Docker Installation
1. Install Docker
   - Windows: [Docker Desktop](https://www.docker.com/products/docker-desktop/)
   - Linux: If you're using Linux, you probably know how to do this already.

2. Edit docker-compose.yml (In the docker-install folder of the source code)
   ```
   version: '1'
   services:
      blockmesh:
         image: aron666/blockmesh
         environment:
            - BM_EMAIL=email
            - BM_PASS=password
            - ADMIN_USER=admin
            - ADMIN_PASS=admin
            - PROXY_ENABLE=false / true
            - PROXY_HOST=http(s)://host:port
            - PROXY_USER=user
            - PROXY_PASS=pass
         ports:
            - 5004:50004
   ```

   - Port 5004 will open a port on your computer. Open firewall port 5004 for LAN access.

3. Execute
   ```
   //cmd, navigate to the directory first (docker-install)
   docker compose up -d
   or
   docker-compose up -d
   ```
   Then, you can check the backend status using the following URLs:

   - Local: [http://localhost:5004](http://localhost:5004)
   - Other devices: Open cmd and type `ipconfig`/`ifconfig` to find your LAN IP, then access [http://IP:5004](http://IP:5004)
     - The process continues even if the webpage is closed.
     - For Windows auto-start, adjust settings in Docker Desktop.

