<?php
     session_start();
?>

<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=0.58, maximum-scale=3.0, minimum-scale=0.58">
        <meta http-equiv="X-UA-Compatible" content="ie=edge">
        <title>Discover</title>
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
    <body onload="changeAccountBar();">
        <header class="headerDiscover">
            <?php
            include("../Header&Footer/headerMain.php");
            ?>
        <div  class="discoverMediaTitle">
            <h2 id="discoverMediaTitle" >PHOTOS</h2>
          </div>
        </header> 
          <div id="modalBodyCover" class="modalBox">
          </div>
            <div id="modal" class="modalBox">
                 <div class="modal-video-content-box animate">
                   <div class="imgcontainer">
                    <span onclick="document.getElementById('modal').style.display='none'" class="close" title="Close Image">&times;</span>
                    <div class="img-magnifier-container">
                      <embed id="myimage" src="" autostart="false" height="550" width="1250" />
                    </div>
                   </div>
                 </div>
            </div>
        <section id="menuPage">
        <div class="discoverMedia container">
         <div class=".media-listing">
          <div class="mediaContent row">
            <div class="col-pht col-md-4" style="height: 230px;">
              <img class="img-fluid" onclick="document.getElementById('modal').style.display='block';changePictureModalSrc(0);" src="../Pictures/photo1.jpg">
            </div>
            <div class="col-pht col-md-4" style="height: 230px;">
              <img class="img-fluid" onclick="document.getElementById('modal').style.display='block';changePictureModalSrc(1);" src="../Pictures/photo2.jpg">
            </div>
            <div class="col-pht col-md-4" style="height: 230px;">
              <img class="img-fluid" onclick="document.getElementById('modal').style.display='block';changePictureModalSrc(2);" src="../Pictures/photo3.jpg">
            </div>
            <div class="col-pht col-md-4" style="height: 230px;">
              <img class="img-fluid" onclick="document.getElementById('modal').style.display='block';changePictureModalSrc(3);" src="../Pictures/photo4.jpg">
            </div>
            <div class="col-pht col-md-4" style="height: 230px;">
              <img class="img-fluid" onclick="document.getElementById('modal').style.display='block';changePictureModalSrc(4);" src="../Pictures/photo5.jpg">
            </div>
            <div class="col-pht col-md-4" style="height: 230px;">
              <img class="img-fluid" onclick="document.getElementById('modal').style.display='block';changePictureModalSrc(5);" src="../Pictures/photo6.jpg">
            </div>
            <div class="col-pht col-md-4" style="height: 230px;">
              <img class="img-fluid" onclick="document.getElementById('modal').style.display='block';changePictureModalSrc(6);" src="../Pictures/photo7.jpg">
            </div>
            <div class="col-pht col-md-4" style="height: 230px;">
              <img class="img-fluid" onclick="document.getElementById('modal').style.display='block';changePictureModalSrc(7);" src="../Pictures/photo8.jpg">
            </div>
            <div class="col-pht col-md-4" style="height: 230px;">
              <img class="img-fluid" onclick="document.getElementById('modal').style.display='block';changePictureModalSrc(8);" src="../Pictures/photo9.jpg">
            </div>
            <div class="col-pht col-md-4" style="height: 230px;">
              <img class="img-fluid" onclick="document.getElementById('modal').style.display='block';changePictureModalSrc(9);" src="../Pictures/photo10.jpg">
            </div>
            <div class="col-pht col-md-4" style="height: 230px;">
              <img class="img-fluid" onclick="document.getElementById('modal').style.display='block';changePictureModalSrc(10);" src="../Pictures/photo11.jpg">
            </div>
            <div class="col-pht col-md-4" style="height: 230px;">
              <img class="img-fluid" onclick="document.getElementById('modal').style.display='block';changePictureModalSrc(11);" src="../Pictures/photo12.jpg">
            </div>
            </div>
          </div>
        </div>
        </section>
        <?php
            include("../Header&Footer/footerMain.php");
            ?>
    </body>
    <script src="../JavaScript/javascript.js"></script>
</html>