using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zero_Hunger.Models
{
    [MetadataType(typeof(FrestaurentMetaData))]
    public partial class Frestaurent
    {
        
       public class FrestaurentMetaData
        {


            [DisplayName("Restaurent Name")]
            public string resname { get; set; }

            [DisplayName("Restaurent Address")]
            public string address { get; set; }
            [DisplayName("Food Item")]
            public string fooditem { get; set; }

            [DisplayName("Availabile")]
            public string available { get; set; }
            public System.DateTime date { get; set; }



        }
      
    }
}