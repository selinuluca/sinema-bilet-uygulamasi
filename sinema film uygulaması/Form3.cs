using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_film_uygulaması
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int[] dolukoltuk = new int[20] ;
            Random rnd = new Random();
                
            for(int j=0; j<20 ; j++) 
            {
                dolukoltuk[j] = rnd.Next(1, 42);
            }

            flowLayoutPanel1.Controls.Clear();

            for (int i = 1; i < 43; i++)
            {
                Button _buton = new Button();
                _buton.BackColor = Color.AliceBlue;
                _buton.Name = i.ToString();
                _buton.Size = new System.Drawing.Size(60, 60);
                _buton.Text = i.ToString();
                _buton.TabIndex = i;
              
                _buton.Tag = null;
                for(int j=0; j<20 ;j++)
                {
                    if (dolukoltuk[j] == i)
                    {
                        _buton.Tag = true;
                                          }
                    else
                    {
                        _buton.Tag = false;
                    }

                    if (Convert.ToBoolean(_buton.Tag) == true)
                    {
                        _buton.Enabled = false;
                    }                    
                    else
                        _buton.BackColor = Color.Turquoise;

                    if (_buton.Enabled == false)
                    {
                        _buton.BackColor = Color.Red;
                    }
                }

                _buton.Click += _buton_Click;

                flowLayoutPanel1.Controls.Add(_buton);
            }
        
        }
        int biletsayisi;
        private void _buton_Click(object sender, EventArgs e)
        {
            Button basilanbutonn = (Button)sender;

                listBox1.Items.Add(basilanbutonn.Name);
                basilanbutonn.Enabled = false;
                basilanbutonn.BackColor = Color.Bisque;
            
            if(listBox1.Items.Count==biletsayisi)
            {
                flowLayoutPanel1.Enabled = false;

                MessageBox.Show(biletsayisi.ToString()+ " tane koltuk seçtiniz. İyi seyirler");
            }
            label14.Visible = true;
            listBox1.Visible = true;
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Enabled = true;
            MessageBox.Show(comboBox3.Text + "  tane koltuk numarasi seçiniz.");
            groupBox1.Visible = true;
            label6.Visible = true;
            label11.Visible = true;
            label11.Text= comboBox3.SelectedItem.ToString();
             biletsayisi = Convert.ToInt32((comboBox3.SelectedItem));
            comboBox3.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            label7.Visible = true;
            label9.Visible = true;
            label9.Text = comboBox1.SelectedItem.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            label8.Visible = true;
            label10.Visible = true;
            label10.Text = comboBox2.SelectedItem.ToString();
            label12.Visible = true;
            label13.Visible = true;
            int tutar;
            tutar = Convert.ToInt32(comboBox3.SelectedItem) * 60;
            label12.Text = Convert.ToString(tutar) + " TL";
        }
    }
}
