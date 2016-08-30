using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;

namespace LYL.Controls
{
    public class count : IMarkupExtension
    {
        public Int32 i { get; set; }
        public Int32 j { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return "count="+(i+j).ToString();
        }
    }
}
