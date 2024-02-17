using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    //Funcion implementaria para validar que no sea necesario hacer un focus al textbox del codigo de barras//
    public class KeyMessageFilter : IMessageFilter
    {
        public event EventHandler<KeyPressedEventArgs> KeyPressed;

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == 0x100)
            {
                char keyChar = (char)m.WParam;
                KeyPressed?.Invoke(this, new KeyPressedEventArgs(keyChar));
            }
            return false;
        }
    }
    public class KeyPressedEventArgs : EventArgs
    {
        public char KeyChar { get; }

        public KeyPressedEventArgs(char keyChar)
        {
            KeyChar = keyChar;
        }
    }
    //Fin//
}
