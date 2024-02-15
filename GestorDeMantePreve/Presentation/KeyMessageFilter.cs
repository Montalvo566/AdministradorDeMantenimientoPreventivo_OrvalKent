using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public class KeyMessageFilter : IMessageFilter
    {
        public event EventHandler<KeyPressedEventArgs> KeyPressed;

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == 0x100) // WM_KEYDOWN
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
}
