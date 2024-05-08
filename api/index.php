<?php

header('Content-Type: application/json; charset=utf-8');
header('Access-Control-Allow-Origin: *'); // live server - CORS
require_once './databaseconnect.php';
$params = explode('/', $_SERVER['QUERY_STRING']);
switch ($params[0]) {
    case "levesek":
        switch ($_SERVER["REQUEST_METHOD"]) {
            case 'GET':
                $request = $conn->query("SELECT * FROM levesek");
                $levesek = $request->fetch_all(MYSQLI_ASSOC);
                http_response_code("201");
                echo json_encode($levesek);
                break;

            default:
                break;
        }
        break;
    case "fogyasztas":
        switch ($_SERVER["REQUEST_METHOD"]) {
            case "POST":
                $sql = "INSERT INTO `fogyasztas`(`levesekkod`, `datum`, `adag`) VALUES (".$_POST['levesekkod'].",'".$_POST['datum']."',".$_POST['adag'].")";
                if ($conn->query($sql)) {
                    http_response_code("201");
                } else{
                    http_response_code("401");
                }
                    break;

            default:
                break;
        }
        break;
    default :
        http_response_code("401");
        break;
}