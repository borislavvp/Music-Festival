<?php
require __DIR__ . '/vendor/autoload.php';
$generator = new Picqer\Barcode\BarcodeGeneratorJPG();
//echo '<img src="data:image/jpg;base64,' . base64_encode($generator->getBarcode('081231723897', $generator::TYPE_CODE_128)) . '">';

/*$to = $email;
$headers = "From: internationalmusicfestival@company.com" . "\r\n";
$headers .= 'MIME-Version: 1.0' . "\r\n";
$headers .= "Content-Type: text/html; charset=UTF-8\r\n";
$subject = "Ticket confirmation";
$message =  '<img src="data:image/png;base64,' . base64_encode($generator->getBarcode('081231723897', $generator::TYPE_CODE_128)) . '">';
/* $message = '
<html>
<body>

 <img src=\"data:image/png;base64,' . base64_encode($generator->getBarcode($barcodeCode, $generator::TYPE_CODE_128)) . '\">
</body>
</html>
';


mail($to, $subject, $message, $headers);
$to = 'b.pavlov1819@gmail.com';
$subject = "Registration confirmation";
$headers = "From: internationalmusicfestival@company.com" . "\r\n";


$txt = '<html><body>';
$txt .= '<h1 style="color:#f40;">Hi Jane!</h1>';
$txt .= '<p style="color:#080;font-size:18px;">Will you marry me?</p>';
$txt .= '</body></html>';


mail($to, $subject, $txt, $headers);
$to = "b.pavlov1819@gmail.com";
$subject = "Registration confirmation";
$txt = "Hello   Thank you for your Registration !";
$headers = "From: internationalmusicfestival@company.com" . "\r\n";
mail($to, $subject, $txt, $headers);
$imgencode = base64_encode($generator->getBarcode('081231723897', $generator::TYPE_CODE_128));
$txt = '<html><body>';
$txt .= ' <br> <img src= "data:image/jpg;base64,' . $imgencode . '"> ';
$txt .= '</body></html>';

echo $txt;

mail('b.pavlov@student.fontys.nl', 'Testing email subject', 'Here you will put your email message');
echo " ARE";*/

session_start();
 $email = ($_SESSION['email']) ;
 $endPos = strrpos($email, '@') - 1;
 $startPos = $endPos - 4;
 $emailSubstr1 = substr($email,$startPos,$endPos - 3);
 $emailSubstr2 = substr($email,$startPos + 4,$endPos );
$barcodeCode = rand(100,1000) . $emailSubstr1 . rand(100,1000).$emailSubstr2. rand(100,1000);
echo $barcodeCode;