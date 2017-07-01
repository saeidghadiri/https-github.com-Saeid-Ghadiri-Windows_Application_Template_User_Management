namespace Models
{
    class DatabaseContext : System.Data.Entity.DbContext
    {
        static DatabaseContext()
        {

        }

        public DatabaseContext() : base()
        {

        }

        //*****************************************  Management System ***********************************************


        //*****************************************  Management System ***********************************************

        //************************************** User Management System **********************************************

        public System.Data.Entity.DbSet<User> Users { get; set; }
    
        //************************************** User Management System **********************************************
    }
}

