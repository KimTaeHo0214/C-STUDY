using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Numerics;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== 가위바위보 게임 ===");
            Console.WriteLine("가위(1), 바위(2), 보(3) 중 하나를 숫자로 입력하세요.");
            Console.Write("나의 선택: ");

            // 1. 플레이어 입력받기 (문자를 숫자로 변환)
            int Loman = int.Parse(Console.ReadLine());

            // 2. 컴퓨터의 선택 (1~3 중 랜덤 뽑기)
            Random number = new Random();
            int computer = number.Next(1, 4);

            // 3. 플레이어가 낸 것 화면에 출력 (switch문 활용)
            Console.Write("player: ");
            switch (Loman)
            {
                case 1: Console.WriteLine("가위"); break;

                case 2: Console.WriteLine("바위"); break;

                case 3: Console.WriteLine("보"); break;

                case 20: Console.WriteLine("하.... 잘못된 숫자라고 몇번이나 말하냐,,,"); return;

                case 21: Console.WriteLine("마지막 기회다... 한번만 더 잘못된 숫자 쓰면..."); return;

                case 22: Console.WriteLine("..."); return;

                case 23: Console.WriteLine("어머나 이렇게 겁 줘도 끝까지 잘못된 숫자 쓰네? 너는 마침 이스터에그 하나 발견한거야!"); return;

                case 404: Console.WriteLine("에러 코드 404 말하는건가?"); return;

                default: Console.WriteLine("잘못된 숫자야 다시 써줄 수 있지?"); return;
            }

            // 4. 컴퓨터가 낸 것 화면에 출력
            Console.Write("컴퓨터: ");
            switch (computer)
            {
                case 1: Console.WriteLine("가위"); break;

                case 2: Console.WriteLine("바위"); break;

                case 3: Console.WriteLine("보"); break;
            }

            // 5. 승패 판정 로직 (if / else if / else 활용)
            if (Loman == computer)
            {
                Console.WriteLine("결과: 무승부입니다!");
            }
            else if ((Loman == 1 && computer == 3) ||
                     (Loman == 2 && computer == 1) ||
                     (Loman == 3 && computer == 2))
            {
                Console.WriteLine("결과: 당신이 승리했습니다!\n컴퓨터: 내가 지다니! 정말 부끄럽군!");
            }
            else
            {
                Console.WriteLine("결과: 당신이 패배했습니다...\n컴퓨터: 내가 이겼네? 다음 기회를 노려보렴.");
            }
        }
    }
}
