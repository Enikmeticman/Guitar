using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuitarMass_FRM
{
    class DynamicControls
    {
        public List<PictureBox> StringKeys { get; set; }

        public DynamicControls()
        {
            StringKeys = new List<PictureBox>();
        }
    }
}
