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

        $cookie_name = 'changedDetails';
        $cookie_value = 'yes';

        $currFname = '';
        $currStreet = '';
        $currCity = '';
        $currPhone = '';
        $currHouseNo = '';
        $currPostCode = '';
        $currNationality = '';
        $currDob = '';
        $currGender = '';


        $fname = validate_data($_POST["fname"]);
        $street = validate_data($_POST["street"]);
        $phone = validate_data( $_POST["phone"]);
        $houseNo = validate_data($_POST["houseNo"]);
        $postCode = validate_data($_POST["postCode"]);
        $city = validate_data($_POST["city"]);
        $nationality =validate_data( $_POST["nationality"]);
        $dob = $_POST["dob"];
        $gender = $_POST["gender"];

        if ($fname == ''){
            $fname = null;
        }
        if ($street == ''){
            $street = null;
        }
        if ($phone == ''){
            $phone = null;
        }
        if ($houseNo == ''){
            $houseNo = null;
        }
        if ($postCode == ''){
            $postCode = null;
        }
        if ($city == ''){
            $city = null;
        }
        if ($nationality == ''){
            $nationality = null;
        }
        if ($dob == ''){
            $dob = null;
        }
        if ($gender == ''){
            $gender = null;
        }


        $sql = "SELECT * FROM user WHERE email = :email";
        if ($stmt = $db->prepare($sql)) {
            // Bind variables to the prepared statement as parameters
            $stmt->bindParam(":email", $email);
            $stmt->execute();
            $result = $stmt->fetchAll(PDO::FETCH_ASSOC);
            foreach ($result as $key => $row) {
                $currFname = $row['first_name'];
                $currStreet = $row['street'];
                $currPhone = $row['phone'];
                $currHouseNo = $row['houseNo'];
                $currPostCode = $row['postCode'];
                $currNationality = $row['nationality'];
                $currDob = $row['dob'];
                $currGender = $row['gender'];
                $currCity = $row['city'];
                unset($stmt);
            }
        }else {
            $db = null;
            $error = "Oops! Something went wrong. Please try again later.";
        }


        $sql = "UPDATE user SET first_name = COALESCE(:fname,'$currFname'),
                                nationality = COALESCE(:nationality,:currNationality),
                                city = COALESCE(:city,:currCity),
                                street = COALESCE(:street,:currStreet),
                                houseNo = COALESCE(:houseNo,:currHouseNo),
                                phone = COALESCE(:phone,:currPhone),
                                dob = COALESCE(:dob,:currDob),
                                gender = COALESCE(:gender,:currGender),
                                postCode = COALESCE(:postCode,:currPostCode)
                WHERE email = :email";
        if ($stmt = $db->prepare($sql)) {
            // Bind variables to the prepared statement as parameters
            $stmt->bindParam(":email", $email);
            $stmt->bindParam(":fname", $fname);
            $stmt->bindParam(":nationality", $nationality);
            $stmt->bindParam(":city", $city);
            $stmt->bindParam(":street", $street);
            $stmt->bindParam(":houseNo", $houseNo);
            $stmt->bindParam(":phone", $phone);
            $stmt->bindParam(":dob", $dob);
            $stmt->bindParam(":gender", $gender);
            $stmt->bindParam(":postCode", $postCode);

            //$stmt->bindParam(":currFname", $currFname);
            $stmt->bindParam(":currNationality", $currNationality);
            $stmt->bindParam(":currCity", $currCity);
            $stmt->bindParam(":currStreet", $currStreet);
            $stmt->bindParam(":currHouseNo", $currHouseNo);
            $stmt->bindParam(":currPhone", $currPhone);
            $stmt->bindParam(":currDob", $currDob);
            $stmt->bindParam(":currGender", $currGender);
            $stmt->bindParam(":currPostCode", $currPostCode);

            if ($stmt->execute()) {

                    echo $stmt->rowCount() . " records UPDATED successfully";
                    setcookie($cookie_name,$cookie_value, time() + 12600 ,"/");
                    $db = null;
                } else {
                    echo "Oops! Something went wrong. Please try again later.";
                }
            }

    }

catch(Exception $e){
    echo $e->getMessage();
}

header("Location: account.php");

exit();

?>
