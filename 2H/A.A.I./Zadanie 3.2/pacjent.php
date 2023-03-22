<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Poradnia</title>
    <link rel="stylesheet" href="poradnia.css">
</head>
<body>
    <div id="baner">
        <h1>PORADNIA SPECJALISTYCZNA</h1>
    </div>
    <div id="panelLewy">
        <h3>LEKARZE SPECJALIŚCI</h3>
        <table border="1px">
            <tr>
                <td colspan=2>Poniedziałek</td>
            </tr>
            <tr>
                <td>Anna Kowalska</td>
                <td>otolaryngolog</td>
            </tr>
            <tr>
                <td colspan=2>Wtorek</td>
            </tr>
            <tr>
                <td>Jan Nowak</td>
                <td>kardiolog</td>
            </tr>
        </table>
        <h3>LISTA PACJENTÓW</h3>
        <?php
            $connection = mysqli_connect("localhost", "root", "", "poradnia");
            $sql = "SELECT `id`,`imie`,`nazwisko`,`choroba` FROM `pacjenci`";
            $result = mysqli_query($connection, $sql);
            if($result->num_rows > 0){
                while($row = $result->fetch_assoc()){
                    echo $row['id']." ".$row['imie']." ".$row['nazwisko']." ".$row['choroba']."<br>";
                }
            }
            mysqli_close($connection);
        ?>
        <br><br>
        <form action="pacjent.php" method="post">
            <label for="idPacjent">Podaj id</label><br>
            <input type="number" id="idPacjent" name="idPacjent"><br>
            <button type="submit">Pokaż szczegóły</button>
        </form>
    </div>
    <div id="panelPrawy">
        <h2>KARTA PACJENTA</h2>
        <?php
            $connection = mysqli_connect("localhost", "root", "", "poradnia");
            $sql = "SELECT `imie`, `nazwisko`, `leki_przepisane`, `opis` FROM `pacjenci` WHERE `id` = ".$_POST['idPacjent'];
            $result = mysqli_query($connection, $sql);
            if($result->num_rows > 0){
                while($row = $result->fetch_assoc()){
                    echo "<p>Imie i nazwisko: ".$row['imie']." ".$row['nazwisko']."</p>
                          <p>Przepisane leki: ".$row['leki_przepisane']."</p>
                          <p>Opis choroby: ".$row['opis']."</p>";
                }
            }
            mysqli_close($connection);
        ?>
    </div>
    <div id="stopka">
        <p>utworzone przez: PESEL</p>
        <a href="./PESEL/kwerendy.txt">Kwerendy do pobrania</a>
    </div>
</body>
</html>