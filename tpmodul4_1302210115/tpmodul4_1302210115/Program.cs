// See https://aka.ms/new-console-template for more information
namespace tpmodul4_1302210115
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            KodePos table_Kodepos = new KodePos();
            Console.WriteLine("==== All Post Code ====");
            table_Kodepos.getAllkodepos();

            Console.WriteLine("==== DOOR KEY ====");

            DoorMachine pintu = new DoorMachine();

            pintu.kunci();

        }

    }
}

class KodePos
{
    Dictionary<string, string> dic = new Dictionary<string, string>() {
            {"Batununggal", "40266"},
            {"Kujangsari","40287" },
            {"Mengger"  ,"40267" },
            {"Wates"    ,"40256" },
            {"Cijaura"  ,"40287"},
            {"Jatisari" ,"40286" },
            {"Margasari","40286"},
            {"Sekejati" ,"40286" },
            {"Kebonwaru","40272"},
            {"Maleer"   ,"40274"},
            {"Samoja"   ,"40273"} };
    public void getKodepos(string Sugoi)
    {
        if (dic.ContainsKey(Sugoi))
        {
            Console.WriteLine(Sugoi + " : " + dic[Sugoi]);
        }
        else
        {
            Console.WriteLine(Sugoi + " Not Founded ");
        }
    }

    public void getAllkodepos()
    {
        foreach (KeyValuePair<string, string> ele1 in dic)
        {
            Console.WriteLine("{0} \t\t {1}", ele1.Key, ele1.Value);
        }
    }
}

class DoorMachine
{
    enum State { Locked, Opened };
    public void kunci()
    {
        State state = State.Locked;

        String[] screenName = { "Terkunci", "Terbuka" };
        do
        {
            Console.WriteLine("Pintu " + screenName[(int)state]);
            Console.Write("Enter Command : ");
            String command = Console.ReadLine();
            switch (state)
            {
                case State.Locked:
                    if (command == "Pintu Terbuka")
                    {
                        state = State.Opened;
                    }
                    break;
                case State.Opened:
                    if (command == "Pintu Terkunci")
                    {
                        state = State.Locked;
                    }
                    break;
            }
        } while (state != State.Locked);
    }
}
