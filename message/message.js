var page=1;
var allPage=Math.ceil(number/10);
document.getElementById("i11").innerHTML="共"+number+"条消息";
document.getElementById("i10").innerHTML=page+"/"+allPage;
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
function c4(){
    if(page===allPage){
        alert("");
    }
    else{

    }
}
function c5(){
    if (page===1) {
        alert("");
    } else {
        
    }
}