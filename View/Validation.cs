using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace View
{
    public class Validation
    {
        #region [- ctor -] 
        public Validation()
        {

        }
        #endregion

        #region [- TextValidation(string String) -]
        public bool TextValidation(string String)
        {
            Regex regex = new Regex("^[a-zA-Z0-9]{1,15}$");
            Match match = regex.Match(String.ToLower());
            if (!match.Success)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        #endregion

        #region [- AddressValidation(string String) -]
        public bool AddressValidation(string String)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9\s]{1,50}$");
            Match match = regex.Match(String.ToLower());
            if (!match.Success)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        #endregion

        #region [- TellValidation -]
        public bool TellValidation(string String)
        {
            Regex regex = new Regex("^[0-9]{8}$");
            Match match = regex.Match(String.ToLower());
            if (!match.Success)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region [- MobileValidation -]
        public bool MobileValidation(string String)
        {
            Regex regex = new Regex("^(09)[0-9]{9}$");
            Match match = regex.Match(String.ToLower());
            if (!match.Success)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region [- NumberValidation(string String) -]
        public bool NumberValidation(string String)
        {
            Regex regex = new Regex("^[0-9]{1,}$");
            Match match = regex.Match(String.ToLower());
            if (!match.Success)
            {
                return false;
            }
            else
            {
                return true;
            }

        } 
        #endregion
    }
}
