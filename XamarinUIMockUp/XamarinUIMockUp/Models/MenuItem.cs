using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinUIMockUp.Models
{
    public class MenuItem
    {
        public MenuItem(string title, string timeRequired, string image)
        {
            Title = title;
            TimeRequired = timeRequired;
            Image = image;
        }

        public string Title { get; set; }
        public string TimeRequired { get; set; }
        public string Image { get; set; }
        public const string Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
            "Ut at risus sit amet neque vehicula bibendum at in elit. Etiam ullamcorper risus placerat " +
            "sem semper cursus. Vestibulum consectetur ultrices purus, eget elementum enim. Suspendisse " +
            "a interdum risus. Donec eros sapien, pharetra sit amet efficitur vel, luctus ac arcu. " +
            "Integer semper, tortor vitae facilisis auctor, massa ipsum malesuada tellus, eu elementum " +
            "neque sem eu quam. In rutrum facilisis enim, et egestas orci sollicitudin sit amet. " +
            "Quisque pharetra at dui at molestie. Nulla facilisi. Proin sollicitudin aliquam turpis, " +
            "in porta odio accumsan in. Praesent orci ex, maximus quis nisi vitae, molestie mattis odio." +
            " Quisque cursus elit quis efficitur ultricies.";

    }
}
