using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_SP_No_File.Models
{
    public class CityMaster:EmployeeMaster
    {
        public int CityId {  get; set; }
        public string CityName { get; set; }

    }
}