<?php

    $conn = mysqli_connect("localhost", "root", "", "google_drive");

    if(!$conn){
        die("Connection Failed". mysqli_connect_error());
    }
?>