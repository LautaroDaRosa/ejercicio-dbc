//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Linq;


namespace Full_GRASP_And_SOLID
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }
        
        public void AddStep(Step step)
        {
            int cantStepIni= steps.Count;
            //precondicones
            if(step==null)
            {
                throw new NullReferenceException("Step vacio");
            }
            
            
            //precondiciones
               if (this.steps.Contains(step))
            {
               throw new ArgumentException("El step ya existe.");
            } 

            this.steps.Add(step);

            //poscondiciones
            if(!this.steps.Contains(step))
            {
                throw new NullReferenceException("No se agrego step");
            }
        }

        public void RemoveStep(Step step)
        {

            int cantStepIni= steps.Count;
            //precondicones
            if(step==null)
            {
                throw new ArgumentNullException("Step vacio");
            }
         

            //precondicion

            if (!this.steps.Contains(step))
            {
               throw new ArgumentException("El step no existe.");
            } 

            this.steps.Remove(step);
            //poscondiciones
            if(this.steps.Contains(step))
            {
                throw new NullReferenceException("No se eliminó correctamente el step");
            }
         
        
        }

        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                // precondicion
                if(step==null)
                {
                    throw new NullReferenceException("Paso vacio");
                }
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
                // postcondicion vacia
            }
        }
    }
}