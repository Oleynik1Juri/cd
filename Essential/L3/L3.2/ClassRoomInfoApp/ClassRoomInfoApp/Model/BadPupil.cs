using System;

namespace ClassRoomInfoApp.Model
{
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Bad.Vova.Study()");
        }

        public override void Read()
        {
            Console.WriteLine("Bad.Vova.Read()");
        }

        public override void Write()
        {
            Console.WriteLine("Bad.Vova.Write()");
        }

        public override void Relax()
        {
            Console.WriteLine("Bad.Vova.Relax()");
        }
    }
}