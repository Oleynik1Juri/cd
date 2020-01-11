namespace FillingOutTheQuestionnaireApp.Model
{
    public class User
    {
        public string Login { get; set; } 
        public string Name { get; set; } 
        public string Surname { get; set; } 
        public string Age { get; set;}

        public override string ToString()
        {
            var overUser = $"{nameof(Login)}: {Login}, {nameof(Name)}: {Name}, {nameof(Surname)}: {Surname}, {nameof(Age)}: {Age}";
            return overUser;
        }
    }
}