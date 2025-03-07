using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rapha_LIS_III.Views
{

    public partial class MainForm : MaterialForm, IPatientView
    {
        public MainForm()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

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

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
        }

        public string SearchValue
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }
        public bool IsEdit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsSuccessful { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PatientFirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string patientLastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string patientMiddleName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int patientAge { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string patientSex { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string patientAddress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string patientCivilStatus { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string patientReligion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string patientContact { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string patientTest { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;

        public void SetPatienttListBindingSource(BindingSource patientList)
        {
            dgvPatients.DataSource = patientList;
        }

    }
}
