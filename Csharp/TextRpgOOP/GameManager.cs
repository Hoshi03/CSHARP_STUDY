using System;
using System.Collections.Generic;
using System.Text;

namespace TextRpgOOP
{
    public enum GameMode
    {
        None = 0,
        Lobby = 1,
        Town = 2,
        Field = 3
    }
    class GameManager
    {
        private GameMode mode = GameMode.Lobby;
        private Player player = null; // 플레이어 수명을 게임 수명만큼 유지시키기 위해 여기에 선언
        private Monster monster = null;
        private Random rand = new Random();

        public void Process()
        {
            switch (mode)
            {
                case GameMode.Lobby:
                    ProcessLobby();
                    break;

                case GameMode.Town:
                    ProcessTown();
                    break;

                case GameMode.Field:
                    ProcessField();
                    break;
            }
        }
        private void ProcessLobby()
        {
            Console.WriteLine("직업 선택");
            Console.WriteLine("[1] 기사 [2] 궁수 [3] 법사");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    player = new Knight();
                    mode = GameMode.Town;
                    break;

                case "2":
                    player = new Archer();
                    mode = GameMode.Town;
                    break;

                case "3":
                    player = new Mage();
                    mode = GameMode.Town;
                    break;
            }

        }
        private void ProcessTown()
        {
            Console.WriteLine("마을 입장");
            Console.WriteLine("[1] 필드 [2] 마을");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    mode = GameMode.Field;
                    break;

                case "2":
                    mode = GameMode.Lobby;
                    break;


            }
        }

        private void ProcessField()
        {
            Console.WriteLine("필드 입장");
            Console.WriteLine("[1] 전투 [2] 런");

            CreateRandomMonster();// 필드 입장시 랜덤 몬스터 생성

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    ProcessFight();
                    break;

                case "2":
                    TryEscape();
                    break;
            }
            

        }

        private void CreateRandomMonster()
        {
            int randvalue = rand.Next(0, 3);

            switch (randvalue)
            {
                case 0:
                    monster = new Slime();
                    Console.WriteLine("슬라임 생성");
                    break;

                case 1:
                    monster = new Orc();
                    Console.WriteLine("오크 생성");
                    break;

                case 2:
                    monster = new Skeleton();
                    Console.WriteLine("스켈레톤 생성");
                    break;
            }
        }

        private void ProcessFight()
        {
            while (true)
            {
                int dmg = player.Getatk();
                monster.OnDamaged(dmg);
                if (monster.isDead())
                {
                    Console.WriteLine("승리");
                    Console.WriteLine($"남은 체력 {player.Gethp()}");
                    break;
                }

                dmg = monster.Getatk();
                player.OnDamaged(dmg);
                if (player.isDead())
                {
                    Console.WriteLine("사망 ㅠㅠ");
                    mode = GameMode.Lobby;
                    break;
                }
            }
        }

        private void TryEscape()
        {
            int randval = rand.Next(0, 100);
            if(randval < 33)
            {
                mode = GameMode.Town;
            }

            else
            {
                Console.WriteLine("도주 실패");
                ProcessFight();
            }
        }


    }
}
