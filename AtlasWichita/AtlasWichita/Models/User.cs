using System.Data.Entity;

namespace AtlasWichita.Models
{
    public class User
    {
        public bool testTaken { get; set; }
        public int UserID { get; set; }
        public int Age { get; set; }
        public char Sex { get; set; }
        public int Race { get; set; }
        public int Education { get; set; }
        public int MaritalStatus { get; set; }
        public int Income { get; set; }
        public int Children { get; set; }
        public int Formal { get; set; }
        public int Conformist { get; set; }
        public int BlueCollar { get; set; }
        public int Simple { get; set; }
        public int Trendy { get; set; }
        public int Gritty { get; set; }
        public int Independent { get; set; }
        public int Local { get; set; }
        public int Energetic { get; set; }
        public int Modern { get; set; }
        public int Elegant { get; set; }
    }

    public class UserDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }

}