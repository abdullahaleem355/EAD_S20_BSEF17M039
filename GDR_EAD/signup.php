<?php session_start(); ?>
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
    <title>signup</title>
</head>
<body id="back-theme">

        <nav class="navbar navbar-expand-md login-nav-style">
            <a class="navbar-brand text-white font-weight-bold" href="#"> Google Drive Replica </a>
            <button class="btn btn-danger btn-sm ml-auto" id="login-btn"> Log In to Existing Account</button>
        </nav>

    <div id="login-form-spacing">

    <div style="text-align:left;">
       
        
        <div class="container">
            <form action="register.php" method="POST">
                <div class="row mt-5">
                    <div class="col-sm-6 offset-sm-3" style="color:white;">
                        <h3>Create A New Account !</h3>
                        <h3 class="mt-4">Just fill this form with appropriate information.</h3>
                    </div>
                </div>
                <div class="row mt-5">
                    <div class="col-sm-6 offset-sm-3">
                        <input type="text" class="form-control" required placeholder="Enter Your Name" name="user-name"/>
                    </div>
                </div>

                <div class="row mt-5">
                    <div class="col-sm-6 offset-sm-3">
                        <input type="text" class="form-control" required placeholder="Enter Login Id" name="user-login-id"/>
                    </div>
                </div>

            <?php if(isset($_SESSION["unique-id-error"]) == true && !empty($_SESSION["unique-id-error"])){ ?>
                    <div class="row mt-5">
                        <div class="col-sm-6 offset-sm-3">
                            <p style="color:red;"><?php echo $_SESSION['unique-id-error']; ?></p>
                        </div>
                    </div>
            <?php } ?>

                <div class="row mt-5">
                    <div class="col-sm-6 offset-sm-3">
                        <input type="password" class="form-control" required placeholder="Enter Password" name="user-passwd"/>
                    </div>
                </div>

                <div class="row mt-5">
                    <div class="col-sm-6 offset-sm-3">
                        <input type="password" class="form-control" required placeholder="Confirm Password" name="user-confirm-passwd"/>
                    </div>
                </div>

                <?php if(isset($_SESSION["passwd-match-error"]) == true && !empty($_SESSION["passwd-match-error"])){ ?>
                    <div class="row mt-5">
                        <div class="col-sm-6 offset-sm-3">
                            <p style="color:red;"><?php echo $_SESSION['passwd-match-error']; ?></p>
                        </div>
                    </div>
            <?php } ?>

                <div class="row mt-5 mb-5">
                    <div class="col-sm-6 offset-sm-3"> 
                        <input class="btn btn-success btn-block" type="submit" name="signup-btn-submit" value="Sign Up"/>
                    </div>
                </div>
            </form>

        </div>

    </div>
</div>

   <script>

        $('#login-btn').click(function(){
            window.location.href = 'login.php';
        });


   </script>

</body>
</html>

<?php session_unset();
      session_destroy(); ?>