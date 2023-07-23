namespace WinFormsApp5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnpoint = new Button();
            btndelet = new Button();
            btnclear = new Button();
            btndivition = new Button();
            btncallector = new Button();
            btnsubtration = new Button();
            btnmultiplication = new Button();
            btnequal = new Button();
            btnone = new Button();
            btnfour = new Button();
            btnseven = new Button();
            btneight = new Button();
            btnfive = new Button();
            btntwo = new Button();
            btnnine = new Button();
            btnsix = new Button();
            btnthree = new Button();
            btnzero = new Button();
            txtdisplay = new TextBox();
            btnonoff = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnpoint);
            panel1.Controls.Add(btndelet);
            panel1.Controls.Add(btnclear);
            panel1.Controls.Add(btndivition);
            panel1.Controls.Add(btncallector);
            panel1.Controls.Add(btnsubtration);
            panel1.Controls.Add(btnmultiplication);
            panel1.Controls.Add(btnequal);
            panel1.Controls.Add(btnone);
            panel1.Controls.Add(btnfour);
            panel1.Controls.Add(btnseven);
            panel1.Controls.Add(btneight);
            panel1.Controls.Add(btnfive);
            panel1.Controls.Add(btntwo);
            panel1.Controls.Add(btnnine);
            panel1.Controls.Add(btnsix);
            panel1.Controls.Add(btnthree);
            panel1.Controls.Add(btnzero);
            panel1.Enabled = false;
            panel1.Location = new Point(6, 183);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 240);
            panel1.TabIndex = 0;
            // 
            // btnpoint
            // 
            btnpoint.Location = new Point(68, 180);
            btnpoint.Name = "btnpoint";
            btnpoint.Size = new Size(59, 56);
            btnpoint.TabIndex = 17;
            btnpoint.Text = ".";
            btnpoint.UseVisualStyleBackColor = true;
            btnpoint.MouseClick += Numbers;
            // 
            // btndelet
            // 
            btndelet.Location = new Point(198, 3);
            btndelet.Name = "btndelet";
            btndelet.Size = new Size(124, 54);
            btndelet.TabIndex = 16;
            btndelet.Text = "<-----";
            btndelet.UseVisualStyleBackColor = true;
            btndelet.MouseClick += btndelet_MouseClick;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(198, 63);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(124, 54);
            btnclear.TabIndex = 15;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.MouseClick += btnclear_MouseClick;
            // 
            // btndivition
            // 
            btndivition.Location = new Point(263, 181);
            btndivition.Name = "btndivition";
            btndivition.Size = new Size(59, 54);
            btndivition.TabIndex = 14;
            btndivition.Text = "/";
            btndivition.UseVisualStyleBackColor = true;
            btndivition.MouseClick += Operators;
            // 
            // btncallector
            // 
            btncallector.Location = new Point(198, 123);
            btncallector.Name = "btncallector";
            btncallector.Size = new Size(59, 54);
            btncallector.TabIndex = 13;
            btncallector.Text = "+";
            btncallector.UseVisualStyleBackColor = true;
            btncallector.MouseClick += Operators;
            // 
            // btnsubtration
            // 
            btnsubtration.Location = new Point(263, 123);
            btnsubtration.Name = "btnsubtration";
            btnsubtration.Size = new Size(59, 54);
            btnsubtration.TabIndex = 12;
            btnsubtration.Text = "-";
            btnsubtration.UseVisualStyleBackColor = true;
            btnsubtration.MouseClick += Operators;
            // 
            // btnmultiplication
            // 
            btnmultiplication.Location = new Point(198, 181);
            btnmultiplication.Name = "btnmultiplication";
            btnmultiplication.Size = new Size(59, 54);
            btnmultiplication.TabIndex = 11;
            btnmultiplication.Text = "*";
            btnmultiplication.UseVisualStyleBackColor = true;
            btnmultiplication.MouseClick += Operators;
            // 
            // btnequal
            // 
            btnequal.Location = new Point(133, 179);
            btnequal.Name = "btnequal";
            btnequal.Size = new Size(59, 56);
            btnequal.TabIndex = 10;
            btnequal.Text = "=";
            btnequal.UseVisualStyleBackColor = true;
            btnequal.MouseClick += btnequal_Click;
            // 
            // btnone
            // 
            btnone.Location = new Point(3, 123);
            btnone.Name = "btnone";
            btnone.Size = new Size(59, 54);
            btnone.TabIndex = 9;
            btnone.Text = "1";
            btnone.UseVisualStyleBackColor = true;
            btnone.MouseClick += Numbers;
            // 
            // btnfour
            // 
            btnfour.Location = new Point(3, 63);
            btnfour.Name = "btnfour";
            btnfour.Size = new Size(59, 54);
            btnfour.TabIndex = 8;
            btnfour.Text = "4";
            btnfour.UseVisualStyleBackColor = true;
            btnfour.MouseClick += Numbers;
            // 
            // btnseven
            // 
            btnseven.Location = new Point(3, 3);
            btnseven.Name = "btnseven";
            btnseven.Size = new Size(59, 54);
            btnseven.TabIndex = 7;
            btnseven.Text = "7";
            btnseven.UseVisualStyleBackColor = true;
            btnseven.MouseClick += Numbers;
            // 
            // btneight
            // 
            btneight.Location = new Point(68, 3);
            btneight.Name = "btneight";
            btneight.Size = new Size(59, 54);
            btneight.TabIndex = 6;
            btneight.Text = "8";
            btneight.UseVisualStyleBackColor = true;
            btneight.MouseClick += Numbers;
            // 
            // btnfive
            // 
            btnfive.Location = new Point(68, 63);
            btnfive.Name = "btnfive";
            btnfive.Size = new Size(59, 54);
            btnfive.TabIndex = 5;
            btnfive.Text = "5";
            btnfive.UseVisualStyleBackColor = true;
            btnfive.MouseClick += Numbers;
            // 
            // btntwo
            // 
            btntwo.Location = new Point(68, 123);
            btntwo.Name = "btntwo";
            btntwo.Size = new Size(59, 54);
            btntwo.TabIndex = 4;
            btntwo.Text = "2";
            btntwo.UseVisualStyleBackColor = true;
            btntwo.MouseClick += Numbers;
            // 
            // btnnine
            // 
            btnnine.Location = new Point(133, 3);
            btnnine.Name = "btnnine";
            btnnine.Size = new Size(59, 54);
            btnnine.TabIndex = 3;
            btnnine.Text = "9";
            btnnine.UseVisualStyleBackColor = true;
            btnnine.MouseClick += Numbers;
            // 
            // btnsix
            // 
            btnsix.Location = new Point(133, 63);
            btnsix.Name = "btnsix";
            btnsix.Size = new Size(59, 54);
            btnsix.TabIndex = 2;
            btnsix.Text = "6";
            btnsix.UseVisualStyleBackColor = true;
            btnsix.MouseClick += Numbers;
            // 
            // btnthree
            // 
            btnthree.Location = new Point(133, 123);
            btnthree.Name = "btnthree";
            btnthree.Size = new Size(59, 54);
            btnthree.TabIndex = 1;
            btnthree.Text = "3";
            btnthree.UseVisualStyleBackColor = true;
            btnthree.MouseClick += Numbers;
            // 
            // btnzero
            // 
            btnzero.Location = new Point(3, 179);
            btnzero.Name = "btnzero";
            btnzero.Size = new Size(59, 54);
            btnzero.TabIndex = 0;
            btnzero.Text = "0";
            btnzero.UseVisualStyleBackColor = true;
            btnzero.MouseClick += Numbers;
            // 
            // txtdisplay
            // 
            txtdisplay.Location = new Point(6, 123);
            txtdisplay.Multiline = true;
            txtdisplay.Name = "txtdisplay";
            txtdisplay.ReadOnly = true;
            txtdisplay.Size = new Size(324, 44);
            txtdisplay.TabIndex = 18;
            // 
            // btnonoff
            // 
            btnonoff.Location = new Point(12, 12);
            btnonoff.Name = "btnonoff";
            btnonoff.Size = new Size(152, 58);
            btnonoff.TabIndex = 19;
            btnonoff.Text = "ON";
            btnonoff.UseVisualStyleBackColor = true;
            btnonoff.Click += btnonoff_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 435);
            Controls.Add(btnonoff);
            Controls.Add(txtdisplay);
            Controls.Add(panel1);
            Font = new Font("Magneto", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 5, 6, 5);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calculator";
            KeyPress += Form1_KeyPress;
            KeyUp += Form1_KeyUp;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnequal;
        private Button btnone;
        private Button btnfour;
        private Button btnseven;
        private Button btneight;
        private Button btnfive;
        private Button btntwo;
        private Button btnnine;
        private Button btnsix;
        private Button btnthree;
        private Button btnzero;
        private Button btndelet;
        private Button btnclear;
        private Button btndivition;
        private Button btncallector;
        private Button btnsubtration;
        private Button btnmultiplication;
        private TextBox txtdisplay;
        private Button btnpoint;
        private Button btnonoff;
    }
}