using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chef
{
    class sortRow
    {
        public CheckBox checkBox;
        public PictureBox pictureBox1, pictureBox2;
        public bool sortWhatAsc;
        public sortRow(CheckBox checkBox, PictureBox pictureBox1, PictureBox pictureBox2, bool sortWhatAsc)
        {
            this.checkBox = checkBox;
            this.pictureBox1 = pictureBox1;
            this.pictureBox2 = pictureBox2;
            this.sortWhatAsc = sortWhatAsc;
        }
    }
}
