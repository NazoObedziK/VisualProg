namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.Options = new System.Windows.Forms.Panel();
			this.test = new System.Windows.Forms.Label();
			this.Triangulation = new System.Windows.Forms.Button();
			this.Clear = new System.Windows.Forms.Button();
			this.PointsLabel = new System.Windows.Forms.Label();
			this.NumOfPoints = new System.Windows.Forms.TextBox();
			this.randPoints = new System.Windows.Forms.Button();
			this.canvas = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.mark10 = new System.Windows.Forms.Label();
			this.mark9 = new System.Windows.Forms.Label();
			this.mark8 = new System.Windows.Forms.Label();
			this.mark7 = new System.Windows.Forms.Label();
			this.mark6 = new System.Windows.Forms.Label();
			this.mark5 = new System.Windows.Forms.Label();
			this.mark4 = new System.Windows.Forms.Label();
			this.mark3 = new System.Windows.Forms.Label();
			this.mark2 = new System.Windows.Forms.Label();
			this.mark1 = new System.Windows.Forms.Label();
			this.pointInside = new System.Windows.Forms.RichTextBox();
			this.mousePos = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Options.SuspendLayout();
			this.canvas.SuspendLayout();
			this.SuspendLayout();
			// 
			// Options
			// 
			this.Options.BackColor = System.Drawing.Color.White;
			this.Options.Controls.Add(this.label2);
			this.Options.Controls.Add(this.test);
			this.Options.Controls.Add(this.Triangulation);
			this.Options.Controls.Add(this.Clear);
			this.Options.Controls.Add(this.PointsLabel);
			this.Options.Controls.Add(this.NumOfPoints);
			this.Options.Controls.Add(this.randPoints);
			this.Options.Dock = System.Windows.Forms.DockStyle.Top;
			this.Options.Location = new System.Drawing.Point(0, 0);
			this.Options.Margin = new System.Windows.Forms.Padding(2);
			this.Options.Name = "Options";
			this.Options.Size = new System.Drawing.Size(946, 53);
			this.Options.TabIndex = 0;
			// 
			// test
			// 
			this.test.AutoSize = true;
			this.test.Location = new System.Drawing.Point(469, 23);
			this.test.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.test.Name = "test";
			this.test.Size = new System.Drawing.Size(0, 13);
			this.test.TabIndex = 5;
			// 
			// Triangulation
			// 
			this.Triangulation.BackColor = System.Drawing.Color.Black;
			this.Triangulation.FlatAppearance.BorderSize = 0;
			this.Triangulation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
			this.Triangulation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Triangulation.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.Triangulation.Location = new System.Drawing.Point(837, 15);
			this.Triangulation.Margin = new System.Windows.Forms.Padding(2);
			this.Triangulation.Name = "Triangulation";
			this.Triangulation.Size = new System.Drawing.Size(100, 28);
			this.Triangulation.TabIndex = 4;
			this.Triangulation.Text = "Обчислити";
			this.Triangulation.UseVisualStyleBackColor = false;
			this.Triangulation.Click += new System.EventHandler(this.MakeTriangulation);
			// 
			// Clear
			// 
			this.Clear.BackColor = System.Drawing.Color.Black;
			this.Clear.FlatAppearance.BorderSize = 0;
			this.Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
			this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Clear.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.Clear.Location = new System.Drawing.Point(274, 15);
			this.Clear.Margin = new System.Windows.Forms.Padding(2);
			this.Clear.Name = "Clear";
			this.Clear.Size = new System.Drawing.Size(86, 28);
			this.Clear.TabIndex = 3;
			this.Clear.Text = "Очистити";
			this.Clear.UseVisualStyleBackColor = false;
			this.Clear.Click += new System.EventHandler(this.ClearCanvas);
			// 
			// PointsLabel
			// 
			this.PointsLabel.AutoSize = true;
			this.PointsLabel.BackColor = System.Drawing.Color.Black;
			this.PointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PointsLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.PointsLabel.Location = new System.Drawing.Point(2, 18);
			this.PointsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.PointsLabel.Name = "PointsLabel";
			this.PointsLabel.Size = new System.Drawing.Size(126, 20);
			this.PointsLabel.TabIndex = 2;
			this.PointsLabel.Text = "Кількість точок";
			// 
			// NumOfPoints
			// 
			this.NumOfPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NumOfPoints.Location = new System.Drawing.Point(141, 20);
			this.NumOfPoints.Margin = new System.Windows.Forms.Padding(2);
			this.NumOfPoints.Name = "NumOfPoints";
			this.NumOfPoints.Size = new System.Drawing.Size(30, 23);
			this.NumOfPoints.TabIndex = 1;
			this.NumOfPoints.Text = "1";
			this.NumOfPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.NumOfPoints.TextChanged += new System.EventHandler(this.NumOfPoints_TextChanged);
			// 
			// randPoints
			// 
			this.randPoints.BackColor = System.Drawing.Color.Black;
			this.randPoints.FlatAppearance.BorderSize = 0;
			this.randPoints.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
			this.randPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.randPoints.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.randPoints.Location = new System.Drawing.Point(184, 15);
			this.randPoints.Margin = new System.Windows.Forms.Padding(2);
			this.randPoints.Name = "randPoints";
			this.randPoints.Size = new System.Drawing.Size(86, 28);
			this.randPoints.TabIndex = 0;
			this.randPoints.Text = "Згенерувати";
			this.randPoints.UseVisualStyleBackColor = false;
			this.randPoints.Click += new System.EventHandler(this.GeneratePoints);
			// 
			// canvas
			// 
			this.canvas.BackColor = System.Drawing.Color.White;
			this.canvas.Controls.Add(this.label1);
			this.canvas.Controls.Add(this.mark10);
			this.canvas.Controls.Add(this.mark9);
			this.canvas.Controls.Add(this.mark8);
			this.canvas.Controls.Add(this.mark7);
			this.canvas.Controls.Add(this.mark6);
			this.canvas.Controls.Add(this.mark5);
			this.canvas.Controls.Add(this.mark4);
			this.canvas.Controls.Add(this.mark3);
			this.canvas.Controls.Add(this.mark2);
			this.canvas.Controls.Add(this.mark1);
			this.canvas.Controls.Add(this.pointInside);
			this.canvas.Controls.Add(this.mousePos);
			this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.canvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.canvas.Location = new System.Drawing.Point(0, 53);
			this.canvas.Margin = new System.Windows.Forms.Padding(2);
			this.canvas.Name = "canvas";
			this.canvas.Size = new System.Drawing.Size(946, 556);
			this.canvas.TabIndex = 1;
			this.canvas.Click += new System.EventHandler(this.AddPoint);
			this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint);
			this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GetMousePos);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(854, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 15);
			this.label1.TabIndex = 18;
			this.label1.Text = "Результат";
			// 
			// mark10
			// 
			this.mark10.AutoSize = true;
			this.mark10.Location = new System.Drawing.Point(521, 343);
			this.mark10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.mark10.Name = "mark10";
			this.mark10.Size = new System.Drawing.Size(0, 15);
			this.mark10.TabIndex = 17;
			// 
			// mark9
			// 
			this.mark9.AutoSize = true;
			this.mark9.Location = new System.Drawing.Point(515, 336);
			this.mark9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.mark9.Name = "mark9";
			this.mark9.Size = new System.Drawing.Size(0, 15);
			this.mark9.TabIndex = 16;
			// 
			// mark8
			// 
			this.mark8.AutoSize = true;
			this.mark8.Location = new System.Drawing.Point(509, 330);
			this.mark8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.mark8.Name = "mark8";
			this.mark8.Size = new System.Drawing.Size(0, 15);
			this.mark8.TabIndex = 15;
			// 
			// mark7
			// 
			this.mark7.AutoSize = true;
			this.mark7.Location = new System.Drawing.Point(503, 323);
			this.mark7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.mark7.Name = "mark7";
			this.mark7.Size = new System.Drawing.Size(0, 15);
			this.mark7.TabIndex = 14;
			// 
			// mark6
			// 
			this.mark6.AutoSize = true;
			this.mark6.Location = new System.Drawing.Point(497, 317);
			this.mark6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.mark6.Name = "mark6";
			this.mark6.Size = new System.Drawing.Size(0, 15);
			this.mark6.TabIndex = 13;
			// 
			// mark5
			// 
			this.mark5.AutoSize = true;
			this.mark5.Location = new System.Drawing.Point(491, 310);
			this.mark5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.mark5.Name = "mark5";
			this.mark5.Size = new System.Drawing.Size(0, 15);
			this.mark5.TabIndex = 12;
			// 
			// mark4
			// 
			this.mark4.AutoSize = true;
			this.mark4.Location = new System.Drawing.Point(485, 304);
			this.mark4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.mark4.Name = "mark4";
			this.mark4.Size = new System.Drawing.Size(0, 15);
			this.mark4.TabIndex = 11;
			// 
			// mark3
			// 
			this.mark3.AutoSize = true;
			this.mark3.Location = new System.Drawing.Point(479, 297);
			this.mark3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.mark3.Name = "mark3";
			this.mark3.Size = new System.Drawing.Size(0, 15);
			this.mark3.TabIndex = 10;
			// 
			// mark2
			// 
			this.mark2.AutoSize = true;
			this.mark2.Location = new System.Drawing.Point(473, 291);
			this.mark2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.mark2.Name = "mark2";
			this.mark2.Size = new System.Drawing.Size(0, 15);
			this.mark2.TabIndex = 9;
			// 
			// mark1
			// 
			this.mark1.AutoSize = true;
			this.mark1.Location = new System.Drawing.Point(212, 102);
			this.mark1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.mark1.Name = "mark1";
			this.mark1.Size = new System.Drawing.Size(0, 15);
			this.mark1.TabIndex = 8;
			// 
			// pointInside
			// 
			this.pointInside.BackColor = System.Drawing.SystemColors.Window;
			this.pointInside.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pointInside.Location = new System.Drawing.Point(837, 31);
			this.pointInside.Margin = new System.Windows.Forms.Padding(2);
			this.pointInside.Name = "pointInside";
			this.pointInside.Size = new System.Drawing.Size(102, 528);
			this.pointInside.TabIndex = 7;
			this.pointInside.Text = "";
			// 
			// mousePos
			// 
			this.mousePos.AutoSize = true;
			this.mousePos.Location = new System.Drawing.Point(903, 574);
			this.mousePos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.mousePos.Name = "mousePos";
			this.mousePos.Size = new System.Drawing.Size(0, 15);
			this.mousePos.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Black;
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(425, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "number of triangles";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(946, 609);
			this.Controls.Add(this.canvas);
			this.Controls.Add(this.Options);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lab2";
			this.Options.ResumeLayout(false);
			this.Options.PerformLayout();
			this.canvas.ResumeLayout(false);
			this.canvas.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Options;
        public System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.TextBox NumOfPoints;
        private System.Windows.Forms.Button randPoints;
        private System.Windows.Forms.Label PointsLabel;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Triangulation;
        private System.Windows.Forms.Label mousePos;
        private System.Windows.Forms.RichTextBox pointInside;
        private System.Windows.Forms.Label mark1;
        private System.Windows.Forms.Label mark10;
        private System.Windows.Forms.Label mark9;
        private System.Windows.Forms.Label mark8;
        private System.Windows.Forms.Label mark7;
        private System.Windows.Forms.Label mark6;
        private System.Windows.Forms.Label mark5;
        private System.Windows.Forms.Label mark4;
        private System.Windows.Forms.Label mark3;
        private System.Windows.Forms.Label mark2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label test;
		private System.Windows.Forms.Label label2;
	}
}

