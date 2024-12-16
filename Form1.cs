using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            byte classHumanNum = 30;
            short seoulBusanDistance = 20000;
            int schoolTeacherAge = 28;
            float distanceToSun = 10000000000;
            double spaceRocketFire = 89.124;
            decimal koreaPeopleHairNum = 99999999999;

            textBox_Print.Text += classHumanNum.GetType();
            textBox_Print.Text += " ";
            textBox_Print.Text += "classHumanNum:";
            textBox_Print.Text += " ";
            textBox_Print.Text += classHumanNum;

            textBox_Print.Text += "\r\n";

            textBox_Print.Text += seoulBusanDistance.GetType();
            textBox_Print.Text += " ";
            textBox_Print.Text += "seoulBusanDistance:";
            textBox_Print.Text += " ";
            textBox_Print.Text += seoulBusanDistance;

            textBox_Print.Text += "\r\n";

            textBox_Print.Text += schoolTeacherAge.GetType();
            textBox_Print.Text += " ";
            textBox_Print.Text += "schoolTeacherAge:";
            textBox_Print.Text += " ";
            textBox_Print.Text += schoolTeacherAge;

            textBox_Print.Text += "\r\n";

            textBox_Print.Text += distanceToSun.GetType();
            textBox_Print.Text += " ";
            textBox_Print.Text += "distanceToSun:";
            textBox_Print.Text += " ";
            textBox_Print.Text += distanceToSun;

            textBox_Print.Text += "\r\n";

            textBox_Print.Text += spaceRocketFire.GetType();
            textBox_Print.Text += " ";
            textBox_Print.Text += "spaceRocketFire:";
            textBox_Print.Text += " ";
            textBox_Print.Text += spaceRocketFire;

            textBox_Print.Text += "\r\n";

            textBox_Print.Text += koreaPeopleHairNum.GetType();
            textBox_Print.Text += " ";
            textBox_Print.Text += "koreaPeopleHairNum:";
            textBox_Print.Text += " ";
            textBox_Print.Text += koreaPeopleHairNum;
        }
    }
}
