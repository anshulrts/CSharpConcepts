using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CSharpConcepts.UsingIComparernamespace
{
    public class UsingIComparer
    {
        public void start()
        {
            // The difference between IComparable and IComparer is that
            // IComparer allows us to specify the criteria on the basis
            // of which we have to sort.

            List<Product> lstProduct = new List<Product>();

            lstProduct.Add(new Product(12, "XYZ"));
            lstProduct.Add(new Product(09, "GHI"));
            lstProduct.Add(new Product(10, "ABC"));
            
            ProductComparer productComparer = new ProductComparer();
            productComparer.SetCriteria = ProductComparer.Criteria.Name;

            lstProduct.Sort(productComparer);

            foreach (var item in lstProduct)
            {
                Console.WriteLine(item.Id);
            }

            productComparer.SetCriteria = ProductComparer.Criteria.Id;
            lstProduct.Sort(productComparer);

            foreach (var item in lstProduct)
            {
                Console.WriteLine(item.Id);
            }
        }
    }

    public class Product
    {
        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

    }

    public class ProductComparer : IComparer<Product>
    {
        public enum Criteria
        {
            Id,
            Name
        }

        public Criteria SetCriteria { get; set; }

        public int Compare(Product x, Product y)
        {
            if (SetCriteria == Criteria.Id)
            {
                return x.Id.CompareTo(y.Id);
            }
            else if (SetCriteria == Criteria.Name)
            {
                return x.Name.CompareTo(y.Name);
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
