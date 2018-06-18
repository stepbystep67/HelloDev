using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;


namespace HelloDev.Models
{


    public class Restaurant
    {

        // le framework le gere on a pas a sen occupé
        public int ID { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        [StringLength(15,MinimumLength =9)]
        public string Telephone { get; set; }


        public string Specialite { get; set; }

        public Restaurant()
        {



        }

    }

}
