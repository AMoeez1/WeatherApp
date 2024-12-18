namespace WeatherApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.handleSearch = new System.Windows.Forms.Button();
            this.sunrise_label = new System.Windows.Forms.Label();
            this.details_label = new System.Windows.Forms.Label();
            this.condition = new System.Windows.Forms.Label();
            this.windSpeed_label = new System.Windows.Forms.Label();
            this.pressure_label = new System.Windows.Forms.Label();
            this.windSpeed = new System.Windows.Forms.Label();
            this.pressure = new System.Windows.Forms.Label();
            this.details = new System.Windows.Forms.Label();
            this.sunrise = new System.Windows.Forms.Label();
            this.sunset_label = new System.Windows.Forms.Label();
            this.sunset = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "City:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 104);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 28);
            this.textBox1.TabIndex = 1;
            // 
            // handleSearch
            // 
            this.handleSearch.BackColor = System.Drawing.Color.Transparent;
            this.handleSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.handleSearch.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handleSearch.ForeColor = System.Drawing.Color.White;
            this.handleSearch.Location = new System.Drawing.Point(484, 104);
            this.handleSearch.Name = "handleSearch";
            this.handleSearch.Size = new System.Drawing.Size(80, 30);
            this.handleSearch.TabIndex = 2;
            this.handleSearch.Text = "Search";
            this.handleSearch.UseVisualStyleBackColor = false;
            this.handleSearch.Click += new System.EventHandler(this.handleSearch_Click);
            // 
            // sunrise_label
            // 
            this.sunrise_label.AutoSize = true;
            this.sunrise_label.BackColor = System.Drawing.Color.Transparent;
            this.sunrise_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunrise_label.ForeColor = System.Drawing.Color.White;
            this.sunrise_label.Location = new System.Drawing.Point(74, 299);
            this.sunrise_label.Name = "sunrise_label";
            this.sunrise_label.Size = new System.Drawing.Size(84, 20);
            this.sunrise_label.TabIndex = 3;
            this.sunrise_label.Text = "Sunrise:";
            // 
            // details_label
            // 
            this.details_label.AutoSize = true;
            this.details_label.BackColor = System.Drawing.Color.Transparent;
            this.details_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details_label.ForeColor = System.Drawing.Color.White;
            this.details_label.Location = new System.Drawing.Point(74, 260);
            this.details_label.Name = "details_label";
            this.details_label.Size = new System.Drawing.Size(72, 20);
            this.details_label.TabIndex = 4;
            this.details_label.Text = "Detail:";
            // 
            // condition
            // 
            this.condition.AutoSize = true;
            this.condition.BackColor = System.Drawing.Color.Transparent;
            this.condition.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condition.ForeColor = System.Drawing.Color.White;
            this.condition.Location = new System.Drawing.Point(74, 225);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(104, 20);
            this.condition.TabIndex = 5;
            this.condition.Text = "Condition:";
            // 
            // windSpeed_label
            // 
            this.windSpeed_label.AutoSize = true;
            this.windSpeed_label.BackColor = System.Drawing.Color.Transparent;
            this.windSpeed_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windSpeed_label.ForeColor = System.Drawing.Color.White;
            this.windSpeed_label.Location = new System.Drawing.Point(468, 225);
            this.windSpeed_label.Name = "windSpeed_label";
            this.windSpeed_label.Size = new System.Drawing.Size(125, 20);
            this.windSpeed_label.TabIndex = 6;
            this.windSpeed_label.Text = "Wind Speed:";
            // 
            // pressure_label
            // 
            this.pressure_label.AutoSize = true;
            this.pressure_label.BackColor = System.Drawing.Color.Transparent;
            this.pressure_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressure_label.ForeColor = System.Drawing.Color.White;
            this.pressure_label.Location = new System.Drawing.Point(469, 260);
            this.pressure_label.Name = "pressure_label";
            this.pressure_label.Size = new System.Drawing.Size(95, 20);
            this.pressure_label.TabIndex = 7;
            this.pressure_label.Text = "Pressure:";
            // 
            // windSpeed
            // 
            this.windSpeed.AutoSize = true;
            this.windSpeed.BackColor = System.Drawing.Color.Transparent;
            this.windSpeed.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windSpeed.ForeColor = System.Drawing.Color.White;
            this.windSpeed.Location = new System.Drawing.Point(628, 225);
            this.windSpeed.Name = "windSpeed";
            this.windSpeed.Size = new System.Drawing.Size(42, 20);
            this.windSpeed.TabIndex = 8;
            this.windSpeed.Text = "N/A";
            // 
            // pressure
            // 
            this.pressure.AutoSize = true;
            this.pressure.BackColor = System.Drawing.Color.Transparent;
            this.pressure.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressure.ForeColor = System.Drawing.Color.White;
            this.pressure.Location = new System.Drawing.Point(628, 260);
            this.pressure.Name = "pressure";
            this.pressure.Size = new System.Drawing.Size(42, 20);
            this.pressure.TabIndex = 9;
            this.pressure.Text = "N/A";
            // 
            // details
            // 
            this.details.AutoSize = true;
            this.details.BackColor = System.Drawing.Color.Transparent;
            this.details.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details.ForeColor = System.Drawing.Color.White;
            this.details.Location = new System.Drawing.Point(203, 260);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(42, 20);
            this.details.TabIndex = 10;
            this.details.Text = "N/A";
            // 
            // sunrise
            // 
            this.sunrise.AutoSize = true;
            this.sunrise.BackColor = System.Drawing.Color.Transparent;
            this.sunrise.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunrise.ForeColor = System.Drawing.Color.White;
            this.sunrise.Location = new System.Drawing.Point(203, 299);
            this.sunrise.Name = "sunrise";
            this.sunrise.Size = new System.Drawing.Size(42, 20);
            this.sunrise.TabIndex = 11;
            this.sunrise.Text = "N/A";
            // 
            // sunset_label
            // 
            this.sunset_label.AutoSize = true;
            this.sunset_label.BackColor = System.Drawing.Color.Transparent;
            this.sunset_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunset_label.ForeColor = System.Drawing.Color.White;
            this.sunset_label.Location = new System.Drawing.Point(79, 341);
            this.sunset_label.Name = "sunset_label";
            this.sunset_label.Size = new System.Drawing.Size(79, 20);
            this.sunset_label.TabIndex = 12;
            this.sunset_label.Text = "Sunset:";
            // 
            // sunset
            // 
            this.sunset.AutoSize = true;
            this.sunset.BackColor = System.Drawing.Color.Transparent;
            this.sunset.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunset.ForeColor = System.Drawing.Color.White;
            this.sunset.Location = new System.Drawing.Point(203, 341);
            this.sunset.Name = "sunset";
            this.sunset.Size = new System.Drawing.Size(42, 20);
            this.sunset.TabIndex = 13;
            this.sunset.Text = "N/A";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(78, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sunset);
            this.Controls.Add(this.sunset_label);
            this.Controls.Add(this.sunrise);
            this.Controls.Add(this.details);
            this.Controls.Add(this.pressure);
            this.Controls.Add(this.windSpeed);
            this.Controls.Add(this.pressure_label);
            this.Controls.Add(this.windSpeed_label);
            this.Controls.Add(this.condition);
            this.Controls.Add(this.details_label);
            this.Controls.Add(this.sunrise_label);
            this.Controls.Add(this.handleSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button handleSearch;
        private System.Windows.Forms.Label sunrise_label;
        private System.Windows.Forms.Label details_label;
        private System.Windows.Forms.Label condition;
        private System.Windows.Forms.Label windSpeed_label;
        private System.Windows.Forms.Label pressure_label;
        private System.Windows.Forms.Label windSpeed;
        private System.Windows.Forms.Label pressure;
        private System.Windows.Forms.Label details;
        private System.Windows.Forms.Label sunrise;
        private System.Windows.Forms.Label sunset_label;
        private System.Windows.Forms.Label sunset;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

