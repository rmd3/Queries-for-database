using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Anjolell_cc5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void patientInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._D_AnjolellMedicalDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_D_AnjolellMedicalDataSet.patientInfo' table. You can move, or remove it, as needed.
            this.patientInfoTableAdapter.Fill(this._D_AnjolellMedicalDataSet.patientInfo);

        }

        private void btnHeight_Click(object sender, EventArgs e)
        {
            this.patientInfoTableAdapter.FillByHeight(this._D_AnjolellMedicalDataSet.patientInfo);
        }

        private void btnWeightOver_Click(object sender, EventArgs e)
        {
            this.patientInfoTableAdapter.FillByWeightOver(this._D_AnjolellMedicalDataSet.patientInfo);
        }

        private void btnWeightUnder_Click(object sender, EventArgs e)
        {
            this.patientInfoTableAdapter.FillByWeightLess(this._D_AnjolellMedicalDataSet.patientInfo);
        }

        private void btnA1c_Click(object sender, EventArgs e)
        {
            this.patientInfoTableAdapter.FillByA1c(this._D_AnjolellMedicalDataSet.patientInfo);
        }

        private void btnAge_Click(object sender, EventArgs e)
        {
            this.patientInfoTableAdapter.FillByAge(this._D_AnjolellMedicalDataSet.patientInfo);
        }
    }
}
