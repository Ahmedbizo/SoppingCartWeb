using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart.Repositories.Repositories;

namespace Commerce.BootstraperTest
{
    public static class MEFLoader
    {
        public static CompositionContainer Init()
        {
            AggregateCatalog catalog = new AggregateCatalog();

            catalog = addCatalogItems(catalog);
            CompositionContainer container = new CompositionContainer(catalog);

            return container;
        }


        public static AggregateCatalog addCatalogItems(AggregateCatalog catalog)
        {
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(DepartmentRepository).Assembly));
            return catalog;
        }

    }
}
