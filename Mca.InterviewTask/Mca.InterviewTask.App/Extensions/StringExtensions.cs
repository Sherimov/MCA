using System;
using System.Collections.Generic;
using System.Text;

namespace Mca.InterviewTask.App.Extensions
{
    public static class StringExtensions
    {
        public static string Truncate(this string value)
        {
            return value.Length <= 30 ? value : value.Substring(0, 30) + "...";
        }
    }
}
