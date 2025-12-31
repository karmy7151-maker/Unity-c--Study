using System;

public class Program
{
    public static void Main()
    {
        // --- [입력 단계] ---
        Console.WriteLine("캐릭터 이름을 입력하세요: ");
        string playerName = Console.ReadLine(); // 유저의 입력을 문자열로 받음

        Console.WriteLine("캐릭터의 나이를 입력하세요: ");
        string ageInput = Console.ReadLine();
        int age = int.Parse(ageInput); // 문자열을 숫자로 변환 (형변환)

        // --- [연산 단계] ---
        int nextYearAge = age + 1; // 내년 나이 계산

        // --- [출력 단계] ---
        Console.WriteLine("\n============================");
        Console.WriteLine($"[캐릭터 정보 등록 완료]");
        Console.WriteLine($"이름: {playerName}");
        Console.WriteLine($"현재 나이: {age}세");
        Console.WriteLine($"내년 나이: {nextYearAge}세");
        Console.WriteLine("============================\n");

      
    }
}
