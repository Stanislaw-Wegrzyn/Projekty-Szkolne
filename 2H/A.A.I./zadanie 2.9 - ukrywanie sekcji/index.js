$$ = (selektor) => {return document.getElementById(selektor); } 

pokaż = (sekcja) => {
    $$('s1').style.display = 'none';
    $$('s2').style.display = 'none';
    $$(sekcja).style.display = 'block';
}