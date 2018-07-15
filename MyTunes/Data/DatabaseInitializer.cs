using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyTunes.Data
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<MyTunesContext>
    {
        protected override void Seed(MyTunesContext context)
        {
            
            context.SaveChanges();
            base.Seed(context);
        }
    }
}