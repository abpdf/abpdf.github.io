self.onmessage = function (data2) {
    num=data2.data;
    let result = 1n; // 使用BigInt来处理大整数  
    for (let i = 2n; i <= BigInt(num); i++) {
        result *= i;
        postMessage(i);
    }//计算
    postMessage(result);
}