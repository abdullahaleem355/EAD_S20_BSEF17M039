using Entities;
using GDR.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDR.BAL
{
    public class FolderBO
    {
        public static List<FolderDTO> GetChildFolders(String pParentFolder)
        {
            return FolderDAO.GetChildFolders(pParentFolder);
        }

        public static FolderDTO CreateFolder(String pFolderName, String pParentID)
        {
            return FolderDAO.CreateFolder(pFolderName, pParentID);
        }
    }
}
