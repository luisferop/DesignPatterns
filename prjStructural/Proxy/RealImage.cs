using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjStructural.Proxy
{
    public class RealImage : Image
    {
        private String _filename;
        public RealImage(String filename)
        {
            _filename = filename;
            LoadImageFromDisk();
        }
        private void LoadImageFromDisk()
        {
            Console.WriteLine($"Loading {_filename}");
        }
        public override void DisplayImage()
        {
            Console.WriteLine($"Displaying {_filename}");
        }
    }
}
