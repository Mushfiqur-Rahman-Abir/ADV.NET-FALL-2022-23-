using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using static Zero_Hunger.Models.restaurant;

namespace Zero_Hunger.Models
{

    [MetadataType(typeof(employeeMetaData))]
    public partial class employee
    {
        public class employeeMetaData
        {
            [DisplayName("Employee Name")]
            public string empname { get; set; }

            [DisplayName("Employee Address")]
            public string address { get; set; }

            [DisplayName("Employee Mobile no")]
            public Nullable<int> mobile { get; set; }
        }
    }
}