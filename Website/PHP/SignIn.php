<?php
    session_start();

if(isset($_SESSION['email'])){

    header("Location: ../index.php");

}
?>


<!DOCTYPE html>
<html lang="en">
<head>

    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=0.66, maximum-scale=3.0, minimum-scale=0.66">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Sign In</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
    <link rel="stylesheet" href="../CSS/styles.css">
    <link href='https://fonts.googleapis.com/css?family=Work Sans' rel='stylesheet'>
    <link rel='stylesheet' href='https://use.fontawesome.com/releases/v5.7.0/css/all.css' integrity='sha384-lZN37f5QGtY3VHgisS14W3ExzMWZxybE1SJSEsQp9S+oqd12jhcu+A56Ebc1zFSJ' crossorigin='anonymous'>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
</head>
<body class="bodySignIn">
<header>
    <?php
    include("../Header&Footer/headerMain.php");
    ?>
</header>
<section>
    <div class="contentSignIn container">
        <h1>My Festival Account</h1>
        <div class="SignInForm container">
            <h2>With your Account you will be able to Pre-Register for Ticket Sales and say up-to date on all
                related news. You can check or change your personal info at any time.</h2>
            <p><b>Log in to your Festival Account here</b></p>
            <form onsubmit="return validateSignInForm();" action="login.php" class="formSignIn" method="post">
                <input class="inputEmail" type="Email" id="semail" name="email" oninput="checkSignInEmail();" placeholder="EMAIL">
                <input class="inputPw" type="Password" id="spassword" name="password" oninput="checkSignInPassword();" placeholder="PASSWORD">
                <input type="submit" value="SIGN IN" class="buttonBox buttonImage">
                <div class="btnCrt">
                    <a href="createAcc.php" class="buttonCreate">Dont have an account yet?</a>
                </div>
            </form>
        </div>
    </div>
</section>
</body>
<script src="../JavaScript/javascript.js"></script>
</html>