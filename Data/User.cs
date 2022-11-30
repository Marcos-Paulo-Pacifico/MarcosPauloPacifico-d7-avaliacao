using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcosPauloPacifico_d7_avaliacao.Data;

public class User
{
    public Guid UserId { get; set; } 
    public string Email { get; set; }
    public string Password { get; set; }
}
