namespace test
{
    class Itog_Prog
    {
        public static void Main()
        {
            List<Test.Res> list = new List<Test.Res>();

            do
            {
                Test A = new Test();
                Test.Res B = new Test.Res();
                
                Test.Vivod C = new Test.Vivod();
                Console.Clear();
                Console.WriteLine("Введите имя:");
                B.Nik = Console.ReadLine();
                Console.Clear();
                int pos = A.nachalo();
                B.Min = pos;
                B.Sec = (float)pos / 60;
                Console.Clear();
                C.RecordsList(B);
            }
            while (true);
        }
    }
}