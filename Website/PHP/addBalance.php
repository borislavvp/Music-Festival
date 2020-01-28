<?php
include '../DBConfig/heraConfig.php';

session_start();
$email = ($_SESSION['email']) ;
$balance = $_POST["user_balance"];
$userID = "";


try {
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
                $error = "This email is wrong.";
            }
        } else {
            $error = "Oops! Something went wrong. Please try again later.";
        }
    }

    unset($stmt);

        $prevBalance = 0;
        $sql = "SELECT balance FROM eventacc WHERE User_userID = :userId";
        if ($stmt = $db->prepare($sql)) {
            $stmt->bindParam(":userId", $userID);
            if ($stmt->execute()) {
            if ($stmt->rowCount() == 1) {
                $result = $stmt->fetchAll(PDO::FETCH_ASSOC);
                foreach ($result as $key => $row) {
                    foreach ($row as $key2 => $row2) {
                        $prevBalance = $row2;
                    }
                }
                $balance = $balance + $prevBalance;

                unset($stmt);

                $sql = "UPDATE eventacc
                             SET balance = :balance
                                   WHERE User_userID =:userId ";
                $stmt = $db->prepare($sql);
                $stmt->bindParam(":userId", $userID);
                $stmt->bindParam(":balance", $balance);
                if ($stmt->execute()) {
                    $db = null;
                    echo "Ok";
                } else {
                    $db = null;
                    $error = "Oops! Something went wrong. Please try again later.";
                    echo $error;
                }
            }

            else {
                unset($stmt);

                $sql = "INSERT INTO eventacc (User_userID,balance)
                                   VALUES ('$userID','$balance')";
                $stmt = $db->prepare($sql);
                if ($stmt->execute()) {
                    $db = null;
                    echo "Ok";
                } else {
                    $db = null;
                    $error = "Oops! Something went wrong. Please try again later.";
                    echo $error;
                }
            }
        }
        else {
            $error = "Oops! Something went wrong. Please try again later.";
        }   }   else {  $error = "Oops! Something went wrong. Please try again later."; }

}catch (Exception $e){
    echo $e->getMessage();
}