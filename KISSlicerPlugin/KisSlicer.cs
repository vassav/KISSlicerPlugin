using System.Collections.Generic;
using System.Linq;
using System.Text;
using RepetierHostExtender.interfaces;

namespace KISSlicerPlugin
{
    public class KisSlicer:ISlicer
    {
        internal const string SlicersFolder = @"slicers\KISSlicer\";
        private readonly IHost _host;
        private List<ISlicerInstance> _list=new List<ISlicerInstance>();
        private IRegMemoryFolder _reg;

        public KisSlicer(IHost host)
        {
            this._host = host;
            this._reg = this._host.GetRegistryFolder(SlicersFolder);
            foreach (string str in this._reg.folders())
            {
                this.CreateInstance(str);
            }
            if ((this._list.Count == 0))
            {
                this.CreateInstance("KISSlicer");
            }
        }


        public override string ToString()
        {
            return this.Name;
        }

        public ISlicerInstance CreateInstance(string name)
        {
            var item=new KisSlicerInstance(name,this._host);
            this._list.Add(item);
            return item;
        }

        public List<ISlicerInstance> GetInstances()
        {
            return this._list;
        }

        public void RemoveInstance(ISlicerInstance inst)
        {
            this._list.Remove(inst);
            this._host.GetRegistryFolder(SlicersFolder + inst.Name).DeleteThisFolder();
        }

        public string Name { get { return "KISSlicer"; } }
    }
}
