//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }

        // Como Step contiene a los objetos Equipment y Product, por EXPERT es Step quien
        // debe calcular el costo total del paso actual.
        public double GetProductionCost()
        {
            double CostoInsumos = this.Input.UnitCost;
            double CostoEquipamiento = this.Equipment.HourlyCost * this.Time/3600;
            double CostoTotal = CostoInsumos + CostoEquipamiento;
            return CostoTotal;
        }
    }
}