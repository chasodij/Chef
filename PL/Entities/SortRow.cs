using System.Windows.Forms;

namespace chef
{
    public class SortRow
    {
        private readonly string _fieldName;

        private bool IsAsc;

        public CheckBox CheckBox { get; }
        public PictureBox PictureBox1 { get; }
        public PictureBox PictureBox2 { get; }

        public string GetStatement
        {
            get
            {
                if (CheckBox.Checked)
                {
                    if (IsAsc)
                    {
                        return _fieldName;
                    }
                    else
                    {
                        return _fieldName + " DESC";
                    }
                }
                return "";
            }
        }

        public SortRow(string fieldName, CheckBox checkBox, PictureBox pictureBox1, PictureBox pictureBox2, bool isAsc)
        {
            _fieldName = fieldName;
            CheckBox = checkBox;
            PictureBox1 = pictureBox1;
            PictureBox2 = pictureBox2;
            IsAsc = isAsc;
        }
        public void ChangeImage()
        {
            if (CheckBox.Checked)
            {
                PictureBox1.Cursor = Cursors.Hand;
                PictureBox2.Cursor = Cursors.Hand;
                if (IsAsc)
                {
                    PictureBox1.Image = Properties.Resources.asc2;
                    PictureBox2.Image = Properties.Resources.desc1;
                }
                else
                {
                    PictureBox1.Image = Properties.Resources.asc1;
                    PictureBox2.Image = Properties.Resources.desc2;
                }
            }
            else
            {
                PictureBox1.Cursor = Cursors.Default;
                PictureBox2.Cursor = Cursors.Default;
                if (IsAsc)
                {
                    PictureBox1.Image = Properties.Resources.asc2_dis;
                    PictureBox2.Image = Properties.Resources.desc1_dis;
                }
                else
                {
                    PictureBox1.Image = Properties.Resources.asc1_dis;
                    PictureBox2.Image = Properties.Resources.desc2_dis;
                }
            }
        }

        public void ChangeOrder(bool isAsc)
        {
            if (isAsc)
            {
                if (CheckBox.Checked && !IsAsc)
                {
                    IsAsc = true;
                    PictureBox1.Image = Properties.Resources.asc2;
                    PictureBox2.Image = Properties.Resources.desc1;
                }
            }
            else
            {
                if (CheckBox.Checked && IsAsc)
                {
                    IsAsc = false;
                    PictureBox1.Image = Properties.Resources.asc1;
                    PictureBox2.Image = Properties.Resources.desc2;
                }
            }
        }
    }
}
