using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class PersonViewModel
    {

        #region [- ctor -]
        public PersonViewModel()
        {
            Ref_PersonCrud = new Model.DomainModel.POCO.PersonCrud();
        }

        #endregion

            
        #region [- prop -]
        public Model.DomainModel.POCO.PersonCrud Ref_PersonCrud { get; set; }
        #endregion

        #region [- SignIn(string userName, string password) -]
        public bool SignIn(string userName, string password)
        {
            return Ref_PersonCrud.SignIn(userName, password);
        }
        #endregion

        #region [- Save(string firstName, string surname, string tell, string mobileNumber, string address, string userName, string password) -]
        public void Save(string firstName, string surname, string tell, string mobileNumber, string address, string userName, string password)
        {
            Ref_PersonCrud.Insert(firstName, surname, tell, mobileNumber, address, userName, password);
        } 
        #endregion
    }
}
