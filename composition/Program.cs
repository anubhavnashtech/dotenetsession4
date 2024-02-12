using System;

namespace composition
{
    public class Logger
    {
        public void Log(string message)
        {
            System.Console.WriteLine(message);
        }
    }


    public class DBMigrator
    {
        private readonly Logger logger;

        public DBMigrator(Logger logger)
        {
            this.logger = logger;
        }

        public void Migration()
        {
            logger.Log("We are migrating");
        }
    }

    public class Initializer
    {
        private readonly Logger logger;

        public Initializer(Logger logger)
        {
            this.logger = logger;
        }

        public void Initializing()
        {
            logger.Log("We are initializing");
        }
    }

    public class Program
        {
            static void Main(string[] args)
            {
                var dbMigrator = new DBMigrator(new Logger());

                var logger = new Logger();

                var initializer = new Initializer(logger);

                dbMigrator.Migration();

                initializer.Initializing();
            }
        }
}