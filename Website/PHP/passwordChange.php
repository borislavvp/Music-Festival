<?php

include '../DBConfig/heraConfig.php';
function validate_data ($data){
    $data = trim($data);
    $data = stripslashes($data);
    $data = htmlspecialchars($data);
    return $data;
}

try {
    session_start();
    $email = ($_SESSION['email']);
    $validPw = '';

    $cookie_name = 'changedDetails';
    $cookie_value = 'yes';

    $cookie_name2 = 'wrongPassword';
    $cookie_value2 = 'yes';

    $cookie_name3 = 'wrongConfirmPassword';
    $cookie_value3 = 'yes';

    $password = validate_data($_POST["password"]);
    $passwordNew = validate_data($_POST["passwordNew"]);
    $passwordNewC = validate_data($_POST["passwordNewC"]);

    $sql = "SELECT password FROM user WHERE email = :email";
    if ($stmt = $db->prepare($sql)) {
        $stmt->bindParam(":email", $email);
        $stmt->execute();
        $result = $stmt->fetchAll(PDO::FETCH_ASSOC);
        foreach ($result as $key => $row) {
            $validPw = substr($row['password'] . $key, 0, 60);
            }
            if (password_verify($password, $validPw)) {
                if ($passwordNew == $passwordNewC) {
                    unset($stmt);

                    $passwordNew = password_hash($passwordNew,PASSWORD_DEFAULT);

                    $sql = "UPDATE user SET password = :passwordNew WHERE email = :email";
                    if ($stmt = $db->prepare($sql)) {
                        // Bind variables to the prepared statement as parameters
                        $stmt->bindParam(":passwordNew", $passwordNew);
                        $stmt->bindParam(":email", $email);

                        if ($stmt->execute()) {

                            echo $stmt->rowCount() . " records UPDATED successfully";
                            setcookie($cookie_name, $cookie_value, time() + 12600, "/");
                            $db = null;

                        } else {
                            $error = "Something went wrong";
                        }
                    }
                }
                else {
                    setcookie($cookie_name3,$cookie_value3, time() + 12600 ,"/");
                }
            }
            else {
                $db = null;
                setcookie($cookie_name2,$cookie_value2, time() + 12600 ,"/");
            }
        }

    else { $error = "Something went wrong";}
}
catch(Exception $e){
    echo $e->getMessage();
}

header("Location: account.php");
exit();

?>
