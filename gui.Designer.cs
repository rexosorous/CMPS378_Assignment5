namespace assignment5
{
    partial class gui
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.squareButton = new System.Windows.Forms.Button();
            this.circleButton = new System.Windows.Forms.Button();
            this.sphereButton = new System.Windows.Forms.Button();
            this.cubeButton = new System.Windows.Forms.Button();
            this.cylinderButton = new System.Windows.Forms.Button();
            this.dim1Input = new System.Windows.Forms.TextBox();
            this.dim1Label = new System.Windows.Forms.Label();
            this.dim2Label = new System.Windows.Forms.Label();
            this.dim3Label = new System.Windows.Forms.Label();
            this.dim2Input = new System.Windows.Forms.TextBox();
            this.dim3Input = new System.Windows.Forms.TextBox();
            this.shapeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.areaText = new System.Windows.Forms.TextBox();
            this.perimeterText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(20, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(402, 58);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Choose A Shape";
            // 
            // squareButton
            // 
            this.squareButton.Location = new System.Drawing.Point(30, 100);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(100, 100);
            this.squareButton.TabIndex = 1;
            this.squareButton.Text = "Square";
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.Click += new System.EventHandler(this.squareButton_Click);
            // 
            // circleButton
            // 
            this.circleButton.Location = new System.Drawing.Point(160, 100);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(100, 100);
            this.circleButton.TabIndex = 2;
            this.circleButton.Text = "Circle";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // sphereButton
            // 
            this.sphereButton.Location = new System.Drawing.Point(290, 100);
            this.sphereButton.Name = "sphereButton";
            this.sphereButton.Size = new System.Drawing.Size(100, 100);
            this.sphereButton.TabIndex = 3;
            this.sphereButton.Text = "Sphere";
            this.sphereButton.UseVisualStyleBackColor = true;
            this.sphereButton.Click += new System.EventHandler(this.sphereButton_Click);
            // 
            // cubeButton
            // 
            this.cubeButton.Location = new System.Drawing.Point(420, 100);
            this.cubeButton.Name = "cubeButton";
            this.cubeButton.Size = new System.Drawing.Size(100, 100);
            this.cubeButton.TabIndex = 4;
            this.cubeButton.Text = "Cube";
            this.cubeButton.UseVisualStyleBackColor = true;
            this.cubeButton.Click += new System.EventHandler(this.cubeButton_Click);
            // 
            // cylinderButton
            // 
            this.cylinderButton.Location = new System.Drawing.Point(550, 100);
            this.cylinderButton.Name = "cylinderButton";
            this.cylinderButton.Size = new System.Drawing.Size(100, 100);
            this.cylinderButton.TabIndex = 5;
            this.cylinderButton.Text = "Cylinder";
            this.cylinderButton.UseVisualStyleBackColor = true;
            this.cylinderButton.Click += new System.EventHandler(this.cylinerButton_Click);
            // 
            // dim1Input
            // 
            this.dim1Input.Location = new System.Drawing.Point(160, 322);
            this.dim1Input.Name = "dim1Input";
            this.dim1Input.Size = new System.Drawing.Size(230, 22);
            this.dim1Input.TabIndex = 6;
            // 
            // dim1Label
            // 
            this.dim1Label.AutoSize = true;
            this.dim1Label.Location = new System.Drawing.Point(30, 322);
            this.dim1Label.Name = "dim1Label";
            this.dim1Label.Size = new System.Drawing.Size(52, 17);
            this.dim1Label.TabIndex = 7;
            this.dim1Label.Text = "Length";
            // 
            // dim2Label
            // 
            this.dim2Label.AutoSize = true;
            this.dim2Label.Location = new System.Drawing.Point(30, 352);
            this.dim2Label.Name = "dim2Label";
            this.dim2Label.Size = new System.Drawing.Size(44, 17);
            this.dim2Label.TabIndex = 8;
            this.dim2Label.Text = "Width";
            // 
            // dim3Label
            // 
            this.dim3Label.AutoSize = true;
            this.dim3Label.Location = new System.Drawing.Point(30, 382);
            this.dim3Label.Name = "dim3Label";
            this.dim3Label.Size = new System.Drawing.Size(49, 17);
            this.dim3Label.TabIndex = 9;
            this.dim3Label.Text = "Height";
            this.dim3Label.Visible = false;
            // 
            // dim2Input
            // 
            this.dim2Input.Location = new System.Drawing.Point(160, 352);
            this.dim2Input.Name = "dim2Input";
            this.dim2Input.Size = new System.Drawing.Size(230, 22);
            this.dim2Input.TabIndex = 10;
            // 
            // dim3Input
            // 
            this.dim3Input.Location = new System.Drawing.Point(160, 382);
            this.dim3Input.Name = "dim3Input";
            this.dim3Input.Size = new System.Drawing.Size(230, 22);
            this.dim3Input.TabIndex = 11;
            this.dim3Input.Visible = false;
            // 
            // shapeLabel
            // 
            this.shapeLabel.AutoSize = true;
            this.shapeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapeLabel.Location = new System.Drawing.Point(20, 250);
            this.shapeLabel.Name = "shapeLabel";
            this.shapeLabel.Size = new System.Drawing.Size(187, 58);
            this.shapeLabel.TabIndex = 12;
            this.shapeLabel.Text = "Square";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 39);
            this.label4.TabIndex = 13;
            this.label4.Text = "Area";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(283, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 39);
            this.label5.TabIndex = 14;
            this.label5.Text = "Perimeter";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(420, 322);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(100, 82);
            this.calcButton.TabIndex = 15;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(30, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(620, 2);
            this.label6.TabIndex = 16;
            // 
            // areaText
            // 
            this.areaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaText.Location = new System.Drawing.Point(33, 497);
            this.areaText.Name = "areaText";
            this.areaText.ReadOnly = true;
            this.areaText.Size = new System.Drawing.Size(227, 36);
            this.areaText.TabIndex = 17;
            // 
            // perimeterText
            // 
            this.perimeterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perimeterText.Location = new System.Drawing.Point(290, 497);
            this.perimeterText.Name = "perimeterText";
            this.perimeterText.ReadOnly = true;
            this.perimeterText.Size = new System.Drawing.Size(230, 36);
            this.perimeterText.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "By: J-Zach Loke";
            // 
            // gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.perimeterText);
            this.Controls.Add(this.areaText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.shapeLabel);
            this.Controls.Add(this.dim3Input);
            this.Controls.Add(this.dim2Input);
            this.Controls.Add(this.dim3Label);
            this.Controls.Add(this.dim2Label);
            this.Controls.Add(this.dim1Label);
            this.Controls.Add(this.dim1Input);
            this.Controls.Add(this.cylinderButton);
            this.Controls.Add(this.cubeButton);
            this.Controls.Add(this.sphereButton);
            this.Controls.Add(this.circleButton);
            this.Controls.Add(this.squareButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "gui";
            this.Text = "Assignment 5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button squareButton;
        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Button sphereButton;
        private System.Windows.Forms.Button cubeButton;
        private System.Windows.Forms.Button cylinderButton;
        private System.Windows.Forms.TextBox dim1Input;
        private System.Windows.Forms.Label dim1Label;
        private System.Windows.Forms.Label dim2Label;
        private System.Windows.Forms.Label dim3Label;
        private System.Windows.Forms.TextBox dim2Input;
        private System.Windows.Forms.TextBox dim3Input;
        private System.Windows.Forms.Label shapeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox areaText;
        private System.Windows.Forms.TextBox perimeterText;
        private System.Windows.Forms.Label label1;
    }
}

