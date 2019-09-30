using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DomainModel.POCO
{
    public class PersonCrud
    {
        #region [- ctor -]
        public PersonCrud()
        {

        }
        #endregion


        #region [- SignIn(string userName, string password) -]
        public bool SignIn(string userName, string password)
        {
            using (var context = new Model.DomainModel.DTO.EF.KubissEntities2())
            {
                try
                {

                    bool message;
                    var myUser = context.Person.FirstOrDefault(u => u.UserName == userName && u.Password == password);
                    if (myUser != null)
                    {
                        message = true;
                    }
                    else
                    {
                        message = false;
                    }
                    return message;
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

        #region [- Insert(string firstName, string surname, string tell, string mobileNumber, string address, string userName, string password) -]
        public void Insert(string firstName, string surname, string tell, string mobileNumber, string address, string userName, string password)
        {
            using (var context = new Model.DomainModel.DTO.EF.KubissEntities2())
            {
                try
                {
                    Model.DomainModel.DTO.EF.Person ref_person = new DTO.EF.Person();
                    ref_person.FirstName = firstName;
                    ref_person.Surname = surname;
                    ref_person.Tell = tell;
                    ref_person.MobileNumber = mobileNumber;
                    ref_person.Address = address;
                    ref_person.UserName = userName;
                    ref_person.Password = password;
                    context.Person.Add(ref_person);
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
    }
}
