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
    $password = validate_data($_POST["user_pw"]);
    $validPw = '';

    $sql = "SELECT password FROM user WHERE email = :email";
    if ($stmt = $db->prepare($sql)) {
        // Bind variables to the prepared statement as parameters
        $stmt->bindParam(":email", $email);
        $stmt->execute();
        $result = $stmt->fetchAll(PDO::FETCH_ASSOC);
        foreach ($result as $key => $row) {
            $validPw = substr($row['password'] . $key, 0, 60);
        }
        if (password_verify($password, $validPw)) {
            $db = null;
            echo "Ok";
        }
        else {
            $db = null;
            echo "Sorry";
        }
    }

}
catch (Exception $e) {
    echo $e->getMessage();
}