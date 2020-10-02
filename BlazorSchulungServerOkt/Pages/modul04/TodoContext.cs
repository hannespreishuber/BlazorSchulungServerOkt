using BlazorSchulungServerOkt.Pages.modul03;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSchulungServerOkt.Pages.modul04
{
    public class TodoContext:DbContext
    {
        public TodoContext(DbContextOptions<TodoContext>options):base(options)
        {

        }
        public virtual DbSet<Aufgabe> Aufgabes { get; set; }
    }
}
