using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IFSman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = "Iterations:\t" + Convert.ToString( trackBar1.Value );
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label2.Text = "Number of fx:\t" + Convert.ToString(trackBar2.Value);
            if (trackBar2.Value == 1)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = false;
                textBox9.Visible = false;
                textBox10.Visible = false;
                textBox11.Visible = false;
                textBox12.Visible = false;
                textBox13.Visible = false;
                textBox14.Visible = false;
                textBox15.Visible = false;
                textBox16.Visible = false;
                textBox17.Visible = false;
                textBox18.Visible = false;
                textBox19.Visible = false;
                textBox20.Visible = false;
                textBox21.Visible = false;
                textBox22.Visible = false;
                textBox23.Visible = false;
                textBox24.Visible = false;
                textBox25.Visible = false;
                textBox26.Visible = false;
                textBox27.Visible = false;
                textBox28.Visible = false;
                textBox29.Visible = false;
                textBox30.Visible = false;
                textBox31.Visible = false;
                textBox32.Visible = false;
                textBox33.Visible = false;
                textBox34.Visible = false;
                textBox35.Visible = false;
                textBox36.Visible = false;
                textBox37.Visible = false;
                textBox38.Visible = false;
                textBox39.Visible = false;
                textBox40.Visible = false;
                textBox41.Visible = false;
                textBox42.Visible = false;
             }

            if (trackBar2.Value == 2)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = true;
                textBox14.Visible = true;
                textBox15.Visible = false;
                textBox16.Visible = false;
                textBox17.Visible = false;
                textBox18.Visible = false;
                textBox19.Visible = false;
                textBox20.Visible = false;
                textBox21.Visible = false;
                textBox22.Visible = false;
                textBox23.Visible = false;
                textBox24.Visible = false;
                textBox25.Visible = false;
                textBox26.Visible = false;
                textBox27.Visible = false;
                textBox28.Visible = false;
                textBox29.Visible = false;
                textBox30.Visible = false;
                textBox31.Visible = false;
                textBox32.Visible = false;
                textBox33.Visible = false;
                textBox34.Visible = false;
                textBox35.Visible = false;
                textBox36.Visible = false;
                textBox37.Visible = false;
                textBox38.Visible = false;
                textBox39.Visible = false;
                textBox40.Visible = false;
                textBox41.Visible = false;
                textBox42.Visible = false;
            }

            if (trackBar2.Value == 3)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = true;
                textBox14.Visible = true;
                textBox15.Visible = true;
                textBox16.Visible = true;
                textBox17.Visible = true;
                textBox18.Visible = true;
                textBox19.Visible = true;
                textBox20.Visible = true;
                textBox21.Visible = true;
                textBox22.Visible = false;
                textBox23.Visible = false;
                textBox24.Visible = false;
                textBox25.Visible = false;
                textBox26.Visible = false;
                textBox27.Visible = false;
                textBox28.Visible = false;
                textBox29.Visible = false;
                textBox30.Visible = false;
                textBox31.Visible = false;
                textBox32.Visible = false;
                textBox33.Visible = false;
                textBox34.Visible = false;
                textBox35.Visible = false;
                textBox36.Visible = false;
                textBox37.Visible = false;
                textBox38.Visible = false;
                textBox39.Visible = false;
                textBox40.Visible = false;
                textBox41.Visible = false;
                textBox42.Visible = false;
            }

            if (trackBar2.Value == 4)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = true;
                textBox14.Visible = true;
                textBox15.Visible = true;
                textBox16.Visible = true;
                textBox17.Visible = true;
                textBox18.Visible = true;
                textBox19.Visible = true;
                textBox20.Visible = true;
                textBox21.Visible = true;
                textBox22.Visible = true;
                textBox23.Visible = true;
                textBox24.Visible = true;
                textBox25.Visible = true;
                textBox26.Visible = true;
                textBox27.Visible = true;
                textBox28.Visible = true;
                textBox29.Visible = false;
                textBox30.Visible = false;
                textBox31.Visible = false;
                textBox32.Visible = false;
                textBox33.Visible = false;
                textBox34.Visible = false;
                textBox35.Visible = false;
                textBox36.Visible = false;
                textBox37.Visible = false;
                textBox38.Visible = false;
                textBox39.Visible = false;
                textBox40.Visible = false;
                textBox41.Visible = false;
                textBox42.Visible = false;
            }

            if (trackBar2.Value == 5)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = true;
                textBox14.Visible = true;
                textBox15.Visible = true;
                textBox16.Visible = true;
                textBox17.Visible = true;
                textBox18.Visible = true;
                textBox19.Visible = true;
                textBox20.Visible = true;
                textBox21.Visible = true;
                textBox22.Visible = true;
                textBox23.Visible = true;
                textBox24.Visible = true;
                textBox25.Visible = true;
                textBox26.Visible = true;
                textBox27.Visible = true;
                textBox28.Visible = true;
                textBox29.Visible = true;
                textBox30.Visible = true;
                textBox31.Visible = true;
                textBox32.Visible = true;
                textBox33.Visible = true;
                textBox34.Visible = true;
                textBox35.Visible = true;
                textBox36.Visible = false;
                textBox37.Visible = false;
                textBox38.Visible = false;
                textBox39.Visible = false;
                textBox40.Visible = false;
                textBox41.Visible = false;
                textBox42.Visible = false;
            }

            if (trackBar2.Value == 6)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = true;
                textBox14.Visible = true;
                textBox15.Visible = true;
                textBox16.Visible = true;
                textBox17.Visible = true;
                textBox18.Visible = true;
                textBox19.Visible = true;
                textBox20.Visible = true;
                textBox21.Visible = true;
                textBox22.Visible = true;
                textBox23.Visible = true;
                textBox24.Visible = true;
                textBox25.Visible = true;
                textBox26.Visible = true;
                textBox27.Visible = true;
                textBox28.Visible = true;
                textBox29.Visible = true;
                textBox30.Visible = true;
                textBox31.Visible = true;
                textBox32.Visible = true;
                textBox33.Visible = true;
                textBox34.Visible = true;
                textBox35.Visible = true;
                textBox36.Visible = true;
                textBox37.Visible = true;
                textBox38.Visible = true;
                textBox39.Visible = true;
                textBox40.Visible = true;
                textBox41.Visible = true;
                textBox42.Visible = true;
            }
        }

        private void draw(object sender, EventArgs e)
        {
            int n_it, n_fx;
            n_it = Convert.ToInt32(trackBar1.Value);
            n_fx = trackBar2.Value;

            double[,] p11 = new double[6, 7];

            p11[0, 0] = Convert.ToDouble(textBox1.Text);
            p11[0, 1] = Convert.ToDouble(textBox2.Text);
            p11[0, 2] = Convert.ToDouble(textBox3.Text);
            p11[0, 3] = Convert.ToDouble(textBox4.Text);
            p11[0, 4] = Convert.ToDouble(textBox5.Text);
            p11[0, 5] = Convert.ToDouble(textBox6.Text);
            p11[0, 6] = Convert.ToDouble(textBox7.Text);

            p11[1, 0] = Convert.ToDouble(textBox8.Text);
            p11[1, 1] = Convert.ToDouble(textBox9.Text);
            p11[1, 2] = Convert.ToDouble(textBox10.Text);
            p11[1, 3] = Convert.ToDouble(textBox11.Text);
            p11[1, 4] = Convert.ToDouble(textBox12.Text);
            p11[1, 5] = Convert.ToDouble(textBox13.Text);
            p11[1, 6] = Convert.ToDouble(textBox14.Text);

            p11[2, 0] = Convert.ToDouble(textBox15.Text);
            p11[2, 1] = Convert.ToDouble(textBox16.Text);
            p11[2, 2] = Convert.ToDouble(textBox17.Text);
            p11[2, 3] = Convert.ToDouble(textBox18.Text);
            p11[2, 4] = Convert.ToDouble(textBox19.Text);
            p11[2, 5] = Convert.ToDouble(textBox20.Text);
            p11[2, 6] = Convert.ToDouble(textBox21.Text);

            p11[3, 0] = Convert.ToDouble(textBox22.Text);
            p11[3, 1] = Convert.ToDouble(textBox23.Text);
            p11[3, 2] = Convert.ToDouble(textBox24.Text);
            p11[3, 3] = Convert.ToDouble(textBox25.Text);
            p11[3, 4] = Convert.ToDouble(textBox26.Text);
            p11[3, 5] = Convert.ToDouble(textBox27.Text);
            p11[3, 6] = Convert.ToDouble(textBox28.Text);

            p11[4, 0] = Convert.ToDouble(textBox29.Text);
            p11[4, 1] = Convert.ToDouble(textBox30.Text);
            p11[4, 2] = Convert.ToDouble(textBox31.Text);
            p11[4, 3] = Convert.ToDouble(textBox32.Text);
            p11[4, 4] = Convert.ToDouble(textBox33.Text);
            p11[4, 5] = Convert.ToDouble(textBox34.Text);
            p11[4, 6] = Convert.ToDouble(textBox35.Text);

            p11[5, 0] = Convert.ToDouble(textBox36.Text);
            p11[5, 1] = Convert.ToDouble(textBox37.Text);
            p11[5, 2] = Convert.ToDouble(textBox38.Text);
            p11[5, 3] = Convert.ToDouble(textBox39.Text);
            p11[5, 4] = Convert.ToDouble(textBox40.Text);
            p11[5, 5] = Convert.ToDouble(textBox41.Text);
            p11[5, 6] = Convert.ToDouble(textBox42.Text);

            for (int i = 0; i < 6; i++)
            {
                if (p11[i, 0] > 1 || p11[i, 0] < 0) { p11[i, 0] = .99; }
                if (p11[i, 1] > 1 || p11[i, 1] < 0) { p11[i, 0] = .99; }
            }

            double[, ,] Trf = new double[2, 2, 6];
            Trf[0, 0, 0] = p11[0, 0] * Math.Cos(3.1415926 * p11[0, 2] / 180);
            Trf[0, 1, 0] = p11[0, 0] * Math.Cos(3.1415926 * p11[0, 2] / 180) * p11[0, 3] - p11[0, 0] * Math.Sin(3.1415926 * p11[0, 2] / 180);
            Trf[1, 0, 0] = p11[0, 1] * Math.Sin(3.1415926 * p11[0, 2] / 180);
            Trf[1, 1, 0] = p11[0, 1] * Math.Sin(3.1415926 * p11[0, 2] / 180) * p11[0, 3] + p11[0, 1] * Math.Cos(3.1415926 * p11[0, 2] / 180);

            Trf[0, 0, 1] = p11[1, 0] * Math.Cos(3.1415926 * p11[1, 2] / 180);
            Trf[0, 1, 1] = p11[1, 0] * Math.Cos(3.1415926 * p11[1, 2] / 180) * p11[1, 3] - p11[1, 0] * Math.Sin(3.1415926 * p11[1, 2] / 180);
            Trf[1, 0, 1] = p11[1, 1] * Math.Sin(3.1415926 * p11[1, 2] / 180);
            Trf[1, 1, 1] = p11[1, 1] * Math.Sin(3.1415926 * p11[1, 2] / 180) * p11[1, 3] + p11[1, 1] * Math.Cos(3.1415926 * p11[1, 2] / 180);

            Trf[0, 0, 2] = p11[2, 0] * Math.Cos(3.1415926 * p11[2, 2] / 180);
            Trf[0, 1, 2] = p11[2, 0] * Math.Cos(3.1415926 * p11[2, 2] / 180) * p11[2, 3] - p11[2, 0] * Math.Sin(3.1415926 * p11[2, 2] / 180);
            Trf[1, 0, 2] = p11[2, 1] * Math.Sin(3.1415926 * p11[2, 2] / 180);
            Trf[1, 1, 2] = p11[2, 1] * Math.Sin(3.1415926 * p11[2, 2] / 180) * p11[2, 3] + p11[2, 1] * Math.Cos(3.1415926 * p11[2, 2] / 180);

            Trf[0, 0, 3] = p11[3, 0] * Math.Cos(3.1415926 * p11[3, 2] / 180);
            Trf[0, 1, 3] = p11[3, 0] * Math.Cos(3.1415926 * p11[3, 2] / 180) * p11[3, 3] - p11[3, 0] * Math.Sin(3.1415926 * p11[3, 2] / 180);
            Trf[1, 0, 3] = p11[3, 1] * Math.Sin(3.1415926 * p11[3, 2] / 180);
            Trf[1, 1, 3] = p11[3, 1] * Math.Sin(3.1415926 * p11[3, 2] / 180) * p11[3, 3] + p11[3, 1] * Math.Cos(3.1415926 * p11[3, 2] / 180);

            Trf[0, 0, 4] = p11[4, 0] * Math.Cos(3.1415926 * p11[4, 2] / 180);
            Trf[0, 1, 4] = p11[4, 0] * Math.Cos(3.1415926 * p11[4, 2] / 180) * p11[4, 3] - p11[4, 0] * Math.Sin(3.1415926 * p11[4, 2] / 180);
            Trf[1, 0, 4] = p11[4, 1] * Math.Sin(3.1415926 * p11[4, 2] / 180);
            Trf[1, 1, 4] = p11[4, 1] * Math.Sin(3.1415926 * p11[4, 2] / 180) * p11[4, 3] + p11[4, 1] * Math.Cos(3.1415926 * p11[4, 2] / 180);

            Trf[0, 0, 5] = p11[5, 0] * Math.Cos(3.1415926 * p11[5, 2] / 180);
            Trf[0, 1, 5] = p11[5, 0] * Math.Cos(3.1415926 * p11[5, 2] / 180) * p11[5, 3] - p11[5, 0] * Math.Sin(3.1415926 * p11[5, 2] / 180);
            Trf[1, 0, 5] = p11[5, 1] * Math.Sin(3.1415926 * p11[5, 2] / 180);
            Trf[1, 1, 5] = p11[5, 1] * Math.Sin(3.1415926 * p11[5, 2] / 180) * p11[5, 3] + p11[5, 1] * Math.Cos(3.1415926 * p11[5, 2] / 180);

            double[,] pts = new double[2, n_it];
            Array.Clear(pts, 0, pts.Length);
            chart1.Series["Series1"].Points.Clear();

            //Weight the transformations based on their probability.
            int[] cum = new int[n_fx+1];
            cum[0] = 0;
            // TODO: Check if sum of the probilities is more than 1!
            for (int i = 1; i < n_fx; i++)
            {
                //p11[i, 6] = p11[i, 6] * 1000;
                cum[i] = cum[i-1] + Convert.ToInt16(p11[i, 6] * 1000);
            }
            cum[n_fx] = 1000;

            Random r = new Random();
            int indx; int p_fx;
            indx = 0;
            for (int i = 0; i < 100; i++)
            {
                p_fx = r.Next(1001);
                for (int j = 0; j < n_fx; j++)
                {
                    if (p_fx >= cum[j] && p_fx < cum[j+1]) { indx = j; }
                }
                pts[0, 0] = Trf[0, 0, indx] * pts[0, 0] + Trf[0, 1, indx] * pts[1, 0] + p11[indx, 4];
                pts[1, 0] = Trf[1, 0, indx] * pts[0, 0] + Trf[1, 1, indx] * pts[1, 0] + p11[indx, 5];
            }
            chart1.Series["Series1"].Points.AddXY(pts[0, 0], pts[1, 0]);

            for (int i = 1; i < n_it; i++)
            {
                p_fx = r.Next(1001);
                for (int j = 0; j < n_fx; j++)
                {
                    if (p_fx >= cum[j] && p_fx < cum[j + 1]) { indx = j; }
                }
                pts[0, i] = Trf[0, 0, indx] * pts[0, i - 1] + Trf[0, 1, indx] * pts[1, i - 1] + p11[indx, 4];
                pts[1, i] = Trf[1, 0, indx] * pts[0, i - 1] + Trf[1, 1, indx] * pts[1, i - 1] + p11[indx, 5];
                chart1.Series["Series1"].Points.AddXY(pts[0, i], pts[1, i]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem == "Seirpinksi")
            {
                trackBar2.Value = 3;
                trackBar2_Scroll(null, null);
                textBox1.Text = Convert.ToString(.5);
                textBox2.Text = Convert.ToString(.5);
                textBox3.Text = Convert.ToString(0);
                textBox4.Text = Convert.ToString(0);
                textBox5.Text = Convert.ToString(0);
                textBox6.Text = Convert.ToString(0);
                textBox7.Text = Convert.ToString(.333);
                textBox8.Text = Convert.ToString(.5);
                textBox9.Text = Convert.ToString(.5);
                textBox10.Text = Convert.ToString(0);
                textBox11.Text = Convert.ToString(0);
                textBox12.Text = Convert.ToString(.5);
                textBox13.Text = Convert.ToString(0);
                textBox14.Text = Convert.ToString(.333);
                textBox15.Text = Convert.ToString(.5);
                textBox16.Text = Convert.ToString(.5);
                textBox17.Text = Convert.ToString(0);
                textBox18.Text = Convert.ToString(0);
                textBox19.Text = Convert.ToString(.25);
                textBox20.Text = Convert.ToString(.433);
                textBox21.Text = Convert.ToString(.333);
            }

            if (listBox1.SelectedItem == "Fern")
            {
                trackBar2.Value = 4;
                trackBar2_Scroll(null, null);
                textBox1.Text = Convert.ToString(0);
                textBox2.Text = Convert.ToString(.19);
                textBox3.Text = Convert.ToString(0);
                textBox4.Text = Convert.ToString(0);
                textBox5.Text = Convert.ToString(0);
                textBox6.Text = Convert.ToString(0);
                textBox7.Text = Convert.ToString(.25);
                textBox8.Text = Convert.ToString(-.3);
                textBox9.Text = Convert.ToString(.3);
                textBox10.Text = Convert.ToString(100);
                textBox11.Text = Convert.ToString(0);
                textBox12.Text = Convert.ToString(0);
                textBox13.Text = Convert.ToString(1);
                textBox14.Text = Convert.ToString(.25);
                textBox15.Text = Convert.ToString(.3);
                textBox16.Text = Convert.ToString(.3);
                textBox17.Text = Convert.ToString(-85);
                textBox18.Text = Convert.ToString(0);
                textBox19.Text = Convert.ToString(0);
                textBox20.Text = Convert.ToString(1.3);
                textBox21.Text = Convert.ToString(.25);
                textBox22.Text = Convert.ToString(.8075);
                textBox23.Text = Convert.ToString(.85);
                textBox24.Text = Convert.ToString(5);
                textBox25.Text = Convert.ToString(0);
                textBox26.Text = Convert.ToString(0);
                textBox27.Text = Convert.ToString(1.8);
                textBox28.Text = Convert.ToString(.25);
            }       




            if (listBox1.SelectedItem == "The Star") {
                trackBar2.Value = 3;
                trackBar2_Scroll(null,null);
                textBox1.Text = Convert.ToString(.5);
                textBox2.Text = Convert.ToString(.5);
                textBox3.Text = Convert.ToString(0);
                textBox4.Text = Convert.ToString(0);
                textBox5.Text = Convert.ToString(0);
                textBox6.Text = Convert.ToString(0);
                textBox7.Text = Convert.ToString(.333);
                textBox8.Text = Convert.ToString(.5);
                textBox9.Text = Convert.ToString(.5);
                textBox10.Text = Convert.ToString(90);
                textBox11.Text = Convert.ToString(0);
                textBox12.Text = Convert.ToString(.5);
                textBox13.Text = Convert.ToString(.5);
                textBox14.Text = Convert.ToString(.333);
                textBox15.Text = Convert.ToString(.5);
                textBox16.Text = Convert.ToString(.5);
                textBox17.Text = Convert.ToString(-90);
                textBox18.Text = Convert.ToString(0);
                textBox19.Text = Convert.ToString(.5);
                textBox20.Text = Convert.ToString(.5);
                textBox21.Text = Convert.ToString(.333);
             }       
        }

       
    }
}
