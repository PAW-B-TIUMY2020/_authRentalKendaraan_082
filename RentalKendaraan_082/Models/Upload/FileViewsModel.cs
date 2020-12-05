using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalKendaraan_082.Models.Upload
{
    public class FileDetails
    {
        public string Name { get; set; }
        public string Path { get; set; }
    }
    public class FileViewsModel
    {
       
            public List<FileDetails> Files { get; set; } = new List<FileDetails>();
        
    }
}
