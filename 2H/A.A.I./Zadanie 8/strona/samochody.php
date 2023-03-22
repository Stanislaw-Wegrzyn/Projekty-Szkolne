<?php
$conn = mysqli_connect('localhost', 'root', '', 'Wynajem');
?>
<!DOCTYPE html>
<html>

<head>
	<meta charset="UTF-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">

	<link rel="stylesheet" href="styl.css">

	<title>Wynajmujemy samochody</title>
</head>

<body>
	<div class="main">
		<div class="wynajem">
			<h1>Wynajem Samochodów</h1>
		</div>
		<div class="toyota">
			<h2>DZIŚ POLECAMY TOYOTĘ ROCZNIK 2014</h2>
			<?php
			$qrr = "SELECT id, marka, kolor, model FROM samochody WHERE marka = 'Toyota' AND  rocznik = 2014";
			$res = mysqli_query($conn, $qrr);
			while ($row = mysqli_fetch_assoc($res)) {
				echo $row['id']." ".$row['marka']." ".$row['model']." Kolor: ".$row['kolor'];
			}
			?>
			<h2>WSZYSTKIE DOSTĘPNE SAMOCHODY</h2>
			<?php
			$qrr = "SELECT id, marka, model, rocznik FROM samochody";
			$res = mysqli_query($conn, $qrr);
			while ($row = mysqli_fetch_assoc($res)) {
				echo $row['id']." ".$row['marka']." ".$row['model']." ".$row['rocznik']."<br>";
			}
			?>
		</div>
		<div class="tele">
			<h2>ZAMÓWIONE AUTA Z NUMERAMI TELEFONÓW KLIENTÓW</h2>
			<?php
			$qrr = "SELECT samochody.id, samochody.model, zamowienia.telefon FROM zamowienia, samochody WHERE samochody.id= zamowienia.id";
			$res = mysqli_query($conn, $qrr);
			while ($row = mysqli_fetch_assoc($res)) {
				echo "".$row['id']." ".$row['model']." ".$row['telefon']."<br>";
			}
			?>
		</div>

		<div class="ogloszenia">
			<h2>NASZA OFERTA</h2>
			<ul>
				<li>Fiat</li>
				<li>Toyota</li>
				<li>Opel</li>
				<li>Mercedes</li>
			</ul>
			<p>Tu pobierzesz naszą <a href="Komis.sql">bazę danych</a></p>
			<p>autor strony: 000000000</p>
		</div>

	</div>
	<?php
	mysqli_close($conn);
	?>

</body>

</html>































































<!-- Jan Kupczyk -->