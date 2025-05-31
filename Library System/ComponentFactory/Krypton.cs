using System.Drawing;
using System.Windows.Forms;

namespace ComponentFactory
{
    internal class Krypton
    {
        internal class Toolkit
        {
            internal class KryptonLinkLabel
            {
                public KryptonLinkLabel()
                {
                }

                public Cursor Cursor { get; internal set; }
                public Point Location { get; internal set; }
                public string Name { get; internal set; }
                public Size Size { get; internal set; }
                public int TabIndex { get; internal set; }
                public object Values { get; internal set; }
            }

            internal class KryptonLinkLabelValues
            {
                public KryptonLinkLabelValues()
                {
                }
            }
        }
    }
}