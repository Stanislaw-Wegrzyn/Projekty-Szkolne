<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style.css">
    <script src="index.js"></script>
    <title>Sekcje</title>
</head>
<body>
    <div id="baner">
        <div class="kontener20">
            <h1>baner</h1>
        </div>
    </div>
    <div id="zawartosc">
        <div id="lewy">
            <div class="kontener20">
                <h2>lewy</h2>
                <a onclick="pokaż('s1')" class="linkiMenu">Sekcja pierwsza</a> |
                <a onclick="pokaż('s2')" class="linkiMenu">Sekcja druga</a>
                <br>
                <?php include "wstawka0.php" ?>
            </div>
        </div>
        <div id="centrum">
            <div class="kontener20">
                <h2>centrum</h2>
                <section id="s1">
                    Sekcja pierwsza
                    <?php include "wstawka1.php" ?>
                </section>
                <section id="s2" style="display: none">
                Sekcja druga
                    <?php include "wstawka2.php" ?>
                </section>
            </div>
        </div>
        <div id="prawy">
            <div class="kontener20">
                <h2>prawy</h2>
            </div>
        </div>
    </div>
    <div id="stopka">
        <div class="kontener20">
            <h1>stopka</h1>
        </div>
    </div>
    
</body>
</html>