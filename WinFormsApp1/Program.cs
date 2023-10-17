namespace WinFormsApp1
{
     public static class Program
    {
        private static Master master;

        public static Master GetMasterInstance()
        {
            if (master == null)
            {
                master = new Master();
            }
            return master;
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            master = GetMasterInstance(); // Отримання єдиного екземпляра Master
            Application.Run(master);
        }
        public static Master GetMaster()
        {
            return master;
        }
    }
}
