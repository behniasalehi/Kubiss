using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DomainModel.POCO
{
    public class ProductCrud
    {
        #region [- ctor -]
        public ProductCrud()
        {

        }
        #endregion

        #region [- Insert(string productName, int unitPrice, int quantity,int code, byte[] image) -]
        public void Insert(string productName, int unitPrice, int quantity,int price, int code, byte[] image)
        {
            using (var context = new Model.DomainModel.DTO.EF.KubissEntities2())
            {
                try
                {
                    Model.DomainModel.DTO.EF.Product ref_product = new DTO.EF.Product();
                    ref_product.ProductName = productName;
                    ref_product.UnitPrice = unitPrice;
                    ref_product.Quantity = quantity;
                    ref_product.Price = price;
                    ref_product.Code = code;
                    ref_product.Image = image;
                    context.Product.Add(ref_product);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [- Select() -]
        public List<Model.DomainModel.DTO.EF.Product> Select()
        {
            using (var context = new Model.DomainModel.DTO.EF.KubissEntities2())
            {
                try
                {
                    
                    var q = context.Product.ToList();
                    return q;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [- Edit(int id, string productName, int unitPrice, int quantity, int price, int code, byte[] image) -]
        public void Edit(int id, string productName, int unitPrice, int quantity, int price, int code, byte[] image)
        {
            using (var context = new Model.DomainModel.DTO.EF.KubissEntities2())
            {
                try
                {
                    var q = context.Product.First(p => p.Id == id) as Model.DomainModel.DTO.EF.Product;
                    if (q != null)
                    {
                        q.ProductName = productName;
                        q.UnitPrice = unitPrice;
                        q.Quantity = quantity;
                        q.Price = price;
                        q.Code = code;
                        q.Image = image;
                        context.Entry(q).CurrentValues.SetValues(context.Product);
                        context.SaveChanges();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }

        }
        #endregion

        #region [- Delete(int id) -]
        public void Delete(int id)
        {
            using (var context = new Model.DomainModel.DTO.EF.KubissEntities2())
            {
                try
                {
                    var q = context.Product.First(p => p.Id == id) as Model.DomainModel.DTO.EF.Product;
                    if (q != null)
                    {
                        context.Product.Remove(q);
                        context.SaveChanges();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

    }
}
