namespace MultiplicationTableNamespace
{
    partial class MultiplicationTableForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiplicationTableForm));
            this.nextButton = new System.Windows.Forms.Button();
            this.levelText = new System.Windows.Forms.Label();
            this.timeText = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.Label();
            this.symbol_text = new System.Windows.Forms.Label();
            this.secondNumberText = new System.Windows.Forms.Label();
            this.firstNumberText = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.equate = new System.Windows.Forms.Label();
            this.aTimer = new System.Windows.Forms.Timer(this.components);
            this.goodOrBad = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.mode_multiply = new System.Windows.Forms.Button();
            this.mode_minus = new System.Windows.Forms.Button();
            this.mode_divide = new System.Windows.Forms.Button();
            this.mode_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextButton.Location = new System.Drawing.Point(345, 113);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(76, 40);
            this.nextButton.TabIndex = 0;
            this.nextButton.Text = "Dalej";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // levelText
            // 
            this.levelText.AutoSize = true;
            this.levelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.levelText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.levelText.Location = new System.Drawing.Point(47, 36);
            this.levelText.Name = "levelText";
            this.levelText.Size = new System.Drawing.Size(151, 39);
            this.levelText.TabIndex = 1;
            this.levelText.Text = "Poziom:";
            // 
            // timeText
            // 
            this.timeText.AutoSize = true;
            this.timeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeText.ForeColor = System.Drawing.SystemColors.Control;
            this.timeText.Location = new System.Drawing.Point(333, 39);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(104, 37);
            this.timeText.TabIndex = 2;
            this.timeText.Text = "Czas:";
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.level.Location = new System.Drawing.Point(185, 40);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(0, 37);
            this.level.TabIndex = 3;
            this.level.UseMnemonic = false;
            // 
            // symbol_text
            // 
            this.symbol_text.AutoSize = true;
            this.symbol_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.symbol_text.Location = new System.Drawing.Point(188, 116);
            this.symbol_text.Name = "symbol_text";
            this.symbol_text.Size = new System.Drawing.Size(30, 37);
            this.symbol_text.TabIndex = 4;
            this.symbol_text.Text = "*";
            // 
            // secondNumberText
            // 
            this.secondNumberText.AutoSize = true;
            this.secondNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secondNumberText.ForeColor = System.Drawing.SystemColors.Control;
            this.secondNumberText.Location = new System.Drawing.Point(211, 116);
            this.secondNumberText.Name = "secondNumberText";
            this.secondNumberText.Size = new System.Drawing.Size(39, 37);
            this.secondNumberText.TabIndex = 5;
            this.secondNumberText.Text = "Y";
            // 
            // firstNumberText
            // 
            this.firstNumberText.AutoSize = true;
            this.firstNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstNumberText.ForeColor = System.Drawing.SystemColors.Control;
            this.firstNumberText.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.firstNumberText.Location = new System.Drawing.Point(147, 116);
            this.firstNumberText.Name = "firstNumberText";
            this.firstNumberText.Size = new System.Drawing.Size(38, 37);
            this.firstNumberText.TabIndex = 6;
            this.firstNumberText.Text = "X";
            this.firstNumberText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.time.Location = new System.Drawing.Point(443, 40);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 37);
            this.time.TabIndex = 7;
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.start.Location = new System.Drawing.Point(151, 159);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(270, 45);
            this.start.TabIndex = 9;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // equate
            // 
            this.equate.AutoSize = true;
            this.equate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.equate.Location = new System.Drawing.Point(256, 116);
            this.equate.Name = "equate";
            this.equate.Size = new System.Drawing.Size(37, 37);
            this.equate.TabIndex = 11;
            this.equate.Text = "=";
            // 
            // aTimer
            // 
            this.aTimer.Enabled = true;
            this.aTimer.Interval = 1000;
            this.aTimer.Tick += new System.EventHandler(this.aTimer_Tick);
            // 
            // goodOrBad
            // 
            this.goodOrBad.AutoSize = true;
            this.goodOrBad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.goodOrBad.Location = new System.Drawing.Point(262, 79);
            this.goodOrBad.Name = "goodOrBad";
            this.goodOrBad.Size = new System.Drawing.Size(0, 24);
            this.goodOrBad.TabIndex = 13;
            this.goodOrBad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sum.Location = new System.Drawing.Point(296, 119);
            this.sum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(43, 29);
            this.sum.TabIndex = 14;
            // 
            // mode_multiply
            // 
            this.mode_multiply.BackColor = System.Drawing.Color.LightSeaGreen;
            this.mode_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mode_multiply.Location = new System.Drawing.Point(12, 217);
            this.mode_multiply.Name = "mode_multiply";
            this.mode_multiply.Size = new System.Drawing.Size(111, 45);
            this.mode_multiply.TabIndex = 15;
            this.mode_multiply.Text = "*";
            this.mode_multiply.UseVisualStyleBackColor = false;
            this.mode_multiply.Click += new System.EventHandler(this.mode_multiply_Click);
            // 
            // mode_minus
            // 
            this.mode_minus.BackColor = System.Drawing.Color.Crimson;
            this.mode_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mode_minus.Location = new System.Drawing.Point(428, 217);
            this.mode_minus.Name = "mode_minus";
            this.mode_minus.Size = new System.Drawing.Size(111, 45);
            this.mode_minus.TabIndex = 16;
            this.mode_minus.Text = "-";
            this.mode_minus.UseVisualStyleBackColor = false;
            this.mode_minus.Click += new System.EventHandler(this.mode_minus_Click);
            // 
            // mode_divide
            // 
            this.mode_divide.BackColor = System.Drawing.Color.LightPink;
            this.mode_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mode_divide.Location = new System.Drawing.Point(151, 217);
            this.mode_divide.Name = "mode_divide";
            this.mode_divide.Size = new System.Drawing.Size(111, 45);
            this.mode_divide.TabIndex = 17;
            this.mode_divide.Text = ":";
            this.mode_divide.UseVisualStyleBackColor = false;
            this.mode_divide.Click += new System.EventHandler(this.mode_divide_Click);
            // 
            // mode_add
            // 
            this.mode_add.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.mode_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mode_add.Location = new System.Drawing.Point(296, 217);
            this.mode_add.Name = "mode_add";
            this.mode_add.Size = new System.Drawing.Size(111, 45);
            this.mode_add.TabIndex = 18;
            this.mode_add.Text = "+";
            this.mode_add.UseVisualStyleBackColor = false;
            this.mode_add.Click += new System.EventHandler(this.mode_add_Click);
            // 
            // MultiplicationTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(551, 274);
            this.Controls.Add(this.mode_add);
            this.Controls.Add(this.mode_divide);
            this.Controls.Add(this.mode_minus);
            this.Controls.Add(this.mode_multiply);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.goodOrBad);
            this.Controls.Add(this.equate);
            this.Controls.Add(this.start);
            this.Controls.Add(this.time);
            this.Controls.Add(this.firstNumberText);
            this.Controls.Add(this.secondNumberText);
            this.Controls.Add(this.symbol_text);
            this.Controls.Add(this.level);
            this.Controls.Add(this.timeText);
            this.Controls.Add(this.levelText);
            this.Controls.Add(this.nextButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MultiplicationTableForm";
            this.Text = "Tabliczka Mnożenia";
            this.Load += new System.EventHandler(this.MultiplicationTableForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label levelText;
        private System.Windows.Forms.Label timeText;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.Label symbol_text;
        private System.Windows.Forms.Label secondNumberText;
        private System.Windows.Forms.Label firstNumberText;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label equate;
        private System.Windows.Forms.Timer aTimer;
        private System.Windows.Forms.Label goodOrBad;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.Button mode_multiply;
        private System.Windows.Forms.Button mode_minus;
        private System.Windows.Forms.Button mode_divide;
        private System.Windows.Forms.Button mode_add;
    }
}

