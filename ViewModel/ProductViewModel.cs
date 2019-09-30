using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ProductViewModel
    {
        #region [- ctor -]
        public ProductViewModel()
        {
            Ref_ProductCrud = new Model.DomainModel.POCO.ProductCrud();
        }
        #endregion

        #region [- prop -]
        public Model.DomainModel.POCO.ProductCrud Ref_ProductCrud { get; set; }
        #endregion

        #region [- Save(string productName, int unitPrice, int quantity,int code , byte[] image) -]
        public void Save(string productName, int unitPrice, int quantity, int price, int code, byte[] image)
        {
            Ref_ProductCrud.Insert(productName, unitPrice, quantity, price, code, image);
        }
        #endregion

        #region [- FillGrid() -]
        public dynamic FillGrid()
        {
            return Ref_ProductCrud.Select();
        }
        #endregion

        #region [- Edit(int id, string productName, int unitPrice, int quantity, int price, int code, byte[] image) -] 
        public void Edit(int id, string productName, int unitPrice, int quantity, int price, int code, byte[] image)
        {
            Ref_ProductCrud.Edit(id, productName, unitPrice, quantity, price, code, image);
        }
        #endregion

        #region [- Delete(int id) -]
        public void Delete(int id)
        {
            Ref_ProductCrud.Delete(id);
        }
        #endregion

    }
}
