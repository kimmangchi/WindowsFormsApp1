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

            byte classHumanCount = 30;
            short seoulBusanDistance = 20000;
            int schoolTeacherAge = 28;
            float distanceToSun = 10000000000;
            double spaceRocketFire = 89.124;
            decimal koreaPeopleHairNum = 99999999999;

            textBox_Print.Text += classHumanCount.GetType();
            textBox_Print.Text += " ";
            textBox_Print.Text += "classHumanCount:";
            textBox_Print.Text += " ";
            textBox_Print.Text += classHumanCount;
            textBox_Print.Text += "num";

            textBox_Print.Text += "\r\n";

            textBox_Print.Text += seoulBusanDistance.GetType();
            textBox_Print.Text += " ";
            textBox_Print.Text += "seoulBusanDistance:";
            textBox_Print.Text += " ";
            textBox_Print.Text += seoulBusanDistance;
            textBox_Print.Text += "KM";

            textBox_Print.Text += "\r\n";

            textBox_Print.Text += schoolTeacherAge.GetType();
            textBox_Print.Text += " ";
            textBox_Print.Text += "schoolTeacherAge:";
            textBox_Print.Text += " ";
            textBox_Print.Text += schoolTeacherAge;
            textBox_Print.Text += "age";

            textBox_Print.Text += "\r\n";

            textBox_Print.Text += distanceToSun.GetType();
            textBox_Print.Text += " ";
            textBox_Print.Text += "distanceToSun:";
            textBox_Print.Text += " ";
            textBox_Print.Text += distanceToSun;
            textBox_Print.Text += "KM";

            textBox_Print.Text += "\r\n";

            textBox_Print.Text += spaceRocketFire.GetType();
            textBox_Print.Text += " ";
            textBox_Print.Text += "spaceRocketFire:";
            textBox_Print.Text += " ";
            textBox_Print.Text += spaceRocketFire;
            textBox_Print.Text += "Pa";

            textBox_Print.Text += "\r\n";

            textBox_Print.Text += koreaPeopleHairNum.GetType();
            textBox_Print.Text += " ";
            textBox_Print.Text += "koreaPeopleHairNum:";
            textBox_Print.Text += " ";
            textBox_Print.Text += koreaPeopleHairNum;

            int a = 100;
            int b = 33;

            int[] result = division(a, b);

            textBox_Print.Text += "\r\n\r\n";

            textBox_Print.Text += "quotient : ";
            textBox_Print.Text += array[0];

            textBox_Print.Text += "\r\n";

            textBox_Print.Text += "remainder : ";
            textBox_Print.Text += array[1];
        }

        int[] division(int x, int y)
        {
            int[] result = new int[2];
            result[0] = x / y;
            result[1] = x % y;
            
            return result;
        }

    }
}
