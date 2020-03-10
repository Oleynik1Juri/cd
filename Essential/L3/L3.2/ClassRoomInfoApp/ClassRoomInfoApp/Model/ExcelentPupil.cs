using System;


namespace ClassRoomInfoApp.Model
{
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Excelent.Vova.Stydy()");
        }

        public override void Read()
        {
            Console.WriteLine("Excelent.Vova.Read()");
        }

        public override void Write()
        {
            Console.WriteLine("Excelent.Vova.Write()");
        }

        public override void Relax()
        {
            Console.WriteLine("Excelent.Vova.Relax()");
        }

    }
}