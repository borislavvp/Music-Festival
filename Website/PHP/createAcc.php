<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Create Account</title>
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
<body class="bodyCreateAcc">
<header class="headerCreateAcc">
</header>
<div class="containerCreateAcc container ">
    <div class="infoCreateAcc container">
        <h2 style="font-size: 2.5rem;margin-bottom: 6px;"> Your Festival Account</h2>
        <h2> International Festival User Account Registration</h2>
        <p>By creating a Festival Account, you will stay up-to-date with all related news. You can change your personal settings at any time once signed in to your account.</p>
    </div>
    <form name="regForm" onsubmit="return validateRegistrationForm();" action="registration.php"   method="POST"  class="createAccForm container">
        <div class="box container">
            <div class="box_title">
                <span>Account details</span>
            </div>

            <div class="form_group">
                <div class="label-container">
                    <label for="email">Email Addres</label>
                </div>
                <input class="input form-control" type="text" id="email" name="email" onkeyup="checkEmail();" required style="height: 53px;">
            </div>
            <div class="form_group">
                <div class="label-container">
                    <label for="Password">Password</label>
                </div>
                <input class="input form-control" type="Password" name="password" required style="height: 53px;">
            </div>
            <div class="form_group">
                <div class="label-container">
                    <label for="Password">Confirm Password</label>
                </div>
                <input class="input form-control" type="Password" name="cpassword" required style="height: 53px;">
            </div>
        </div>

        <div class="box2 container">
            <div class="box_title">
                <span>Your details</span>
            </div>

            <div class="form_group">
                <div class="label-container">
                    <label for="email">First Name</label>
                </div>
                <input class="input form-control" type="text" name="fname" required style="height: 53px;">
            </div>
            <div class="form_group">
                <div class="label-container">
                    <label for="Address">Address</label>
                </div>
                <input class="input form-control" type="text" name="street" placeholder="STREET" required
                       style="height: 53px;">
                <input class="inputNumber form-control" type="number" name="houseNo" placeholder=" NUMBER" required
                       style="height: 53px;">
                <input class="inputNumber form-control" type="text" name="postCode" placeholder=" POSTAL CODE" required
                       style="height: 53px;">
                <input class="input form-control" type="text" name="city" placeholder="CITY" required
                       style="height: 53px;">
            </div>
            <div class="form_group">
                <div class="label-container">
                    <label for="Nationality">Nationality</label>
                </div>
                <input class="input form-control" type="text" name="nationality" required style="height: 53px;">
            </div>
            <div class="form_group">
                <div class="label-container">
                    <label for="Mobile">Mobile Number</label>
                </div>
                <input class="input form-control" type="text" name="phone" required style="height: 53px;">
            </div>
            <div class="form_group">
                <div class="label-container">
                    <label for="Address">Date of birth</label>
                </div>
                <input class="inputDate form-control" type="date" name="bday" required min="1950-12-31"
                       placeholder=" DATE OF BIRTH" style="height: 53px;">
            </div>
            <div class="form_group" style="margin-left: 100px;">
                <div class="label-container">
                    <label for="gender">Gender</label>
                </div>
                <input type="radio" name="gender" required value="male" checked> Male<br>
                <input type="radio" name="gender" value="female"> Female<br>
                <input type="radio" name="gender" value="other"> Other
            </div>
        </div>
        <div class="createAccBtn">
             <input type="submit" value="Create Account" class="buttonBox buttonImage">
        </div>
    </form>
</div>
</body>
<script src="../JavaScript/javascript.js"></script>
</html>