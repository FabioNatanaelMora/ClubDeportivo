namespace ClubDeportivo
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
            Listas listas = new Listas();
          FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
            Application.Run();



        }
    }
}