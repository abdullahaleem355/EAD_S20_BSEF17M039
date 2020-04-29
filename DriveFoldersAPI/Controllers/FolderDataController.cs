using Entities;
using GDR.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DriveFoldersAPI.Controllers
{
    public class FolderArgs
    {
        public String Action { get; set; }
        public String Pfolder { get; set; }
        public String NewFolderName { get; set; }
    }


    [EnableCors(origins: "https://localhost:44333", headers: "*", methods: "*")]
    public class FolderDataController : ApiController
    {
        [Authorize]
        [HttpPost]
        public Object FolderInfo([FromBody]FolderArgs pData)
        {
            if (pData.Action == "getFolderNames")
            {
                String PfName = null;
                if (pData.Pfolder != null)
                    PfName = pData.Pfolder;
                List<FolderDTO> folderlist = FolderBO.GetChildFolders(PfName);
                if (String.IsNullOrEmpty(PfName))
                {
                    var data = new
                    {
                        id = 0,
                        folderlist
                    };
                    return data;
                }
                else
                {
                    var data = new
                    {
                        id = PfName,
                        folderlist
                    };
                    return data;
                }
            }

            else if (pData.Action == "createFolder")
            {
                if (String.IsNullOrEmpty(pData.NewFolderName))
                {
                    var error = new
                    {
                        errorMsg = "Folder name is mandatory!"
                    };
                    return error;
                }
                else
                {
                    String FolderName = pData.NewFolderName;
                    String PFolder = pData.Pfolder;
                    FolderDTO dto = FolderBO.CreateFolder(FolderName, PFolder);
                    if (dto.FolderID == -1) // if already exists, id must have -1.
                    {
                        var error = new
                        {
                            errorMsg = "Folder name must be unique!"
                        };
                        return error;
                    }

                    var data = new
                    {
                        id = dto.FolderID,
                        newfoldername = dto.FolderName
                    };
                    return data;
                }
            }
            return "Invalid Hit.";
        }
    }
}
