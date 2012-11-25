using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace FractalViewer
{
    public partial class OptionsForm : Form
    {
        private FractalsForm fractalsForm;
        public OptionsForm(FractalsForm fractalsForm, int maxIterations, int gamma, int intensity)
        {
            InitializeComponent();
            maxIterationsTextBox.Text = maxIterations.ToString();
            gammaTrackBar.Value = gamma;
            intensityTrackBar.Value = intensity;
            this.fractalsForm = fractalsForm;
        }
        

        private void resetButton_Click(object sender, EventArgs e)
        {
            maxIterationsTextBox.Text = "800";
            gammaTrackBar.Value = 1;
            intensityTrackBar.Value = 255;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            int maxIterations = System.Convert.ToInt32(maxIterationsTextBox.Text);
            int gamma = gammaTrackBar.Value;
            int intensity = intensityTrackBar.Value;
            fractalsForm.setOptionsParameters(maxIterations, gamma, intensity);
            fractalsForm.Invalidate();
            this.Close();
        }
    }
}
