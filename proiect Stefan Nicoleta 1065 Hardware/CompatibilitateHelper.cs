using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_Stefan_Nicoleta_1065_Hardware
{
    public partial class CompatibilitateHelper: Form
    {
        public CompatibilitateHelper()
        {
            InitializeComponent();
        }

        
            public static Dictionary<string, List<string>> compatibilitate = new Dictionary<string, List<string>>
    {
        { "Lenovo", new List<string> { "RAM DDR4", "SSD NVMe", "Placa video dedicata","Mouse" } },
        { "Dell", new List<string> { "RAM DDR5", "HDD SATA", "DVD/CD","Tastatura" } },
        { "Asus", new List<string> { "RAM DDR4", "SSD SATA", "Placa video integrata" } },
        {"Apple", new List<string>{ "Procesor","RAM DDR5","SSD NVMe PCle","GPU integrat","Placa de baza","Tastatura","Mouse"} }
    };
        
    }
}
