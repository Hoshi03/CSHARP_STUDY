using System;

namespace Csharp
{
    class TextRpg
    {
        enum ClassType
        {
            None = 0,
            Knight = 1,
            Archer = 2,
            Mage = 3
        };

        struct Player 
        {
            public int hp;
            public int atk;
        }

        enum MonsterType
        {
            None = 0,
            Slime = 1,
            Orc = 2,
            Skeleton = 3
        };

        struct Monster
        {
            public int hp;
            public int atk;
        }

        static ClassType ChooseClass()
        {
            Console.WriteLine("직업을 선택하세요!");
            Console.WriteLine("(1) 기사");
            Console.WriteLine("(2) 궁수");
            Console.WriteLine("(3) 법사");
            ClassType choice = ClassType.None;


            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    choice = ClassType.Knight;
                    break;
                case 2:
                    choice = ClassType.Archer;
                    break;
                case 3:
                    choice = ClassType.Mage;
                    break;
            }

            return choice;
        }

        static void CreatePlayer(out Player player, ClassType choice)
        {
            switch (choice)
            {
                case ClassType.Knight:
                    player.hp = 100;
                    player.atk = 10;
                    break;
                case ClassType.Archer:
                    player.hp = 75;
                    player.atk = 12;
                    break;
                case ClassType.Mage:
                    player.hp = 50;
                    player.atk = 15;
                    break;
                default:
                    player.hp = 0;
                    player.atk = 0;
                    break;
            }
        }

        static void EnterGame(ref Player player)
        {
            while (true)
            {
                Console.WriteLine("게임 ON");
                Console.WriteLine("[1] 필드로 가기");
                Console.WriteLine("[2] 로비로 돌아가기");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        EnterField(ref player);
                        break;

                    case "2":
                        return;//함수를 빠져나감


                }
            }
        }

        static void CreateMonster(out Monster monster)
        {
            Random rand = new Random();

            int randmonster = rand.Next(1, 4);//  1~3

            switch (randmonster)
            {
                case (int)MonsterType.Slime:
                    Console.WriteLine("슬라임");
                    monster.hp = 20;
                    monster.atk = 2;
                    break;
                case (int)MonsterType.Orc:
                    Console.WriteLine("오크");
                    monster.hp = 40;
                    monster.atk = 4;
                    break;
                case (int)MonsterType.Skeleton:
                    Console.WriteLine("스켈레톤");
                    monster.hp = 50;
                    monster.atk = 5;
                    break;
                default:
                    monster.hp = 0;
                    monster.atk = 0;
                    break;

            }

        }

        static void EnterField(ref Player player)
        {
            while (true)
            {

                Console.WriteLine("필드 on");
                Monster monster;

                CreateMonster(out monster);

                Console.WriteLine("[1] battle");
                Console.WriteLine("[2] run");

                string input = Console.ReadLine();
                if(input == "1")
                {
                    Battle(ref player, ref monster);
                }

                else if (input == "2")
                {
                    Random rand = new Random();
                    int randvalue = rand.Next(1, 101);
                    if (randvalue <= 33)
                    {
                        Console.WriteLine("도망 성공");
                        break;
                    }

                    else
                        Battle(ref player, ref monster);

                }
            }

        }

        static void Battle(ref Player player, ref Monster monster)
        {
            while (true)
            {
                monster.hp -= player.atk;
                if (monster.hp <= 0)
                {
                    Console.WriteLine("승리!");
                    Console.WriteLine($"남은 체력 {player.hp}");
                    break;
                }

                player.hp -= monster.atk;
                if(player.hp <= 0)
                {
                    Console.WriteLine("패배");
                    ClassType choice = ChooseClass();
                    if (choice != ClassType.None)
                    {

                        CreatePlayer(out player, choice);

                    }

                    break;
                }
            }
        }

        static void Main(string[] args)
        {

            while (true)
            {
                ClassType choice = ChooseClass();
                if (choice != ClassType.None)
                {
                    Player player;

                    CreatePlayer(out player, choice);
                    /*Console.WriteLine($"hp = {player.hp} atk = {player.atk}");*/

                    EnterGame(ref player);

                }

            }
        }
    }
}