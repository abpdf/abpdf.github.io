const http = require('http');
const https = require('https');
const net = require('net');
const url = require('url');

class ProxyServer {
    constructor() {
        this.start();
    }

    start() {
        const server = http.createServer();
        
        server.on('request', this.handleHttpRequest.bind(this));
        server.on('connect', this.handleHttpsRequest.bind(this));
        
        server.listen(55554, () => {
            console.log('HTTP/HTTPS 代理服务器运行在端口 55554');
        });
    }

    handleHttpRequest(clientReq, clientRes) {
        console.log(`HTTP 请求: ${clientReq.method} ${clientReq.url}`);
        
        const parsedUrl = url.parse(clientReq.url);
        const options = {
            hostname: parsedUrl.hostname,
            port: parsedUrl.port || 80,
            path: parsedUrl.path,
            method: clientReq.method,
            headers: { ...clientReq.headers }
        };

        const proxyReq = http.request(options, (proxyRes) => {
            clientRes.writeHead(proxyRes.statusCode, proxyRes.headers);
            proxyRes.pipe(clientRes);
        });

        proxyReq.on('error', (err) => {
            console.error('HTTP 代理错误:', err);
            clientRes.writeHead(500);
            clientRes.end('代理服务器错误');
        });

        clientReq.pipe(proxyReq);
    }

    handleHttpsRequest(req, clientSocket, head) {
        const { port, hostname } = url.parse(`//${req.url}`, false, true);
        
        console.log(`HTTPS 连接: ${hostname}:${port}`);
        
        const serverSocket = net.connect(port || 443, hostname, () => {
            clientSocket.write('HTTP/1.1 200 Connection Established\r\n\r\n');
            serverSocket.write(head);
            
            serverSocket.pipe(clientSocket);
            clientSocket.pipe(serverSocket);
        });

        serverSocket.on('error', (err) => {
            console.error('HTTPS 代理错误:', err);
            clientSocket.end();
        });

        clientSocket.on('error', (err) => {
            console.error('客户端连接错误:', err);
            serverSocket.end();
        });
    }
}

// 启动代理服务器
new ProxyServer();