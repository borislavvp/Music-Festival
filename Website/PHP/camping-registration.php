<?php
include '../DBConfig/heraConfig.php';
function validate_data ($data){
    $data = trim($data);
    $data = stripslashes($data);
    $data = htmlspecialchars($data);
    return $data;
}

try {
    if (empty($_POST["email1"]) || empty($_POST["email2"]) || empty($_POST["email3"]) || empty($_POST["email4"])
        || empty($_POST["email5"]) || empty($_POST["email6"]) ||  empty($_POST["spotID"]) ) {

         $error = "Invalid details";
    }else {
        session_start();
        $buyerEmail = ($_SESSION['email']) ;
        $email1 = validate_data($_POST["email1"]);
        $email2 = validate_data($_POST["email2"]);
        $email3 = validate_data($_POST["email3"]);
        $email4 = validate_data($_POST["email4"]);
        $email5 = validate_data($_POST["email5"]);
        $email6 = validate_data($_POST["email6"]);

        $spotID = validate_data($_POST["spotID"]);
        $arrayEmails = array($email1,$email2,$email3,$email4,$email5,$email6);
        $arrayIDs = array(1,2,3,4,5,6);

        $buyerUserID = "";
$sql = "SELECT idUser FROM user WHERE email = :email";
if ($stmt = $db->prepare($sql)) {
    // Bind variables to the prepared statement as parameters
    $stmt->bindParam(":email", $buyerEmail);
    if ($stmt->execute()) {
        if ($stmt->rowCount() == 1) {
            $result = $stmt->fetchAll(PDO::FETCH_ASSOC);
            foreach ($result as $key => $row) {
                foreach ($row as $key2 => $row2){
                    $buyerUserID = $row2;
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

$sql = "SELECT 	balance FROM eventacc WHERE User_userID = :userId";
if ($stmt = $db->prepare($sql)) {
    // Bind variables to the prepared statement as parameters
    $stmt->bindParam(":userId", $buyerUserID);
    if ($stmt->execute()) {
        if ($stmt->rowCount() == 1) {
            $result = $stmt->fetchAll(PDO::FETCH_ASSOC);
            foreach ($result as $key => $row) {
                foreach ($row as $key2 => $row2) {
                    if ($row2 < 40) {
                        $db = null;
                        $error = "Low balance";
                    } else {
                        unset($stmt);
                        for ($i = 0; $i < count($arrayEmails); $i++) {
                            $sql = "SELECT idUser FROM user WHERE email = :email";
                            if ($stmt = $db->prepare($sql)) {
                                // Bind variables to the prepared statement as parameters
                                $stmt->bindParam(":email", $arrayEmails[$i]);
                                $stmt->execute();
                                $result = $stmt->fetchAll(PDO::FETCH_ASSOC);
                                foreach ($result as $key => $row) {
                                    $arrayIDs[$i] = $row['idUser'];
                                }
                            }
                        }
                        unset($stmt);
                        $existTicket = "";
                        for ($i = 0; $i < count($arrayIDs); $i++) {
                            $sql = "SELECT ticketID FROM tickets
                                     WHERE EventAcc_userID = :userID";
                            $stmt = $db->prepare($sql);
                            $stmt->bindParam(":userID", $arrayIDs[$i]);
                            if ($stmt->execute()) {
                                $existTicket = "yes";
                            } else {
                                $existTicket = "no";
                                break;
                            }
                        }
                        if ($existTicket == "yes") {

                            unset($stmt);
                            $status = "";
                            for ($i = 0; $i < count($arrayIDs); $i++) {
                                $sql = "UPDATE eventacc SET Camping_SpotID = :spotID
                                     WHERE User_userID = :userID";
                                $stmt = $db->prepare($sql);
                                $stmt->bindParam(":spotID", $spotID);
                                $stmt->bindParam(":userID", $arrayIDs[$i]);
                                if ($stmt->execute()) {
                                    $status = "ok";
                                } else {
                                     $status = "no";
                                    break;
                                }
                            }
                            if ($status == "ok") {
                                unset($stmt);
                                $sql = "UPDATE camping SET Booked = '1'
                                     WHERE SpotID = :spotID";
                                $stmt = $db->prepare($sql);
                                $stmt->bindParam(":spotID", $spotID);
                                if ($stmt->execute()) {
                                    unset($stmt);
                                    $newBalance = 0;
                                    $sql = "SELECT balance FROM eventacc WHERE User_userID = :userId";
                                    if ($stmt = $db->prepare($sql)) {
                                        $stmt->bindParam(":userId", $buyerUserID);
                                        if ($stmt->execute()) {
                                            if ($stmt->rowCount() == 1) {
                                                $result = $stmt->fetchAll(PDO::FETCH_ASSOC);
                                                foreach ($result as $key => $row) {
                                                    foreach ($row as $key2 => $row2) {
                                                        $newBalance = $row2 - 40;
                                                    }
                                                }
                                                unset($stmt);

                                                $sql = "UPDATE eventacc
                                                        SET balance = :newbalance
                                                        WHERE User_userID =:userId ";
                                                $stmt = $db->prepare($sql);
                                                $stmt->bindParam(":userId", $buyerUserID);
                                                $stmt->bindParam(":newbalance", $newBalance);
                                                if ($stmt->execute()) {

                                                    echo "Updated Successfully";
                                                    $db = null;
                                                } else {

                                                    $error = "Oops! Something went wrong. Please try again later.";
                                                }
                                            } else {
                                                $error = "Oops! Something went wrong. Please try again later.";
                                            }
                                        } else {
                                            $error = "Oops! Something went wrong. Please try again later.";
                                        }
                                    }
                                } else {
                                    $error = "Something went wrong";
                                    $db = null;
                                }
                            } else {
                                 $error = "Something swent wrong";
                            }
                        }
                    }
                }
            }
        }
      }
     }
    }
}

catch(Exception $e){
    echo $e->getMessage();
}

header("Location: festival.php");
exit();

?>
