using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ZFilesUtils
{
    public class Utils
    {
        public static void MakeTextBoxShowSampleValue(TextBox txt,String textSampleValue)
        {
            txt.Text = textSampleValue;
            txt.ForeColor = System.Drawing.Color.DimGray;
            txt.Enter += Txt_Enter;
          //  txt.
        }

        private static void Txt_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.ForeColor = System.Drawing.Color.Black;
            txt.Text = "";
            txt.Enter -= Txt_Enter;
           // throw new NotImplementedException();
        }
    }
}
