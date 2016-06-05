using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using RepetierHostExtender.interfaces;

namespace KISSlicerPlugin
{
    public class KisSlicerInstance : ISlicerInstance
    {
        private readonly string _name;
        private readonly IHost _host;
        private SetupPanel _setupPanel;
        private IRegMemoryFolder _reg;
        private Panel _panel = new Panel();
        private FileSystemWatcher _watcher;

        public KisSlicerInstance(string name, IHost host)
        {
            this._name = name;
            this._host = host;
            this._reg = host.GetRegistryFolder(KisSlicer.SlicersFolder + name);
            InitWatcher();

        }

        private void InitWatcher()
        {
            this._watcher = new FileSystemWatcher();
            this._watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
              | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            this._watcher.Filter = "*.gcode";
            this._watcher.Path = Path.GetDirectoryName(this.OutFile);

            // Only watch text files.

            this._watcher.Created += OnChangedFile;
            this._watcher.Changed += OnChangedFile;
            this._watcher.EnableRaisingEvents = true;
        }

        private void OnChangedFile(object sender, FileSystemEventArgs e)
        {
            if (e.FullPath == this.OutFile)
            {
                try
                {
                    var s = File.ReadAllText(this.OutFile);
                    this._host.SlicingFinished(this.OutFile);

                }
                catch (IOException err)
                {
                    //throw;
                }

            }
        }


        public bool PrepareSlicing()
        {
            return true;
        }

        public void Slice(string[] files, string output)
        {
            var strFormat = "\"{0}\"";
            var exe = this.ExeFile;
            if (!File.Exists(exe))
            {
                MessageBox.Show("Not found KISSliser.. \nCheck setting.", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (files.Length > 0)
            {
                var strParams = string.Join(" ", files
                    .Where(x=>x!="-")
                    .Select(x => string.Format(strFormat,x)));
                Process.Start(exe, strParams);
                SetSlice(true);
            }

        }

        private void SetSlice(bool state)
        {
            return;
            this._host.SetSlicing(state);
        }

        public void KillSlicing()
        {
            SetSlice(false);
        }

        public void SelectPrinter(IPrinter printer)
        {
            
        }

        public void RefreshConfigurations()
        {
            
        }

        public void SetAction(string action)
        {
            
        }

        public void SlicingFinished()
        {
            FunctionVoid method = () => this.SetSlice(false);
            this._panel.Invoke(method);
        }


        public string Name { get { return this._name; } }
        public Control Panel { get {return this._panel;} }

        public Control Setup
        {
            get
            {
                if(this._setupPanel==null)
                    this._setupPanel=new SetupPanel();

                this._setupPanel.Init(this);
                return this._setupPanel;
            }
        }

        public string InputFormat { get { return "stls"; } }
        public string SlicerName { get { return "KISSlicer"; } }
        public bool IsAutostart { get { return false; } }
        public DockStyle PanelDockStyle { get {return DockStyle.Top;} }

        public string ExeFile
        {
            get { return this._reg.GetString("ExeFile", "KISSlicer64.exe"); }
            set
            {
                this._reg.SetString("ExeFile", value);
            }
        }

        public string OutFile
        {
            get { return this._reg.GetString("OutFile", Path.Combine(this._host.WorkingDirectory,"composition.gcode")); }
            set
            {
                this._reg.SetString("OutFile",value);
                try
                {
                    this._watcher.Path = Path.GetDirectoryName(value);
                }
                catch (Exception) { }
            }
        }


        public override string ToString()
        {
            return this.Name;
        }
    }
}