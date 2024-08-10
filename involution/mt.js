var t = 0;
var number1;
var number3;
var number2 = new Array();
self.onmessage = function (data1) {
   t += 1;
   if (t === 1) {
      number1 = data1.data;
   }
   if (t === 2) {
      number3 = data1.data;
      cal();
   }
}
function cal() {
   number2[0] = 1;
   for (i = 1; i <= number3; i++) {
      for (g = 0; g < number2.length; g++) {
         number2[g] = number2[g] * number1;
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
      postMessage(i);
   }
   postMessage(number2);
}