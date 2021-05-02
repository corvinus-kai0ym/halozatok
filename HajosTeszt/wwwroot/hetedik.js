var kérdések;
var jelenlegiKérdés = 1;

window.onload = kérdésBetöltés(jelenlegiKérdés);


function kérdésBetöltés(id) {
    fetch(`/questions/${id}`)
        .then(response => {
            if (!response.ok) {
                console.error(`Hibás válasz: ${response.status}`)
            }
            else {
                return response.json()
            }
        })
        .then(data => letöltésBefejeződött(data));
}    

function letöltésBefejeződött(d){

    console.log('Sikeres letöltés!');
    console.log(d);
    kérdések = d;

    kérdésMegjelenítés(d);
    console.log("jelenlegi kérdés megjelenítve");

    let előre = document.getElementById("előre");
    let vissza = document.getElementById("vissza");

    let válasz1 = document.getElementById("válasz1");
    let válasz2 = document.getElementById("válasz2");
    let válasz3 = document.getElementById("válasz3");

    válasz1.classList.remove("jó");
    válasz1.classList.remove("rossz");
    válasz2.classList.remove("jó");
    válasz2.classList.remove("rossz");
    válasz3.classList.remove("jó");
    válasz3.classList.remove("rossz");
    

    előre.addEventListener('click', () => { előreLépés(); });
    vissza.addEventListener('click', () => { visszaLépés(); });

    var jóVálasz = kérdések.correctAnswer;
    console.log("jóválasz:" + jóVálasz);

    válasz1.addEventListener('click', () => { választVálasz(1, válasz1, jóVálasz); console.log("1-es kattintás") });
    válasz2.addEventListener('click', () => { választVálasz(2, válasz2, jóVálasz); console.log("2-es kattintás") });
    válasz3.addEventListener('click', () => { választVálasz(3, válasz3, jóVálasz); console.log("3-es kattintás") });

}

function kérdésMegjelenítés(i) {

    console.log(i);

    let kérdés_szöveg = document.getElementById("kérdés_szöveg");
    let kép= document.getElementById("kép1");

    
    kérdés_szöveg.innerText=i.questionText;
    válasz1.innerText=i.answer1;
    válasz2.innerText=i.answer2;
    válasz3.innerText = i.answer3;
    
 
    if(i.image !="")
    {
        kép.src="https://szoft1.comeback.hu/hajo/"+i.image
        kép.hidden=false;
    }
    else
    {
        kép.hidden=true;
    }
    
}

function előreLépés() {
    jelenlegiKérdés++;
    console.log("lépés előre" + "jelenlegi kérdés: " + jelenlegiKérdés)
    kérdésBetöltés(jelenlegiKérdés)
}

function visszaLépés() {
    jelenlegiKérdés--;
    console.log("lépés vissza" + "jelenlegi kérdés: " + jelenlegiKérdés)
    kérdésBetöltés(jelenlegiKérdés)
}

function kérdésVáltó(irány) {
    if (irány < 0 && jelenlegiKérdés >= 2) {
        jelenlegiKérdés = jelenlegiKérdés-1;
    }
    if (irány > 0) {
        jelenlegiKérdés = jelenlegiKérdés+1;
    }
    console.log(jelenlegiKérdés);
    kérdésBetöltés(jelenlegiKérdés);
}

function választVálasz(b, btnRef, jóVálasz) {
    if (jóVálasz == b) {
        btnRef.classList.add("jó");
    }
    else {
        btnRef.classList.add("rossz")
    }
}





