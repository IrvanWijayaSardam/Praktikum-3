namespace AplikasiGameThread_20SA11206
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Play = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPlayerOne = new System.Windows.Forms.Label();
            this.lbPlayerTwo = new System.Windows.Forms.Label();
            this.lbPlayerThree = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(21, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 83);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(21, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 83);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(21, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 83);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_Play
            // 
            this.btn_Play.Location = new System.Drawing.Point(33, 375);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(110, 36);
            this.btn_Play.TabIndex = 1;
            this.btn_Play.Text = "Play";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "PLayer 1: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "PLayer 2 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(600, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "PLayer 3 :";
            // 
            // lbPlayerOne
            // 
            this.lbPlayerOne.AutoSize = true;
            this.lbPlayerOne.Location = new System.Drawing.Point(239, 386);
            this.lbPlayerOne.Name = "lbPlayerOne";
            this.lbPlayerOne.Size = new System.Drawing.Size(13, 15);
            this.lbPlayerOne.TabIndex = 5;
            this.lbPlayerOne.Text = "0";
            // 
            // lbPlayerTwo
            // 
            this.lbPlayerTwo.AutoSize = true;
            this.lbPlayerTwo.Location = new System.Drawing.Point(457, 386);
            this.lbPlayerTwo.Name = "lbPlayerTwo";
            this.lbPlayerTwo.Size = new System.Drawing.Size(13, 15);
            this.lbPlayerTwo.TabIndex = 6;
            this.lbPlayerTwo.Text = "0";
            // 
            // lbPlayerThree
            // 
            this.lbPlayerThree.AutoSize = true;
            this.lbPlayerThree.Location = new System.Drawing.Point(663, 386);
            this.lbPlayerThree.Name = "lbPlayerThree";
            this.lbPlayerThree.Size = new System.Drawing.Size(13, 15);
            this.lbPlayerThree.TabIndex = 7;
            this.lbPlayerThree.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 442);
            this.Controls.Add(this.lbPlayerThree);
            this.Controls.Add(this.lbPlayerTwo);
            this.Controls.Add(this.lbPlayerOne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Game Racing with Thread";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btn_Play;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbPlayerOne;
        private Label lbPlayerTwo;
        private Label lbPlayerThree;
        private System.Windows.Forms.Timer timer1;
    }
}