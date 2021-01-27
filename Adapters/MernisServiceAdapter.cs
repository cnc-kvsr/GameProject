using GameProject.Abstract;
using GameProject.Entities;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace GameProject.Adapters
{
    public class MernisServiceAdapter : IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            return TaskAsync(player).Result;
        }
        public static async Task<bool> TaskAsync(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var durum = await (client.TCKimlikNoDogrulaAsync(Convert.ToInt64(player.NationalityId),
                player.FirstName.ToUpper(), player.LastName.ToUpper(), player.DateOfBirth.Year));
            return durum.Body.TCKimlikNoDogrulaResult;
        }
    }
}
