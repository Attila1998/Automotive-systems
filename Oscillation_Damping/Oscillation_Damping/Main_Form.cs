using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MccDaq;
using System.IO;
    

namespace Oscillation_Damping
{
    
    public partial class Main_Form : Form
    {
        int counter = 0;
        MccDaq.MccBoard Daqboard = new MccDaq.MccBoard(0);
        bool file_Enable = true;
        int fileCounter = 0;
        string fileString = "p=[";

        double e_1 = 0;
        double e_2 = 0;
        double u_1 = 0;

        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            Timer.Interval = 15;
            Timer.Start();

        }

        private void Lab_Generate_Pulse()
        {
            counter++;
            if(counter<300){
               Daqboard.AOut(0,Range.Uni5Volts,4095);
               Daqboard.AOut(1,Range.Uni5Volts,2048);
               Control_Signal_TextBox.Text = "5V";
            }
            else if (counter<600)
            {
                Daqboard.AOut(0,Range.Uni5Volts,0);
                Daqboard.AOut(1,Range.Uni5Volts,2048);
                Control_Signal_TextBox.Text = "-5V";
            }
            else if (counter > 600)
            {
                counter = 0;
   
            }

            

        }

        private void Lab_Save_Data()
        {
            Lab_Generate_Pulse();
            short AI0;
            Daqboard.AIn(0, Range.Bip10Volts, out AI0);
            double p = (20.0) * (double)AI0 / 4095.0 - 10;
            Position_Signal_TextBox.Text = p.ToString();
            if(file_Enable)
                if (fileCounter < 1000)
                {
                    fileString += p.ToString("F") + " ";
                    fileCounter++;
                }
                else{
                    file_Enable = false;
                    fileString += "];";
                    StreamWriter f = File.CreateText("measurement.m");
                    f.WriteLine(fileString);
                    f.WriteLine("plot(p)");
                    f.Close();
                }

        }

        private void Lab_PID_Control()
        {
            short AI0;
            Daqboard.AIn(0, Range.Bip10Volts, out AI0);
            double x = (20.0) * (double)AI0 / 4095.0 - 10;
            Position_Signal_TextBox.Text = x.ToString();

            double r=0;

            counter++;

            if (counter < 300)
            {
                r = 0;
            }
            else if (counter < 600)
            {
                r = 1;
            }
            else if (counter > 600)
            {
                counter = 0;

            }
            double e = r - x;

            double u=0;
            double Kp = 50;
            double q0 = 5.47;
            double q1 = -6.64;
            double q2 = 2.82;


            u = u_1 + Kp * (q0 * e + q1 * e_1 + q2 * e_2);

            u_1 = u;
            e_2 = e_1;
            e_1 = e;

            if (u > 2047)
            {
                u = 2047;
            }
            else if (u < -2047)
            {
                u = -2047;
            }


            u = u + 2047;
            Daqboard.AOut(0, Range.Uni5Volts, (short)u);
            Daqboard.AOut(1, Range.Uni5Volts, 2047);


        }

        private void Lab_State_Space_Control()
        {


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Lab_Selector_ComboBox.SelectedIndex == 0)
                Lab_Generate_Pulse();
            else if (Lab_Selector_ComboBox.SelectedIndex == 1)
                Lab_Save_Data();
            else if (Lab_Selector_ComboBox.SelectedIndex == 2)
                Lab_PID_Control();
            else if (Lab_Selector_ComboBox.SelectedIndex == 3)
                Lab_State_Space_Control();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Velocity_Signal_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
