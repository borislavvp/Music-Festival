<?php
include '../DBConfig/heraConfig.php';
function validate_data ($data){
    $data = trim($data);
    $data = stripslashes($data);
    $data = htmlspecialchars($data);
    return $data;
}
try {
    $email = validate_data($_POST["user_email"]);

    $sql = "SELECT idUser FROM user WHERE email = :email";
    if ($stmt = $db->prepare($sql)) {
        // Bind variables to the prepared statement as parameters
        $stmt->bindParam(":email", $email);
        if ($stmt->execute()) {
            if ($stmt->rowCount() == 1) {

                $db = null;
                echo "Exist";
            } else {

                $db = null;
                echo "Ok";
            }
        }
    }

}
catch (Exception $e) {
    echo $e->getMessage();
}