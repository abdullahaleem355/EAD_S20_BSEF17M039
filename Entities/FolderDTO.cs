using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class FolderDTO
    {
        public int FolderID { set; get; }

        public String FolderName { set; get; }

        public int ParentFolderID { set; get; }
    }
}
