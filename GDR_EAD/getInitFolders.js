$(document).ready(function(){
    var dataToSend = {"action": "getFolderNames" , "p-folder" : null};
    var settings = {
        type: "POST",
        dataType: "json",
        url: 'folderInfoApi.php',
        data: dataToSend,
        success: displayFolders
    };
    $.ajax(settings);

    function displayFolders(res){

        // response recieved [parent's id, child's[{id,name}{id,name}...]]
        $('row.folder-row').remove();
        var rowDiv = $('<div>').attr("class", "row folder-row");
        for(var i = 1; i < res.length; i++){
            var folderDiv = $('<div>');
            $(folderDiv).attr("class", "f-div col-sm-3 mt-4 ml-5").attr("id", res[i]["f_id"]);
            $(folderDiv).html('<h6>' + res[i]["f_name"] + '</h6>');
            $(rowDiv).append(folderDiv);
        }
        $('.folder-panel').attr("id", res[0]);  // We'll give current folder's id to main folder-panel-div to remember current directory.
        $('.folder-panel').append(rowDiv); 
    } 
});
