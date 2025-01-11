using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_program_preparation_2
{
    public partial class UserControl1 : UserControl
    {
        public event Action NumericChanged;
        public event UserControl1.delegateWithObject CircleRemove;

        public delegate void delegateWithObject(object sender);

        public UserControl1(int X, int Y, int R)
        {
            InitializeComponent();
            this.X = X;
            this.Y = Y;
            this.R = R;

        }
        public int X
        {
            get
            {
                return (int)numericUpDownX.Value;
            }
            set
            {
                numericUpDownX.Value = value;
            }
        }
        public int Y
        {
            get
            {
                return (int)numericUpDownY.Value;
            }
            set
            {
                numericUpDownY.Value = value;
            }
        }
        public int R
        {
            get
            {
                return (int)numericUpDownR.Value;
            }
            set
            {
                numericUpDownR.Value = value;
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDownX_ValueChanged(object sender, EventArgs e)
        {
            bool flag = NumericChanged != null;
            if (flag)
            {
                this.NumericChanged();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = CircleRemove != null;
            if (flag)
            {
                CircleRemove(this);
            }
        }
    }
}

