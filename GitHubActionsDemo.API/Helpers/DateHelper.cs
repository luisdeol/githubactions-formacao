using System;

namespace GitHubActionsDemo.API.Helpers
{
    public class SayHelper : ISayHelper
    {
        public void SayHi(string firstName, string lastName) {
            var ola = "";
            int numero = 5;

            Console.WriteLine($"Hi {firstName} {lastName}");
        }
    }

    public interface ISayHelper {
        void SayHi(string name, string surname);
    }
}