<?php
require __DIR__ . '/vendor/autoload.php';
include '../../DBConfig/heraConfig.php';

try {
    session_start();
    $email = ($_SESSION['email']);


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
    unset($stmt);

    $sql = "SELECT 	balance FROM eventacc WHERE User_userID = :userId";
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
                            $error = "Low balance";
                        } else {
                            unset($stmt);
                            $ticketType = 'Regular';

                            $sql = "INSERT INTO tickets (EventAcc_userID,ticketType)
                                      VALUES ('$userID','$ticketType')";
                            $stmt = $db->prepare($sql);
                            if ($stmt->execute()) {

                            } else {

                                $error = "Oops! Something went wrong. Please try again later.";
                                echo $error;
                            }
                            unset($stmt);

                            $newBalance = 0;


                            $sql = "SELECT balance FROM eventacc WHERE User_userID = :userId";
                            if ($stmt = $db->prepare($sql)) {
                                $stmt->bindParam(":userId", $userID);
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
                                        $stmt->bindParam(":userId", $userID);
                                        $stmt->bindParam(":newbalance", $newBalance);
                                        if ($stmt->execute()) {


                                        } else {

                                            $error = "Oops! Something went wrong. Please try again later.";
                                        }
                                    } else {
                                        $error = "Oops! Something went wrong. Please try again later.";
                                    }
                                } else {
                                    $error = "Oops! Something went wrong. Please try again later.";
                                }
                            } else {
                                $error = "Oops! Something went wrong. Please try again later.";
                            }
                            unset($stmt);
                           // //$endPos = strrpos($email, '@') - 1;
                           // $startPos = $endPos - 4;
                           // $emailSubstr1 = substr($email,$startPos,$endPos - 5);
                           // $emailSubstr2 = substr($email,$startPos + 4,$endPos - 3);
                           // $barcodeCode = rand(100,1000) . $emailSubstr1 . rand(0,100). $emailSubstr2. rand(100,1000);
                            $barcodeCode = '081231723897'; // For the Presentation
                            $sql = "UPDATE user 
                                SET Barcode = :barcodeCode
                                      WHERE idUser =:userId ";
                            $stmt = $db->prepare($sql);
                            $stmt->bindParam(":userId", $userID);
                            $stmt->bindParam(":barcodeCode", $barcodeCode);
                            if ($stmt->execute()) {
                                $db = null;
                            } else {
                                $db = null;
                                $error = "Oops! Something went wrong. Please try again later.";
                            }

                            $cookie_name2 = 'existTicket';
                            $cookie_value2 = 'yes';
                            setcookie($cookie_name2, $cookie_value2, time() + 122600, "/");

                            $generator = new Picqer\Barcode\BarcodeGeneratorPNG();

                            $to = $email;
                            $subject = "Ticket confirmation";
                            $headers = "From: internationalmusicfestival@company.com" . "\r\n";
                            $headers .= 'MIME-Version: 1.0' . "\r\n";
                            $headers .= 'Content-type: text/html; charset=iso-8859-1' . "\r\n";
                            $imgencode = base64_encode($generator->getBarcode($barcodeCode, $generator::TYPE_CODE_128));
                            $txt = '<html><body>';
                            $txt .= '<p>Thank you for purchasing your festival ticket .Your Account Number is : <strong> ' . $userID . '</strong> . Please print the barcode below and keep it safe because 
                                    you need it to access the event .  See you soon ! 
                                </p> <br> <img src= "data:image/png;base64,' . $imgencode . '"> ';
                            $txt .= '</body></html>';

                            mail($to, $subject, $txt, $headers);
                            echo $txt;
                        }
                    }
                }
            } else {
                $error = "Something went wrong";
            }
        } else {
            $error = "Oops! Something went wrong. Please try again later.";
        }
    }
}catch (Exception $e){
    echo $e->getMessage();
}

header("Location: ../festival.php");
exit();

?>

