<?php
include '../DBConfig/heraConfig.php';
function validate_data ($data){
    $data = trim($data);
    $data = stripslashes($data);
    $data = htmlspecialchars($data);
    return $data;
}

try {

        $email = validate_data($_POST["email"]);
        $password = validate_data($_POST["password"]);
        $fname = validate_data($_POST["fname"]);
        $street = validate_data($_POST["street"]);
        $phone = validate_data( $_POST["phone"]);
        $houseNo = validate_data($_POST["houseNo"]);
        $postCode = validate_data($_POST["postCode"]);
        $city = validate_data($_POST["city"]);
        $nationality =validate_data( $_POST["nationality"]);
        $dob = $_POST["dob"];
        $gender = $_POST["gender"];
        $password = password_hash($password,PASSWORD_DEFAULT);

        $sql = "SELECT idUser FROM user WHERE email = :email";
        if ($stmt = $db->prepare($sql)) {
            // Bind variables to the prepared statement as parameters
            $stmt->bindParam(":email", $email);
            if ($stmt->execute()) {
                if ($stmt->rowCount() == 1) {

                    $db = null;
                    $error = "Already exist user with that email";

                    header("Location: createAcc.php");
                } else {


                    $sql = "INSERT INTO user (email,first_name, password,street,houseNo,postCode
                                            ,city,nationality,phone,dob,gender)
                                      VALUES ('$email','$fname','$password','$street','$houseNo','$postCode','$city',
                                               '$nationality','$phone','$dob','$gender')";
                    $stmt = $db->prepare($sql);
                    $stmt->execute();
                    $db = null;
                    session_start();

                    $to = $email;
                    $subject = "Registration confirmation";
                    $txt = "Hello " . $fname . " , Thank you for your Registration !";
                    $headers = "From: internationalmusicfestival@company.com" . "\r\n";
                    mail($to, $subject, $txt, $headers);

                    $_SESSION['email'] = $email;
                    $cookie_name = "Logged" ;
                    $cookie_value = "yes";
                    setcookie($cookie_name,$cookie_value, time() + 122600 ,"/");
                }
            }
            else {
                $error = "Oops! Something went wrong. Please try again later.";

            }
        }

}
catch(Exception $e){
    echo $e->getMessage();
}

header("Location: ../index.php");
exit();

?>
