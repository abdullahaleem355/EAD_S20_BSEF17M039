<?php require ('dbconn.php');
    
    if(isset($_REQUEST["signup-btn-submit"]) == true){
        session_start();

        $loginId = $_REQUEST["user-login-id"];
        $sql = "SELECT * from `user table` where '$loginId'=Login";
        $result = mysqli_query($conn, $sql);
        $recordsFound = mysqli_num_rows($result);
        if($recordsFound == 0){
            $passwd = $_REQUEST["user-passwd"];
            $confirmPasswd = $_REQUEST["user-confirm-passwd"];
            if(strcmp($passwd, $confirmPasswd) != 0){
                $_SESSION["passwd-match-error"] = "Password you entered does not match with confirm password.";
                header('Location:signup.php');
            }
            else{
                $fName = $_REQUEST["user-name"];
                $insertQuery = "INSERT INTO `user`(Name, Login, Password) VALUES ('$fName', '$loginId', '$passwd')";
                if(mysqli_query($conn, $insertQuery) === true){  // we will redirect user from here to log in page.
                    header('Location:login.php');
                }
            }
        }
        else{
            $_SESSION["unique-id-error"] = "This Logid Id is already taken, Please choose a different id.";
            header('Location:signup.php');
        }
    }
    else{
        header('Location:login.php');
    }
    ?>