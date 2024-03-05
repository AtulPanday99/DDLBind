using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_SP_No_File.Models
{
    public class StateMaster : EmployeeMaster
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
    }
}