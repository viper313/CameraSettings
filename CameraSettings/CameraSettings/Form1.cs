using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Threading;

namespace CameraSettings
{
    public partial class Form1 : Form
    {
        VideoCapture capture;

        bool Stop = false;
        bool Start = false;
        bool Pauza = false;

        bool Stop2 = false;
        bool Start2=false;
        bool Pauza2 = false;

        public Mat Orginal = new Mat();
        public Mat Kopia = new Mat();
        public Mat Szara = new Mat();

        byte[] tablica_LUT = new byte[256];
        byte[] tablica_LUTC = new byte[256];
        byte[] tablica_LUTB = new byte[256];

        Mat LUT = new Mat();

        Image<Bgr, byte> obrazek1;
        Image<Bgr, byte> obrazek2;
        Image<Gray, byte> obrazekSzary;
        

        public Form1()
        {
            InitializeComponent();

            obrazek1 = new Image<Bgr, byte>(ibOrginal.Size);
            obrazek2 = new Image<Bgr, byte>(ibKopia.Size);
            obrazekSzary = new Image<Gray, byte>(ibKopia.Size);

            for (int i = 0; i < tablica_LUTB.Length; i++)// w ramach testu
            {
                tablica_LUTB[i] = (byte)i;
            }

            for (int i = 0; i < tablica_LUTC.Length; i++)// w ramach testu
            {
                tablica_LUTC[i] = (byte)i;
            }
        }
        

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (capture == null)
            {
                capture = new VideoCapture();
            }
            capture.ImageGrabbed += Capture_ImageGrabbed;           //to jest złe
            capture.ImageGrabbed += Capture_ImageGrabbed1;          //to jest złe

            Start = true;
            Stop = false;
            Pauza = false;
            capture.Start();
        }
        ////////////////////////////////////////////////////////////////////////start ImageBox1
        private void Capture_ImageGrabbed(object sender, EventArgs e)
        {

            if (Start == true && Pauza==false && Stop==false)
            {
                try
                {
                    //Mat temp, przekazująca następnie dane do Mat głównej

                    capture.Retrieve(Orginal);
                    ibOrginal.Image = Orginal.ToImage<Bgr, byte>();
                    //obrazek1 = Orginal.ToImage<Bgr, byte>();
                }
                catch (Exception wyjontek)
                {
                    MessageBox.Show(wyjontek.Message);
                }
            }
            else if (Start == false && Pauza == true && Stop == false)
            {
                ibOrginal.Image = Orginal.ToImage<Bgr, byte>();
            }
            else
            {
                ibOrginal.Image = null;
                capture.Stop();
                
                //Orginal = null;
                //Kopia = null;
                //capture = null;
            }
        }

        ///////////////////////////////////////////////////////////////////////Start2 ImageBox2
        private void Capture_ImageGrabbed1(object sender, EventArgs e)
        {
            
            if (Start2 == true && Pauza2==false && Stop2==false)
            {
                try
                {
                    Orginal.CopyTo(Kopia);
                    //capture.Retrieve(Kopia);
                    obrazek1 = Kopia.ToImage<Bgr, byte>();
                    /*
                    if (rbRgb.Checked == true)
                    {
                        obrazek1 = Kopia.ToImage<Bgr, byte>();

                    }
                    else
                    {
                        ////skala szarości
                        ///
                        //ibKopia.Image = Kopia.ToImage<Gray, byte>();
                        //obrazekSzary = obrazek1.Convert<Gray, byte>();
                        //obrazekSzary = Kopia.ToImage<Gray, byte>();
                        GrayScalee(obrazek1);
                        
                    }
                    */
                    /*
                    /////jasność
                    byte[,,] temp1 = obrazek1.Data;
                    byte[,,] temp2 = obrazek1.Data;

                    for (int x = 0; x < obrazek1.Width; x++)
                    {
                        for (int y = 0; y < obrazek1.Height; y++)
                        {
                            temp2[y, x, 0] = (byte)(tablica_LUT[temp1[y, x, 0]]);
                            temp2[y, x, 1] = (byte)(tablica_LUT[temp1[y, x, 1]]);
                            temp2[y, x, 2] = (byte)(tablica_LUT[temp1[y, x, 2]]);
                        }
                    }
                    obrazek2.Data = temp2;
                    */
                    /*Brightnesss(obrazek1);
                    Contrast(obrazek2);*/
                    ApplyLUT(obrazek1, tablica_LUTB);
                    ApplyLUT(obrazek2, tablica_LUTC);
                    if(rbRgb.Checked == true)
                    {
                        ibKopia.Image = obrazek2;
                    }
                    else
                    {
                        obrazekSzary = obrazek2.Convert<Gray, byte>();
                        ibKopia.Image = obrazekSzary;
                        
                    }
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (Start2 == false && Pauza2 == true && Stop2==false)
            {
                if (rbRgb.Checked == true)
                {

                    //ibKopia.Image = Kopia.ToImage<Bgr, byte>();//zastąpić te dwa warunki jednym?
                    ibKopia.Image = obrazek2;
                    
                }
                else
                {
                    //ibKopia.Image = Kopia.ToImage<Gray, byte>();
                    
                    ibKopia.Image = obrazek2;

                }
            }
            else
            {
                ibKopia.Image = null;
                ibKopia.Image = null;
                obrazek2.SetZero();
            }
        }

        private void btnStart2_Click(object sender, EventArgs e)
        {
            if (Start2 == false)
            {
                Start2 = true;
                Pauza2 = false;
                Stop2 = false;
            }
        }

        private void btnStop2_Click(object sender, EventArgs e)
        {
            if (Stop2 == false)
            {
                Stop2 = true;
                Start2 = false;
                Pauza2 = false;
            }
            //ibKopia.Image = null;
        }

        private void btnPauza_Click(object sender, EventArgs e)
        {
            Start = false;
            Pauza = true;
            Stop = false;
        }

        private void btnPauza2_Click(object sender, EventArgs e)
        {
            if (Pauza2 == false)
            {
                Pauza2 = true;
                Stop2 = false;
                Start2 = false;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (Stop == false)
            {
                Start = false;
                Pauza = false;
                Stop = true;
                Stop2 = true;
                Start2 = false;
                Pauza2 = false;
            }
            //Application.Idle -= new EventHandler(this.Capture_ImageGrabbed);
            //capture.Stop();
            //ibOrginal.Image = null;
            //capture = null;
        }

        private void btnLUT_Click(object sender, EventArgs e)
        {
            int jasnosc = (int)numJasnosc.Value;


            for (int i = 0; i < tablica_LUTB.Length; i++)
            {
                int temp = i + jasnosc;
                if (temp < 0)
                    temp = 0;
                else if (temp > 255)
                    temp = 255;
                tablica_LUTB[i] = (byte)temp;
            }

            int kontrast = (int)numKontrast.Value;
            double scale = 255.0 / (255.0 - 2 * kontrast);
            double scaleFlat = scale;
            //double roundedVal;
            //Math.Round(scale);
            //roundedVal = Convert.ToByte(scale);

            /////////KONTRAST
            for (int i = kontrast; i < ((tablica_LUTC.Length) - (kontrast + 2)); i++)
            {
                tablica_LUTC[i] = (byte)scale;
                scale += scaleFlat;
                //roundedVal = Math.Round(scale);
                //roundedVal = Convert.ToByte(scale);
            }
            for (int i = 0; i < kontrast; i++)
            {
                tablica_LUTC[i] = 0;
            }

            for (int i = ((tablica_LUTC.Length) - kontrast); i < tablica_LUTC.Length; i++)
            {
                tablica_LUTC[i] = 255;
            }
            
            //zrobić tak żeby w wyniku działania(jakiego działania?) obie tablice składały się w jedną, której zastosowanie będzie dawało identyczny rezultat jak zastosowanie tych dwóch tablic z osobna (implementacja tego działanie?) - splot(Convolution), podejrzany o bycie tym działaniem

        }


        public void GrayScalee(Image<Bgr, byte> img)
        {
            byte[,,] temp3 = img.Data;
            byte[,,] varGray = new byte[obrazek1.Height, obrazek1.Width, obrazek1.NumberOfChannels];

            int width = img.Width;
            int height = img.Height;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    byte mono = (byte)((temp3[y, x, 0] + temp3[y, x, 1] + temp3[y, x, 2]) / 3);
                    for (int z = 0; z < obrazek1.NumberOfChannels; z++)
                    {
                        varGray[y, x, z] = mono;
                    }
                }
            }
            obrazek1 = new Image<Bgr, byte>(varGray);
        }
        /*
        public void Brightnesss(Image<Bgr, byte> img)
        {
            byte[,,] temp1 = img.Data;
            byte[,,] temp2 = img.Data;

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    temp2[y, x, 0] = (byte)(tablica_LUTB[temp1[y, x, 0]]);
                    temp2[y, x, 1] = (byte)(tablica_LUTB[temp1[y, x, 1]]);
                    temp2[y, x, 2] = (byte)(tablica_LUTB[temp1[y, x, 2]]);
                }
            }
            obrazek2.Data = temp2;
        }
        
        
        public void Contrast(Image<Bgr, byte> img)
        {
            byte[,,] temp1 = img.Data;
            byte[,,] temp2 = img.Data;

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    temp2[y, x, 0] = (byte)(tablica_LUTC[temp1[y, x, 0]]);
                    temp2[y, x, 1] = (byte)(tablica_LUTC[temp1[y, x, 1]]);
                    temp2[y, x, 2] = (byte)(tablica_LUTC[temp1[y, x, 2]]);
                }
            }
            obrazek2.Data = temp2;
        }
        */

        public void ApplyLUT(Image<Bgr, byte> img, byte[] LUT)
        {
            byte[,,] temp1 = img.Data;
            byte[,,] temp2 = img.Data;

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    temp2[y, x, 0] = (byte)(LUT[temp1[y, x, 0]]);
                    temp2[y, x, 1] = (byte)(LUT[temp1[y, x, 1]]);
                    temp2[y, x, 2] = (byte)(LUT[temp1[y, x, 2]]);
                }
            }
            obrazek2.Data = temp2;
        }
        

    }

   
}
