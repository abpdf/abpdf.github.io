self.onmessage = function (number1) {
   var i;
   var g;
   var h;
   var number2 = new Array();
   number2[0] = 1;
   if (number1 >= 0 && (number1 % 1) === 0) {
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
   }
   postMessage(number2);
}