<?php
include '../DBConfig/heraConfig.php';

try {

    session_start();
    $email = ($_SESSION['email']) ;
    $userID = '';
    $ticketType = '';
    $sql = "SELECT idUser FROM user WHERE email = :email";
    if ($stmt = $db->prepare($sql)) {
        // Bind variables to the prepared statement as parameters
        //
        $stmt->bindParam(":email", $email);
        $stmt->execute() ;
        $result = $stmt->fetchAll(PDO::FETCH_ASSOC);
        foreach ($result as $key => $row) {
            foreach ($row as $key2 => $row2){
                $userID = $row2;
            }
        }
    }else{
        echo "Something went wrong";
    }
    unset($stmt);
    if ($userID !== '') {
        $sql = "SELECT ticketType FROM tickets WHERE EventAcc_userID  = :userID";
        if($stmt = $db->prepare($sql)){

            $stmt->bindParam(":userID", $userID);
            $stmt->execute() ;
            $result = $stmt->fetchAll(PDO::FETCH_ASSOC);
            foreach ($result as $key => $row) {
                foreach ($row as $key2 => $row2){
                    $ticketType = $row2;
                }
            }
            if ($ticketType == 'Regular' || $ticketType == 'VIP'){
                unset($stmt);
                $existingCamping = 0;
                $sql = "SELECT Camping_SpotID FROM eventacc WHERE User_userID  = :userID";
                if($stmt = $db->prepare($sql)){

                    $stmt->bindParam(":userID", $userID);
                    $stmt->execute() ;
                    $result = $stmt->fetchAll(PDO::FETCH_ASSOC);
                    foreach ($result as $key => $row) {
                        foreach ($row as $key2 => $row2){
                            $existingCamping = $row2;
                        }
                    }
                    if ($existingCamping == 0){
                        echo "You have ". $ticketType . " ticket. See you soon at the event !";
                    }else {
                        echo "You have ". $ticketType . " ticket and a Camping Spot Number ".$existingCamping." . See you soon at the event !";
                    }
                }
            } else {
                echo "You have not purchased any tickets";
            }
        }


    }
}
catch(Exception $e){
    echo $e->getMessage();
}

?>
