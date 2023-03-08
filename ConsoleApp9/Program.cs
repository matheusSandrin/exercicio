//EXERCÍCIO 2, FIBONACCI
Console.WriteLine("exercicio 2");
int num, a = 0, b = 1, c = 0;

Console.Write("Digite um número: ");
num = int.Parse(Console.ReadLine());

while (c < num)
{
    c = a + b;
    a = b;
    b = c;
}

if (c == num)
{
    Console.WriteLine("{0} pertence à sequência de Fibonacci.", num);
}
else
{
    Console.WriteLine("{0} não pertence à sequência de Fibonacci.", num);
}

Console.WriteLine();
Console.WriteLine("---------------------------------------------------------");
Console.WriteLine("exercício 5");

string input = "exemplo de string";
char[] chars = input.ToCharArray();

int left = 0;
int right = chars.Length - 1;

while (left < right)
{
    char temp = chars[left];
    chars[left] = chars[right];
    chars[right] = temp;

    left++;
    right--;
}

string reversed = new string(chars);
Console.WriteLine(reversed);