using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zero_Hunger.Models
{

    [MetadataType(typeof(restaurantMetaData))]
    public partial class restaurant
    {

        public class restaurantMetaData
        {
            [DisplayName("Restaurant Name")]
            public string resname { get; set; }

            [DisplayName("Food Item")]
            public string food { get; set; }

            [DisplayName("Quantity(Kg/Pcs)")]
            public string quantity { get; set; }

            [DisplayName("Available")]
            public string available { get; set; }



        }



    }
}