using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Font_and_Size
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declareren van de variabelen


        string strTekst = "", strGekozenFile, strLetter;
        int intStringLengte, intTeller, intWillekeurigGetal, intWillekeurigeLetterGrootte;

        private void openFD_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            openFD.Title = "Open tekstfile";
            openFD.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFD.FileName = "";
            openFD.Filter = "Tekst (*.txt)|*.txt";
            openFD.ShowDialog();

            strGekozenFile = openFD.FileName;
            rtbTekst.LoadFile(strGekozenFile, RichTextBoxStreamType.PlainText);
            strTekst = rtbTekst.Text;
        }

        Random rndWillekeurigGetal = new Random();
        Random rndWillekeurigeLetterGrootte = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            String[] arrayLetterType = new string[10];
            arrayLetterType[0] = "MV Boli";
            arrayLetterType[1] = "MS Gothic";
            arrayLetterType[2] = "Mongolian Baiti";
            arrayLetterType[3] = "Segoe Print";
            arrayLetterType[4] = "SimSun";
            arrayLetterType[5] = "Tahoma";
            arrayLetterType[6] = "Times New Roman";
            arrayLetterType[7] = "Verdana";
            arrayLetterType[8] = "Ink Free";
            arrayLetterType[9] = "Impact";

            //rtbTekst.SelectionFont = new Font(arrayLetterType[0], 11);
            //rtbTekst.SelectedText = strTekst;
            //rtbTekst.SelectionFont = new Font(arrayLetterType[4], 11);
            //rtbTekst.SelectedText  += strTekst2;

            strTekst = rtbTekst.Text;
            intStringLengte = strTekst.Length;
            rtbTekst.Clear();

            for(intTeller = 1; intTeller <= intStringLengte; intTeller++)
            {
                strLetter = strTekst.Substring(intTeller - 1, 1);
                intWillekeurigGetal = rndWillekeurigGetal.Next(0, 10);
                intWillekeurigeLetterGrootte = rndWillekeurigeLetterGrootte.Next(8, 30);
                rtbTekst.SelectionFont = new Font(arrayLetterType[intWillekeurigGetal], intWillekeurigeLetterGrootte);
                rtbTekst.SelectedText += strLetter;


            }
            

        }
    }
}
