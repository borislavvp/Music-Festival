<?php
     session_start();
?>

<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=0.56, maximum-scale=3.0, minimum-scale=0.56">
        <meta http-equiv="X-UA-Compatible" content="ie=edge">
        <title>About us</title>
        <link rel="icon" type="image/png"  href="../favicon.png" />
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
        <link rel="stylesheet" type="text/css" href="../CSS/styles.css">
        <link href='https://fonts.googleapis.com/css?family=Work Sans' rel='stylesheet'>
        <link rel='stylesheet' href='https://use.fontawesome.com/releases/v5.7.0/css/all.css' integrity='sha384-lZN37f5QGtY3VHgisS14W3ExzMWZxybE1SJSEsQp9S+oqd12jhcu+A56Ebc1zFSJ' crossorigin='anonymous'>
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
         <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
    </head>
    <body onload="changeAccountBar();notifyForSentMessage();" class="bodyAboutUs">
        <header class="headerAboutUs">
            <?php
            include("../Header&Footer/headerMain.php");
            ?>
        </header>
        <section class="container">
          <div class="companyPage">
          <div class="companyName container">
            <h1>Z7-Layers</h1>
          </div>
          <div class="companyInfo container">
            <h1> About </h1>
            <p>At Z7-Layers, we all come to work every day because we want to solve the biggest problem in web applications. Everyone is guessing. Publishers don’t know what apps to build, how to monetize them, or even what to price them at. Advertisers & brands don’t know where their target users are, how to reach them, or even how much they need to spend in order to do so. Investors aren’t sure which apps and genres are growing the quickest, and where users are really spending their time (and money).

            Throughout the history of business, people use data to make more informed decisions. Our mission at Apptopia is to make the app economy more transparent. Today we provide the most actionable web applications & insights in the industry. We want to make this data available to as many people as possible (not just the top 5%).</p>
          </div>
        </div>
      </section>
      <section class="container" style="margin-top: -500px; max-width: 1400px;">
          <div class="companyTeam">
            <p>Team members</p>
            <div class="member">
              <img src="../Pictures/bobby.jpg">
              <h2>Senior Software Engineer</h2>
            </div>
            <div class="member">
              <img src="../Pictures/radu.jpg">
              <h2>Director of Product Engineering</h2>
            </div>
            <div class="member">
              <img src="../Pictures/wissam.jpg">
              <h2>Communications Lead & Researcher</h2>
            </div>
            <div class="member">
              <img src="../Pictures/djimi.jpg">
              <h2>Sr. Service Reliability Engineer</h2>
            </div>
          </div>
        </section>
        <section class="container">
          <div class="companyContact" style="margin-top: 100px;">
            <div id="googleMap" class="googleMap"></div>
            <div class="companyContactInfo">
              <h1>Z7-Layers</h1>
              <h2> is headquartered in Eindhoven,Netherlands</h2>
              <p>Contact us on:</p>
              <h1>z7-layers@gmail.com</h1>
            </div>
          </div>
        </section>
        <section class="container" style=" padding-top: 100px;margin-left: 300px;">
           <div class="contactFormDiv">
            <p>Send us an email if you have any problems and also share your thoughts about the event !</p>
            <form action="userMessages.php"   method="POST">
              <label for="fname">First Name</label>
              <input required type="text" id="fname" name="firstname" placeholder="Your name..">

              <label for="country">Country</label>
              <input required type="text" id="country" name="countryname" placeholder="Country name..">

              <label for="subject">Subject</label>
              <textarea required id="subject" name="subject" placeholder=".." style="height:100px;width:600px;"></textarea><br>

              <input type="submit" value="SEND MESSAGE" class="buttonBox buttonImageCompany" style="width:150px;">
           </form>
          </div>
      </section>

        <?php
        include("../Header&Footer/footerMain.php");
        ?>

   </body>    
<script src="../JavaScript/javascript.js"></script>
<script async defer
    src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCFRMjcCjyhXrMzXAxIlsO_VON2kv2Sv50&callback=myMap">
</script>

</html>