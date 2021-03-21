function createDiv (){
    
}

var faktorialis = function(n){
    let er=1;
for (let i = 2; i< n; i++) {
    er=er*i
}
return er;
}

function szamitas(){
    let n=document.getElementById("nTb").value;
    let er=faktorialis(n);
    document.getElementById("pascal").innerText=er;
}

function pascal(){
    let hova = document.getElementById("pascal");
    for (let i = 0; i < 10; i++) {
        var sor=document.createElement('div');
        sor.classList.add("sor")
        hova.appendChild(sor);
        
        for (let j = 1; j < 10; j++) {
        var szam = document.createElement("div");
        szam.classList.add("elem")
        szam.innerText=i*j
        sor.appendChild(szam);


            
        }
    }
}

