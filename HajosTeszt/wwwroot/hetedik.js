var kérdések;
var jelenlegiKérdés=0;

let válasz1=document.getElementById("válasz1");
let válasz2=document.getElementById("válasz2");
let válasz3=document.getElementById("válasz3");

valasz1.addEventListener('click', () => { választVálasz(1, válasz1) });
valasz2.addEventListener('click', () => { választVálasz(2, válasz2) });
valasz3.addEventListener('click', () => { választVálasz(3, válasz3) });


elore.addEventListener('click', () => { kérdésVáltó(1) });
vissza.addEventListener('click', () => { kérdésVáltó(-1) });

function letoltes(){

    fetch('/questions.json')
    .then(Response => Response.json())
    .then(adat=> adatÉrkezett(adat));

}

function adatÉrkezett(adat){

    console.log(`${adat.length} kérdés érketett`);
    letöltésBefejeződött(adat);

}

function letöltésBefejeződött(d){

    console.log('Sikeres letöltés!');
    console.log(d);
    kérdések=d;
}

window.onload(letoltes(),
kérdésMegjelenítés());

function kérdésMegjelenítés(i){

    let kérdés_szöveg = document.getElementById("kérdés_szöveg");
    let kép= document.getElementById("kép1");
    

    kérdés_szöveg.innerText=kérdések[i].questionText;
    válasz1.innerHTML=kérdések[i].answer1;
    válasz2.innerHTML=kérdések[i].answer2;
    válasz3.innerHTML=kérdések[i].answer3;
    
    if(kérdések[i].image !="")
    {
        kép.src="https://szoft1.comeback.hu/hajo/"+kerdesek[i].image
        kép.hidden=false;
    }
    else
    {
        kép.hidden=true;
    }
    
}

function kérdésVáltó(irány) {
    if (irány > 0) {
        if (jelenlegiKerdes + 1 > kerdesek.length - 1) {
            jelenlegiKerdes = 0;
        }
        else {
            jelenlegiKerdes++;
        }
    }
    else {
        if (jelenlegiKerdes - 1 == -1) {
            jelenlegiKerdes = kerdesek.length - 1;
        }
        else {
            jelenlegiKerdes--;
        }
    }
}

function választVálasz(i, btnRef) {
    let jóVálasz = kérdések[jelenlegiKérdés].correctAnswer;
    if (jóValasz == i) {
        btnRef.classList.add("jo");
    }
    else {
        btnRef.classList.add("rossz")
    }
}   
