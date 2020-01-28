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
                unset($stmt);

                $sql = "SELECT ticketID FROM tickets
                                     WHERE EventAcc_userID = :userID";
                $stmt = $db->prepare($sql);
                $stmt->bindParam(":userID", $userID);
                if ($stmt->execute()) {
                    if ($stmt->rowCount() == 1) {
                        echo "Exist";
                    }
                } else {
                    echo "no";
                }
            } else {
                $error = "Something went wrong";
            }
        } else {
            $error = "Oops! Something went wrong. Please try again later.";
        }
    }

}
catch (Exception $e) {
    echo $e->getMessage();
}