using System;

namespace Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 4;
            /*
             Mine gæt: 
              1. a == b || a > 0 = true
              2. a + b > 0 && a > 0 = true
              3. a == 5 && a + b > 0 = false
              4. (true || false) && a > b = false
              5. 3 > 5 && true || a == b = false
              6. b > a && true || false || b > 4 = true
              7. b < 4 && a < b || a + b > 4 && true = true
              8. true && true || false = true
              9. true && false && true = false
              10. true || false || false = true
              11. false && false = false
              12. a == 3 && b > 4 || a + 3 > b = true
              13. a > b && b < a && a + a == b = false
             */
             /* 
             Resultater:
             1. true
             2. true
             3. false
             4. false
             5. false
             6. true
             7. true
             8. true
             9. false
             10. true
             11. false
             12. true
             13. false
             */
        }
    }
}
