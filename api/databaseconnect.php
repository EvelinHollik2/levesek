<?php
$conn=new mysqli("localhost", "root", "", "etelek");
if ($conn->errno) {
    echo 'Adatbázis hiba';
    die();
}
$conn->set_charset('utf8');