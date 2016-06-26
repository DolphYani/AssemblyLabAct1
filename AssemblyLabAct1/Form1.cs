using AssemblyLabAct1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssemblyLabAct1
{
    public partial class Form1 : Form
    {
        public List<Instruction> instructionList = new List<Instruction>();                     // This list store all the instruction (binary) using Instruction class as an object
        public int curr = 0;                                                                    // Pointer 

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String Ins1 = mtxt1.Text;
            String Ins2 = mtxt2.Text;
            String Ins3 = mtxt3.Text;
            String Ins4 = mtxt4.Text;
            String OneInstruction = Ins1 + Ins2 + Ins3 + Ins4;

            instructionList.Add(new Instruction(Ins1, Ins2, Ins3, Ins4, OneInstruction));       // Adds the user input 

            // Instruction 1
                // Subject (Civil war male character's name)
            String wIns1 = null;
            switch (instructionList[curr].getIns1()) {
                case "00":
                    wIns1 = "Steve Rogers";
                    break;
                case "01":
                    wIns1 = "Tony Stark";
                    break;
                case "10":
                    wIns1 = "Peter Parker";
                    break;
                case "11":
                    wIns1 = "Scott Lang";
                    break;
            }

            // Instruction 2
                // Verb
            String wIns2 = null;
            switch (instructionList[curr].getIns2())
            {
                case "00":
                    wIns2 = "eats";
                    break;
                case "01":
                    wIns2 = "plays";
                    break;
                case "10":
                    wIns2 = "gets";
                    break;
                case "11":
                    wIns2 = "calls";
                    break;
            }

            // Instruction 3
            String wIns3 = null;
                // Eats
            if(instructionList[curr].getIns2().Equals("00")) {
                switch(instructionList[curr].getIns3()) {
                    case "00":
                        wIns3 = "a delicious cake.";
                        break;
                    case "01":
                        wIns3 = "an expired musroom.";
                        break;
                    case "10":
                        wIns3 = "a cheap sausage.";
                        break;
                    case "11":
                        wIns3 = "an expensive lollipop.";
                        break;
                }
            }

                // Plays
            if (instructionList[curr].getIns2().Equals("01"))
            {
                switch (instructionList[curr].getIns3())
                {
                    case "00":
                        wIns3 = "Dota 2 in Trinix.";
                        break;
                    case "01":
                        wIns3 = "the old piano awesomely.";
                        break;
                    case "10":
                        wIns3 = "a movie.";
                        break;
                    case "11":
                        wIns3 = "patintero with his fellow Avengers.";
                        break;
                }
            }

                // Gets
            if (instructionList[curr].getIns2().Equals("10"))
            {
                switch (instructionList[curr].getIns3())
                {
                    case "00":
                        wIns3 = "the first price.";
                        break;
                    case "01":
                        wIns3 = "his brand new cellphone.";
                        break;
                    case "10":
                        wIns2 = "";
                        wIns3 = "will get her.";
                        break;
                    case "11":
                        wIns2 = "";
                        wIns3 = "will get his allowance.";
                        break;
                }
            }

                // Calls
            if (instructionList[curr].getIns2().Equals("11"))
            {
                switch (instructionList[curr].getIns3())
                {
                    case "00":
                        wIns3 = "Mumei suddenly.";
                        break;
                    case "01":
                        wIns3 = "the police for help.";
                        break;
                    case "10":
                        wIns2 = "";
                        wIns3 = "Calling " +wIns1+ " right now.";
                        wIns1 = "";
                        break;
                    case "11":
                        wIns2 = "";
                        wIns3 = "doen not have a load.";
                        break;
                }
            }

            // Instruction 4
                // Creating a Loop
            switch (instructionList[curr].getIns4())
            {
                    // Repeat previous
                case "00":
                    break;
                    // Go back 1 instruction
                case "01":
                    break;
                    // Back 2 instruction
                case "10":
                    break;
                    // End
                case "11":
                    break;
            }
        }
    }
}
