using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ElectronCashApi
{
    public static class WalletService
    {
        public static async Task<Balance> GetBalanceAsync()
        {
            var jsonResult = await ElectronCashService.SendCommandAsync("getbalance");
            var result = JsonConvert.DeserializeObject<Balance>(jsonResult);

            return result;
        }

        public static async Task<string> CreateNewAddressAsync()
        {
            return await ElectronCashService.SendCommandAsync("createnewaddress");
        }

        public static async Task<Balance> GetAddressBalanceAsync(string address)
        {
            if (address == null) throw new ArgumentNullException(nameof(address));

            var jsonResult = await ElectronCashService.SendCommandAsync($"getaddressbalance {address}");
            var result = JsonConvert.DeserializeObject<Balance>(jsonResult);

            return result;
        }
    }
}