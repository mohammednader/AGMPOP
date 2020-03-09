using System;
using System.Collections.Generic;
using System.Text;

namespace AGMPOP.BL.Models.ViewModels
{

    public class UserDetailsDto
    {
        public int Id { get; set; }
        public string Name { get;  set; }
        public int JobTitleId { get;  set; }
        public string JobTitleName { get;  set; }
        public int DepartmentId { get;  set; }
    
    }

}
