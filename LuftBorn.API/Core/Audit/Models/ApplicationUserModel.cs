using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Audit.Models
{

    public class ApplicationUserModel
    {

        public string UserName { get; set; }

        public string Token { get; set; }




    }
}
