using System.Threading.Tasks;
using HttpJsonRpc;

namespace ElectronCashApi
{
    [JsonRpcClass("wallet")]
    public static class WalletApi
    {
        [JsonRpcMethod]
        public static async Task<string> CreateNewAddressAsync()
        {
            return await WalletService.CreateNewAddressAsync();
        }

        [JsonRpcMethod]
        public static async Task<Balance> GetBalanceAsync()
        {
            return await WalletService.GetBalanceAsync();
        }

        [JsonRpcMethod]
        public static async Task<Balance> GetAddressBalanceAsync(string address)
        {
            return await WalletService.GetAddressBalanceAsync(address);
        }
    }
}