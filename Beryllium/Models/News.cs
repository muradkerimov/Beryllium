using System;

namespace Beryllium.Models
{
    public class News : Base
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }
    }
}
