using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Dtos.Fight
{
    public class FightRequestDto
    {
        public List<int> CharacterId { get; set; } = new List<int>();
    }
}