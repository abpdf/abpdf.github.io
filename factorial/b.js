self.onmessage = function (data2) {
    function a1 () {
        postMessage(i);
    }
    setInterval(a1 (), 500);
    num=data2.data;
    let result = 1n; // 使用BigInt来处理大整数
    var i;
    for (i = 2n; i <= BigInt(num); i++) {
        result *= i;
    }//计算
    postMessage(result);
}