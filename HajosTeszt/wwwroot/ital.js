function ItalBetoltes() {
    fetch('api/italok')
        .then(result => {
            if (!result.ok) {
                console.error('Hibás letöltés: ${result.status}');
                return null;
            }
            else {
                return result.json();
            }
        })
        .then(data => {
            for (var i = 0; i < data.length; i++) {
                document.getElementById("italList").innerHTML += (i + 1) + ". - " + data[i].italNev + " " + data[i].italÁr + "Ft" + "<br/>"
            }
        })

    fetch('api/italok/count',
    {
            method: 'PUT'
    })
        .then(result => {
            if (!result.ok) {
                console.error('Hibás letöltés: ${result.status}');
                return null;
            }
            else {
                return result.json();
            }
        })
        .then(data2 => {
            console.log(data2)
                document.getElementById("italCount").innerHTML += data2 + " ital szerepel az itallapon"
        })
}

window.onload = () => {
    ItalBetoltes();
}

function ItalHozzadas() {

    let data = {
        italNev: document.getElementById("italNevText").value,
        italÁr: Number(document.getElementById("italÁrText").value),
    }
    console.log(JSON.stringify(data))
    fetch("api/italok",
        {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(data)
        }
    ).then(x => {
        if (x.ok) {
            alert("Siker!");
        } else {
            alert("Kudarc!");
        }
    });

}


function ItalTorles() {

    let id = document.getElementById("torlendoItal").value
    console.log(JSON.stringify(document.getElementById("torlendoItal")) + "törlése")

    fetch("api/italok/" + id,
        {
            method: 'DELETE',
            headers:
            {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(id)
        }).then(x => {
            if (x.ok) {

                alert("Siker");
            }
            else {
                alert("Kudarc");
            }
            location.reload();
        });
}

