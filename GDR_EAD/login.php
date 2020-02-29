<?php session_start();
     $_SESSION["user"] = null;  //If user gets logged out and comes to this screen, its session gets expired.
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="bootstrap-js-jquery-files/bootstrap.min.css">
    <link rel="stylesheet" href="css/generic-stylesheet.css">
    <script src="bootstrap-js-jquery-files/jquery-3.4.1.js"></script>
    <script src="bootstrap-js-jquery-files/popper.min.js"></script>
    <script src="bootstrap-js-jquery-files/bootstrap.min.js"></script>
    <title>login</title>
</head>
<body id="back-theme">

        <nav class="navbar navbar-expand-md login-nav-style">
            <a class="navbar-brand text-white font-weight-bold" href="#"> Google Drive Replica </a>
            <button class="btn btn-danger btn-sm ml-auto" id="signup-btn"> Create a new account</button>
        </nav>

    <div class="text-center">

    <div class="text-left">
       
        
        <div class="container">
            <form action="validate.php" method="POST">
                <div class="row mt-5">
                    <div class="col-sm-6 offset-sm-3">
                        <h3 style="color:white;">Log in to existing account.</h3>
                    </div>
                </div>
                <div class="row mt-5">
                    <div class="col-sm-6 offset-sm-3">
                        <input type="text" class="form-control" required placeholder="Enter Login Id" name="user-login-name"/>
                    </div>
                </div>

                <div class="row mt-5">
                    <div class="col-sm-6 offset-sm-3">
                        <input type="password" class="form-control" required placeholder="Enter Password" name="user-password"/>
                    <div>
                </div>

                <?php if(isset($_SESSION["login-error"]) == true && !empty($_SESSION["login-error"])){ ?>
                    <div class="row mt-5">
                        <div class="col-sm-6 offset-sm-3">
                            <p style="color:red;"><?php echo $_SESSION['login-error']; ?></p>
                        </div>
                    </div>
            <?php } ?>

                <input class="btn btn-success btn-block mt-5" type="submit" name="login-btn-submit" value="Login"/>

            </form>

        </div>

    </div>
</div>

    <script>
         $('#signup-btn').click(function(){
            window.location.href = 'signup.php';
        });
    </script>
   
</body>
</html>

<?php session_unset();
      session_destroy(); ?>