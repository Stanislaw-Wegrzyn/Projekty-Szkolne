<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Wędkujemy</title>
    <link rel="stylesheet" href="styl_1.css">
</head>
<body>
    <header>
        <h1>Portal dla wędkarzy</h1>
    </header>
    <div id="lewy">
        <h2>Ryby drapieżne naszych wód</h2>
        <ul>
            <?php 
            
                $conn = mysqli_connect('localhost', 'root', '', 'wedkowanie');

                $sql = "SELECT `nazwa`,`wystepowanie` FROM `ryby` WHERE `styl_zycia` = 1";

                $result = $conn -> query($sql);

                while ($row = mysqli_fetch_assoc($result)) {
                    echo "<li>" . $row["nazwa"] . ", występowaie: ". $row["wystepowanie"] . "</li>";
                }

                $conn->close();
            ?>
        </ul>
    </div>
    <div id="prawy">
        <img src="ryba1.jpg" alt="Sum"> <br>
        <a href="./PESEL/kwerendy.txt">Pobierz kwerendy</a>
    </div>
    <footer>
        <p>Stronę wykonał: PESEL</p>
    </footer>
</body>
</html>