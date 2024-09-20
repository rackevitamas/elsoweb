
namespace TombokProjekt
{
    public static class TombMuveletek
    {
        public static int GetEgyesekSzama(int[] tomb) 
        {
            int db = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == 1)
                {
                    db++;
                }
            }
            return db;
        }
        public static int GetDbElozoKetSzamKetszerese(int[] tomb) 
        {
            int db = 0;
            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i] == tomb[i - 1] * 2)
                    db++;
            }
            return db; 
        }
        public static int GetDbElozoKetSzamNegyzete(int[] tomb)
        {
            int db = 0;
            for (int i = 1; i < tomb.Length ; i++)
            {
                if (tomb[i] == Math.Pow(tomb[i - 1], 2))
                    db++;
            }
            return db;
        }
        public static int GetElozoKora(int a, int b, int[] tomb)
        {
            string ak = "Az a-nak korábban szerepel!";
            string bk = "A b-nek korábban szerepel!";
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == a)
                {
                    if (tomb[i + 1] == b)
                    {
                        return ak;
                    }
                }
                else if (tomb[i] == b)
                {
                    if (tomb[i + 1] == a)
                    {
                        return bk;
                    }
                }
            }
            return 0;
        }
    }
}
