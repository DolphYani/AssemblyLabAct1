﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyLabAct1
{
    public class Instruction
    {
        private String Ins1;
        private String Ins2;
        private String Ins3;
        private String Ins4;
        private String OneInstruction;

        // Storing values into a list
        public Instruction(String Ins1, String Ins2, String Ins3, String Ins4, String OneInstruction) {
            this.Ins1 = Ins1;
            this.Ins2 = Ins2;
            this.Ins3 = Ins3;
            this.Ins4 = Ins4;
            this.OneInstruction = OneInstruction;
        }

        // Return first instruction (binary)
        public String getIns1() {
            return Ins1;
        }

        // Return second instruction (binary)
        public String getIns2() {
            return Ins2;
        }

        // Return third instruction (binary)
        public String getIns3() {
            return Ins3;
        }

        // Return fourth instruction (binary)
        public String getIns4() {
            return Ins4;
        }

        // Rerurn one line instruction (binary)
        public String getOneInstruction() {
            return OneInstruction;
        }

    }
}
