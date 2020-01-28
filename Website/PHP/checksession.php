<?php
include '../DBConfig/heraConfig.php';
session_start();
if(isset($_SESSION['email'])){

    $booked = "0";
    $sql = "SELECT SpotID FROM camping WHERE Booked = :booked";
    if ($stmt = $db->prepare($sql)) {
        // Bind variables to the prepared statement as parameters
        $stmt->bindParam(":booked", $booked);
        if ($stmt->execute()) {
            if ($stmt->rowCount() < 1) {

                $db = null;
                echo "nospots";
            } else {

                $db = null;
                echo "set";
            }
        }
    }
}else {
    echo "no";
}
exit();

?>