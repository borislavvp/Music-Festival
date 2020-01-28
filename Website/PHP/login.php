<?php
include '../DBConfig/heraConfig.php';
function validate_data ($data){
    $data = trim($data);
    $data = stripslashes($data);
    $data = htmlspecialchars($data);
    return $data;
}
try {
    $userID = '';
    $validEmail = '';
    $validPw = '';
    $error = '';
    if ($_SERVER["REQUEST_METHOD"] == "POST") {
        if (empty($_POST["email"]) || empty($_POST["password"])) {
            $error = "Invalid email or password";
        } else {

            $email = validate_data($_POST["email"]);
            $password = validate_data($_POST["password"]);

            $sql = "SELECT idUser FROM user WHERE email = :email";
            if ($stmt = $db->prepare($sql)) {
                // Bind variables to the prepared statement as parameters
                $stmt->bindParam(":email", $email);
                if ($stmt->execute()) {
                    if ($stmt->rowCount() == 1) {
                        $validEmail = 'true';
                            $result = $stmt->fetchAll(PDO::FETCH_ASSOC);
                            foreach ($result as $key => $row) {
                                foreach ($row as $key2 => $row2){
                                    $userID = $row2;
                                }
                            }
                    } else {
                        $error =  "This email is wrong.";
                    }
                } else {
                    $error = "Oops! Something went wrong. Please try again later.";
                }
            }
            unset($stmt);

            if ($validEmail == 'true') {
                $sql = "SELECT password FROM user WHERE email = :email";
                if ($stmt = $db->prepare($sql)) {
                    // Bind variables to the prepared statement as parameters
                    $stmt->bindParam(":email", $email);
                    $stmt->execute() ;
                    $result = $stmt->fetchAll(PDO::FETCH_ASSOC);
                    foreach ($result as $key=> $row) {
                        $validPw  = substr( $row['password'] . $key, 0, 60 );
                    }
                        if (password_verify($password, $validPw)) {
                            unset($stmt);
                            session_start();
                            $_SESSION['email'] = $email;

                            $cookie_name = "Logged" ;
                            $cookie_value = "yes";
                            setcookie($cookie_name,$cookie_value, time() + 122600 ,"/");


                        } else {
                            $db = null;
                            $error = "This password is wrong.";
                        }
                    } else {
                    $db = null;
                    $error = "Oops! Something went wrong. Please try again later.";
                    }
                }
            else {
                $db = null;
                $error = "invalid email";
            }
        }
    }
}
catch(Exception $e){
    echo $e->getMessage();
}

header("Location: ../index.php");
exit();
?>
