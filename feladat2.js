function van(){
    let vnev = document.getElementById('vnev').value;
    let knev = document.getElementById('knev').value;
    let kedvenc = document.getElementById('kedvenc').value;
    let kiir = document.getElementById('kiir');
    kiir.innerHTML = `Van jogsija: ${vnev} ${knev} ${kedvenc}.`
}

function nincs(){
    let vnev = document.getElementById('vnev').value;
    let knev = document.getElementById('knev').value;
    let kedvenc = document.getElementById('kedvenc').value;
    let kiir = document.getElementById('kiir');
    kiir.innerHTML = `Nincs jogsija: ${vnev} ${knev} ${kedvenc}.`
}