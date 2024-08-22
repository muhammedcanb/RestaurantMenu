namespace RestaurantMenu
{
    partial class MainPage
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
            this.p3buttonAdvancedSearch = new System.Windows.Forms.Button();
            this.p3buttonClose = new System.Windows.Forms.Button();
            this.p3buttonWeekly = new System.Windows.Forms.Button();
            this.p3buttonMonthly = new System.Windows.Forms.Button();
            this.p3buttonDaily = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // p3buttonAdvancedSearch
            // 
            this.p3buttonAdvancedSearch.BackColor = System.Drawing.Color.AliceBlue;
            this.p3buttonAdvancedSearch.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p3buttonAdvancedSearch.ForeColor = System.Drawing.Color.DarkRed;
            this.p3buttonAdvancedSearch.Location = new System.Drawing.Point(202, 271);
            this.p3buttonAdvancedSearch.Name = "p3buttonAdvancedSearch";
            this.p3buttonAdvancedSearch.Size = new System.Drawing.Size(437, 62);
            this.p3buttonAdvancedSearch.TabIndex = 9;
            this.p3buttonAdvancedSearch.Text = "Advanced Search";
            this.p3buttonAdvancedSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.p3buttonAdvancedSearch.UseVisualStyleBackColor = false;
            this.p3buttonAdvancedSearch.Click += new System.EventHandler(this.p3buttonAdvancedSearch_Click);
            // 
            // p3buttonClose
            // 
            this.p3buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.p3buttonClose.Location = new System.Drawing.Point(143, 373);
            this.p3buttonClose.Name = "p3buttonClose";
            this.p3buttonClose.Size = new System.Drawing.Size(360, 56);
            this.p3buttonClose.TabIndex = 8;
            this.p3buttonClose.Text = "Close the application";
            this.p3buttonClose.UseVisualStyleBackColor = true;
            this.p3buttonClose.Click += new System.EventHandler(this.p3buttonClose_Click);
            // 
            // p3buttonWeekly
            // 
            this.p3buttonWeekly.BackColor = System.Drawing.Color.AliceBlue;
            this.p3buttonWeekly.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p3buttonWeekly.ForeColor = System.Drawing.Color.DarkRed;
            this.p3buttonWeekly.Location = new System.Drawing.Point(202, 109);
            this.p3buttonWeekly.Name = "p3buttonWeekly";
            this.p3buttonWeekly.Size = new System.Drawing.Size(437, 62);
            this.p3buttonWeekly.TabIndex = 7;
            this.p3buttonWeekly.Text = "Weekly Food Menu";
            this.p3buttonWeekly.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.p3buttonWeekly.UseVisualStyleBackColor = false;
            this.p3buttonWeekly.Click += new System.EventHandler(this.p3buttonWeekly_Click);
            // 
            // p3buttonMonthly
            // 
            this.p3buttonMonthly.BackColor = System.Drawing.Color.AliceBlue;
            this.p3buttonMonthly.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p3buttonMonthly.ForeColor = System.Drawing.Color.DarkRed;
            this.p3buttonMonthly.Location = new System.Drawing.Point(26, 190);
            this.p3buttonMonthly.Name = "p3buttonMonthly";
            this.p3buttonMonthly.Size = new System.Drawing.Size(437, 62);
            this.p3buttonMonthly.TabIndex = 6;
            this.p3buttonMonthly.Text = "Monthly Food Menu";
            this.p3buttonMonthly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.p3buttonMonthly.UseVisualStyleBackColor = false;
            this.p3buttonMonthly.Click += new System.EventHandler(this.p3buttonMonthly_Click);
            // 
            // p3buttonDaily
            // 
            this.p3buttonDaily.BackColor = System.Drawing.Color.AliceBlue;
            this.p3buttonDaily.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p3buttonDaily.ForeColor = System.Drawing.Color.DarkRed;
            this.p3buttonDaily.Location = new System.Drawing.Point(26, 28);
            this.p3buttonDaily.Name = "p3buttonDaily";
            this.p3buttonDaily.Size = new System.Drawing.Size(437, 62);
            this.p3buttonDaily.TabIndex = 5;
            this.p3buttonDaily.Text = "Daily Food Menu";
            this.p3buttonDaily.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.p3buttonDaily.UseVisualStyleBackColor = false;
            this.p3buttonDaily.Click += new System.EventHandler(this.p3buttonDaily_Click);
            // 
            // MainPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(665, 453);
            this.Controls.Add(this.p3buttonAdvancedSearch);
            this.Controls.Add(this.p3buttonClose);
            this.Controls.Add(this.p3buttonWeekly);
            this.Controls.Add(this.p3buttonMonthly);
            this.Controls.Add(this.p3buttonDaily);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button p3buttonAdvancedSearch;
        private System.Windows.Forms.Button p3buttonClose;
        private System.Windows.Forms.Button p3buttonWeekly;
        private System.Windows.Forms.Button p3buttonMonthly;
        private System.Windows.Forms.Button p3buttonDaily;
    }
}