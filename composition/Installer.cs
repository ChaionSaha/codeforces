namespace composition
{
    public class Installer
    {
        private readonly Logger logger;

        public Installer(Logger logger)
        {
            this.logger = logger;
        }

        public void install()
        {
            logger.log("We are installing the program");
        }
    }
}
