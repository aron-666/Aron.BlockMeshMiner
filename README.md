![Total Visitors](https://komarev.com/ghpvc/?username=aron-666blockmeshminer&color=green)

[![en](https://img.shields.io/badge/lang-en-red.svg)](https://github.com/aron-666/Aron.BlockMeshMiner/blob/master/Readme.en.md)
[![中文](https://img.shields.io/badge/lang-中文-blue.svg)](https://github.com/aron-666/Aron.BlockMeshMiner)

# Aron.BlockMeshMiner 
使用.Net 8撰寫


## 好用請支持，使用我的推薦碼註冊: c7a6c248-f315-4401-acb1-163fe25a1375
[立即註冊 app.blockmesh.xyz](https://app.blockmesh.xyz/register?invite_code=c7a6c248-f315-4401-acb1-163fe25a1375)


## 執行畫面
1. 登入
![image](https://github.com/aron-666/Aron.BlockMeshMiner/blob/master/%E6%88%AA%E5%9C%96/%E5%BE%8C%E8%87%BA%E7%99%BB%E5%85%A5%E7%95%AB%E9%9D%A2.png?raw=true)

2. 挖礦資訊
![image](https://github.com/aron-666/Aron.BlockMeshMiner/blob/master/%E6%88%AA%E5%9C%96/%E6%8C%96%E7%A4%A6%E7%95%AB%E9%9D%A2.png?raw=true)

## 1. Docker 安裝
1. 安裝 Docker
   - Windows: [Docker Desktop](https://www.docker.com/products/docker-desktop/)
   - Linux: 你都會用Linux了還要我教？


2. 編輯 docker-compose.yml (在程式碼的docker-install資料夾內)
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
            - PROXY_ENABLE=true / false
            - PROXY_HOST=http(s)://host:port
            - PROXY_USER=user
            - PROXY_PASS=pass
         ports:
            - 5004:50004
   ```

   - Port 5004 會在你電腦上開一個 Port，要讓區網連請開防火牆 Port 5004

3. 執行
   ```
   //cmd請先 cd 到資料夾目錄(docker-install)
   docker compose up -d
   或
   docker-compose up -d
   ```
   再來就可以用網址看後臺狀態了

   - 本機: [http://localhost:5004](http://localhost:5004)
   - 其他設備: 先開 cmd 打 `ipconfig`/`ifconfig` 找到你的區網 IP [http://IP:5004](http://IP:5004)
     - 關掉網頁還會繼續執行
     - Windows 要開機自動執行要去Docker Desktop設定改


