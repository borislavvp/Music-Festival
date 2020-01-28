<?php
    session_start();

if(!isset($_SESSION['email']) || empty($_SESSION['email'])){

    header("Location: ../index.php");

}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=0.489, maximum-scale=3.0, minimum-scale=0.489">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Account Overview</title>
    <link rel="icon" type="image/png"  href="../favicon.png" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
    <link rel="stylesheet"  type="text/css" href="../CSS/styles.css">
    <link href='https://fonts.googleapis.com/css?family=Work Sans' rel='stylesheet'>
    <link rel='stylesheet' href='https://use.fontawesome.com/releases/v5.7.0/css/all.css' integrity='sha384-lZN37f5QGtY3VHgisS14W3ExzMWZxybE1SJSEsQp9S+oqd12jhcu+A56Ebc1zFSJ' crossorigin='anonymous'>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
</head>
<body onload="changeAccountBar();alertForChangedDetails();">
<header>
    <?php
    include("../Header&Footer/headerMain.php");
    ?>
</header>
<div id="modalBodyCover" class="modalBalance">
</div>
<section>

    <div id="modal" class="modalBalance">
        <div class="modal-balance-content animate">
            <div class="imgcontainer">
                <span onclick="document.getElementById('modal').style.display='none'" class="close" title="Close Modal">&times;</span>
                <div class="balance">
                    <p>By clicking one of the buttons below you can add an amount to your event account depending on the button that you have clicked.</p>
                    <div class="AddBalanceBtn">
                        <button onclick="addBalance10()" class="buttonBox buttonImage">Add 10$</button>
                    </div>
                    <div class="AddBalanceBtn">
                        <button onclick="addBalance20()" class="buttonBox buttonImage">Add 20$</button>
                    </div>
                    <div class="AddBalanceBtn">
                        <button onclick="addBalance50()" class="buttonBox buttonImage">Add 50$</button>
                    </div>
                    <div class="AddBalanceBtn">
                        <button onclick="addBalance100()" class="buttonBox buttonImage">Add 100$</button>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div id="navbar-side-acc" class="containerSide">
        <nav class="sideNav">
            <ul>
                <li><a class="activeSideBar" id="accountOvervieww" onclick="loadSidePage('accountOverview.php')" href="#"><i class='fas fa-home'></i> Overview</a></li>
                <li><a id="accountTicketss" onclick="loadSidePage('accountTickets.php')"  href="#"><i  class="fa fa-ticket"></i> Tickets</a></li>
                <li><a id="accountSettingss" onclick="loadSidePage('accountSettings.php')"  href="#"><i class="material-icons">settings</i> Settings</a></li>
            </ul>
        </nav>
        <nav class="navSignOutbtn">
            <a href="signOut.php" class="SignOut">Sign Out</a>
        </nav>
    </div>
    <div class="container">
        <div class="introAcc">
            <div class="row">
                <div class="tittleAcc col-md-4">Account balance: <?php include 'showbalance.php' ;?> $
                </div>
                <div class="accName col-md-4"><?php
                    echo $_SESSION['email']
                    ?>
                </div>
            </div>
            <div class="hrAccBox">
                <hr class="hrAcc">
            </div>
            <div class="balanceBtn">
                <button onclick="document.getElementById('modal').style.display='block'" class="buttonBox buttonImage">Add Balance</button>
            </div>
        </div>
    </div>
</section>
<article id="menuPage" class="container">
    <div class="contentOverview">
        <div class="box_title">
            <span>Festival relieve</span>
        </div>
        <div class="overviewTextIntro">
            <p>Experience the most memorable festival moments all year long.</p>
            <a href="discover.php">DISCOVER</a>
        </div>
        <div class="livesets-box">
            <a href="discover.php" ><img class="img-fluid" src="../Pictures/trailerimg4.jpg"></a>
            <a style="text-decoration:none;" href="discover.php" ><h2>Watch Livesets</h2></a>
        </div>
        <div class="overview-videos-title">
            <p>POPULAR VIDEOS</p>
            <hr>
        </div>
        <div class="overview-videos">
            <embed src="https://www.youtube.com/embed/GS3GYQQUS3o" autostart="false" showcontrols="false"/>
            <embed src="https://www.youtube.com/embed/HkyVTxH2fIM" autostart="false" showcontrols="false"/>
            <embed src="https://www.youtube.com/embed/5egGsrpe9eE" autostart="false" showcontrols="false"/>
        </div>
    </div>
</article>
<footer>
    <div id="contactAcc" class="contactAcc">
        <div class="contact">
            <hr width="900">
            <div class="contactInfo">
                <p class="contName"> 2019 BPM music festival </p>
                <nav class="navSocialNetworkF">
                    <ul>
                        <li><a href="https://www.facebook.com/borislav.pavlov11" target="blank1"><i class='fab fa-facebook-f' ></i></a></li>
                        <li><a href="https://www.instagram.com/borislavvp/" target="blank1"><i class='fab fa-instagram' ></i></a></li>
                        <li><a href="#" target="blank1"><i class='fab fa-twitter' ></i></a></li>
                    </ul>
                </nav>
            </div>
        </div>
    </div>
</footer>
</body>
<script src="../JavaScript/javascript.js"></script>
</html>