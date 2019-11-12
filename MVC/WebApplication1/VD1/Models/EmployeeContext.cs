using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VD1.Models;

namespace VD1.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }
        public DbSet<tblSkill> tblSkills { get; set; }
        public DbSet<tblEmployee> tblEmployees { get; set; }
        public DbSet<VD1.Models.EmployeeViewModel> EmployeeViewModel { get; set; }
        public DbSet<VD1.Models.EmployeeCreateModel> EmployeeCreateModel { get; set; }
        public DbSet<VD1.Models.EmployeeEditModel> EmployeeEditModel { get; set; }
    }
}
