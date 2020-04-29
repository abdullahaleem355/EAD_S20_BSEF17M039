$('#create-new-folder').click(function(){ 
	
	var basePath = "https://localhost:44393/";                                                                
    // as folder-panel div has parent folder id as its id.
    var dataToSend = {"Action": "createFolder" ,"Pfolder" : $('.folder-panel').attr("id") ,"NewFolderName" : $('#new-folder-name').val()};
    var settings = {
    type: "POST",
    dataType: "json",
    url: basePath + 'api/FolderData/FolderInfo',
    data: dataToSend,
    success: addNewFolder
    };
    $.ajax(settings);
});

function addNewFolder(res){
    if(res.errorMsg){
        alert(res.errorMsg);
    }
    else{
        // true response we recieved is [{id of newly created folder, name of newly created folder}].
        var folderDiv = $('<div>');
        $(folderDiv).attr("class", "f-div col-sm-3 mt-4 ml-5").attr("id", res.id);
        $(folderDiv).html('<h6>' + res.newfoldername + '</h6>');
        $('.folder-row').append(folderDiv);
    }
}
