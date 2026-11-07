using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mr.Edip_s_guzel_Programmers_Project1
{
    public class Player
    {
        public string Name { get; set; }
        public int AvatarIndex { get; set; }
        public int Points { get; set; }


        public Player(string name, int avatarIndex)
        {
            Name = name.ToUpper();
            AvatarIndex = avatarIndex;
            Points = 0;
        }

        public void AddPoints(int points)
        {
            Points++;
        }


    }
}
