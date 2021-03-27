using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coach_Form_UI
{
    interface IEditText
    {

        void EnterHint(TextBox text);

        void LeaveHint(TextBox text, string message);
    }
}
