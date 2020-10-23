//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        //Receipe se encarga de calcular el costo total en base a los costos de cada Step. Expert.
        public double GetProductionCost
        {
            get
            {
                double result = 0;
                foreach (Step item in this.steps)
                {
                    result = result + item.StepCost;   
                }
                return result;
            }
        }

        //PrintRecipe esta mal que este en esta clase, deberia de estar en una clase separada (SRP)
        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
            Console.WriteLine($"Total: {this.GetProductionCost}");
        }
    }
}