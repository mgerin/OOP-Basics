//namespace _04.FirstAndReserveTeam
//{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var team = new Team("Barsa");
        for (int i = 0; i < n; i++)
        {
            var inputArgs = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var player = new Person(inputArgs[0], inputArgs[1], int.Parse(inputArgs[2]), double.Parse(inputArgs[3]));
            team.AddPlayer(player);
        }
        Console.WriteLine($"First team have {team.FirstTeam.Count} players");
        Console.WriteLine($"Reserve team have {team.ReserveTeam.Count} players");
    }
}
//}
