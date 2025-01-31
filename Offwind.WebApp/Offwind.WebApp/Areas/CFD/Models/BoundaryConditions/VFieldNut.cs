﻿using Offwind.Products.OpenFoam.Models.Fields;

namespace Offwind.WebApp.Areas.CFD.Models.BoundaryConditions
{
    public class VFieldNut
    {
        public decimal InternalField { get; set; }

        public PatchType BottomType { get; set; }
        public decimal BottomCmu { get; set; }
        public decimal BottomKappa { get; set; }
        public decimal BottomE { get; set; }
        public decimal BottomValue { get; set; }

        public PatchType TopType { get; set; }
        public decimal TopCmu { get; set; }
        public decimal TopKappa { get; set; }
        public decimal TopE { get; set; }
        public decimal TopValue { get; set; }

        public PatchType WestType { get; set; }
        public decimal WestValue { get; set; }

        public PatchType EastType { get; set; }
        public decimal EastValue { get; set; }

        public PatchType NorthType { get; set; }
        public decimal NorthValue { get; set; }

        public PatchType SouthType { get; set; }
        public decimal SouthValue { get; set; }
    }
}