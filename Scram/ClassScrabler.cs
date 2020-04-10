using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scram
{
    class ClassScrabler
    {
        // все оперируемые символы
        private string AllScrChrs = "><!@#$%&*abcdefghiklmnopqrstuvwxyzABCDEFGHIKLMNOPQRSTUVWXYZ1234567890";

        // генерация бинарной строки
        public string BinaryString(string MainString)
        {
            return BinaryWork(MainString);
        }

        // один из методов скремблирующий поступающий тескт
        public string ScrambledString(string MainString)
        {
            return ScrambstrBinaryext(BinaryWork(MainString));
        }

        // работа с главной строкой
        public string MainString(string PassingStr, byte BinaryOrScrambled)
        {
            string MainText = "";
            switch (BinaryOrScrambled)
            {
                case 0:
                    MainText = DecodeBinary(PassingStr);
                    break;
                case 1:
                    MainText = DecodeBinary((UnScrambstrBinaryext(PassingStr)));
                    break;
            }

            return MainText;
        }

        // метод работы с бинарными данными
        private string BinaryWork(string WhatToWorkOn)
        {
            string BinaryResults = "";

            foreach (char GetChr in WhatToWorkOn)
            {
                BinaryResults += GetBinary(GetChr);
            }

            return BinaryResults;
        }

        // декодирование бинарных данных
        private string DecodeBinary(string PassingString)
        {
            int ii;
            string CharResult = "";

            for (ii = 0; ii < PassingString.Length; ii += 8)
            {
                try
                {
                    CharResult += GetCharacter(PassingString.Substring(ii, 8));
                }
                catch (OverflowException) { }
            }
            return CharResult;
        }

        // дескремблирование послепающего бинарного потока
        private string UnScrambstrBinaryext(string Uscr)
        {

            // вырезаем последние 9 символов текста
            // последние 9 символов содержат дополнительный символ с символами 1/0 для усложения криптоалгоритмов
            string[] strOneToZero = new string[3];
            string ScrChrs = AllScrChrs;
            int ii;

            string LastNine = rvsString(Uscr.Substring(Uscr.Length - 9));

            // поиск уникальных символов для усложения криптоалгоритмов
            foreach (char ChrNine in LastNine)
            {
                if (strOneToZero[0] == null)
                {
                    strOneToZero[0] = ChrNine.ToString(); continue;
                }
                if (strOneToZero[0] == ChrNine.ToString()) continue;
                if (strOneToZero[1] == null)
                {
                    strOneToZero[1] = ChrNine.ToString(); continue;
                }
                if (strOneToZero[1] == ChrNine.ToString()) continue;
                strOneToZero[2] = ChrNine.ToString();
                break;
            }

            // нам нужен массив 1 и 2. 0 является дополнительным
            ScrChrs = ScrChrs.Replace(strOneToZero[1], "");
            ScrChrs = ScrChrs.Replace(strOneToZero[2], "");

            for (ii = 0; ii < ScrChrs.Length; ii++)
            {
                Uscr = Uscr.Replace(ScrChrs.Substring(ii, 1), "");
            }

            // этот метод написан для простоты
            Uscr = SingleString(strOneToZero[1], Uscr);
            Uscr = SingleString(strOneToZero[2], Uscr);

            Uscr = Uscr.Replace(";", "");
            Uscr = Uscr.Replace(":", "");
            Uscr = Uscr.Replace(strOneToZero[1], "0");
            Uscr = Uscr.Replace(strOneToZero[2], "1");

            return Uscr.Substring(0, (Uscr.Length - 2));
        } // запоминаем последние два символа, для манипуляции

        // заменить повторяющиеся символы одним
        private string SingleString(string MultiString, string StrFull)
        {
            while (StrFull.IndexOf(MultiString + MultiString) != -1)
            {
                StrFull = StrFull.Replace(MultiString + MultiString, MultiString);
            }

            return StrFull;
        }

        // написал этот реверсер для последних 9 символов зашифрованного текста
        private string rvsString(string ReverseThis)
        {
            string rvSt = "";
            int ii;
            for (ii = (ReverseThis.Length - 1); ii > 0; ii--)
            {
                rvSt += ReverseThis.Substring(ii, 1);
            }
            return rvSt;
        }

        // делаем скремблинг строки для бинарных данных
        private string ScrambstrBinaryext(string ScrString)
        {
            int rndRep;

            Random intRan = new Random();
            string newString = "";
            string ScrChrs = AllScrChrs;
            string chrOne = ScrChrs.Substring(intRan.Next(ScrChrs.Length), 1);
            ScrChrs = ScrChrs.Replace(chrOne, "");
            string chrZero = ScrChrs.Substring(intRan.Next(ScrChrs.Length), 1);
            ScrChrs = ScrChrs.Replace(chrZero, "");

            int IntStrLength = ScrString.Length;

            foreach (char OZchr in ScrString)
            {
                rndRep = intRan.Next(3);

                switch (OZchr)
                {
                    case '1': // Написал метод, для упрощения
                        newString += OneAndZero(rndRep, chrOne) + OneAndZero(rndRep, ";");
                        break;
                    case '0':
                        newString += OneAndZero(rndRep, chrZero) + OneAndZero(rndRep, ":");
                        break;
                }

                newString += OneAndZero(intRan.Next(1, 3), ScrChrs.Substring(intRan.Next(ScrChrs.Length), 1));
            }

            // При возврате первый и последний символ случайным образом смешиваются для большей криптографической сложности.
            // мы следим за этими символами
            return OneAndZero(intRan.Next(1, 3), ScrChrs.Substring(intRan.Next(ScrChrs.Length), 1))
                + newString + OneAndZero(intRan.Next(3), chrOne) + OneAndZero(intRan.Next(3), chrZero)
                + OneAndZero(intRan.Next(1, 3), ScrChrs.Substring(intRan.Next(ScrChrs.Length), 1));
        }

        // Метод вызывается несколько раз для ввода случайного количества символов
        private string OneAndZero(int Rept, string sOZ)
        {
            int ii;
            for (ii = 0; ii < Rept; ii++)
            {
                sOZ += sOZ.Substring(0, 1);
            }
            return sOZ;
        }

        //private string GetCharacter(string strBinary){

        //    return GetCharacter(strBinary).ToString();
        //}

        // выборка символа
        private char GetCharacter(string strBinary)
        {
            return (char)Convert.ToInt32(strBinary, 2);
        }

        // выборка бинарных данных
        private string GetBinary(char strChr)
        {
            return Convert.ToString(strChr, 2).PadLeft(8, '0');
        }
    }
}
