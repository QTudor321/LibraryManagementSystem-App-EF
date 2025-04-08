using Microsoft.EntityFrameworkCore;
using LibraryManagementSystem.Entities;
namespace LibraryManagementSystem.Database
{//Clasa care reprezinta intreaga baza de date
    public class LibraryDatabaseContext : DbContext //clasa intermediara care va construi instructiunile de interogare
    {                                                 //pentru interactiunea intre baza de date si obiectele din program
        //Constructorul clasei pentru realizarea conectarii la baza de date
        public LibraryDatabaseContext(DbContextOptions<LibraryDatabaseContext> options) : base(options) { }
        //Proprietatile care corespund cu tabelele si entitatile definite care sunt gestionate de EntityFramework
        public DbSet<Users> Users { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<Cards> Cards { get; set; }
        public DbSet<Loans> Loans { get; set; }
    }
}
