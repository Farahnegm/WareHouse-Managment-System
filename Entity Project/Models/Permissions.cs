using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Project.Models
{
    
    [Flags] 
    public enum Permission
    {
        None = 0,   
        Search = 1,   // 0001
        Update = 2,   // 0010
        Add = 4,   // 0100
        FullControl = Search | Update | Add //= 7 (0111)
    }
}
