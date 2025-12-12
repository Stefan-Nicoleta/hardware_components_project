namespace proiect_Stefan_Nicoleta_1065_Hardware
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
           
            Application.Run(new Introducere());

            Application.Run(new Form1());


        }

    }
}