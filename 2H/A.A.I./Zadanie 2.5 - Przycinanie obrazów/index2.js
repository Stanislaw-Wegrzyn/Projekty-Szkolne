function zmiana(sekcja){
    if (sekcja % 2 == 0){
        document.getElementById("sekcja2").style.display = "block";
        document.getElementById("sekcja1").style.visibility = "hidden";
    } else {
        document.getElementById("sekcja2").style.display = "none";
        document.getElementById("sekcja1").style.visibility = "visible";
    }
}