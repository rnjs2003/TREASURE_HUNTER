using System;
using System.Runtime.CompilerServices;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp5
{
  internal class Program
  {
        public static void Main(string[] args)
        {
            intro();
        }

        static void intro()
        {
            Console.WriteLine("■ ■ ■ ■  ■ ■ ■   ■ ■ ■ ■     ■       ■ ■    ■     ■  ■ ■ ■   ■ ■ ■ ■");
            Console.WriteLine("   ■     ■    ■  ■          ■ ■    ■     ■  ■     ■  ■    ■  ■      ");
            Console.WriteLine("   ■     ■ ■ ■   ■ ■ ■ ■   ■   ■     ■      ■     ■  ■ ■ ■   ■ ■ ■ ■");
            Console.WriteLine("   ■     ■  ■    ■        ■ ■ ■ ■      ■    ■     ■  ■  ■    ■      ");
            Console.WriteLine("   ■     ■    ■  ■        ■     ■  ■     ■  ■     ■  ■    ■  ■      ");
            Console.WriteLine("   ■     ■    ■  ■ ■ ■ ■  ■     ■    ■ ■      ■ ■    ■    ■  ■ ■ ■ ■");
            Console.WriteLine("─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─");
            Console.WriteLine("           ■     ■  ■     ■  ■     ■  ■ ■ ■ ■  ■ ■ ■ ■  ■ ■ ■  ");
            Console.WriteLine("           ■     ■  ■     ■  ■ ■   ■     ■     ■        ■    ■");
            Console.WriteLine("           ■ ■ ■ ■  ■     ■  ■  ■  ■     ■     ■ ■ ■ ■  ■ ■ ■  ");
            Console.WriteLine("           ■     ■  ■     ■  ■   ■ ■     ■     ■        ■  ■  ");
            Console.WriteLine("           ■     ■    ■ ■    ■     ■     ■     ■ ■ ■ ■  ■    ■");

            Console.WriteLine("검을 강화하여 보스를 잡아보세요! 보물을 찾을 수 있을거에요!");
            Console.WriteLine("1. 게임 시작\n2. 게임 설명");
            Console.WriteLine("다른 입력은 게임을 종료합니다.");
            String input = Console.ReadLine();

            if (input == "1")
            {
                Game();
            }
            else if (input == "2")
            {
                rule();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("게임을 종료합니다.");
            }
        }

        static void Game()
        {
            bool isGameClear = false;
            bool isGameOver = false;
            bool isReStart = true;
            while (isReStart)
            {
                while (!isGameClear && !isGameOver)
                {
                    if (Sword.force == 0)
                    {
                        isReStart = false;
                        Gamescreen();
                    }

                    String select = "";
                    if(select != "1" && select != "2")
                    {
                        Console.WriteLine("1. 강화");
                        Console.WriteLine("2. 공격");
                        select = Console.ReadLine();

                        if (select == "1" && Sword.gold != 0)
                        {
                            Sword.strengthen();
                            Gamescreen();
                        }
                        else if (select == "1" && Sword.gold == 0)
                        {
                            Console.WriteLine("코인이 부족하여 공격만 가능합니다.");
                        }
                        else if (select == "2")
                        {
                            isGameClear = Sword.attack();
                            isGameOver = Sword.gameover();
                            Gamescreen();
                        }
                        else
                        {
                            Console.WriteLine("1과 2만 입력가능합니다.");
                        }
                    }
                }

                if (isGameClear)
                {
                    Console.Clear();
                    Console.WriteLine(Sword.force + "강 검으로 보스를 처치하였습니다!\n");
                    Console.WriteLine("★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★");
                    Console.WriteLine("☆                             ☆");
                    Console.WriteLine("★   보물 상자를 얻었습니다!   ★");
                    Console.WriteLine("☆                             ☆");
                    Console.WriteLine("★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★\n");
                    Console.WriteLine("강화 도전 횟수 : " + Sword.strengthen_count);
                    Console.WriteLine("강화 성공 횟수 : " + Sword.success_count);
                }
                else if (isGameOver)
                {
                    Console.WriteLine("검의 내구도가 다 닳아 전의를 잃었습니다..");
                    Console.WriteLine("강화 도전 횟수 : " + Sword.strengthen_count);
                    Console.WriteLine("강화 성공 횟수 : " + Sword.success_count);
                }

                String restart = "";
                while (restart != "1" && restart != "2")
                {
                    Console.WriteLine("1. 다시하기");
                    Console.WriteLine("2. 게임 종료");
                    restart = Console.ReadLine();

                    if (restart == "1")
                    {
                        Sword.reset();
                        Monster.reset();
                        isGameClear = false;
                        isGameOver = false;
                        isReStart = true;
                    }
                    else if (restart == "2")
                    {
                        isReStart = false;
                    }
                    else
                    {
                        Console.WriteLine("1, 2 중 선택하여 입력해주세요.");
                    }
                }
            }
        }
            
        static void Gamescreen()
        {
            Sword.printsword();
            Monster.bring_monster();
        }

        static void rule()
        {
            Console.Clear();
            Console.WriteLine("플레이어는 내구도 5, 강화 0강짜리 검과 5골드를 가진 채로 게임을 시작합니다.\n");
            Console.WriteLine("검 강화와 몬스터 공격 중 하나의 행동을 계속 고를 수 있습니다.\n");
            Console.WriteLine("검의 내구도가 다 닳으면 게임 오버입니다.\n");
            Console.WriteLine("보스 몬스터의 체력을 다 깎으면 게임 클리어입니다.\n\n");
            Console.WriteLine("시작하려면 아무 키나 입력하세요.");

            String go = Console.ReadLine();
            if (go != "")
            {
                Game();
            }
        }
    }

    
    class Monster
    {
        static public int now_monster = 0;
        static public string name = "슬라임";
        static public int monster_heart = 5;
        static public string monster_heart_dot = "";

        static public void reset()
        {
            now_monster = 0;
            name = "슬라임";
            monster_heart = 5;
            monster_heart_dot = "";
        }

        static public void change()
        {
            if (now_monster == 1)
            {
                name = "유령";
            }
            else if (now_monster == 2)
            {
                name = "나무 괴물";
            }
        }

        static public void bring_monster()
        {
            if (now_monster == 0)
            {
                Slime();
            }
            else if (now_monster == 1)
            {
                Ghost();
            }
            else if (now_monster == 2)
            {
                BossTree();
            }
            print_heart();
        }

        static public void Slime()
        {
            Console.WriteLine("       ■ ■ ■");
            Console.WriteLine("    ■ ■ ■ ■ ■ ■");
            Console.WriteLine("    ■   ■ ■   ■");
            Console.WriteLine("  ■ ■ ■ ■ ■ ■ ■ ■");
            Console.WriteLine("  ■ ■ ■ ∪∪  ■ ■ ■");
            Console.WriteLine("    ■ ■ ■ ■ ■ ■");
        }

        static public void Ghost()
        {
            Console.WriteLine("      ■ ■ ■ ■  ");
            Console.WriteLine("    ■ ■ ■ ■ ■ ■");
            Console.WriteLine("  ■ ■   ■ ■   ■ ■ ");
            Console.WriteLine("  ■ ■ ■ ■ ■ ■ ■ ■");
            Console.WriteLine("  ■ ■ ■ △△  ■ ■ ■ ■ ");
            Console.WriteLine("■ ■ ■ ■ ■ ■ ■ ■ ■ ■");
            Console.WriteLine("■ ■     ■ ■     ■ ■");
        }

        static public void BossTree()
        {
            Console.WriteLine("        ■ ■ ■ ■ ■");
            Console.WriteLine("■ ■   ■           ■");
            Console.WriteLine("■ ■ ■ ■ ■ ■ ■ ■ ■ ■");
            Console.WriteLine("  ■ ■ ■ ■   ■   ■ ■");
            Console.WriteLine("      ■ ■ ■ ■ ■ ■ ■ ■ ■");
            Console.WriteLine("      ■ ■ ■   ■ ■ ■ ■ ■ ■ ■");
            Console.WriteLine("      ■ ■ ■ ■ ■ ■ ■   ■ ■");
            Console.WriteLine("        ■ ■ ■ ■ ■");
        }

        static public void print_monster_attack()
        {
            Console.Clear();
            Console.WriteLine("\n ΣΣ");
            Console.WriteLine("ΣΣΣ 공격에 성공하였습니다.");
            Console.WriteLine("ΣΣΣ " + name + "의 체력이 " + Sword.damage + "만큼 깎였습니다.");
            Console.WriteLine(" ΣΣ\n");
        }

        static public void print_heart()
        {
            monster_heart_dot = "";
            for (int i = 0; i < monster_heart; i++)
            {
                monster_heart_dot += "♥";
            }

            Console.WriteLine("\n\n" + name + "의 체력 : " + monster_heart_dot + "\n\n");
        }
    }
    

    class Sword
    {
        static public int durability = 5;
        static public string durability_dot = " ";
        static public int force = 0;
        static public int gold = 5;
        static public int damage = 0;
        static public int strengthen_count = 0;
        static public int success_count = 0;

        static public void reset()
        {
            durability = 5;
            durability_dot = " ";
            force = 0;
            gold = 5;
            damage = 0;
            strengthen_count = 0; 
            success_count = 0;
        }

        static public void printsword()
        {
            Console.WriteLine("\n보유 골드 : " + gold);
            Console.WriteLine("(+ " + force + "강)");
            Console.WriteLine("■ ■");
            Console.WriteLine("■ ■ ■");
            Console.WriteLine("  ■ ■ ■   ■ ■");
            Console.WriteLine("    ■ ■ ■ ■");
            Console.WriteLine("      ■ ◇ ■  ");
            Console.WriteLine("    ■ ■ ■ ■ ■");
            Console.WriteLine("    ■     ■ ■");
            print_durability();
            Console.WriteLine("현재 검의 데미지 : " + damage + "\n\n");
        }

        static public void strengthen()
        {
            //랜덤함수 설정
            Random rand = new Random();
            int random = rand.Next(0, 100);
            //성공/실패

            gold--;//골드드 소모
            strengthen_count++;//총 강화 횟수 카운트

            if (damage == 0)//강화 확률 변동되는 기준
            {
                if (random > 5)//강화 성공 확률
                {
                    force++;
                    durability++;
                    damage++;
                    print_strengthen_success();
                    success_count++;
                }
                else if (random <= 5)//강화 실패 확률
                {
                    Console.Clear();
                    Console.WriteLine("강화에 실패하셨습니다. \n 0강이므로 강화가 하락하지 않습니다.");
                }
            }
            else if (force > 0 && force <= 3)
            {
                if (random > 15)//강화 성공 확률
                {
                    if (force == 3) { damage ++; }
                    force++;
                    durability++;
                    print_strengthen_success();
                    success_count++;
                }
                else if (random <= 15)//강화 실패 확률
                {
                    if (force == 1) { damage --; }
                        force--;
                    Console.Clear();
                    Console.WriteLine("강화에 실패하셨습니다.");
                }
            }
            else if (force > 3 && force <= 5)
            {
                if (random > 30)//강화 성공 확률
                {
                    if (force == 5) { damage ++; }
                    force++;
                    durability++;
                    print_strengthen_success();
                    success_count++;
                }
                else if (random <= 30)//강화 실패 확률
                {
                    if (force == 4) { damage --; }
                    force--;
                    Console.Clear();
                    Console.WriteLine("강화에 실패하셨습니다.");
                }
            }else if(force > 5 && force <= 10)
            {
                if (random > 50)//강화 성공 확률
                {
                    if (force == 10) { damage++; }
                    force++;
                    durability++;
                    print_strengthen_success();
                    success_count++;
                }
                else if (random <= 50)//강화 실패 확률
                {
                    if (force == 6) { damage--; }
                    force--;
                    Console.Clear();
                    Console.WriteLine("강화에 실패하셨습니다.");
                }
            }
        }

        static public void print_durability()
        {
            durability_dot = "";
            for (int i = 0; i < durability; i++)
            {
                durability_dot += "●";
            }

            Console.WriteLine("\n현재 검의 내구도 : " + durability_dot);
        }

        static public void print_strengthen_success()
        {
            Console.Clear();
            Console.WriteLine("◈ ▽ ▼ ▽ ▼ ▽ ▼ ▽ ▼ ▽ ▼ ▽ ▼ ▽ ▼ ▽ ▼ ◈");
            Console.WriteLine("▷                                 ◀");
            Console.WriteLine("▶         강화에 성공하여         ◁");
            Console.WriteLine("▶       " + force + "강 검이 되었습니다!      ◁");
            Console.WriteLine("▷                                 ◀");
            Console.WriteLine("◈ △ ▲ △ ▲ △ ▲ △ ▲ △ ▲ △ ▲ △ ▲ △ ▲ ◈");
        }

        static public bool attack()
        {
            Monster.print_monster_attack();
            Monster.monster_heart -= damage;
            durability--;
            if(damage != 0){ gold++; }
            if (Monster.monster_heart <= 0 && Monster.now_monster == 0)
            {
                Console.WriteLine("§ "+ Monster.name + "을 사냥하였습니다! \n§ 3골드가 지급됩니다.");
                gold += 3;
                Monster.now_monster ++;
                Monster.change();
                Console.WriteLine("\n" + Monster.name + "이 나타났어요!");
                Monster.monster_heart = 10;
                return false;
            } else if (Monster.monster_heart <= 0 && Monster.now_monster == 1) 
            {
                Console.WriteLine("§ " + Monster.name + "을 사냥하였습니다! \n§ 5골드가 지급됩니다.");
                gold += 5;
                Monster.now_monster++;
                Monster.change();
                Console.WriteLine("\n보스 몬스터 " + Monster.name +"이 등장합니다!");
                Monster.monster_heart = 20;
                return false;
            } else if (Monster.monster_heart <= 0 && Monster.now_monster == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public bool gameover()
        {
            if(durability <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
  }
}
