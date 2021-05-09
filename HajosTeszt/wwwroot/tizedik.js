var hotList = [];
var questionInHotList = 3;
var displayedQuestion;
var numberOfQuestion;
var nextQuestion = 1;
var timerHandler;

function init() {

    for (let i = 0; i < questionInHotList; i++) {
        hotList[i] = {
            question: {},
            goodAnswer: 0
        }
    } 

    fetch(`questions/count`).then(result => result.text())
        .then(n => { numberOfQuestion = parseInt(n) })

    document.getElementById("előre").addEventListener("click", előre);
    document.getElementById("vissza").addEventListener("click", vissza);
    if (localStorage.getItem("hotList")) {
        hotList = localStorage.getItem("hotList");
    }
    if (localStorage.getItem("displayedQuestion")) {
        displayedQuestion = localStorage.getItem("displayedQuestion");
    }
    if (localStorage.getItem("nextQuestion")) {
        nextQuestion = localStorage.getItem("nextQuestion");
    }

    if (hotList.length>0) {
        for (let i = 0; i < questionInHotList; i++) {
            kérdésBetöltés(nextQuestion, i)
            nextQuestion++;
        }
    }
    else {
        kérdésMegjelenítés();
    }
    

}

function kérdésBetöltés(questionNumber, destination) {
    fetch(`questions/${questionNumber}`)
        .then(q => {
            if (!q.ok) {
                console.error('hibás letöltés');
                return null;
            }
            else {
                return q.json();
            }
        })
    .then(q => {
        hotList[destination].question = q;
        hotList[destination].goodAnswer = 0;
        console.log('A $(questionNumber). kérdés letöltésre került a hotList $(destination). helyére')
        if (displayedQuestion === undefined && destination === 0) {
            displayedQuestion = 0
            kérdésMegjelenítés();
        }
    })
        
}

function kérdésMegjelenítés() {
    let kérdés = hotList[displayedQuestion].question;
    document.getElementById("kérdés_szöveg").innerText = kérdés.questionText;
    document.getElementById("válasz1").innerText = kérdés.answer1;
    document.getElementById("válasz2").innerText = kérdés.answer2;
    document.getElementById("válasz3").innerText = kérdés.answer3;
    

    if (kérdés.image) {
        document.getElementById("kép1").src = "https://szoft1.comeback.hu/hajo/" + kérdés.image;
        document.getElementById("kép").style.display="block";
    }
    else {
        document.getElementById("kép").style.display = "none";

    }

    for (var i = 1; i <= 3; i++) {
        document.getElementById("válasz" + i).classList.remove("jó", "rossz");
    }

    document.getElementById("válaszok").style.pointerEvents = "auto";

}

window.onload = init;

function előre() {
    clearTimeout(timerHandler);
    displayedQuestion++;
    if (displayedQuestion === questionInHotList) displayedQuestion = 0;
    kérdésMegjelenítés();
}
function vissza() {
    displayedQuestion--;
    if (displayedQuestion < 0) displayedQuestion = questionInHotList-1;
    kérdésMegjelenítés();
    }

function választás(n) {
    let kérdés = hotList[displayedQuestion].question;
    if (n === kérdés.correctAnswer) {
        document.getElementById("válasz" + n).classList.add("jó");
        hotList[displayedQuestion].goodAnswer++;
        if (hotList[displayedQuestion].goodAnswer === 3) {
            kérdésBetöltés(nextQuestion, displayedQuestion);
            nextQuestion++;
            //toDO kérdéslista vége
        }
    }
    else {
        document.getElementById("válasz" + n).classList.add("rossz");
        document.getElementById("válasz" + kérdés.correctAnswer).classList.add("jó");
    }

    document.getElementById("válaszok").style.pointerEvents = "none";

    timerHandler = setTimeout(előre, 3000)

    localStorage.setItem("hotList", JSON.stringify(hotList));
    localStorage.setItem("displayedQuestion", displayedQuestion);
    localStorage.setItem("nextQuestion", nextQuestion);
}