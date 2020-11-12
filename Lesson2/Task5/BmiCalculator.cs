using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class BmiCalculator
    {

        public const double MinimumNormal = 18.5;
        public const double MinimumOverweight = 25;
        public const double MinimumObesity = 30;
        public const double MinimumObesityII = 35;
        public const double MinimumObesityIII = 40;

        public double Weigt { get; }
        public double Heiht { get; }
        public double BodyMassIndex { get; private set; }

        public BmiCalculator(double weigt, double heiht)
        {
            Weigt = weigt;
            Heiht = heiht;

            BodyMassIndex = Weigt / Math.Pow(Heiht / 100, 2);
        }

        public string GetAdvice()
        {
            if (BodyMassIndex >= MinimumNormal && BodyMassIndex < MinimumOverweight)
            {
                return "Ваш вес в пределах нормы!";
            }
            else if (BodyMassIndex < MinimumNormal)
            {
                return $"Вам нужно набрать ещё хотя бы {RequiredWeight(MinimumNormal) - Weigt:F3} кг";
            }
            else
            {
                double requiredWeight = RequiredWeight(MinimumOverweight - 0.01);                
                return $"Вам нужно сбросить ещё хотя бы {Weigt - requiredWeight:F3} кг";
            }
        }

        private double RequiredWeight(double requiredIndex) => 
            requiredIndex * Math.Pow(Heiht / 100, 2);


        // Является ли такое множество else-if оптимальным вариантом решения задачи?
        // Возможно, есть какая-то конструкция, которая упрощает код, возвращая тот же результат?
        public override string ToString() 
        {
            if (BodyMassIndex < 18.5)
            {
                return "Ниже нормального веса";
            }
            else if (BodyMassIndex >= MinimumNormal && BodyMassIndex < MinimumOverweight)
            {
                return "Нормальный вес";
            }
            else if (BodyMassIndex >= MinimumOverweight && BodyMassIndex < MinimumObesity)
            {
                return "Избыточный вес";
            }
            else if (BodyMassIndex >= MinimumObesity && BodyMassIndex < MinimumObesityII)
            {
                return "Ожирение I степени";
            }
            else if (BodyMassIndex >= MinimumObesityII && BodyMassIndex < MinimumObesityIII)
            {
                return "Ожирение II степени";
            }
            else // if (BodyMassIndex >= MinimumObesityIII)
            {
                return "Ожирение III степени";
            }
        }



    }
}
