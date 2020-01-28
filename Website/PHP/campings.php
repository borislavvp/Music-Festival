<?php
session_start();
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Campings Information</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
    <link rel="stylesheet"  type="text/css" href="../CSS/styles.css">
    <link href='https://fonts.googleapis.com/css?family=Work Sans' rel='stylesheet'>
    <link href='https://fonts.googleapis.com/css?family=Alex Brush' rel='stylesheet'>
    <link rel='stylesheet' href='https://use.fontawesome.com/releases/v5.7.0/css/all.css' integrity='sha384-lZN37f5QGtY3VHgisS14W3ExzMWZxybE1SJSEsQp9S+oqd12jhcu+A56Ebc1zFSJ' crossorigin='anonymous'>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
</head>
<body>
<header class="headerFestival">
    <?php
    include("headerMain.php");
    ?>
<div id="modalBodyCover" class="modalBox">
</div>
<article id="menuPage" class="tickets-content ">
    <div class="ticket-info-imageL">
        <img src="../Pictures/campings.jpg">
    </div>
    <div class="tickets-info container" >
        <div class="tickets-info-title">
            <h1> Campings Information</h1>
        </div>
        <div class="tickets-info-text">
            <p>Enjoy your weekend in a spacious, luxurious tent. Two comfortable beds with soft bed sheets ensure you a good night’s sleep. You’ll get your own locker, power socket, indoor lighting and comfortable chairs. Your personal covered terrace allows ample space to enjoy your weekend rain or shine.

                You will be welcomed in the Montagoe chill-out area. The Camping Lobby offers quality catering, a separated bar and restaurant etc. The Lobby team and the Camping crew are at your service 24h/24h.</p>
            <h3>A Camping Package includes :</h3>
            <ul>
                <li>Access to your own lockable Modern Camp</li>
                <li>Interior space: 1300 x 1450 cm</li>
                <li>Raised wooden deck with canvas roof</li>
                <li>6 fully equipped beds</li>
                <li>A power outlet (220 volt – EU outlet), interior lighting, mirror and a locker</li>
                <li>Access to The Lobby - Chill out zone</li>
                <li>Parking</li>
            </ul>
        </div>
        <div class="box-tickets-price-text">
            <h2>Please note</h2>
            <p>The Campings are valid <strong> only</strong> for 6 people</p>
        </div>

</article>


<?php
include("footerMain.php");
?>
</body>
<script src="../JavaScript/javascript.js"></script>
</html>