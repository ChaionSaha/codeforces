namespace composition
{

    class Program
    {
        
        static void Main()
        {
            var migrator = new dbMigrator(new Logger());
            migrator.Migrate();


            var logger = new Logger();
            var installer = new Installer(logger);
            installer.install();
        }
    }
}
