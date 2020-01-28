<?php
     session_start();
?>

<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=0.58, maximum-scale=3.0, minimum-scale=0.58">
        <meta http-equiv="X-UA-Compatible" content="ie=edge">
        <title>Festival</title>
        <link rel="icon" type="image/png"  href="../favicon.png" />
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
        <link rel="stylesheet"  type="text/css" href="../CSS/styles.css">
        <link href='https://fonts.googleapis.com/css?family=Work Sans' rel='stylesheet'>
        <link href='https://fonts.googleapis.com/css?family=Alex Brush' rel='stylesheet'>
        <link rel='stylesheet' href='https://use.fontawesome.com/releases/v5.7.0/css/all.css' integrity='sha384-lZN37f5QGtY3VHgisS14W3ExzMWZxybE1SJSEsQp9S+oqd12jhcu+A56Ebc1zFSJ' crossorigin='anonymous'>
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
        <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
    </head>
    <body onload="changeAccountBar();notifyForPurchasedTicket();">
        <header class="headerFestival">
          <div class="banner">
              <video autoplay muted loop id="bgVid" poster="../Pictures/header1.jpg">
                <source src="\videos\vF.mp4" type="video/mp4" ></source>
                <source src="\videos\vFW.webm" type="video/webm" ></source>
                <source src="\videos\vFO.ogg" type="video/ogg" ></source>
              </video>
          </div>
            <?php
            include("../Header&Footer/headerMain.php");
            ?>
        </header>
          <div id="modalBodyCover" class="modalBox">
          </div>
        <section id="menuPage">
          
            <div id="modal" class="modalBox">
                 <div class="modal-video-content-box animate">
                   <div class="imgcontainer">
                    <span onclick="document.getElementById('modal').style.display='none'" class="close" title="Close">&times;</span>
                    <div class="img-magnifier-container">
                      <embed id="myimage" src="https://www.youtube.com/embed/9uBUIlQIIgE" autostart="false" showcontrols="false" height="550" width="1250" />
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
                <div class="introBox">
                    <div class="content-video-trailer">
                     <div class="trailer-box">
                       <img onclick="document.getElementById('modal').style.display='block'" src="../Pictures/trailerimg4.jpg">
                       <div class="trailerContent">
                          <h2>BPM music festival 2019</h2> 
                          <p>Trailer</p> 
                       </div>
                       <div class="playImg">
                        <img src="../Pictures/Play.png">
                       </div>
                     </div>
                    </div>
                    <div class="columns">
                        <div onclick="document.getElementById('modalAftermovie').style.display='block'"  class="box-aftermovie">
                            <img src="../Pictures/aftermovie.jpg">
                              <h2>Festival</h2>
                              <p>Enter a fascinating story to be written during a weekend of love and unity.</p>
                              <p class="bottomText">Watch</p>
                       </div>
                   </div>
                   <div class="columns">
                        <div onclick="loadTopPage('campings-info.php')" class="box-campings">
                            <img  src="../Pictures/camping.jpg">
                              <h2>Campings</h2>
                              <p>A vibrant city that welcomes tens of thousands festival visitors after an exuberant day at the festival.</p>
                              <p class="bottomText">More info</p>
                        </div>
                   </div>
                    <div class="info-fest">
                      <h2>  We believe ..</h2> <p> in enjoying life to the fullest without having to compromise everything. We are responsible for the generation of tomorrow and respect each other and Mother Nature.</p>
                    </div>
                </div>
            </div>
        </section>
        <article id="article_prev_year" class="article-previousYear">
            <p class="year">2018</p>
            <div class="info-prev-year">
                <h2>2018</h2>
                <h3>Bulgaria,Sofia</h3>
                <p>In 2018 a magical gathering of the People of the BPM 
                Music Festival took place during 2 weekends. On June 14-15-16 and June 21-22-23
               more than 400.000 friends discover Sofia.A show that is seldom seen, a gathering of talents that left you in wonder.</p>
            </div>
            
            <div class="container slideshow-container">
                <div id="myCarousel" class="carousel slide" data-ride="carousel">
                    <!-- Indicators -->
                    <ol class="carousel-indicators">
                       <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                       <li data-target="#myCarousel" data-slide-to="1"></li>
                       <li data-target="#myCarousel" data-slide-to="2"></li>
                       <li data-target="#myCarousel" data-slide-to="3"></li>
                       <li data-target="#myCarousel" data-slide-to="4"></li>
                       <li data-target="#myCarousel" data-slide-to="5"></li>
                       <li data-target="#myCarousel" data-slide-to="6"></li>
                       <li data-target="#myCarousel" data-slide-to="7"></li>
                       <li data-target="#myCarousel" data-slide-to="8"></li>
                       <li data-target="#myCarousel" data-slide-to="9"></li>
                       <li data-target="#myCarousel" data-slide-to="10"></li>
                       <li data-target="#myCarousel" data-slide-to="11"></li>
                    </ol>

                    <!-- Wrapper for slides -->
                    <div class="carousel-inner">

                        <div class="carousel-item active">
                            <img class="d-block w-100" src="../Pictures/photo1.jpg"  style="width:100%;">
                        </div>
    
                        <div class="carousel-item">
                            <img class="d-block w-100" src="../Pictures/photo2.jpg"  style="width:100%;">
                        </div>

                        <div class="carousel-item">
                            <img class="d-block w-100" src="../Pictures/photo3.jpg"  style="width:100%;">
                        </div>

                        <div class="carousel-item">
                            <img class="d-block w-100" src="../Pictures/photo4.jpg"  style="width:100%;">
                        </div>
    
                        <div class="carousel-item">
                            <img class="d-block w-100" src="../Pictures/photo5.jpg"  style="width:100%;">
                        </div>

                        <div class="carousel-item">
                            <img class="d-block w-100" src="../Pictures/photo6.jpg"  style="width:100%;">
                        </div>

                        <div class="carousel-item">
                            <img class="d-block w-100" src="../Pictures/photo7.jpg"  style="width:100%;">
                        </div>
    
                        <div class="carousel-item">
                            <img class="d-block w-100" src="../Pictures/photo8.jpg"  style="width:100%;">
                        </div>

                        <div class="carousel-item">
                            <img class="d-block w-100" src="../Pictures/photo9.jpg"  style="width:100%;">
                        </div>

                        <div class="carousel-item">
                            <img class="d-block w-100" src="../Pictures/photo10.jpg"  style="width:100%;">
                        </div>
    
                        <div class="carousel-item">
                            <img class="d-block w-100" src="../Pictures/photo11.jpg"  style="width:100%;">
                        </div>

                        <div class="carousel-item">
                            <img class="d-block w-100" src="../Pictures/photo12.jpg"  style="width:100%;">
                        </div>
                    </div>

                    <!-- Left and right controls -->
                    <a class="carousel-control-prev" href="#myCarousel" role="button" data-slide="prev">
                        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                        <span class="sr-only">Previous</span>
                    </a>
                    <a class="carousel-control-next" href="#myCarousel" role="button" data-slide="next">
                        <span class="carousel-control-next-icon" aria-hidden="true"></span>
                        <span class="sr-only">Next</span>
                    </a>
                </div>
            </div>
            <hr>
        </article>
        <?php
            include("../Header&Footer/footerMain.php");
            ?>
    </body>
    <script src="../JavaScript/javascript.js"></script>
</html>