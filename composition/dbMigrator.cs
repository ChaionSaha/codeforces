namespace composition
{
    public class dbMigrator
    {
        private readonly Logger logger;

        public dbMigrator(Logger logger)
        {
            this.logger = logger;
        }

        public void Migrate()
        {
            logger.log("We are migrating blah blah blah");
        }

    }
}
