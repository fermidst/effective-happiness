using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace SodaVendingService.Models
{
    public class VendingSession
    {
        public VendingStates VendingState { get; set; }
        public int CoinsInTray { get; set; }
        public int SelectedSodaId { get; set; }
        public int Change { get; set; }

        public void InsertMoney(int value)
        {
            if (VendingState != VendingStates.HasMoney)
            {
                VendingState = VendingStates.HasMoney;
                CoinsInTray += value;
            }
            else
                CoinsInTray += value;
        }

        public void DispenseSoda(int sodaId, IList<Soda> sodas)
        {
            var soda = sodas.Single(s => s.SodaId == sodaId);

            if (soda.SodaStock < 1)
            {
                VendingState = VendingStates.Failure;
                Change = CoinsInTray;
                CoinsInTray = 0;
                return;
            }

            if (CoinsInTray < soda.SodaPrice)
            {
                VendingState = VendingStates.NotEnough;
                return;
            }

            if (VendingState == VendingStates.HasMoney)
            {
                VendingState = VendingStates.Success;
                Change = CoinsInTray - soda.SodaPrice;
                CoinsInTray = 0;
                sodas.Single(s => s.SodaId == sodaId).SodaStock -= 1;
                File.WriteAllText("wwwroot/inventory.json", JsonConvert.SerializeObject(sodas));
            }
            else
            {
                VendingState = VendingStates.NoMoney;
            }
        }
    }
}