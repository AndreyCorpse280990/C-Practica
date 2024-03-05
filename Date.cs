using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practica
{
     internal class Date
    {
        public int year;
        public int month;
        public int day;

        //свойства класса
        public int Day
        {
            get { return day; }
            set
            {
                if (value < 1 || value > 31)
                {
                    throw new ArgumentException("Некорректное значение дня");
                }
                day = value;
            }
        }


        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1 || value > 9999)
                {
                    throw new ArgumentException("Некорректное значение года");
                }
                year = value;
            }
        }

        public int Month
        {
            get { return month; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Некорректное значение месяца");
                }
                month = value;
            }
        }

        // конструкторы
        // Конструктор устанавливающий начальную дату
        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        // Конструктор устанавливающий день и месяц, а значение year – текущий год
        public Date(int day, int month) : this(day, month, DateTime.Now.Year) { }

        // Конструктор, устанавливающий день и текущие месяц и год
        public Date(int day) : this(day, DateTime.Now.Month, DateTime.Now.Year) { }

        // Конструктор, устанавливающий текущий день, месяц и год
        public Date() : this(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year) { }

        //метод перемещения даты на один день вперед 
        public void Next()
        {
            // проверка на последний день месяца
            if(day < DateTime.DaysInMonth(year, month))
            {
                day++;
            }
            else
            {
                day = 1;

                if(month < 12)
                {
                    month++; 
                }
                else
                {
                    month = 1;
                    year++;
                }
            }
        }


        // метод получения кол-ва времени, прошедшего от даты 01.01.0000 в днях 
        public int ToDays()
        {
            DateTime startDate = new DateTime(1, 1, 1);
            DateTime currentDate = new DateTime(year, month, day);
            return (currentDate - startDate).Days;
        }

        //  Метод для получения разницы между двумя датами в днях
        public int DateOffset(Date other)
        { 
            DateTime thisDate = new DateTime(year, month, day);
            DateTime otherDate = new DateTime(other.Year, other.Month, other.Day);
            return (otherDate - thisDate).Days;
        }

        // Переопределение ToString
        public override string ToString()
        {
            return $"{day:D2}.{month:D2}.{year:D4}";
        }

    }

}

