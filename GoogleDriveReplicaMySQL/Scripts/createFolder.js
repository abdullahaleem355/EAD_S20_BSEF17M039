$('#create-new-folder').click(function(){                                                                 
    // as folder-panel div has parent folder id as its id.
    var dataToSend = {"action": "createFolder" , "new-folder-name":$('#new-folder-name').val(),"p-folder" : $('.folder-panel').attr("id")};
    var settings = {
    type: "POST",
    dataType: "json",
    url: '/User/FolderInfo',
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
