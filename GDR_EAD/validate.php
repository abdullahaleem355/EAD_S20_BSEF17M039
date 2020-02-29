<?php require ('dbconn.php');

    if(isset($_REQUEST["login-btn-submit"]) == true){
        session_start(); 

        $loginId = $_REQUEST["user-login-name"];
        $passwd = $_REQUEST["user-password"];

        $sql = "SELECT * from `user` where '$loginId'=Login AND '$passwd'=Password";
        $result = mysqli_query($conn, $sql);
        $recordsFound = mysqli_num_rows($result);

        if($recordsFound == 0){
            $_SESSION["login-error"] = "Log Id or password does not exist.";
            header('Location:login.php');
        }
        else{
            $_SESSION["user"] = $loginId;
            $_SESSION["parent-folder"] = null;
            header('Location:home.php');
        }
    }
    else{
        header('Location:login.php');
    }
?>