using System;
using System.Collections.Generic;
using System.Text;

namespace Mca.InterviewTask.App.Extensions
{
    public static class IntegerExtensions
    {
        public static string PrintWeight(this int weight)
        {

            return weight == 0 ? "N/A" : $"{weight}g";
        }

    }
}
