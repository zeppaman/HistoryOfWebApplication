<?php

 require "include.php";

$name=$_POST["name"];
$email= $_POST["email"];

 $sql = "INSERT INTO contacts (contact_name, email) VALUES ('".$name."','".$email."')";

 if ($conn->query($sql) === TRUE) {
     echo "New record created successfully";
 } else {
     echo "Error: " . $sql . "<br>" . $conn->error;
 }

?>


<html>
<body>

Welcome <?php echo  $name ?><br>
Your email address is: <?php echo $email?>

</body>
</html>

<?php
echo 'Connected successfully';
mysqli_close($conn);
?>

