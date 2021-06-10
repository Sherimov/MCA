using Mca.InterviewTask.App.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mca.InterviewTask.App
{
    public class Product
    {
        public string Name { get; set; }
        public bool Domestic { get; set; }
        public double Price { get; set; }
        public int Weight { get; set; }
        public string Description { get; set; }


        public override string ToString()
        {
            return $"... {Name} {Environment.NewLine} Price: ${Price} {Environment.NewLine} {Description.Truncate()} {Environment.NewLine} Weight: {Weight.PrintWeight()}" ;
        }
    }
    
    
    
}
