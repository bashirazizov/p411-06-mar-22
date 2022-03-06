using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace phantom.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }

        public Blog(string Title, string SubTitle, string Text, string Image)
        {
            this.Title = Title;
            this.SubTitle = SubTitle;
            this.Text = Text;
            this.Image = Image;
        }
    }
}
