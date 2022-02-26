using Beryllium.Models;
using System.Collections.Generic;

namespace Beryllium.ViewModel
{
    public class HomeViewModel
    {
        public List<Slider> sliders { get; set; }
        public List<Project> Projects { get; set; }
        public List<News> News { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<Offer> Offers { get; set; }
    }
}
