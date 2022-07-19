using System.Linq;
using Practica.Models;

namespace Practica
{
    public static class SampleData
    {
        public static void Initialize(MobileContext context)
        {
            if (!context.Players.Any())
            {
                context.Players.AddRange(
                    new Player
                    {
                        Name = "Alohadance",
                        Team = "None",
                        Rang = 14999
                    },
                    new Player
                    {
                        Name = "EvilArtas",
                        Team = "None",
                        Rang = 0
                    },
                    new Player
                    {
                        Name = "Daxak",
                        Team = "Winstrake",
                        Rang = 15000
                    }
                );
                context.SaveChanges();
            }
        }
    }
}