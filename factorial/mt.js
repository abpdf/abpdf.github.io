worker.onmessage = function (number1) { 

   var i;
   var g;
   var h;
   var number2 = new Array();
   number2[0] = 1;
   if (number1 < 0) {
      alert("请输入一个正数");
   } else {
      if ((number1 % 1) != 0) {
         alert("请输入一个整数");
      } else {
         var a = Date.now();
         for (i = 1; i <= number1; i++) {
            for (g = 0; g < number2.length; g++) {
               number2[g] = number2[g] * i;
            }
            for (h = 0; h < number2.length; h++) {
               while (number2[h] >= 1000) {
                  if (number2[h + 1] === undefined) {
                     number2[h + 1] = 0
                  }
                  number2[h + 1] = number2[h + 1] + 1;
                  number2[h] = number2[h] - 1000;
               }
            }
         }
         document.write("<p style='word-break: break-all'>" + number1 + "!=");
         document.write(number2[number2.length - 1]);
         for (i = number2.length - 2; i >= 0; i = i - 1) {
            if (number2[i] >= 100) {
               document.write(number2[i]);
            }
            else {
               if (number2[i] >= 10) {
                  document.write("0" + number2[i]);
               }
               else {
                  document.write("00" + number2[i]);
               }
            }
         }
         document.write("</p>");
         var b = Date.now();
         alert("计算成功，共用时" + ((b - a) / 1000) + "秒");
      }
   }
}