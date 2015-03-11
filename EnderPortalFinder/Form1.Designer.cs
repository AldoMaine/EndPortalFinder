namespace EnderPortalFinder
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
            this.txtP1X = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtP1Z = new System.Windows.Forms.TextBox();
            this.txtP2Z = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtP2X = new System.Windows.Forms.TextBox();
            this.txtP1Brg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label8 = new System.Windows.Forms.Label();
            this.txtP2Brg = new System.Windows.Forms.TextBox();
            this.txtEPZ = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEPX = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtP1X
            // 
            this.txtP1X.Location = new System.Drawing.Point(44, 36);
            this.txtP1X.Name = "txtP1X";
            this.txtP1X.Size = new System.Drawing.Size(79, 20);
            this.txtP1X.TabIndex = 0;
            this.txtP1X.Text = "-128";
            this.txtP1X.Leave += new System.EventHandler(this.input_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Point 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Z";
            // 
            // txtP1Z
            // 
            this.txtP1Z.Location = new System.Drawing.Point(165, 36);
            this.txtP1Z.Name = "txtP1Z";
            this.txtP1Z.Size = new System.Drawing.Size(79, 20);
            this.txtP1Z.TabIndex = 1;
            this.txtP1Z.Text = "40";
            this.txtP1Z.Leave += new System.EventHandler(this.input_TextChanged);
            // 
            // txtP2Z
            // 
            this.txtP2Z.Location = new System.Drawing.Point(165, 106);
            this.txtP2Z.Name = "txtP2Z";
            this.txtP2Z.Size = new System.Drawing.Size(79, 20);
            this.txtP2Z.TabIndex = 4;
            this.txtP2Z.Text = "-196";
            this.txtP2Z.Leave += new System.EventHandler(this.input_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Z";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Point 2";
            // 
            // txtP2X
            // 
            this.txtP2X.Location = new System.Drawing.Point(44, 106);
            this.txtP2X.Name = "txtP2X";
            this.txtP2X.Size = new System.Drawing.Size(79, 20);
            this.txtP2X.TabIndex = 3;
            this.txtP2X.Text = "-46";
            this.txtP2X.Leave += new System.EventHandler(this.input_TextChanged);
            // 
            // txtP1Brg
            // 
            this.txtP1Brg.Location = new System.Drawing.Point(337, 36);
            this.txtP1Brg.Name = "txtP1Brg";
            this.txtP1Brg.Size = new System.Drawing.Size(79, 20);
            this.txtP1Brg.TabIndex = 2;
            this.txtP1Brg.Text = "173";
            this.txtP1Brg.Leave += new System.EventHandler(this.input_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Bearing";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(447, 270);
            this.shapeContainer1.TabIndex = 7;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 14;
            this.lineShape2.X2 = 427;
            this.lineShape2.Y1 = 141;
            this.lineShape2.Y2 = 141;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 13;
            this.lineShape1.X2 = 426;
            this.lineShape1.Y1 = 69;
            this.lineShape1.Y2 = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Bearing";
            // 
            // txtP2Brg
            // 
            this.txtP2Brg.Location = new System.Drawing.Point(337, 106);
            this.txtP2Brg.Name = "txtP2Brg";
            this.txtP2Brg.Size = new System.Drawing.Size(79, 20);
            this.txtP2Brg.TabIndex = 5;
            this.txtP2Brg.Text = "155";
            this.txtP2Brg.Leave += new System.EventHandler(this.input_TextChanged);
            // 
            // txtEPZ
            // 
            this.txtEPZ.Location = new System.Drawing.Point(165, 186);
            this.txtEPZ.Name = "txtEPZ";
            this.txtEPZ.Size = new System.Drawing.Size(79, 20);
            this.txtEPZ.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(142, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Z";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "X";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "End Portal Location";
            // 
            // txtEPX
            // 
            this.txtEPX.Location = new System.Drawing.Point(44, 186);
            this.txtEPX.Name = "txtEPX";
            this.txtEPX.Size = new System.Drawing.Size(79, 20);
            this.txtEPX.TabIndex = 15;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(297, 187);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(61, 13);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Instructions";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 270);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtEPZ);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEPX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtP2Brg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtP1Brg);
            this.Controls.Add(this.txtP2Z);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtP2X);
            this.Controls.Add(this.txtP1Z);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtP1X);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "End Portal Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtP1X;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtP1Z;
        private System.Windows.Forms.TextBox txtP2Z;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtP2X;
        private System.Windows.Forms.TextBox txtP1Brg;
        private System.Windows.Forms.Label label7;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtP2Brg;
        private System.Windows.Forms.TextBox txtEPZ;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEPX;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

