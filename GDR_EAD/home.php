<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="bootstrap-js-jquery-files/bootstrap.min.css">
    <link rel="stylesheet" href="css/generic-stylesheet.css">
    <link rel="stylesheet" href="css/home-stylesheet.css">
    <script src="bootstrap-js-jquery-files/jquery-3.4.1.js"></script>
    <script src="bootstrap-js-jquery-files/popper.min.js"></script>
    <script src="bootstrap-js-jquery-files/bootstrap.min.js"></script>
</head>

<?php session_start();
        if(isset($_SESSION["user"]) == false){
            header('Location:login.php');
        }
        if($_SESSION["parent-folder"] == null){ ?>
            <script type="text/javascript" src="getInitFolders.js"></script>
       
<?php } ?>   

<body id="back-theme">
    
        <nav class="navbar navbar-expand-md login-nav-style">
            <a class="navbar-brand text-white font-weight-bold" href="#"> Google Drive Replica </a>
            <div class="dropdown ml-auto" id="drop-btn">
                <button class="dropdown btn btn-danger btn-sm" data-toggle="dropdown"><?php echo $_SESSION["user"]?></button>
                <ul class="dropdown-menu dropdown-menu-right bg-dark">
                    <li class="nav-item text-center"> <a href="login.php"><p class="mx-auto my-auto font-weight-bold" style="color:white;">Log Out</p></a></li>
                </ul>
            </div>
        </nav>
        
         <!-- We will show directory here -->

        <button class="btn btn-success btn-sm ml-4 mt-4" id="create-folder" data-toggle="modal" data-target="#myModal"> Create Folder + </button>

        <div class="container folder-panel mt-5"></div>

    <div class="modal fade" id="myModal" role="dialog">
        <div class="modal-dialog">
        
   
        <!-- Modal content-->
      <div class="modal-content">
        <div class="modal-header">
          <h4 class="modal-title">Create a new Folder.</h4>
          <button type="button" class="close" data-dismiss="modal">&times;</button>
        </div>
        <div class="modal-body row">
            <div class="col-sm-4">
                <h5>Folder Name:</h5>
            </div>
            <div class="col-sm-6">
                <input type="text" id="new-folder-name" class="form-control"/>
            </div>
        </div>
        <div class="modal-footer">
          <button type="button" class="btn btn-success" id="create-new-folder" data-dismiss="modal">Create</button>
        </div>
      </div>
      
        </div>
    </div>

        <script type="text/javascript" src="getChFolders.js"></script>

        <script type="text/javascript" src="createFolder.js"></script>

</body>
</html>
