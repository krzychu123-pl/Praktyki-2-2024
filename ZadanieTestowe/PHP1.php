<html>

<?php 
$a = 5;
$imiona = array("Jan", "Krzysztof", "Pawel", "Grzegorz", "Andrzej");
foreach ($imiona as $imie) {
    echo " ", $imie,"<br>  ";}
?>
<br><br>
<?php 
$a = 16;
$b = "Kremowka";
for ($i = 0; $i < $a; $i++) {
    echo "  ", $i,". ", $b, "<br>";}
?>
<br><br>
<?php 
$a = 1;
do {
    echo "Liczba wynosi: ", $a, "<br>";
    $a++;
} while ($a < 13);
?>
<br><br>
<?php

$a = 1;
while ($a < 13 ) {
    echo "Liczba wyonsi: ", $a, "<br>";
    $a++;
}   
?>
</html>