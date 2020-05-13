using System;
using System.Text;


namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				int s = 0;
				Console.Write("Введите строку: ");
				StringBuilder a = new StringBuilder(Console.ReadLine());
				string str = a.ToString();
				if (!String.IsNullOrWhiteSpace(str))
				{
					for (int i = 0; i < str.Length; i++)
					{
						if (str[i] == ':') s++;
					}
					if (s > 0)
						Console.WriteLine("Символы после последнего двоеточия: " + str.Substring(str.LastIndexOf(':') + 1));
					else Console.WriteLine("Двоеточие в предложении отсутствует!");
				}
				else
				{
					throw new Exception();
				}
			}
			catch { Console.WriteLine("Некорректный ввод!"); }
		}
	}
}
