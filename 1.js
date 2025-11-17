const http = require('http');
const fs = require('fs');
const path = require('path');
const url = require('url');

const PORT = 55555;
const HOST = '0.0.0.0';

// 创建HTTP服务器
const server = http.createServer((req, res) => {
  // 解析请求的URL
  const parsedUrl = url.parse(req.url);
  let pathname = decodeURIComponent(parsedUrl.pathname);
  
  // 安全考虑：防止路径遍历攻击
  if (pathname.includes('../')) {
    res.statusCode = 400;
    res.end('Invalid path');
    return;
  }
  
  // 获取实际文件系统路径
  const fullPath = path.join("/", pathname);
  
  // 检查路径是否存在
  fs.stat(fullPath, (err, stats) => {
    if (err) {
      res.statusCode = 404;
      res.end('File or directory not found');
      return;
    }
    
    if (stats.isDirectory()) {
      // 读取目录内容
      fs.readdir(fullPath, { withFileTypes: true }, (err, items) => {
        if (err) {
          res.statusCode = 500;
          res.end('Error reading directory');
          return;
        }
        
        // 生成目录列表HTML
        const directoryList = generateDirectoryListing(pathname, items, fullPath);
        res.setHeader('Content-Type', 'text/html; charset=utf-8');
        res.end(directoryList);
      });
    } else {
      // 如果是文件，提供下载
      const fileStream = fs.createReadStream(fullPath);
      fileStream.pipe(res);
    }
  });
});

// 生成目录列表HTML
function generateDirectoryListing(currentPath, items, fullPath) {
  // 排序：目录在前，文件在后
  items.sort((a, b) => {
    if (a.isDirectory() && !b.isDirectory()) return -1;
    if (!a.isDirectory() && b.isDirectory()) return 1;
    return a.name.localeCompare(b.name);
  });
  
  // 构建表格行
  let rows = '';
  
  // 添加父目录链接（如果不是根目录）
  if (currentPath !== '/') {
    const parentPath = path.dirname(currentPath);
    rows += `
      <tr>
        <td><img src="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAIAAACQkWg2AAAACXBIWXMAAAsTAAALEwEAmpwYAAAAB3RJTUUH3gUECiQqKgo9AAAAQklEQVQoz2P4//8/Awy8evUKgziYGMDExIQk9f8/DPz//x9dCkUKRQ+6FIZhGFIYhmFIYRiGIYVhGIYUhgAA9TcKchM4Xj8AAAAASUVORK5CYII=" alt="[DIR]"></td>
        <td><a href="${parentPath === '/' ? '/' : parentPath + '/'}">Parent Directory</a></td>
        <td></td>
        <td></td>
      </tr>
    `;
  }
  
  // 添加文件和目录行
  items.forEach(item => {
    const isDirectory = item.isDirectory();
    const name = item.name;
    const linkPath = path.join(currentPath, name);
    let size = '';
    let lastModified = '';
    
    if (!isDirectory) {
      try {
        const stat = fs.statSync(path.join(fullPath, name));
        size = formatFileSize(stat.size);
        lastModified = formatDate(stat.mtime);
      } catch (e) {
        // 如果无法获取文件信息，显示问号
        size = '?';
        lastModified = '?';
      }
    }
    
    rows += `
      <tr>
        <td><img src="data:image/png;base64,${isDirectory ? 
          'iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAIAAACQkWg2AAAACXBIWXMAAAsTAAALEwEAmpwYAAAAB3RJTUUH3gUECiQqKgo9AAAAQklEQVQoz2P4//8/Awy8evUKgziYGMDExIQk9f8/DPz//x9dCkUKRQ+6FIZhGFIYhmFIYRiGIYVhGIYUhgAA9TcKchM4Xj8AAAAASUVORK5CYII=' : 
          'iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAIAAACQkWg2AAAACXBIWXMAAAsTAAALEwEAmpwYAAAAB3RJTUUH3gUFCQ0UoTSpbwAAAFVJREFUOMtjYKAU+P//PwM6YGRkRJH6////r1+/fv/+/efPn3///iGkYFJMTEzM/8GAmZkZLoWkGQb+/v0Ll0KXQjYMXRbdMAzDMKQwDMOQwjAMQwoArTYO6DaQxZgAAAAASUVORK5CYII='}" alt="${isDirectory ? '[DIR]' : '[FILE]'}"></td>
        <td><a href="${linkPath}${isDirectory ? '/' : ''}">${name}${isDirectory ? '/' : ''}</a></td>
        <td>${isDirectory ? '-' : size}</td>
        <td>${lastModified}</td>
      </tr>
    `;
  });
  
  // 完整的HTML页面
  return `<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 3.2 Final//EN">
<html>
<head>
<title>Index of ${currentPath}</title>
<style>
body {
  font-family: 'Courier New', monospace;
  margin: 20px;
  background-color: #f0f0f0;
}
h1 {
  font-size: 18px;
  color: #333;
  margin-bottom: 20px;
}
table {
  width: 100%;
  border-collapse: collapse;
  background-color: white;
  box-shadow: 0 1px 3px rgba(0,0,0,0.1);
}
th {
  background-color: #e0e0e0;
  text-align: left;
  padding: 8px;
  border-bottom: 2px solid #ccc;
}
td {
  padding: 8px;
  border-bottom: 1px solid #eee;
}
tr:hover {
  background-color: #f5f5f5;
}
a {
  color: #3366cc;
  text-decoration: none;
}
a:hover {
  text-decoration: underline;
}
</style>
</head>
<body>
<h1>Index of ${currentPath}</h1>
<table>
  <thead>
    <tr>
      <th>Type</th>
      <th>Name</th>
      <th>Size</th>
      <th>Last Modified</th>
    </tr>
  </thead>
  <tbody>
    ${rows}
  </tbody>
</table>
</body>
</html>`;
}

// 格式化文件大小
function formatFileSize(bytes) {
  if (bytes === 0) return '0B';
  const k = 1024;
  const sizes = ['B', 'K', 'M', 'G', 'T'];
  const i = Math.floor(Math.log(bytes) / Math.log(k));
  return parseFloat((bytes / Math.pow(k, i)).toFixed(1)) + sizes[i];
}

// 格式化日期
function formatDate(date) {
  const months = ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 
                 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'];
  
  const day = date.getDate();
  const month = months[date.getMonth()];
  const year = date.getFullYear();
  const hours = date.getHours().toString().padStart(2, '0');
  const minutes = date.getMinutes().toString().padStart(2, '0');
  
  return `${day}-${month}-${year} ${hours}:${minutes}`;
}

// 启动服务器
server.listen(PORT, HOST, () => {
  console.log(`Server running at http://${HOST}:${PORT}/`);
});

// 处理优雅关闭
process.on('SIGINT', () => {
  console.log('\nShutting down server...');
  server.close(() => {
    console.log('Server has been stopped.');
    process.exit(0);
  });
});