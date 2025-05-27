using _5_nights_in_sturgeon.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_nights_in_sturgeon
{
    public partial class FinalGame: Form
    {
        public FinalGame()
        {
            InitializeComponent();
            lobby();
        }
        int boltscount = -5;
        int night = 1;
        int timeMin = 30; // I maean minutes
        int timeHours = 5;
        bool timestart = false;

        private void lobby()
        {
            lobbyMedia.uiMode = "none";
            lobbyMedia.URL = "C:\\Users\\i.shutiuk\\Desktop\\5 nights in sturgeon\\videos\\podval1.mp4";
            lobbyMedia.settings.setMode("loop", true);
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {

            lobbyMedia.Visible = false;
            textSturgeon.Visible = false;
            textNights.Visible = false;
            ExitBtn.Visible = false;
            StartBtn.Visible = false;
            loadingLbl.Visible = true;
            loadingBox.Visible = true;
            Btncontiunue.Visible = true;
        }

        private void tightenBtn_Click(object sender, EventArgs e)
        {
            boltscount = boltscount + 5;
            tightenOutput.Text = boltscount.ToString();

        }
        private void meinCamerastart()
        {
            btnCameras.Visible = false;
            mainLoc.Visible = false;
            loadingBox.Visible = false;
            loadingLbl.Visible = false;
            Camera6Btn.Visible = true;
            camera1Btn.Visible = true;
            Camera2Btn.Visible = true;
            Camera5Btn.Visible = true;  
            Camera4Btn.Visible = true;
            camera3Btn.Visible = true;
            telephone.Visible = true;
            telephone.uiMode = "none";
            loadingBox.Visible = false;
            Btncontiunue.Visible = false;
            ExitCamerasBtn.Visible = true;
        }

        private void Btncontiunue_Click(object sender, EventArgs e)
        {
           mainlocation();
            boltscount = 100;
           timestart = true;
            TimeOutput.Visible = true;
        }

        private void btnCameras_Click(object sender, EventArgs e)
        {
            meinCamerastart();
            
        }
       private void mainlocation()
        {
            loadingBox.Visible = false;
            Btncontiunue.Visible = false;
            mainLoc.Visible = true;
            btnCameras.Visible = true;
            loadingLbl.Visible =false;
            Camera6Btn.Visible = false;
            camera1Btn.Visible = false;
            Camera2Btn.Visible = false;
            Camera5Btn.Visible = false;
            Camera4Btn.Visible = false;
            camera3Btn.Visible = false;
            telephone.Visible = false;

            loadingBox.Visible = false;
            Btncontiunue.Visible = false;
            ExitCamerasBtn.Visible = false;
            exitcamera4();
        }

        private void ExitCamerasBtn_Click(object sender, EventArgs e)
        {
            mainlocation();
        }

        private void Camera4Btn_Click(object sender, EventArgs e)
        {
            cameraToll();
        }
        void cameraToll()
        {
            tightenBtn.Visible = true;
            tightenOutput.Visible = true;
            telephone.URL = "C:\\Users\\i.shutiuk\\Desktop\\5 nights in sturgeon\\videos\\podval1.mp4";
            telephone.uiMode = "none";
            telephone.settings.setMode("loop", true);
            telephone.Ctlcontrols.play();
        }
        void smerti()
        {
            MessageBox.Show("You die...");
            Application.Exit();
        }
        void boltdie()
        {
            telephone.URL = "C:\\Users\\i.shutiuk\\Desktop\\5 nights in sturgeon\\videos\\podval2.mp4";
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timeMin = timeMin + 1;
            if (timeMin == 60) 
            { 
                timeMin = 0;
                timeHours = timeHours + 1;
                if (timeHours == 6)
                {
                    MessageBox.Show("next Night ");
                    mainlocation();
                    timeHours = 0;
                    timeMin = 0;
                   
                }
            }
            else if (timestart == true) TimeOutput.Text = timeHours.ToString() + " Am " + timeMin.ToString() + " sec " + night.ToString() + " Night ";
            else if (timestart == true) TimeOutput.Text = timeHours.ToString() + " Am " + timeMin.ToString() + " sec " + night.ToString() + " Night ";

            boltscount = boltscount - 1;
            tightenOutput.Text = boltscount.ToString();
             if (boltscount == 0)
            {
                boltdie();
                smerti();
            }


        }
        void exitcamera4()
        {
            tightenOutput.Visible = false;
            tightenBtn.Visible = false;
        }

        private void Camera6Btn_Click(object sender, EventArgs e)
        {
            exitcamera4();
            //telephone.URL = 
        }

        private void Camera5Btn_Click(object sender, EventArgs e)
        {
            exitcamera4();
            //telephone.URL = 
            if (night == 2)
            {

            }
            else
            {

            }
        }

        private void Camera2Btn_Click(object sender, EventArgs e)
        {
            exitcamera4();
            //telephone.URL = 
            if (night > 0)
            {

            }
            else
            {

            }
        }

        private void camera3Btn_Click(object sender, EventArgs e)
        {
            exitcamera4();
            //telephone.URL = 
            if (night > 3)
            {

            }
            else {
                //telephone.URL =
            }
        }

        private void camera1Btn_Click(object sender, EventArgs e)
        {
            exitcamera4();
            //telephone.URL = 
            if (night == 5)
            {

            }
            else
            {

            }
        }


    }
}

