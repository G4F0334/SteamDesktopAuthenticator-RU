using System;
using System.Windows.Forms;
using System.Diagnostics;
using CommandLine;

namespace Steam_Desktop_Authenticator
{
    static class Program
    {
        public static Process PriorProcess()
        // Returns a System.Diagnostics.Process pointing to
        // a pre-existing process with the same name as the
        // current one, if any; or null if the current process
        // is unique.
        {
            try
            {
                Process curr = Process.GetCurrentProcess();
                Process[] procs = Process.GetProcessesByName(curr.ProcessName);
                foreach (Process p in procs)
                {
                    if ((p.Id != curr.Id) &&
                        (p.MainModule.FileName == curr.MainModule.FileName))
                        return p;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // run the program only once
            if (PriorProcess() != null)
            {
                MessageBox.Show("Экземпляр приложения уже запущен.");
                return;
            }

            // Parse command line arguments
            CommandLineOptions options = new();
            Parser.Default.ParseArguments<CommandLineOptions>(args)
                .WithParsed(o => options = o);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Manifest man;

            try
            {
                man = Manifest.GetManifest();
            }
            catch (ManifestParseException)
            {
                // Manifest file was corrupted, generate a new one.
                try
                {
                    MessageBox.Show("Ваши настройки были неожиданно повреждены и были сброшены к значениям по умолчанию.", "Steam Desktop Authenticator", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    man = Manifest.GenerateNewManifest(true);
                }
                catch (MaFileEncryptedException)
                {
                    // An maFile was encrypted, we're fucked.
                    MessageBox.Show("Извините, но SDA не смог восстановить ваши аккаунты, так как вы использовали шифрование.\nВам нужно восстановить свои аккаунты Steam, удалив аутентификатор.\nНажмите OK для просмотра инструкции.", "Steam Desktop Authenticator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Process.Start(@"https://github.com/Jessecar96/SteamDesktopAuthenticator/wiki/Help!-I'm-locked-out-of-my-account");
                    return;
                }
            }

            MainForm mf = new MainForm();
            mf.SetEncryptionKey(options.EncryptionKey);
            mf.StartSilent(options.Silent);
            Application.Run(mf);
        }
    }
}
