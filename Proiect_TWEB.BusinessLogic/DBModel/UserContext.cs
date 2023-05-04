using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect_TWEB.Domain.Entities.User;

namespace Proiect_TWEB.BusinessLogic.DBModel
{
      class UserContext : DbContext
     {
          public UserContext() :
               base("name=Proiect_TWEB") // connection string name define in web.config
          {
          }

          public virtual DbSet<UDbTable> Users { get; set; }
     }
}
