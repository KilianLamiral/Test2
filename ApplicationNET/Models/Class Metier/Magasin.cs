using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApplicationNET.Models.Class_Metier
{
    public class Magasin
    {
        public int MagasinID { get; set; }
        [Display(Name =("Nom du magasin : "))]
        public string NomMagasin { get; set; }

    }
}