<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="muzyka.css">
    <title>Sklep muzyczny</title>
</head>
<body>
    <div class="baner">
        <h1>SKLEP MUZYCZNY</h1>
    </div>
    <div class="panelLewy">
        <h2>NASZA OFERTA</h2>
        <ol>
            <li>Instrumenty muzyczne</li>
            <li>Sprzęt audio</li>
            <li>Płyty CD</li>
        </ol>
    </div>
    <div class="panelPrawy" id="panelPrawy_form">
        <?php
            $baza = mysqli_connect("localhost", "root", "", "sklep");
            $query = "INSERT INTO `uzytkownicy`(`imie`, `nazwisko`, `adres`, `telefon`) VALUES ('".$_POST["imie"]."','".$_POST["nazwisko"]."','".$_POST["adres"]."','".$_POST["telefon"]."')";
            mysqli_query($baza, $query);
            $query = "INSERT INTO `konta`(`login`, `haslo`) VALUES ('".$_POST["login"]."','".$_POST["haslo"]."')";
            mysqli_query($baza, $query);
            mysqli_close($baza);
            echo 'Konto '.$_POST['imie'].' '.$_POST['nazwisko'].' zostało zarejestrowane w sklepie muzycznym';
        ?>
    </div>
</body>
</html>