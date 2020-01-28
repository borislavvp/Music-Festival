<?php
     session_start();
?>

<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=0.58, maximum-scale=3.0, minimum-scale=0.58">
        <meta http-equiv="X-UA-Compatible" content="ie=edge">
        <title>BPM</title>
        <link rel="icon" type="image/png"  href="favicon.png" />
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
        <link rel="stylesheet" type="text/css" href="CSS/styles.css">
        <link href='https://fonts.googleapis.com/css?family=Work Sans' rel='stylesheet'>
        <link rel='stylesheet' href='https://use.fontawesome.com/releases/v5.7.0/css/all.css' integrity='sha384-lZN37f5QGtY3VHgisS14W3ExzMWZxybE1SJSEsQp9S+oqd12jhcu+A56Ebc1zFSJ' crossorigin='anonymous'>
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
        <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
    </head>
    <body onload="changeAccountBar();">
        <header class="headerVideo">
            <div class="banner">
              <video autoplay muted loop id="bgVid" poster="../Pictures/header1.jpg">
                <source src="\videos\vH.mp4" type="video/mp4" ></source>
                <source src="\videos\vHO.ogg" type="video/ogg" ></source>
                <source src="\videos\vHW.webm" type="video/webm" ></source>
              </video>
            </div>
            <div class="logo">
              <img id="logo" class="logoImage" src="favicon.png">
              <h1>bpm</h1>
              <p>international music festival</p>
            </div>
            <?php
            include("Header&Footer/headerMain.php");
            ?>
        </header>
        <section>
            <div id="modal" class="modalBox" >
                 <div class="modal-video-content-box animate">
                   <div class="imgcontainer">
                    <span onclick="document.getElementById('modal').style.display='none'" class="close" title="Close Map">&times;</span>
                    <div class="img-magnifier-container">
                      <img id="festmap" class="festMapImg" src="Pictures/festivalMap.png">
                    </div>
                   </div>
                 </div>
            </div>
            <div id="modalAftermovie" class="modalBox">
                 <div class="modal-video-content-box animate">
                   <div class="imgcontainer">
                    <span onclick="document.getElementById('modalAftermovie').style.display='none'" class="close" title="Close">&times;</span>
                    <div class="img-magnifier-container">
                      <embed id="myimage" src="https://www.youtube.com/embed/HkyVTxH2fIM" autostart="false" showcontrols="false" height="550" width="1250" />
                    </div>
                   </div>
                 </div>
            </div>
            <div class="contentBox">
                <div class="introBox ">
                    <div class="segmentBox container">
                        <h1 class="text-center">BPM Music Festival</h1>
                        <p class="text-center"> March 2019 - Amsterdam,Netherlands</p>
                        <p class="text-center"> Enjoy your trip around the most majestic city in Netherlands </p> 
                     <div class="btnFestivalMap">
                       <a onclick="document.getElementById('modal').style.display='block'" 
                       class="buttonBox buttonImage">Festival map</a>
                     </div>
                    </div>
                    <div class="segmentBox container">
                     <div class="pictureInfo ">
                      <img class="img-fluid" src="Pictures/trailerimg3.jpg">
                     </div>
                     <div class="tickets-titles">
                      <h1 class="titleTicketsBox text-center">Purchase Tickets</h1>
                      <h2 class="regularTicketTitle text-left">Pleasure Day Pass</h2>
                      <h2 class="vipTicketTitle text-center">Comfort Day Pass</h2>
                      <p class="infoTickets text-center">You can buy your weekend tickets by clicking the button below </br> and you can choose between "Regular" and "VIP" ticket.</p>
                    </div>
                      <div class="btnBuyTickets">
                         <a href="PHP/festival.php" id="buyTicketsHome" class="buttonBox buttonImage">Buy Tickets</a>
                      </div>
                     </div>

                     <div class="pictures-box container">
                      <div class="row">
                         <div onmouseover="moveLeft('text1')" onmouseout="moveBack('text1')" 
                          onclick="document.getElementById('modalAftermovie').style.display='block'" class="col-md-6 picAfterMovie ">
                             <img class="img-fluid" src="Pictures/homeFestAfterMovie.jpg">
                             <p id="text1">BPM music festival 2018|Aftermovie</p>
                         </div>
                         <div onmouseover="moveLeft('text2')" onmouseout="moveBack('text2')" class="col-md-6 picFestInfo ">
                            <a href="PHP/festival.php"><img class="img-fluid" src="Pictures/homeFestInfo.jpg"></a>
                               <p id="text2">All info</p>
                               <h2>BPM music festival 2019</h2>
                         </div>
                     </div>
                   </div>
                  <div class="festival-information-box container-fluid">
                      <p class="info">  Experience our festival during the most magical season of the year… Spring
                         Discover one of the most beautiful and majestic city in the world - Amsterdam 
                         and also ejoy one of the biggest festivals in the world for a weekend</br></br>
                         Unite with more than 10 000 People from all over the world , guided by the Amsterdam's magic.
                         Live Today, Love Tomorrow, Unite Forever</p>
                     <div class="cols12">
                          <div class="col1">
                             <p class="col-heading"> BPM music festival</p>
                             <p class="col-date"> 15 March 2019</p>
                             <p class="col-loc"> Amsterdam,Netherlands</p>
                          </div>
                          <div class="col2">
                             <p class="col2-heading"> Unforgettable weekend in Amsterdam</p>
                             <p class="col2-heading"> 15-17 March 2019</p>
                             <p class="col2-register"> Create your Festival Account or sign in </p>
                             <div class="btnRegister">
                               <a href="PHP/SignIn.php" class="buttonBox buttonImage">Register</a>
                             </div>
                          </div>
                     </div>
                   </div>
                </div>
            </div>
        </section>
        <section>
             <div class="footerContent">
             </div>
             <div class="contentF1">
               <div class="contentPicture pictureAnimation"> 
                <p class="titleF">Photos</p>
                 <img src="Pictures/pictureF2.jpg">
                 <a href="PHP/discover.php">
                    <div class="overlayBox">
                        <i class="material-icons">photo_camera</i>
                        <p>View Gallery</p>
                    </div>
                </a>
               </div> 

             </div>
             <div class="contentF2">
                <div class="contentPicture pictureAnimation">
                  <p class="titleF">Videos</p>
                  <img src="Pictures/pictureF1.jpg">
                  <a href="PHP/discover.php" >
                    <div class="overlayBox">
                        <i class="fa fa-video-camera"></i>
                        <p>View Videos</p>
                    </div>
                </a>
                </div>
             </div>
             <div class="contentF3">
                <div class="contentPicture pictureAnimation">
                  <p class="titleF">Campings</p>
                  <img src="Pictures/campings.jpg">
                  <a href="PHP/festival.php">
                    <div class="overlayBox">
                        <i class='fas fa-campground'></i>
                        <p>View Campings</p>
                    </div>
                  </a>
                </div>
             </div>
        </section>
        <?php
        include("Header&Footer/footerMain.php");
        ?>
    </body>    
<script src="JavaScript/javascript.js"></script>
</html>