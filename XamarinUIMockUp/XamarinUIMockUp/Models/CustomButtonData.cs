using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinUIMockUp.Models
{
    public class CustomButtonData
    {
        public CustomButtonData(string categoryName, string image)
        {
            CategoryName = categoryName;
            Image = image;
        }

        public string CategoryName { get; set; }
        public string Image { get; set; }
    }
}
