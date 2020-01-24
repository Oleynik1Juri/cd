using System;

namespace EmployeeInformationApp.Model
{
   public class Profession
   {
        private readonly string _junion;
        private readonly string _middel;
        private readonly string _senior;
        
        public Profession(string Junion, string Middel, string Senior)
        {
            _junion = Junion;
            _middel = Middel;
            _senior = Senior;
        }

        public enum Position
        {
            Junion = 2000,
            Middel = 3000,
            Senior = 4000
        }
   }
}   