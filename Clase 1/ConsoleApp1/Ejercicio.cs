namespace ConsoleApp1
{
    public class Ejercicio
    {
        public static int BuscarMayor(int A, int B, int C)
        {
            if (A < B)
            {
                if (B < C)
                {
                    return C;
                }
                else
                {
                    if (B == C)
                    {
                        if (A == B)
                        {
                            return -1;
                        }
                        else
                        {
                            return A;
                        }
                    }
                    else
                    {
                        return B;
                    }
                }
            }
            else if (A < C)
            {
                return C;
            }
            else if (A == B)
            {
                if (B == C)
                {
                    return -1;
                }
                else
                {
                    return C;
                }
            }
            else if (A == C)
            {
                if (A == B)
                {
                    return -1;
                }
                else
                {
                    return B;
                }
            }
            else
            {
                return -1;
            }
        }
    }
}
