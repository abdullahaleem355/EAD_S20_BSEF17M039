<?php require ('dbconn.php');
    
    session_start();
if(isset($_SESSION["user"]) == true){

    if($_REQUEST["action"] == "getFolderNames"){
        $fName;
        if($_REQUEST["p-folder"] == null)
            $fName = 0;
        else{
            $fName = $_REQUEST["p-folder"];
        }
        $sql = "SELECT * from `folder` where '$fName'=ParentFolderId";
        $result = mysqli_query($conn, $sql);
        $recordsFound = mysqli_num_rows($result);
        $folderData = (array) null;
        array_push($folderData, $fName);
        if($recordsFound > 0){
            while($row = mysqli_fetch_assoc($result)){
                $folderInfo = array("f_id" => $row["FolderId"], "f_name" => $row["FolderName"]);
                array_push($folderData, $folderInfo);
            }
        }
        echo json_encode($folderData);
    }
    else if($_REQUEST["action"] == "createFolder"){
        $newFolderInfo = (array) null;
        if($_REQUEST["new-folder-name"] == null){
            echo json_encode(array("error-msg" => "Folder Name is Mandatory!"));
        }
        else{
            $newF = $_REQUEST["new-folder-name"];
            $parent = $_REQUEST["p-folder"];
            $sql = "SELECT * from `folder` where '$parent'=ParentFolderId AND '$newF'=FolderName";
            $result = mysqli_query($conn, $sql);
            $recordsFound = mysqli_num_rows($result);
            $insertQuery;
            if($recordsFound > 0){
                echo json_encode(array("error-msg" => "Folder Name must be unique!"));
            }
            else{
                $insertQuery = "INSERT INTO `folder` (`FolderName`, `ParentFolderId`) VALUES ('$newF', '$parent')";
                if(mysqli_query($conn, $insertQuery) === true){
                    $sql = "SELECT * from `folder` where '$newF'=FolderName AND '$parent'=ParentFolderId"; //get the id of the newly inserted folder
                    $result = mysqli_query($conn, $sql);
                    $row = mysqli_fetch_assoc($result);
                    array_push($newFolderInfo, array("id"=>$row["FolderId"], "new-f-name"=>$newF));
                    echo json_encode($newFolderInfo);
                }
            }
        }
    }
}
else{
    echo "Un-authorized hit! (No User logged in).";
}
?>