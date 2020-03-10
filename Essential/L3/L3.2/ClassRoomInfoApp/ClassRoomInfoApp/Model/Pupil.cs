using System;
namespace ClassRoomInfoApp.Model
{
    internal class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Vova.Stydy()");
        }

        public virtual void Read()
        {
            Console.WriteLine("Vova.Read()");
        }

        public virtual void Write()
        {
            Console.WriteLine("Vova.Write()");
        }

        public virtual void Relax()
        {
            Console.WriteLine("Vova.Relax()");
        }

    }
}