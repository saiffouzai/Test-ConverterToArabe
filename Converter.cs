using System;
using System.Collections.Generic;

namespace FnacTest
{
    public class Converter
    {
        private Dictionary<char, int> dictionary = new Dictionary<char, int>
                                                       {
                                                           {'I', 1},
                                                           {'V', 5},
                                                           {'X', 10},
                                                           {'L', 50},
                                                           {'C', 100},
                                                           {'D', 500},
                                                           {'M', 1000}
                                                       };

        public int ConvertRomainNumberToArabe(string romain)
        {
            char[] romainArray = romain.ToCharArray();
            int maxBrothers = 0, previouseValue = 0, resultat = 0;

            foreach (char number in romainArray)
            {
                if (!dictionary.ContainsKey(number))
                {
                    throw new ArgumentException("Impossible de convertir ce nombre");
                }

                var auxNumber = dictionary[number];

                if (auxNumber == 1000)
                {
                    resultat += auxNumber;
                    maxBrothers = 0;
                    previouseValue = 0;
                    continue;
                }

                if (auxNumber == previouseValue)
                {
                    maxBrothers++;
                }

                if (maxBrothers <= 2)
                {
                    resultat += auxNumber;
                    previouseValue = auxNumber;
                }
                else
                {

                    switch (maxBrothers)
                    {
                        case 3:
                            previouseValue = auxNumber;
                            maxBrothers++;
                            break;
                        case 4:
                            int newValue = auxNumber - previouseValue;
                            resultat += newValue;
                            maxBrothers = 0;
                            previouseValue = 0;
                            break;
                    }
                }
            }
            return resultat;
        }
    }
}