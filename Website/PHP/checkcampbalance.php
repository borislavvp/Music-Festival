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

    if ($email != NULL) {
        $userID = "";
        $sql = "SELECT idUser FROM user WHERE email = :email";
        if ($stmt = $db->prepare($sql)) {
            // Bind variables to the prepared statement as parameters
            $stmt->bindParam(":email", $email);
            if ($stmt->execute()) {
                if ($stmt->rowCount() == 1) {
                    $result = $stmt->fetchAll(PDO::FETCH_ASSOC);
                    foreach ($result as $key => $row) {
                        foreach ($row as $key2 => $row2) {
                            $userID = $row2;
                        }
                    }
                } else {
                    $error = "Something went wrong";

                }
            } else {
                $error = "Oops! Something went wrong. Please try again later.";
            }
        }
        if ($userID !== "") {
            unset($stmt);
                        $sql = "SELECT balance FROM eventacc WHERE User_userID = :userId";
                        if ($stmt = $db->prepare($sql)) {
                            // Bind variables to the prepared statement as parameters
                            $stmt->bindParam(":userId", $userID);
                            if ($stmt->execute()) {
                                if ($stmt->rowCount() == 1) {
                                    $result = $stmt->fetchAll(PDO::FETCH_ASSOC);
                                    foreach ($result as $key => $row) {
                                        foreach ($row as $key2 => $row2) {
                                            if ($row2 < 40) {
                                                $db = null;
                                                echo "Sorry";
                                            } else {
                                                $db = null;
                                                echo "Ok";
                                            }
                                        }
                                    }
                                } else {

                                    $db = null;
                                    echo "Something went wrong";
                                }
                            }
                        }
                    }

        }
        else {
            echo "nosess";
    }
}
catch (Exception $e) {
    echo $e->getMessage();
}