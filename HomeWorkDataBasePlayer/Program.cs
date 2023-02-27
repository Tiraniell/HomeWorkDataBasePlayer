using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDataBasePlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>()
                {
                new Player("Dima ", 1, 1, true),
                new Player("Leha ", 2, 2, false),
                new Player("Igor ", 3, 3, true),
                new Player("Roma ", 4, 4, true)
                };

            players.Add(new Player("Gogi ", 1, 1, true));

            foreach (var player in players)
            {
                player.ShowInfo();
            }
        }
    }

    class DataBase
    {
        private List<Player> players = new List<Player>();

        private int _idCounter = 0;

        private void AddPlayer(Player player)
        {
            if(player== null)
            {
                return;
            }

            player.SetId(_idCounter++);

            players.Add(player);
        }
        private void RemovePlayer()
        {

        }      

        public void Ban()
        {
            //IsBanned = true;
        }

        public void Unban()
        {
            //IsBanned = false;
        }
    }

    class Player
    {
        public string Name { get; }
        public int Id { get; private set; }
        public int Level { get; private set; }
        public bool IsBanned { get; private set; }

        public Player(string name, int id, int level, bool isBanned)
        {
            Name = name;
            Id = id;
            Level = level;
            IsBanned = isBanned;
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public void Ban()
        {
            if (IsBanned == true)
            {
                Console.WriteLine("Забанен");
            }
        }

        public void Unban()
        {
            if (IsBanned == false)
            {
                Console.WriteLine("Не забанен");
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Имя героя - " + Name + " ID игрока - " + Id, " Уровень игрока - " +
                Level + " Статус - " + IsBanned);
        }
    }
}
