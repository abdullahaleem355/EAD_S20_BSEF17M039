                isDblClick = false;  // to handle single click and dbclick behaviour we used timeout. 
                $('.folder-panel').on('click', '.f-div', function() {
                    var fId = $(this).attr("id");
                    setTimeout(function(){
                    if (!isDblClick){
                        $('#' + fId).siblings().attr("class", "f-div col-sm-3 mt-4 ml-5");
                        $('#' + fId).attr("class","clicked-f-div col-sm-3 mt-4 ml-5");
                    } 
                   }, 20);
                });  
               
                $('.folder-panel').on('dblclick', '.f-div, .clicked-f-div', function() {
                    isDblClick = true;
                    var dataToSend = {"action": "getFolderNames" , "p-folder" : $(this).attr("id")}; // as we've given parent folder id to folder-panel div.
                    var settings = {
                        type: "POST",
                        dataType: "json",
                        url: 'folderInfoApi.php',
                        data: dataToSend,
                        success: displayChildFolders
                    };
                    $.ajax(settings);

                    function displayChildFolders(res){
                         // response recieved [parent's id, child's[{id,name}{id,name}...]]
                        $('div.folder-row').remove();
                        var rowDiv = $('<div>').attr("class", "row folder-row");
                        for(var i = 1; i < res.length; i++){
                            var folderDiv = $('<div>');
                            $(folderDiv).attr("class", "f-div col-sm-3 mt-4 ml-5").attr("id", res[i]["f_id"]);
                            $(folderDiv).html('<h6>' + res[i]["f_name"] + '</h6>');
                            $(rowDiv).append(folderDiv);
                    }
                        $('.folder-panel').attr("id", res[0]);  // now the dbclicked folder becomes the parent folder, so we set it's id to folder-panel div.
                        $('.folder-panel').append(rowDiv); 
                    }
                    setTimeout(function() {
                    isDblClick = false;
                    }, 20);
                });