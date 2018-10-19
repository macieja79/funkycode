using System;
using System.Collections.Generic;
using System.Text;

namespace FunkyCode
{
    public class WhatsNew
    {


        ILogger _logger;

        // C# 6.0
        public string Name => ".NET";

        // C# 7.0
        string _name2;
        public string Name2
        {
            get => _name2;
            set => _name2 = value;
        }


        void Tuples()
        {
            var (transation, user) = GetMockData();
        }

        void Out()
        {
            // before
            double x, y;
            GetCoordinates(out x, out y);

            // now
            GetCoordinates(out double x1, out double y1);
        }


        void PatternMatching()
        {

            object obj = new User();

            if (obj is User user)
            {
                Console.WriteLine(user.FirstName);
            }
        }

        void NotImplemented() => throw new NotImplementedException();


        void LocalFunctions()
        {
            // before
            Action<string> logByAction = message => _logger.Log(DateTime.UtcNow, MessageType.Informarmation, message);

            // now
            void logByLocalFunction(string message)
            {
                _logger.Log(DateTime.UtcNow, MessageType.Informarmation, message);
            };

            logByAction("This works");
            logByLocalFunction("This works also :)");

            // (...)
        }

        void Syntax()
        {
            decimal milion = 1_000_000;
            Console.WriteLine(milion);
        }


        void PatternMatchingCase()
        {
            // You can switch on any type(not just primitive types)
            // Patterns can be used in case clauses
            // Case clauses can have additional conditions on them

            Shape shape = new Rectangle();

            switch(shape)
            {
                case Rectangle r:
                    Console.Write($"Height = {r.Height}");
                    break;

                case Circle c when c.Radius > 100:
                    Console.Write($"Big radius = {c.Radius}");
                    break;

                case Circle c:
                    Console.Write($"Radius = {c.Radius}");
                    break;

                case null:
                    Console.Write($"Where is shape .... ?");
                    break;

                default:
                    Console.Write($"How about triangle ... ?");
                    break;
            }

        }













        public (User User, Transaction Transaction) GetMockData()
        {
            var user = new User();
            var transaction = new Transaction();

            // (...)

            return (user, transaction);
        }

        public void GetCoordinates(out double x, out double y)
        {
            x = 0;
            y = 0;
        }
    }
}
