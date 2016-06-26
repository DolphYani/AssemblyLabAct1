namespace AssemblyLabAct1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblEnter = new System.Windows.Forms.Label();
            this.mtxt1 = new System.Windows.Forms.MaskedTextBox();
            this.mtxt2 = new System.Windows.Forms.MaskedTextBox();
            this.mtxt3 = new System.Windows.Forms.MaskedTextBox();
            this.mtxt4 = new System.Windows.Forms.MaskedTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.rtxtBody = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.Location = new System.Drawing.Point(19, 66);
            this.lblEnter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(158, 20);
            this.lblEnter.TabIndex = 0;
            this.lblEnter.Text = "Enter Instructions:";
            // 
            // mtxt1
            // 
            this.mtxt1.Location = new System.Drawing.Point(57, 109);
            this.mtxt1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtxt1.Mask = "00";
            this.mtxt1.Name = "mtxt1";
            this.mtxt1.Size = new System.Drawing.Size(35, 26);
            this.mtxt1.TabIndex = 1;
            this.mtxt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxt2
            // 
            this.mtxt2.Location = new System.Drawing.Point(109, 109);
            this.mtxt2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtxt2.Mask = "00";
            this.mtxt2.Name = "mtxt2";
            this.mtxt2.Size = new System.Drawing.Size(35, 26);
            this.mtxt2.TabIndex = 2;
            this.mtxt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxt3
            // 
            this.mtxt3.Location = new System.Drawing.Point(162, 109);
            this.mtxt3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtxt3.Mask = "00";
            this.mtxt3.Name = "mtxt3";
            this.mtxt3.Size = new System.Drawing.Size(35, 26);
            this.mtxt3.TabIndex = 3;
            this.mtxt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxt4
            // 
            this.mtxt4.Location = new System.Drawing.Point(214, 109);
            this.mtxt4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtxt4.Mask = "00";
            this.mtxt4.Name = "mtxt4";
            this.mtxt4.Size = new System.Drawing.Size(35, 26);
            this.mtxt4.TabIndex = 4;
            this.mtxt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(266, 105);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(73, 164);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 35);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Delete";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(210, 164);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(163, 18);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(100, 35);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(269, 18);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(100, 35);
            this.btnAbout.TabIndex = 9;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbout.UseVisualStyleBackColor = false;
            // 
            // rtxtBody
            // 
            this.rtxtBody.BackColor = System.Drawing.Color.White;
            this.rtxtBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtBody.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxtBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtBody.Location = new System.Drawing.Point(15, 223);
            this.rtxtBody.Name = "rtxtBody";
            this.rtxtBody.ReadOnly = true;
            this.rtxtBody.Size = new System.Drawing.Size(354, 323);
            this.rtxtBody.TabIndex = 10;
            this.rtxtBody.Text = "";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.rtxtBody);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.mtxt4);
            this.Controls.Add(this.mtxt3);
            this.Controls.Add(this.mtxt2);
            this.Controls.Add(this.mtxt1);
            this.Controls.Add(this.lblEnter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 600);
            this.MinimumSize = new System.Drawing.Size(400, 600);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Story Maker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.MaskedTextBox mtxt1;
        private System.Windows.Forms.MaskedTextBox mtxt2;
        private System.Windows.Forms.MaskedTextBox mtxt3;
        private System.Windows.Forms.MaskedTextBox mtxt4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.RichTextBox rtxtBody;
    }
}

