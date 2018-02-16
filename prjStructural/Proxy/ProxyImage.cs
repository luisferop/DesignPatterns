using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjStructural.Proxy
{
    public class ProxyImage : Image
    {
        private String _filename;
        private RealImage _image;

        public ProxyImage(String filename)
        {
            _filename = filename;
        }
        public override void DisplayImage()
        {
            if (_image == null)
            {
                _image = new RealImage(_filename);
            }
            _image.DisplayImage();
        }
    }
}
