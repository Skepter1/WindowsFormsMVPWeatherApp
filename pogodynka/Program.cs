namespace pogodynka
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

            IView view = new Form1();
            Model model = new Model();
            Presenter presenter = new Presenter(model, view);

            Application.Run((Form)view);
        }
    }
}