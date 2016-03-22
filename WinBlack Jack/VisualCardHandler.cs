using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinBlack_Jack.Properties;

namespace WinBlack_Jack
{
    public class VisualCardHandler
    {
        private List<Bitmap> _cardPictures;
        public Bitmap CardBack { get; }

        public VisualCardHandler()
        {
            _cardPictures = new List<Bitmap>();
            CardBack = Resources.red;
        }

        public Bitmap GetcardPicture(string name)
        {
            // TODO add linkage
            return null;
        }
    }
}
