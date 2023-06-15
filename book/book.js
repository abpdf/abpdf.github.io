number=134;
var page=1;
var allPage=Math.ceil(number/10);
var loaf=number;
document.getElementById("i11").innerHTML="共"+number+"条消息";
document.getElementById("i10").innerHTML=page+"/"+allPage;
for( var member=0;member<10;member=member+1){
    if(loaf>0){
        document.getElementById("i"+member).src="https://book.pep.com.cn/1441001121191/files/mobile/"+loaf+".jpg";
        document.getElementById("i"+member).className="";
    }
    else{
        document.getElementById("i"+member).className="hidden";
    }
    loaf=loaf-1;
}
function c4(){
    if (page===1) {
        alert("已是第一页");
    }
    else {
        loaf=loaf+20;
        page=page-1;
        for( var member=0;member<10;member=member+1){
            if(loaf>0){
                document.getElementById("i"+member).src="https://book.pep.com.cn/1441001121191/files/mobile/"+loaf+".jpg";
                document.getElementById("i"+member).className="";
            }
            else{
                document.getElementById("i"+member).className="hidden";
            }
            loaf=loaf-1;
        }
        document.getElementById("i10").innerHTML=page+"/"+allPage;
    }
}
function c5(){
    if(page===allPage){
        alert("已是最后一页");
    }
    else{
        loaf=loaf;
        page=page+1;
        for( var member=0;member<10;member=member+1){
        if(loaf>0){
            document.getElementById("i"+member).src="https://book.pep.com.cn/1441001121191/files/mobile/"+loaf+".jpg";
            document.getElementById("i"+member).className="";
        }
        else{
            document.getElementById("i"+member).className="hidden";
        }
        loaf=loaf-1;
    }
    document.getElementById("i10").innerHTML=page+"/"+allPage;
    }
}