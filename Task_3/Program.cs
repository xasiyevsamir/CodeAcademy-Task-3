namespace Task_3;

class Program
{
    static void Main(string[] args)
    {
        // A, B ededleri arasinda 3e tam bolunen ededleri tapan alqoritm

        for (int i = 0; i <=100; i++)
        {
            if (i%3==0 && i>0)
            {
                Console.WriteLine(i);
            }
        }


       
        // Verilmish ededin 2-nin quvveti olub olmadigini
        // tapan alqoritm misal: 8 quvvetidir, 6 quvveti deyil

        int data = 8, number = data;
        bool value = true;
        for (; data > 0; data /= 2)
        {
            if (data % 2 != 0 && data != 1)
            {
                Console.WriteLine($"{number} ededi 2 quvveti deyil.");
                value = false;
                break;
            }
        }
        if (value)
        {
            Console.WriteLine($"{number} ededi 2 quvvetidir.");
        }
    }
}
