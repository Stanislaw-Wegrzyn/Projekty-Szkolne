<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Nasze hobby</title>
    <link rel="stylesheet" href="hobby.css">
</head>
<body>
    <?php
    $conn = mysqli_connect('localhost', 'root', '', 'Forum');

    if ($_POST["plec"] == 'K'){
        $plec = 'K';
    } else {
        $plec = 'M';
    }

    $sql = "INSERT INTO `uzytkownicy` (nick, zainteresowania, zawod, plec) VALUES ('".$_POST['nick']."','". $_POST['hobby'] ."','".$_POST['zawod']."', '".$plec."')";
    mysqli_query($conn, $sql);

    $sql2 = "INSERT INTO konta (login, haslo) VALUES ('".$_POST['login']."','". $_POST['password']."')";
    mysqli_query($conn, $sql2);
    ?>
    <header>
        <h1>FORUM HOBBYSTYCZNE</h1>
    </header>
    <div id="lewy">
        <p>Konto <?php echo $_POST["nick"]; ?> zostało zarejestrowane na forum hobbystycznym</p>
    </div>
    <div id="prawy">
        <h3>TEMATYKA FORUM</h3>
        <ul>
            <li>Hodowla zwierząt</li>
            <ul>
                <li>psy</li>
                <li>koty</li>
            </ul>
            <li>Muzyka</li>
            <li>Gry komputerowe</li>
        </ul>
    </div>

    <?php
    mysqli_close($conn);
    ?>
</body>
</html>