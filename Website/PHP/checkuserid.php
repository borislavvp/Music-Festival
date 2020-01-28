<?php
include '../DBConfig/heraConfig.php';
function validate_data ($data){
    $data = trim($data);
    $data = stripslashes($data);
    $data = htmlspecialchars($data);
    return $data;
}
try {
    $userId = validate_data($_POST["user_id"]);

    $sql = "SELECT User_userID FROM eventacc WHERE User_userID = :userId";
    if ($stmt = $db->prepare($sql)) {
        // Bind variables to the prepared statement as parameters
        $stmt->bindParam(":userId", $userId);
        if ($stmt->execute()) {
            if ($stmt->rowCount() == 1) {

                $db = null;
                echo "Exist";
            } else {

                $db = null;
                echo "Oops";
            }
        }
    }

}
catch (Exception $e) {
    echo $e->getMessage();
}