List<int> nums = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35,
36,37 ,38 ,39 ,40 ,41 ,42 ,43 ,44 ,45 ,46 ,47 ,48 ,49 ,50 ,51 ,52 ,53 ,54 ,55 ,56 ,57 ,58 ,59 ,60 };
Random random = new Random();
int num1 = nums[random.Next(0, nums.Count)];
int num2 = nums[random.Next(0, nums.Count)];
int num3 = nums[random.Next(0, nums.Count)];
int num4 = nums[random.Next(0, nums.Count)];
int num5 = nums[random.Next(0, nums.Count)];
int num6 = nums[random.Next(0, nums.Count)];

List<int> numsSorteados = new() { num1, num2, num3, num4, num5, num6 };

Console.WriteLine($"ALEATÓRIO \n" +
    $"{num1}, {num2}, {num3}, {num4}, {num5}, {num6}\n ");

numsSorteados.Sort();
Console.WriteLine("CRESCENTE");
for (int i = 0; i < numsSorteados.Count; i++)
{
    if (i < numsSorteados.Count - 1)
        Console.Write(numsSorteados[i] + ",");
    else
    {
        Console.Write($"{numsSorteados[i] + "."}\n");
    }
}