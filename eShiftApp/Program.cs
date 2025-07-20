namespace eShiftApp
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

            // Show the login form as a modal dialog
            using (var loginForm = new LoginForm())
            {
                var result = loginForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // On success, grab the username and start MainForm
                    Application.Run
                        (new MainForm
                            (loginForm.LoggedInUser,
                            loginForm.IsAdmin
                        )
                    );
                }

            }
        }
    }
}