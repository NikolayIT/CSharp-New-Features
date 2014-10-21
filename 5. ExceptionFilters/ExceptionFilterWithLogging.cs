namespace _5.ExceptionFilters
{
    using System;

    public static class ExceptionFilterWithLogging
    {
        public static void Demo()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex) if (Log(ex)) { }
        }

        /// <summary>
        /// This method can inspect an exception “flying by” without intercepting its course.
        /// This is a false-returning helper function which executes the side effects (logging).
        /// </summary>
        private static bool Log(Exception exception)
        {
            // Side effect (logging)
            Console.WriteLine("======== Message ========");
            Console.WriteLine(exception.Message);
            Console.WriteLine("======== Stack trace from Log() ========");
            Console.WriteLine(exception.StackTrace);

            // Continue to the catch block
            return false;
        }
    }
}
