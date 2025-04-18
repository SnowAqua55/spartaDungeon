namespace SpartaRPG
{
    public class sparta
    {
        class Inventory
        {
            public List<ItemList> Items = new List<ItemList>();
        }
        class Player
        {
            public string name;
            public string job;
            public int lvl;
            public int atk;
            public int def;
            public int hp;
            public int gold;

            public void PlayerInfo()
            {
                Console.Clear();

                Console.WriteLine("내 정보");
                Console.WriteLine("나의 정보가 표시됩니다.\n");
                Console.WriteLine("────────────────────");
                Console.WriteLine($"NAME: {name}");
                Console.WriteLine($"LV: {lvl}");
                Console.WriteLine($"CLASS: {job}");
                Console.WriteLine($"ATK: {atk}");
                Console.WriteLine($"DEF: {def}");
                Console.WriteLine($"HP: {hp}");
                Console.WriteLine($"GOLD: {gold}");
                Console.WriteLine("────────────────────");
                Console.WriteLine("0. 나가기");
            }
        }
        class itemList
        {

        }
        struct ItemList
        {
            public string ItemName;
            public string ItemDescription;
            public int AtkOption;
            public int DefOption;
            public string ItemPrice;
        }
        public static List<string> inventory = new List<string>();

        

        

        static void Main(string[] args)
        {
            Player player = new Player();

            ItemList commonWeapon;
            ItemList uncommonWeapon;
            ItemList rareWeapon;
            commonWeapon.ItemName = "낡은 검";
            commonWeapon.ItemDescription = "쉽게 볼 수 있는 낡은 검입니다.";
            commonWeapon.ItemPrice = "600";
            commonWeapon.AtkOption = 2;
            uncommonWeapon.ItemName = "청동 도끼";
            uncommonWeapon.ItemDescription = "어디선가 사횽했던 것 같은 도끼입니다.";
            uncommonWeapon.ItemPrice = "1500";
            uncommonWeapon.AtkOption = 5;
            rareWeapon.ItemName = "스파르타의 창";
            rareWeapon.ItemDescription = "스파르타의 전사들이 사용했다는 전설의 창입니다.";
            rareWeapon.ItemPrice = "4000";
            rareWeapon.AtkOption = 7;

            ItemList commonArmor;
            ItemList uncommonArmor;
            ItemList rareArmor;
            commonArmor.ItemName = "수련자 갑옷";
            commonArmor.ItemDescription = "수련에 도움을 주는 갑옷입니다";
            commonArmor.ItemPrice = "1000";
            commonArmor.DefOption = 5;
            uncommonArmor.ItemName = "무쇠갑옷";
            uncommonArmor.ItemDescription = "무쇠로 만들어져 튼튼한 갑옷입니다.";
            uncommonArmor.ItemPrice = "2000";
            uncommonArmor.DefOption = 9;
            rareArmor.ItemName = "스파르타의 갑옷";
            rareArmor.ItemDescription = "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.";
            rareArmor.ItemPrice = "3500";
            rareArmor.DefOption = 15;

            void InvenInfo()
            {
                Console.Clear();

                Console.WriteLine("인벤토리");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                Console.WriteLine("\n[아이템 목록]\n");
                Console.WriteLine("────────────────────");

                if (!inventory.Any())
                {
                    Console.WriteLine("인벤토리가 비어있습니다.");
                }
                else
                {
                    foreach (string invList in inventory)
                    {
                        Console.WriteLine($"- {invList}");
                    }
                }
                Console.WriteLine("────────────────────");
                Console.WriteLine("1. 장착 관리");
                Console.WriteLine("0. 나가기");
            }
            void EqupmentInfo()
            {

            }


            while (player.name == null)
            {
                Console.Clear();

                Console.WriteLine("곧 스파르타 마을에 방문할 예정입니다.");
                Console.Write("\n이곳에서 사용하실 이름을 정해주세요.\n>> ");
                player.name = Console.ReadLine();

                Console.Clear();

                Console.WriteLine($"[{player.name}]\n정말 이 이름으로 하시겠습니까?");
                Console.WriteLine("1. 예");
                Console.WriteLine("2. 아니오");
                Console.Write("\n원하시는 행동을 입력해주세요.\n>> ");
                while (true)
                {
                    string input = Console.ReadLine();
                    if (input == "1")
                        break;
                    else if (input == "2")
                    {
                        player.name = null;
                        break;
                    }
                    else
                        Console.Write("\n올바른 행동을 입력해주세요.\n>> ");
                    continue;

                }
            }

            while (player.job == null)
            {
                Console.Clear();

                Console.WriteLine("원하시는 직업을 선택해주세요.");
                Console.WriteLine("────────────────────");
                Console.WriteLine("1. 전사");
                Console.WriteLine("2. 도적");
                Console.WriteLine("3. 궁수");
                Console.WriteLine("4. 마법사");
                Console.WriteLine("────────────────────");
                Console.Write("\n>> ");
                string input = Console.ReadLine();

                Console.Clear();

                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("정말 [전사]로 선택하시겠습니까?");
                        Console.WriteLine("1. 예");
                        Console.WriteLine("2. 아니오");
                        Console.Write("\n원하시는 행동을 입력해주세요.\n>> ");
                        while (true)
                        {
                            input = Console.ReadLine();

                            if (input == "1")
                            {
                                player.job = "[전사]";
                                break;
                            }
                            else if (input == "2")
                                break;
                            else
                            {
                                Console.Write("\n올바른 행동을 입력해주세요.\n>> ");
                                continue;
                            }
                        }
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("정말 [도적]으로 선택하시겠습니까?");
                        Console.WriteLine("1. 예");
                        Console.WriteLine("2. 아니오");
                        Console.Write("\n원하시는 행동을 입력해주세요.\n>> ");
                        while (true)
                        {
                            input = Console.ReadLine();

                            if (input == "1")
                            {
                                player.job = "[도적]";
                                break;
                            }
                            else if (input == "2")
                                break;
                            else
                            {
                                Console.Write("\n올바른 행동을 입력해주세요.\n>> ");
                                continue;
                            }
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("정말 [궁수]로 선택하시겠습니까?");
                        Console.WriteLine("1. 예");
                        Console.WriteLine("2. 아니오");
                        Console.Write("\n원하시는 행동을 입력해주세요.\n>> ");
                        while (true)
                        {
                            input = Console.ReadLine();

                            if (input == "1")
                            {
                                player.job = "[궁수]";
                                break;
                            }
                            else if (input == "2")
                                break;
                            else
                            {
                                Console.Write("\n올바른 행동을 입력해주세요.\n>> ");
                                continue;
                            }
                        }
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("정말 [마법사]로 선택하시겠습니까?");
                        Console.WriteLine("1. 예");
                        Console.WriteLine("2. 아니오");
                        Console.Write("\n원하시는 행동을 입력해주세요.\n>> ");
                        while (true)
                        {
                            input = Console.ReadLine();

                            if (input == "1")
                            {
                                player.job = "[마법사]";
                                break;
                            }
                            else if (input == "2")
                                break;
                            else
                            {
                                Console.Write("\n올바른 행동을 입력해주세요.\n>> ");
                                continue;
                            }
                        }
                        break;

                }

            }

            

            while (true)  // 메뉴 화면
            {
                Console.Clear();

                Console.WriteLine("스파르타 마을에 오신 것을 환영합니다.\n");
                Console.WriteLine("이곳에서 던전으로 들아가기 전 활동을 할 수 있습니다.\n");
                Console.WriteLine("────────────────────");
                Console.WriteLine("1. 내 정보");
                Console.WriteLine("2. 인벤토리");
                Console.WriteLine("3. 상점");
                Console.WriteLine("4. 던전");
                Console.WriteLine("5. 휴식");
                Console.WriteLine("6. 저장");
                Console.WriteLine("────────────────────");
                Console.Write("\n원하시는 행동을 입력해주세요.\n>> ");

                while (true)
                {
                    string input = Console.ReadLine();
                    switch (input)
                    {
                        case "1":
                            {
                                player.PlayerInfo();
                                Console.Write("\n원하시는 행동을 입력해주세요.\n>> ");
                                while (true)
                                {
                                    input = Console.ReadLine();
                                    switch (input)
                                    {
                                        case "0":
                                            {
                                                break;
                                            }
                                        default:
                                            {
                                                Console.Write("\n올바른 행동을 입력해주세요.\n>> ");
                                                continue;
                                            }
                                    } break;
                                } break;
                            } // 내 정보
                        case "2":
                            {
                                InvenInfo();
                                Console.Write("\n원하시는 행동을 입력해주세요.\n>> ");
                                while (true)
                                {
                                    input = Console.ReadLine();
                                    switch (input)
                                    {
                                        case "1":
                                            {
                                                Console.Clear();
                                                Console.WriteLine("인벤토리 - 장착 관리");
                                                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                                                Console.WriteLine("\n[아이템 목록]\n");
                                                Console.WriteLine("────────────────────");
                                                if (!inventory.Any())
                                                {
                                                    Console.WriteLine("인벤토리가 비어있습니다.");
                                                }
                                                else
                                                {
                                                    
                                                    foreach (string invList in inventory)
                                                    {
                                                        Console.WriteLine($"{invList}");
                                                    }
                                                }
                                                Console.WriteLine("────────────────────");
                                                Console.WriteLine("0. 나가기");
                                                Console.Write("\n원하시는 행동을 입력해주세요.\n>> ");
                                                input = Console.ReadLine();
                                                
                                                while (int.TryParse(input, out int number))
                                                {

                                                } break;


                                                    break;
                                            }
                                        case "0":
                                            {
                                                break;
                                            }
                                    } break;
                                } break;  // 장착 관리 while 끝내기
                                    break;  // case 2 끝내기
                            } // 인벤토리
                        case "3":
                            {
                                Console.Clear();

                                Console.WriteLine("상점");
                                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다");
                                Console.WriteLine("\n[보유 골드]");
                                Console.WriteLine($"{player.gold} G");
                                Console.WriteLine("────────────────────");
                                Console.WriteLine($"- {commonArmor.ItemName} | 방어력 + {commonArmor.DefOption} | {commonArmor.ItemDescription} | {commonArmor.ItemPrice} G");
                                Console.WriteLine($"- {uncommonArmor.ItemName} | 방어력 + {uncommonArmor.DefOption} | {uncommonArmor.ItemDescription} | {uncommonArmor.ItemPrice} G");
                                Console.WriteLine($"- {rareArmor.ItemName} | 방어력 + {rareArmor.DefOption} | {rareArmor.ItemDescription} | {rareArmor.ItemPrice} G");
                                Console.WriteLine($"- {commonWeapon.ItemName} | 공격력 + {commonWeapon.AtkOption} | {commonWeapon.ItemDescription} | {commonWeapon.ItemPrice} G");
                                Console.WriteLine($"- {uncommonWeapon.ItemName} | 공격력 + {uncommonWeapon.AtkOption} | {uncommonWeapon.ItemDescription} | {uncommonWeapon.ItemPrice} G");
                                Console.WriteLine($"- {rareWeapon.ItemName} | 공격력 + {rareWeapon.AtkOption} | {rareWeapon.ItemDescription} | {rareWeapon.ItemPrice} G");
                                Console.WriteLine("────────────────────");
                                Console.WriteLine("1. 아이템 구매");
                                Console.WriteLine("2. 아이템 판매");
                                Console.WriteLine("0. 나가기");
                                Console.Write("\n원하시는 행동을 입력해주세요.\n>> ");
                                while (true)
                                {
                                    input = Console.ReadLine();
                                    switch (input)
                                    {
                                        case "0":
                                            {
                                                break;
                                            }
                                        case "1":
                                            {
                                                Console.WriteLine("상점 - 아이템 구매");
                                                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다");
                                                Console.WriteLine("\n[보유 골드]");
                                                Console.WriteLine($"{player.gold} G");
                                                Console.WriteLine("────────────────────");
                                                Console.WriteLine($"1. {commonArmor.ItemName} | 방어력 + {commonArmor.DefOption} | {commonArmor.ItemDescription} | {commonArmor.ItemPrice} G");
                                                Console.WriteLine($"2. {uncommonArmor.ItemName} | 방어력 + {uncommonArmor.DefOption} | {uncommonArmor.ItemDescription} | {uncommonArmor.ItemPrice} G");
                                                Console.WriteLine($"3. {rareArmor.ItemName} | 방어력 + {rareArmor.DefOption} | {rareArmor.ItemDescription} | {rareArmor.ItemPrice} G");
                                                Console.WriteLine($"4. {commonWeapon.ItemName} | 공격력 + {commonWeapon.AtkOption} | {commonWeapon.ItemDescription} | {commonWeapon.ItemPrice} G");
                                                Console.WriteLine($"5. {uncommonWeapon.ItemName} | 공격력 + {uncommonWeapon.AtkOption} | {uncommonWeapon.ItemDescription} | {uncommonWeapon.ItemPrice} G");
                                                Console.WriteLine($"6. {rareWeapon.ItemName} | 공격력 + {rareWeapon.AtkOption} | {rareWeapon.ItemDescription} | {rareWeapon.ItemPrice} G");
                                                Console.WriteLine("────────────────────");
                                                Console.WriteLine("1. 아이템 구매");
                                                Console.WriteLine("2. 아이템 판매");
                                                Console.WriteLine("0. 나가기");
                                                Console.Write("\n원하시는 행동을 입력해주세요.\n>> ");
                                                while (true)
                                                {
                                                    input = Console.ReadLine();
                                                    switch (input)
                                                    {
                                                        case "0":
                                                            {
                                                                break;
                                                            }
                                                    } break;
                                                } break;

                                            }
                                            
                                    } break;
                                } break;
                            } // 상점
                        case "4":
                            {
                                break;
                            } // 던전
                        case "5":
                            {
                                break;
                            } // 휴식
                        case "6":
                            {
                                break;
                            } // 저장
                        default:
                            Console.Write("\n올바른 행동을 입력해주세요.\n>>");
                            continue; // 그 외

                    }
                    break; // switch 끝
                } // while 끝
            }
        }
    }
}
