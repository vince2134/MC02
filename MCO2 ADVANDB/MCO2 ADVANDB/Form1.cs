using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCO2_ADVANDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var pos = this.PointToScreen(label1.Location);
            pos = pictureBox1.PointToClient(pos);
            label1.Parent = pictureBox1;
            label1.Location = pos;
            label1.BackColor = Color.Transparent;

            pos = this.PointToScreen(label4.Location);
            pos = pictureBox2.PointToClient(pos);
            label4.Parent = pictureBox2;
            label4.Location = pos;
            label4.BackColor = Color.Transparent;

            pos = this.PointToScreen(radioButton3.Location);
            pos = pictureBox2.PointToClient(pos);
            radioButton3.Parent = pictureBox2;
            radioButton3.Location = pos;
            radioButton3.BackColor = Color.Transparent;

            pos = this.PointToScreen(radioButton4.Location);
            pos = pictureBox2.PointToClient(pos);
            radioButton4.Parent = pictureBox2;
            radioButton4.Location = pos;
            radioButton4.BackColor = Color.Transparent;

            pos = this.PointToScreen(radioButton5.Location);
            pos = pictureBox2.PointToClient(pos);
            radioButton5.Parent = pictureBox2;
            radioButton5.Location = pos;
            radioButton5.BackColor = Color.Transparent;

            pos = this.PointToScreen(regionRadio.Location);
            pos = pictureBox1.PointToClient(pos);
            regionRadio.Parent = pictureBox1;
            regionRadio.BackColor = Color.Transparent;

            pos = this.PointToScreen(radioButton1.Location);
            pos = pictureBox1.PointToClient(pos);
            radioButton1.Parent = pictureBox1;
            radioButton1.BackColor = Color.Transparent;

            pos = this.PointToScreen(radioButton2.Location);
            pos = pictureBox1.PointToClient(pos);
            radioButton2.Parent = pictureBox1;
            radioButton2.BackColor = Color.Transparent;

            pos = this.PointToScreen(label5.Location);
            pos = pictureBox3.PointToClient(pos);
            label5.Parent = pictureBox3;
            label5.BackColor = Color.Transparent;
        }
    }
}
