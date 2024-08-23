using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burak.OgrenciTakip.Data.Contexts.OgrenciTakipMigration
{
    public class Configuration : DbMigrationsConfiguration<OgrenciTakipContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true; //migration işlmelerini otamatik yap demiş olduk
            AutomaticMigrationDataLossAllowed = true;  //migration işlmelerinde veri kayıpları olma durumunda kayıp olmasına izin veriyoruz
        }
    }
}
