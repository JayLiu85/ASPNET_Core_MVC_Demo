using System;
using System.ComponentModel.DataAnnotations;

namespace ASPNET_Core_MVC_Demo.Models.University
{
    public class EnrollmentDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }

        public int StudentCount { get; set; }
    }
}
