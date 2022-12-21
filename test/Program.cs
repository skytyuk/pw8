using Newtonsoft.Json;
using System.Diagnostics;

namespace test
{
    public class Test
    {
        public int nachalo()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            str = text[random.Next(text.Length)];
            Console.WriteLine(str + "\nНажмите Enter");
            Console.ReadLine();
            thread.Start();
            do
            {
                Console.SetCursorPosition(0, 11);
                Console.Write("        ");
                Console.SetCursorPosition(0, 11);
                key = Console.ReadKey();
                if (str[position] == key.KeyChar)
                {
                    Console.SetCursorPosition(position - (position / 120) * 120, position / 120);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(str[position]);
                    Console.ResetColor();
                    position++;

                }
            } while (thread.IsAlive && stopwatch.ElapsedMilliseconds < 60000);

            thread.Suspend();
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("Stop");
            Thread.Sleep(3000);
            return position;
        }
        private string[] text =
        {"Чтобы узнать, насколько хороша ваша скорость и точность печати в данный момент. В среднем, скорость печати составляет 200 знаков в минуту. Будет отличным результатом, если вы сможете ее превзойти!",
                "Проходя тест несколько раз, вы увидите динамику, как ваш навык улучшается в режиме реального времени. Пройдя онлайн-тест вы получите сертификат скорости печати, который можно добавить к резюме, показать работодателю или похвалиться перед друзьями."
        };
        string str;
        Random random = new Random();
        ConsoleKeyInfo key;
        int position;
        Thread thread = new Thread(() =>
        {
            Stopwatch stop = Stopwatch.StartNew();
            stop.Restart();
            do
            {
                Console.SetCursorPosition(0, 10);
                Console.WriteLine(stop.ElapsedMilliseconds / 1000 + "/60");
                Thread.Sleep(1000);
            }while(true);
        });
        public class Vivod
        {
            List<Res> Spisok = new List<Res>();
            public void RecordsList(Res res)
            {
                if (File.Exists("D:\\Vivod.txt"))
                {
                    string Text = File.ReadAllText("C:\\Vivod.txt");
                    Spisok = JsonConvert.DeserializeObject<List<Res>>(Text);
                }
                Spisok.Add(res);
                string json = JsonConvert.SerializeObject(Spisok);
                File.WriteAllText("D:\\Vivod.txt", json);

                Console.WriteLine("Рекорды:");
                foreach (Res i in Spisok)
                {
                    Console.WriteLine(i.Nik + "    " + i.Min + " символов в минуту   " + i.Sec + " символов в секунду");
                }
                Console.WriteLine("Нажмите Enter ");
                Console.ReadLine();
            }
        }
        public class Res
        {
            public float Min;
            public float Sec;
            public string Nik;
        }
    }
}