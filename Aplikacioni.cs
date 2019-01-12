using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VingereEncDec
{

    public partial class Aplikacioni : Form
    {
        public Aplikacioni()
        {
        InitializeComponent();
        }
        private void Aplikacioni_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }
        private void btnEnkripto_Click(object sender, EventArgs e)
        {
                for (int i = 0; i < txtPlaintext.TextLength; i++)
                {
                    if ((char.IsLetter(txtPlaintext.Text, i) == false) && (char.IsSeparator(txtPlaintext.Text, i) == false))
                    {
                        MessageBox.Show("Pleintext-i Permbanë vlera të Panjohura!!");
                        lblrezultati.Text = "Gabim!!!!";
                        goto Fundi;
                    }
                    else
                    {
                        continue;
                    }
                }

                for (int i = 0; i < txtCelesi.TextLength; i++)
                {
                    if ((char.IsLetter(txtCelesi.Text, i) == false) && (char.IsSeparator(txtCelesi.Text, i) == false))
                    {
                        MessageBox.Show("Çelësi Permbanë vlera të Panjohura!!");
                        lblrezultati.Text = "Gabim!!!!";
                        goto Fundi; 
                    }
                    else
                    {
                        continue;
                    }
                }
               
                if (txtPlaintext.Text == "" || txtCelesi.Text == "" )
                {
                    MessageBox.Show("Mbusheni Hapësirat e Zbrazeta", "Vërejtje", MessageBoxButtons.OKCancel);
                }
                else  
                {
                    Enkriptimi_Dekriptimi_Bazik EnkriptoTekstin = new Enkriptimi_Dekriptimi_Bazik(txtPlaintext.Text, txtCelesi.Text);
                    lblrezultati.Text = EnkriptoTekstin.Enkript();
                }

        Fundi: return;
        }
        private void btnDekripto_Click(object sender, EventArgs e)
        {

                for (int i = 0; i < txtPlaintext.TextLength; i++)
                {
                    if ((char.IsLetter(txtPlaintext.Text, i) == false) && (char.IsSeparator(txtPlaintext.Text,i)==false))
                    {
                        MessageBox.Show("Pleintext-i Permbanë vlera të Panjohura!!");
                        lblrezultati.Text = "Gabim!!!!";
                        goto Fundi;
                    }
                    else
                    {
                        continue;
                    }
                }

                for (int i = 0; i < txtCelesi.TextLength; i++)
                {
                    if ((char.IsLetter(txtCelesi.Text, i) == false) && (char.IsSeparator(txtCelesi.Text, i) == false))
                    {
                        MessageBox.Show("Çelësi Permbanë vlera të Panjohura!!");
                        lblrezultati.Text = "Gabim!!!!";
                        goto Fundi;
                    }
                    else
                    {
                        continue;
                    }
                }

                if (txtPlaintext.Text == "" || txtCelesi.Text == "")
                {
                    MessageBox.Show("Mbusheni Hapësirat e Zbrazeta", "Vërejtje", MessageBoxButtons.OKCancel);
                }
                else
                {
                    Enkriptimi_Dekriptimi_Bazik DekriptoTekstin = new Enkriptimi_Dekriptimi_Bazik(txtPlaintext.Text, txtCelesi.Text);
                    lblrezultati.Text = DekriptoTekstin.Dekript();
                }

        Fundi: return;
        }     
        private void btnEnkriptoAvancuar_Click(object sender, EventArgs e)
        {
                Enkriptimi_Dekriptimi_Avancuar EnkriptoTekstin = new Enkriptimi_Dekriptimi_Avancuar(txtPlaintext.Text, txtCelesi.Text, txtCelesiAlfabetik.Text);
                for (int i = 0; i < txtCelesiAlfabetik.TextLength; i++)
                {
                    if (char.IsLetter(txtCelesiAlfabetik.Text, i) == false)
                    {
                        MessageBox.Show("Çelësi Alfabetik Permbanë vlera të Panjohura!!");
                        lblrezultati.Text = "Gabim!!!!";
                        goto Fundi;
                    }
                    else 
                    {
                        continue;
                    }
                }


                for (int i = 0; i < txtPlaintext.TextLength; i++)
                {
                    if ((char.IsLetter(txtPlaintext.Text, i) == false) && (char.IsSeparator(txtPlaintext.Text, i) == false))
                    {
                        MessageBox.Show("Pleintext-i Permbanë vlera të Panjohura!!");
                        lblrezultati.Text = "Gabim!!!!";
                        goto Fundi;
                    }
                    else
                    {
                        continue;
                    }
                }

                for (int i = 0; i < txtCelesi.TextLength; i++)
                {
                    if ((char.IsLetter(txtCelesi.Text, i) == false) && (char.IsSeparator(txtCelesi.Text, i) == false))
                    {
                        MessageBox.Show("Çelësi Permbanë vlera të Panjohura!!");
                        lblrezultati.Text = "Gabim!!!!";
                        goto Fundi;
                    }
                    else
                    {
                        continue;
                    }
                }
            
                if (txtPlaintext.Text == "" || txtCelesi.Text == "" || txtCelesiAlfabetik.Text=="")
                {
                    MessageBox.Show("Mbusheni Hapësirat e Zbrazeta", "Vërejtje", MessageBoxButtons.OKCancel);
                }
                else
                {
                    lblrezultati.Text = EnkriptoTekstin.Enkript();
                }

        Fundi: return;  
        }
        private void btnDekriptoAvancuar_Click(object sender, EventArgs e)
        {
                Enkriptimi_Dekriptimi_Avancuar DekriptoTekstin = new Enkriptimi_Dekriptimi_Avancuar(txtPlaintext.Text, txtCelesi.Text, txtCelesiAlfabetik.Text);

                for (int i = 0; i < txtCelesiAlfabetik.TextLength; i++)
                {
                    if (char.IsLetter(txtCelesiAlfabetik.Text, i) == false)
                    {
                        MessageBox.Show("Keni Kujdes Celesi Alfabetik Permban \nVlera Pa Njohura Programi");
                        goto Fundi;
                    }
                    else { continue; }
                }

                for (int i = 0; i < txtPlaintext.TextLength; i++)
                {
                    if ((char.IsLetter(txtPlaintext.Text, i) == false) && (char.IsSeparator(txtPlaintext.Text, i) == false))
                    {
                        MessageBox.Show("Keni Kujdes Plainteksti Permban \nVlera Pa Njohura Programi");
                        goto Fundi;
                    }
                    else
                    {
                        continue;
                    }
                }
         
                for (int i = 0; i < txtCelesi.TextLength; i++)
                {
                    if ((char.IsLetter(txtCelesi.Text, i) == false) && (char.IsSeparator(txtCelesi.Text, i) == false))
                    {
                        MessageBox.Show("Keni Kujdes Çelesi Permban \nVlera Pa Njohura Programi");
                        goto Fundi;
                    }
                    else
                    {
                        continue;
                    }
                }

                if (txtPlaintext.Text == "" || txtCelesi.Text == "" || txtCelesiAlfabetik.Text == "")
                {
                    MessageBox.Show("Mbushni Hapsirat e Zbrazta ", "Verejtje", MessageBoxButtons.OKCancel);
                }
                else
                {
                    lblrezultati.Text = DekriptoTekstin.Dekript();
                }
        Fundi: return;    
        }
        private void btnPastro_Click(object sender, EventArgs e)
        {
            txtPlaintext.Clear();
            txtCelesi.Clear();
            txtCelesiAlfabetik.Clear();
            lblrezultati.Text = "";
        }
        private void btnMerrRezultatin_Click(object sender, EventArgs e)
        {
            txtPlaintext.Text = lblrezultati.Text;
        }
        private void btnExit_Click(object sender, EventArgs e)
        { Application.Exit(); }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblCelesiAlfabetik.Visible = false;
            txtCelesiAlfabetik.Visible = false;
            btnEnkriptoAvancuar.Visible = false;
            btnDekriptoAvancuar.Visible = false;
            btnEnkripto.Visible = true;
            btnDekripto.Visible = true;

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblCelesiAlfabetik.Visible = true;
            txtCelesiAlfabetik.Visible = true;
            btnEnkriptoAvancuar.Visible = true;
            btnDekriptoAvancuar.Visible = true;
            btnEnkripto.Visible = false;
            btnDekripto.Visible = false;
        }

    }
}
