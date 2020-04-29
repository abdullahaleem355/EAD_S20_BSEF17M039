$(document).ready(function(){
	
	var basePath = "https://localhost:44393/";
    var dataToSend = {"Action": "getFolderNames" , "Pfolder" : null , "NewFolderName" : null};
    var settings = {
        type: "POST",
        dataType: "json",
        url: basePath + 'api/FolderData/FolderInfo',
        data: dataToSend,
        success: displayFolders
    };
    $.ajax(settings);

    function displayFolders(res){
        // response recieved {parent's id, folderlist}
        $('row.folder-row').remove();
        var rowDiv = $('<div>').attr("class", "row folder-row");
        for(var i = 0; i < res.folderlist.length; i++){
            var folderDiv = $('<div>');
			var folderObj = res.folderlist[i];
            $(folderDiv).attr("class", "f-div col-sm-3 mt-4 ml-5").attr("id", folderObj.FolderID);
            $(folderDiv).html('<h6>' + folderObj.FolderName + '</h6>');
            $(rowDiv).append(folderDiv);
        }
        $('.folder-panel').attr("id", res.id);  // We'll give current folder's id to main folder-panel-div to remember current directory.
        $('.folder-panel').append(rowDiv); 
    } 
});
