using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp73
{
    class cValid
    {
       public int lenght
        {
            get;
            set;
        }
        private string ct;
        public string Text
        {
            get
            {
                return ct;
            }
            set
            {
                if (value.Length <= lenght)
                {
                    ct = value;
                    for (int i = 0; i < ct.Length; i++)
                    {
                        if (!char.IsLetter(char.Parse(ct.Substring(i, 1))))
                            ct = ct.Remove(i, 1);
                    }
                }
            }
        }
                
            }
        }
    

