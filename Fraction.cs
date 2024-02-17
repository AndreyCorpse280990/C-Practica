using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practica
{
    /*Дробь.
    Реализовать класс Fraction для работы с обыкновенными дробями. 
    Реализовать методы операций:
    сложения, вычитания, умножения, деления двух дробей
    перегрузить эти методы для дроби и действительного числа (double, int)
    изменение знака дроби
    инкремент/декремент
    получение целой части дроби
    Equals, GetHashCode, CompareTo
    получение числителя по индексу 0, получение знаменателя по индексу 1*/
    internal class Fraction
    {
        private int numerator = 0;
        private int denominator = 0;

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        // Сложение двух дробей
        public Fraction Add(Fraction fr2)
        {
            int newNumerator = this.numerator * fr2.denominator + fr2.numerator * this.denominator;
            int newDenominator = this.denominator * fr2.denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        // Вычитание двух дробей
        public Fraction Subtract(Fraction f1, Fraction f2)
        {
            int newNumerator = f1.numerator * f2.denominator - f2.numerator * f1.denominator;
            int newDenominator = f1.denominator * f2.denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        //делениe двух дробей
        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            int newNumerator = f1.numerator * f2.denominator;
            int newDenominator = f1.denominator * f2.numerator;
            return new Fraction(newNumerator, newDenominator);
        }
        
        // Умножение дробей
        public static Fraction operator *(Fraction fr1, Fraction fr2)
        {
            int newNumerator = fr1.numerator * fr2.numerator;
            int newDenominator = fr1.denominator * fr2.denominator;
            return new Fraction(newNumerator, newDenominator);
        }


        //изменение знака дроби
        public static Fraction operator -(Fraction fr)
        {
            fr.numerator = -fr.numerator;
            return fr;
        }

        // инкремент
        public static Fraction operator ++(Fraction fr)
        {
            fr.numerator += fr.denominator;
            return fr;
        }

        //декремент
        public static Fraction operator -- (Fraction fr)
        {
            fr.numerator -= fr.denominator;
            return fr;
        }


        // получение целой части дроби
        public static Fraction GetWholePart(Fraction fr)
        {
            int wholePart = fr.numerator / fr.denominator;
            return new Fraction(wholePart, 1);
        }


        // получение числителя по индексу 0, получение знаменателя по индексу 1
        public int this[int index]
        {
            get
            {
                if (index == 0)
                    return numerator;
                else if (index == 1)
                    return denominator;
                else
                    return 0;
            }
        }

        //Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            { 
                return false; 
            }
            Fraction other = (Fraction)obj;
            return numerator == other.numerator && denominator == other.denominator;
        }


        // геттер к числителю
        public int Numerator
        {
            get { return numerator; }
        }

        // геттер к знаменателю
        public int Denominator
        {
            get { return denominator; }
            set { denominator = value; }
        }


        // печать
        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }


    }
    }


