using Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart.Repositories.Repositories;


namespace ShoppingCart.Bootstraper
{
    public static class MEFLoader
    {
        public static CompositionContainer Init(ICollection<ComposablePartCatalog> catalogParts)
        {

            AggregateCatalog catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(DepartmentRepository).Assembly));

            catalog = addCatalogParts(catalog, catalogParts);
            CompositionContainer container = new CompositionContainer(catalog);
            ObjectBase.Container = container;
            return container;
        }


        /// <summary>
        /// Adds the catalog parts to the catalog.
        /// </summary>
        /// <param name="catalog"></param>
        /// <param name="catalogParts"></param>
        /// <returns></returns>
        private static AggregateCatalog addCatalogParts(AggregateCatalog catalog, ICollection<ComposablePartCatalog> catalogParts)
        {
            if (catalogParts != null)
            {
                foreach (var part in catalogParts)
                {
                    catalog.Catalogs.Add(part);
                }
            }
            return catalog;

        }

    }
}
