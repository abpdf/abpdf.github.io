function a1() {
    var a = Date.now();
    var b = 1681131049000;
    var c = (a - b) / 1000;
    var year = Math.floor(c / 31536000);
    var day = Math.floor((c - year * 31536000) / 86400);
    var hour = Math.floor((c - year * 31536000 - day * 86400) / 3600);
    var min = Math.floor((c - year * 31536000 - day * 86400 - hour * 3600) / 60);
    var s = Math.floor((c - year * 31536000 - day * 86400 - hour * 3600 - min * 60) * 1000) / 1000;
    var year1 = Math.floor(year / 10);
    var year2 = year - year1 * 10;
    var day1 = Math.floor(day / 100);
    var day2 = Math.floor((day - day1 * 100) / 10);
    var day3 = day - day1 * 100 - day2 * 10;
    var hour1 = Math.floor(hour / 10);
    var hour2 = hour - hour1 * 10;
    var min1 = Math.floor(min / 10);
    var min2 = min - min1 * 10;
    var s1 = Math.floor(s / 10);
    var s2 = Math.floor(s - s1 * 10);
    document.getElementById("c1").src = "number/" + year1 + ".svg";
    document.getElementById("c2").src = "number/" + year2 + ".svg";
    document.getElementById("c3").src = "number/" + day1 + ".svg";
    document.getElementById("c4").src = "number/" + day2 + ".svg";
    document.getElementById("c5").src = "number/" + day3 + ".svg";
    document.getElementById("c6").src = "number/" + hour1 + ".svg";
    document.getElementById("c7").src = "number/" + hour2 + ".svg";
    document.getElementById("c8").src = "number/" + min1 + ".svg";
    document.getElementById("c9").src = "number/" + min2 + ".svg";
    document.getElementById("c10").src = "number/" + s1 + ".svg";
    document.getElementById("c11").src = "number/" + s2 + ".svg";
}