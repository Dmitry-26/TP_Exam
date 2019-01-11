using System;

namespace ConsoleApp
{
    class Converter
    {
        private string text;

        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                if (value.Length > 0 && value.Length <= 250)
                {
                    text = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Знаков должно быть от 1 до 250!");
                    text = "";
                }
                for (int i = 0; i <= value.Length - 1; i++)
                {
                    if (value[i].Equals('1') || value[i].Equals('0'))
                    {
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Строка должна состоять из '1' и '0' !");
                        text = "";
                        break;
                    }
                }
            }
        }

            public string Convert(string txt, string txtNew)
        {
            Text = txt;
            if (Text == "")
            {
                return "";
            }
            else
            {
                if (Text[0] == '0')
                {
                    txtNew += '0';
                }
                else
                {
                    txtNew += '1';
                }
                for (int i = 1; i <= txt.Length - 1; i++)
                {
                    if (Text[i] == Text[i - 1])
                    {
                        txtNew += '0';
                    }
                    else
                    {
                        txtNew += '1';
                    }
                }
                return txtNew;
            }
        }
    }
}
