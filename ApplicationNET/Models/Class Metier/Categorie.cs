using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApplicationNET.Models.Class_Metier
{
    public class Categorie
    {
        public int CategorieID { get; set; }
        [Display(Name = ("Nom de la categorie : "))]
        public string NomCategorie { get; set; }

    }
}