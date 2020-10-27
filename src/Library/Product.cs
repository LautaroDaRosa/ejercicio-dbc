//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Linq;


namespace Full_GRASP_And_SOLID
{
    public class Product
    {
        public Product(string description, double unitCost)
        {

            if (string.IsNullOrEmpty(description))
        {
            throw new ArgumentNullException("description invalida");
        }
        this.Description=description;

        if (double.IsNormal(unitCost))
        {
            throw new ArgumentNullException("unitCost invalido");
        }
        this.UnitCost=unitCost;

       }

        public string Description { get; set; }

        public double UnitCost { get; set; }
    }
}