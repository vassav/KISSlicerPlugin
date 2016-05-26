using RepetierHostExtender.interfaces;

namespace KISSlicerPlugin
{
    public class KISSlicerPlugin : IHostPlugin
    {
        private IHost _host;

        public void PreInitalize(IHost host)
        {
            this._host = host;
        }

        public void PostInitialize()
        {
            this._host.RegisterSlicer(new KisSlicer(this._host));
            this._host.AboutDialog.RegisterThirdParty("KISSlicerPlugin", "\r\n\r\nKISSlicerPlugin written by Repetier\r\nUse it like you want.");
        }

        public void FinializeInitialize()
        {
            
        }
    }
}