using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KISSlicerPlugin
{
    public partial class SlicePanel : UserControl
    {
        private KisSlicerInstance _instance;

        public SlicePanel()
        {
            InitializeComponent();
        }

        public void Init(KisSlicerInstance instance)
        {
            this._instance = instance;
        }

        private void RunBtnClick(object sender, EventArgs e)
        {
            var host = this._instance.Host;

            var workdir = host.WorkingDirectory;


            int numberOfExtruder = host.ActivePrinter.NumberOfExtruder;
            var strArray = new string[numberOfExtruder];
            bool[] flagArray = host.Scene.UsedExtruders();
            for (int i = 0; i < numberOfExtruder; i++)
            {
                if (flagArray[i])
                {
                    string[] textArray1 = new string[] { workdir, Path.DirectorySeparatorChar.ToString(), "composition", i.ToString(), ".stl" };
                    strArray[i] = string.Concat(textArray1);
                }
                else
                {
                    strArray[i] = "-";
                }
            }



            host.Scene.SaveScene(strArray,0);

            this._instance.SliceInternall(strArray,null,false);
        }
    }
}
