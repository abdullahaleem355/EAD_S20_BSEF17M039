using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDR.DAL
{
    public class FolderDAO
    {
        private static FolderDTO DoesFolderExist(String pFolder, String pParentId)
        {
            FolderDTO dto = null;
            String sqlQuery = null;
            if (String.IsNullOrEmpty(pParentId))
                sqlQuery = String.Format("Select * from dbo.Folders where FolderName='{0}' AND ParentFolderID={1}", pFolder, 0);
            else
                sqlQuery = String.Format("Select * from dbo.Folders where FolderName='{0}' AND ParentFolderID={1}", pFolder, pParentId);
            using (DBHelper helper = new DBHelper())
            {
                SqlDataReader reader = helper.ExecuteReader(sqlQuery);
                if(reader.Read())
                {
                    dto = new FolderDTO();
                    dto.FolderID = reader.GetInt32(reader.GetOrdinal("FolderID"));
                    dto.FolderName = reader.GetString(reader.GetOrdinal("FolderName"));
                    dto.ParentFolderID = reader.GetInt32(reader.GetOrdinal("ParentFolderID"));
                }
                return dto;
            }
        }
        public static List<FolderDTO> GetChildFolders(String pParentFolder)
        {
            List<FolderDTO> childFoldersList = new List<FolderDTO>();
            String sqlQuery = null;
            if (String.IsNullOrEmpty(pParentFolder))
                sqlQuery = String.Format("Select FolderID, FolderName from dbo.Folders where ParentFolderID={0}", 0);
            else
                sqlQuery = String.Format("Select FolderID, FolderName from dbo.Folders where ParentFolderID={0}", pParentFolder);
            using (DBHelper helper = new DBHelper())
            {
                SqlDataReader reader = helper.ExecuteReader(sqlQuery);
                while (reader.Read())
                {
                    FolderDTO childFolder = new FolderDTO();
                    childFolder.FolderID = reader.GetInt32(reader.GetOrdinal("FolderID"));
                    childFolder.FolderName = reader.GetString(reader.GetOrdinal("FolderName"));
                    childFoldersList.Add(childFolder);
                }
                return childFoldersList;
            }
        }

        public static FolderDTO CreateFolder(String pFolderName, String pParentFolder)
        {
            FolderDTO dto = FolderDAO.DoesFolderExist(pFolderName, pParentFolder);
            if (dto != null)
            {
                // this name's folder already exists.
                dto.FolderID = -1; // it will tell us the unique id error.
                return dto;
            }
            String insertQuery = null;
            if (pParentFolder == null)
                insertQuery = String.Format("INSERT INTO dbo.Folders(FolderName, ParentFolderID) VALUES ('{0}', {1})", pFolderName, 0);
            else
                insertQuery = String.Format("INSERT INTO dbo.Folders(FolderName, ParentFolderID) VALUES ('{0}', {1})", pFolderName, pParentFolder);
            using (DBHelper helper = new DBHelper())
            {
                int count = helper.ExecuteQuery(insertQuery);
                if (count != 0)
                    dto = FolderDAO.DoesFolderExist(pFolderName, pParentFolder); // get info of newly inserted folder.
            }
            return dto;
        }
    }
}
