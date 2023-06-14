var allPage=Math.ceil(number/10);
for( var member=0;member<10;member=member+1){
    if(number>0){
        document.getElementById("i"+member).src="message/"+number+".html";
        document.getElementById("i"+member).className="";
    }
    else{
        document.getElementById("i"+member).className="hidden";
    }
    number=number-1;
}