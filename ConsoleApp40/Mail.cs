using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    enum Parts
    {
        Login,
        Service,
        Domen
    }

    class Mail
    {
        public string Input { get; set; }

        public string Login { get; set; }

        public string Service { get; set; }

        public string Domen { get; set; }

        public bool IsCorrect { get; set; }

        public Mail(string input)
        {
            IsCorrect = true;
            Input = input;
            CheckForCorrect(0, Parts.Login);
        }

        private void CheckForCorrect(int index, Parts part)
        {
            var sb = new StringBuilder();
            switch (part)
            {
                case Parts.Login:
                    while (Input[index] != '@' && index < Input.Length - 1)
                    {
                        sb.Append(Input[index]);
                        index++;
                    }
                    if (index == Input.Length)
                    {
                        IsCorrect = false;
                    }
                    sb.Append('@');
                    Login = sb.ToString();
                    sb.Clear();
                    CheckForCorrect(index + 1, Parts.Service);
                    break;
                case Parts.Service:
                    if(index>=Input.Length)
                    {
                        IsCorrect = false;
                        index -= 2;
                    }
                    while(Input[index]!='.' && index < Input.Length - 1)
                    {
                        sb.Append(Input[index]);
                        index++;
                    }
                    sb.Append('.');
                    Service = sb.ToString();
                    sb.Clear();
                    CheckForCorrect(index + 1, Parts.Domen);
                    break;
                case Parts.Domen:
                    int count = 0;
                    for (int i = index; i < Input.Length; i++)
                    {
                        if (Input[i] == '.')
                            IsCorrect = false;
                        sb.Append(Input[i]);
                        count++;
                    }
                    if (count < 2)
                        IsCorrect = false;
                    Domen = sb.ToString();
                    sb.Clear();
                    break;
            }

        }
    }
}
