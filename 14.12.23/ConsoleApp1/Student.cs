using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        /// <summary>
        /// Поле фамилии
        /// </summary>
        private string fam;

        /// <summary>
        /// Поле курса
        /// </summary>
        private int kurs;



        public string Fam
        {
            get
            {
                return (fam != "") ? fam : "Неизвестный";
            }
            set
            {
                fam = value.ToUpper();
            }
        }


        public int Kurs
        {
            get
            {
                return (kurs >1) ? kurs : 0;
            }
            set
            {
                kurs = value;
            }
        }


        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Student()
        {
        }

        public Student(string fam, int kurs)
        {
            this.Fam = fam;
            this.Kurs = kurs;
        }

        public string ShowInfo()
        {
            return $"Фамилия: {Fam}\nКурс: {Kurs}";
        }





    }
}
