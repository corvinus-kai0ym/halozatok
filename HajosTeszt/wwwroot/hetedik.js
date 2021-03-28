var kérdések;
var jelenlegiKérdés = 0;

function letoltes(){

    fetch('/questions.json')
    .then(Response => Response.json())
    .then(adat=> adatÉrkezett(adat));

    console.log("Leltöltés kész!")
}

function adatÉrkezett(adat){

    console.log(`${adat.length} kérdés érketett`);
    letöltésBefejeződött(adat);

}

function letöltésBefejeződött(d){

    console.log('Sikeres letöltés!');
    console.log(d);
    kérdések = d;

    kérdésMegjelenítés(jelenlegiKérdés);
    console.log("jelenlegi kérdés megjelenítve")

    let előre = document.getElementById("előre");
    let vissza = document.getElementById("vissza");

    let válasz1 = document.getElementById("válasz1");
    let válasz2 = document.getElementById("válasz2");
    let válasz3 = document.getElementById("válasz3");

    előre.addEventListener('click', () => { kérdésVáltó(1) });
    vissza.addEventListener('click', () => { kérdésVáltó(-1) });

    válasz1.addEventListener('click', () => { választVálasz(1, válasz1) });
    válasz2.addEventListener('click', () => { választVálasz(2, válasz2) });
    válasz3.addEventListener('click', () => { választVálasz(3, válasz3) });

}

window.onload = letoltes();

function kérdésMegjelenítés(i) {

    console.log(i);

    let kérdés_szöveg = document.getElementById("kérdés_szöveg");
    let kép= document.getElementById("kép1");

    
    kérdés_szöveg.innerHTML=kérdések[i].questionText;
    válasz1.innerHTML=kérdések[i].answer1;
    válasz2.innerHTML=kérdések[i].answer2;
    válasz3.innerHTML=kérdések[i].answer3;

 
    if(kérdések[i].image !="")
    {
        kép.src="https://szoft1.comeback.hu/hajo/"+kérdések[i].image
        kép.hidden=false;
    }
    else
    {
        kép.hidden=true;
    }
    
}

function kérdésVáltó(irány) {
    if (irány > 0) {
        if (jelenlegiKérdés + 1 > kérdések.length - 1) {
            jelenlegiKérdés = 0;
        }
        else {
            jelenlegiKérdés++;
        }
    }
    else {
        if (jelenlegiKérdés - 1 == -1) {
            jelenlegiKérdés = kérdések.length - 1;
        }
        else {
            jelenlegiKérdés--;
        }
    }
    
    kérdésMegjelenítés(jelenlegiKérdés);
    

}

function választVálasz(i, btnRef) {
    let jóVálasz = kérdések[jelenlegiKérdés].correctAnswer;
    if (jóVálasz == i) {
        btnRef.classList.add("jó");
    }
    else {
        btnRef.classList.add("rossz")
    }
}   
