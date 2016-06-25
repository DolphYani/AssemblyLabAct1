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
        public List<Instruction> instructionList = new List<Instruction>();

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

            instructionList.Add(new Instruction(Ins1, Ins2, Ins3, Ins4, OneInstruction));

            rtxtBody.Text = OneInstruction;
        }
    }
}
