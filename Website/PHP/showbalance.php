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
    $email = ($_SESSION['email']) ;


    $userID = "";
    $sql = "SELECT idUser FROM user WHERE email = :email";
    if ($stmt = $db->prepare($sql)) {
        // Bind variables to the prepared statement as parameters
        $stmt->bindParam(":email", $email);
        if ($stmt->execute()) {
            if ($stmt->rowCount() == 1) {
                $result = $stmt->fetchAll(PDO::FETCH_ASSOC);
                foreach ($result as $key => $row) {
                    foreach ($row as $key2 => $row2){
                        $userID = $row2;
                    }
                }
            } else {
                $error =  "Something went wrong";

            }
        } else {
            $error = "Oops! Something went wrong. Please try again later.";

        }
    }

    unset($stmt);
    $sql = "SELECT balance FROM eventacc WHERE User_userID = :userId";
    if ($stmt = $db->prepare($sql)) {
        // Bind variables to the prepared statement as parameters
        $stmt->bindParam(":userId", $userID);
        if ($stmt->execute()) {
            if ($stmt->rowCount() == 1) {
                $result = $stmt->fetchAll(PDO::FETCH_ASSOC);
                foreach ($result as $key => $row) {
                    foreach ($row as $key2 => $row2){
                        $balance = $row2;
                        echo $balance;
                        $db = null;
                    }
                }
            } else {

                $db = null;
                echo "0";
            }
        }
    }

}
catch (Exception $e) {
    echo $e->getMessage();
}