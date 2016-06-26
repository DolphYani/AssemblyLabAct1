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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            String msgIns1 = "First Instruction (Subject of the sentence):"
                            + "\n00\t-\tSteve Rogers"
                            + "\n01\t-\tTony Stark"
                            + "\n10\t-\tPeter Parker"
                            + "\n11\t-\tScott Lang\n";

            String msgIns2 = "Second Instruction (Verb of the sentence):"
                            + "\n00\t-\teats"
                            + "\n01\t-\tplays"
                            + "\n10\t-\tgets"
                            + "\n11\t-\tcalls\n";

            String msgIns3Eat = "Third Instruction (For eats instruction):"
                            + "\n00\t-\ta delicious cake."
                            + "\n01\t-\tan expired mushroom."
                            + "\n10\t-\ta cheap sausage."
                            + "\n11\t-\tan expensive lollipop.\n";

            String msgIns3Play = "Third Instruction (For plays instruction):"
                            + "\n00\t-\tDota 2 in Trinix."
                            + "\n01\t-\tthe old piano awesomely."
                            + "\n10\t-\ta movie."
                            + "\n11\t-\tpatintero with his fellow Avengers.\n";

            String msgIns3Get = "Third Instruction (For gets instruction):"
                            + "\n00\t-\tthe first prize."
                            + "\n01\t-\this brand new cellphone."
                            + "\n10\t-\twill get her.."
                            + "\n11\t-\twill get his allowance.\n";

            String msgIns3Call = "Third Instruction (For calls instruction):"
                            + "\n00\t-\tMumei Suddenly."
                            + "\n01\t-\tthe police man for help."
                            + "\n10\t-\tcalling <subject> right now."
                            + "\n11\t-\tdoes not have a load.\n";

            String msgIns4 = "Fourth Instruction (Different processes):"
                            + "\n00\t-\tRepeat previous Instruction"
                            + "\n01\t-\tGo back 1 instruction (most recent)"
                            + "\n10\t-\tBack 2 instruction"
                            + "\n11\t-\tDo nothing\n";

            rtxtHelp.AppendText(msgIns1 + Environment.NewLine + msgIns2 + Environment.NewLine + 
                                msgIns3Eat + Environment.NewLine + msgIns3Play + Environment.NewLine + msgIns3Get +
                                Environment.NewLine + msgIns3Call + Environment.NewLine + msgIns4);
        }
    }
}
