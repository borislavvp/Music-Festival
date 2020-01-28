<?php
session_start();
$email = ($_SESSION['email']);

if ($email == ""){
    $email = "Unknown";
}
$to = "z7.layers.company@gmail.com";
$subject = $_POST['firstname'] . " from " . $_POST['countryname'];
$headers = "From: " . $email . "\r\n";
$txt .= $_POST['subject'];

mail($to, $subject, $txt, $headers);

$cookie_name2 = 'sentMessage';
$cookie_value2 = 'yes';
setcookie($cookie_name2, $cookie_value2, time() + 122600, "/");

header("Location: aboutUs.php");
exit();

?>