using System.Diagnostics;
using System.Threading.Tasks;

namespace ElectronCashApi
{
    public static class ElectronCashService
    {
        public static async Task<string> SendCommandAsync(string command)
        {
            var p = new Process();
            p.StartInfo.FileName = "electron-cash";
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.Arguments = command;
            p.Start();
            var result = await p.StandardOutput.ReadToEndAsync();

            return result;
        }
    }
}