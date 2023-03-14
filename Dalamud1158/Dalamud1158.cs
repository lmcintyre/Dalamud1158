using Dalamud.Plugin;
using Dalamud.IoC;
using Dalamud.Logging;
using FFXIVClientStructs.FFXIV.Client.Graphics.Kernel;

namespace Dalamud1158
{
    public class Dalamud1158 : IDalamudPlugin
    {
        public string Name => "Dalamud1158";

        private const string CommandName = "/dalamud1158";

        public unsafe Dalamud1158([RequiredVersion("1.0")] DalamudPluginInterface pluginInterface)
        {
            DalamudContainer.Initialize(pluginInterface);

            var test = new SharpDX.Direct3D11.Device((nint)Device.Instance()->D3D11Forwarder);
            var contextTest = test.ImmediateContext;
            PluginLog.Debug($"Device: {test.NativePointer:X} Context: {contextTest.NativePointer:X}");
        }

        public void Dispose()
        {
        }
    }
}
