using System;


namespace ClassRoomInfoApp.Model
{
    internal class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Good.Vova.Study()");
        }

        public override void Read()
        {
            Console.WriteLine("Good.Vova.Read()");
        }

        public override void Write()
        {
            Console.WriteLine("Good.Vova.Write()");
        }

        public override void Relax()
        {
            Console.WriteLine("Good.Vova.Relax()");
        }

    }
}