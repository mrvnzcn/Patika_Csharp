using System;

    namespace arayuzler
    {
    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            // throw new NotImplementedException();
            Console.WriteLine("DB ustune log yazar.");
        }
    }

}