using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KISSlicerPlugin
{
    public partial class SetupPanel : UserControl
    {
        private KisSlicerInstance _instance;

        public SetupPanel()
        {
            InitializeComponent();
        }

        public void Init(KisSlicerInstance kisSlicerInstance)
        {
            this._instance = kisSlicerInstance;
            this.tbGcode.Text = this._instance.OutFile;
            this.tbExe.Text = this._instance.ExeFile;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            this._instance.ExeFile = this.tbExe.Text;
            this._instance.OutFile = this.tbGcode.Text;
        }

        private void btSelectKiss_Click(object sender, EventArgs e)
        {
            var dialog=new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Filter = "Kissliser|*.exe";
            if (dialog.ShowDialog(this) == DialogResult.OK)
                this.tbExe.Text = dialog.FileName;

        }

        private void btSelectGcode_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Filter = "gcode files|*.gcode";
            if (dialog.ShowDialog(this) == DialogResult.OK)
                this.tbGcode.Text = dialog.FileName;

        }
    }
}
