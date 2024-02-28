using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCorporation.Domain.Entities.ForToken
{
  
     public class TokenUser
     {
         public Guid Id { get; set; } = Guid.NewGuid();
         public string FullName { get; set; }
         public string Login { get; set; }
         public string Password { get; set; }
         public string Role { get; set; }

     }
    
}
