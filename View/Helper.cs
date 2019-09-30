using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace View
{
    public class Helper
    {
        #region [- ctor -]
        public Helper()
        {

        }
        #endregion

        #region [- Price() -]
        public int Price(string unitPrice , string quantity)
        {
            int firstNumber = Convert.ToInt32(unitPrice);
            int secondNumber = Convert.ToInt32(quantity);
            int price = firstNumber * secondNumber;
            return price;
        }
        #endregion

        #region [- AddImage() -]
        public byte[] AddImage(string path)
        {
            FileStream Ref_FileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader Ref_BinaryReader = new BinaryReader(Ref_FileStream);
            byte[] imageByte = Ref_BinaryReader.ReadBytes((int)Ref_FileStream.Length);
            return imageByte;
        }
        #endregion

        #region [- ConverImage(object path) -]
        public Image ConverImage(object path)
        {
            byte[] bytes = (byte[])path;
            MemoryStream ms = new MemoryStream(bytes);
            return Image.FromStream(ms);
        }
        #endregion

        #region [- ImageToByteArray -]
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        } 
        #endregion

    }
}
