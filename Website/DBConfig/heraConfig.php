<?php
$db_host = "studmysql01.fhict.local";
$db_name = "dbi416657";
$db_user = "dbi416657";
$db_password = 'hera.fhict';

$db = new PDO("mysql:dbname=".$db_name.";host=".$db_host, $db_user,$db_password );
$db -> setAttribute(PDO::ATTR_ERRMODE,PDO::ERRMODE_EXCEPTION);
