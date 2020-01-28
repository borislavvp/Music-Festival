<?php
include '../DBConfig/heraConfig.php';
function validate_data ($data){
    $data = trim($data);
    $data = stripslashes($data);
    $data = htmlspecialchars($data);
    return $data;
}
try {

    $spotId = validate_data(($_POST["spotId"]));

    $booked = '0';
    $sql = "SELECT Booked FROM camping WHERE SpotID = :spotid";
    if ($stmt = $db->prepare($sql)) {
        // Bind variables to the prepared statement as parameters
        $stmt->bindParam(":spotid", $spotId);
        if ($stmt->execute()) {
            $result = $stmt->fetchAll(PDO::FETCH_ASSOC);
            foreach ($result as $key => $row) {
                $booked = $row['Booked'];
            }
            if ($booked == '1') {
                $db = null;
                echo "Exist";
            } else {

                $db = null;
                echo "no";
            }
        }

    }

}
catch (Exception $e) {
    echo $e->getMessage();
}