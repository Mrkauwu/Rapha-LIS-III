using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rapha_LIS_III.Views
{
    public partial class UserControlForm : MaterialForm
    {
        public UserControlForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
            (Primary)0xFFFFFF,  // Pure white background
            (Primary)0xF1F8E9,  // Very light green (subtle medical feel)
            (Primary)0xC8E6C9,  // Slightly darker green (depth)
            (Accent)0x66BB6A,   // Soft green accent (natural and calming)
            TextShade.BLACK     // Black text for contrast
);
        }

        
    }
}
