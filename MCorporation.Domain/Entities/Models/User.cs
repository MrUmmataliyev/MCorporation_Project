using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCorporation.Domain.Entities.Models
{
   
     public class TokenUser
     {
         public int Id { get; set; }
         public string FullName { get; set; }
         public string Login { get; set; }
         public string Password { get; set; }
         public string Role { get; set; }

     }
    
}

