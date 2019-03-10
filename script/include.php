<?php

// we connect to example.com and port 3307
$conn = mysqli_connect($_ENV["MYQSQL_HOSTNAME"], $_ENV["MYSQL_USER"], $_ENV["MYSQL_PASSWORD"]);
if (!$conn) {
    die('Could not connect: ' . mysql_error());
}

mysqli_select_db($conn,$_ENV["MYSQL_DATABASE"]);
//echo 'Connected successfully';

$create="CREATE TABLE IF NOT EXISTS contacts (
    id int(11) NOT NULL auto_increment,   
    contact_name VARCHAR(560) NOT NULL,
    email VARCHAR(560) NOT NULL,
   primary key (id)    
);";

if ($conn->query($create) === TRUE) {
   //OK
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}
