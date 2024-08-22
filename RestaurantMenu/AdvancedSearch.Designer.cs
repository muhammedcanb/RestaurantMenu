namespace RestaurantMenu
{
    partial class AdvancedSearch
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
            this.p5buttonPreviousPage = new System.Windows.Forms.Button();
            this.p5listViewDaily = new System.Windows.Forms.ListView();
            this.AdvancedDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdvancedSoup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdvancedMainCourse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdvancedDesert = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdvancedDrink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.p5buttonFoodFilter = new System.Windows.Forms.Button();
            this.p5textBoxSelectedFood = new System.Windows.Forms.TextBox();
            this.p5datePickAdvanced = new System.Windows.Forms.DateTimePicker();
            this.p5labelSearchbyDay = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // p5buttonPreviousPage
            // 
            this.p5buttonPreviousPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.p5buttonPreviousPage.Location = new System.Drawing.Point(648, 384);
            this.p5buttonPreviousPage.Name = "p5buttonPreviousPage";
            this.p5buttonPreviousPage.Size = new System.Drawing.Size(222, 46);
            this.p5buttonPreviousPage.TabIndex = 13;
            this.p5buttonPreviousPage.Text = "Previous Page";
            this.p5buttonPreviousPage.UseVisualStyleBackColor = true;
            this.p5buttonPreviousPage.Click += new System.EventHandler(this.p5buttonPreviousPage_Click);
            // 
            // p5listViewDaily
            // 
            this.p5listViewDaily.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AdvancedDay,
            this.AdvancedSoup,
            this.AdvancedMainCourse,
            this.AdvancedDesert,
            this.AdvancedDrink});
            this.p5listViewDaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.p5listViewDaily.HideSelection = false;
            this.p5listViewDaily.Location = new System.Drawing.Point(271, 80);
            this.p5listViewDaily.Name = "p5listViewDaily";
            this.p5listViewDaily.Size = new System.Drawing.Size(599, 254);
            this.p5listViewDaily.TabIndex = 12;
            this.p5listViewDaily.UseCompatibleStateImageBehavior = false;
            this.p5listViewDaily.View = System.Windows.Forms.View.Details;
            // 
            // AdvancedDay
            // 
            this.AdvancedDay.Text = "Day";
            this.AdvancedDay.Width = 75;
            // 
            // AdvancedSoup
            // 
            this.AdvancedSoup.Text = "Soup";
            this.AdvancedSoup.Width = 150;
            // 
            // AdvancedMainCourse
            // 
            this.AdvancedMainCourse.Text = "Main Course";
            this.AdvancedMainCourse.Width = 148;
            // 
            // AdvancedDesert
            // 
            this.AdvancedDesert.Text = "Desert";
            this.AdvancedDesert.Width = 101;
            // 
            // AdvancedDrink
            // 
            this.AdvancedDrink.Text = "Drink";
            this.AdvancedDrink.Width = 86;
            // 
            // p5buttonFoodFilter
            // 
            this.p5buttonFoodFilter.BackColor = System.Drawing.Color.PaleTurquoise;
            this.p5buttonFoodFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.p5buttonFoodFilter.Location = new System.Drawing.Point(20, 294);
            this.p5buttonFoodFilter.Name = "p5buttonFoodFilter";
            this.p5buttonFoodFilter.Size = new System.Drawing.Size(215, 43);
            this.p5buttonFoodFilter.TabIndex = 11;
            this.p5buttonFoodFilter.Text = "Search by Food";
            this.p5buttonFoodFilter.UseVisualStyleBackColor = false;
            this.p5buttonFoodFilter.Click += new System.EventHandler(this.p5buttonFoodFilter_Click);
            // 
            // p5textBoxSelectedFood
            // 
            this.p5textBoxSelectedFood.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p5textBoxSelectedFood.Location = new System.Drawing.Point(21, 234);
            this.p5textBoxSelectedFood.Name = "p5textBoxSelectedFood";
            this.p5textBoxSelectedFood.Size = new System.Drawing.Size(215, 43);
            this.p5textBoxSelectedFood.TabIndex = 10;
            // 
            // p5datePickAdvanced
            // 
            this.p5datePickAdvanced.CalendarFont = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p5datePickAdvanced.CalendarMonthBackground = System.Drawing.Color.PaleTurquoise;
            this.p5datePickAdvanced.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p5datePickAdvanced.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.p5datePickAdvanced.Location = new System.Drawing.Point(21, 124);
            this.p5datePickAdvanced.MaxDate = new System.DateTime(2024, 8, 31, 0, 0, 0, 0);
            this.p5datePickAdvanced.MinDate = new System.DateTime(2024, 8, 1, 0, 0, 0, 0);
            this.p5datePickAdvanced.Name = "p5datePickAdvanced";
            this.p5datePickAdvanced.Size = new System.Drawing.Size(214, 43);
            this.p5datePickAdvanced.TabIndex = 9;
            this.p5datePickAdvanced.ValueChanged += new System.EventHandler(this.p5datePickAdvanced_ValueChanged);
            // 
            // p5labelSearchbyDay
            // 
            this.p5labelSearchbyDay.AutoSize = true;
            this.p5labelSearchbyDay.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p5labelSearchbyDay.Location = new System.Drawing.Point(29, 80);
            this.p5labelSearchbyDay.Name = "p5labelSearchbyDay";
            this.p5labelSearchbyDay.Size = new System.Drawing.Size(196, 26);
            this.p5labelSearchbyDay.TabIndex = 14;
            this.p5labelSearchbyDay.Text = "Search by day :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(21, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 8);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // AdvancedSearch
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.p5labelSearchbyDay);
            this.Controls.Add(this.p5buttonPreviousPage);
            this.Controls.Add(this.p5listViewDaily);
            this.Controls.Add(this.p5buttonFoodFilter);
            this.Controls.Add(this.p5textBoxSelectedFood);
            this.Controls.Add(this.p5datePickAdvanced);
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "AdvancedSearch";
            this.Text = "AdvancedSearch";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button p5buttonPreviousPage;
        private System.Windows.Forms.ListView p5listViewDaily;
        private System.Windows.Forms.ColumnHeader AdvancedDay;
        private System.Windows.Forms.ColumnHeader AdvancedSoup;
        private System.Windows.Forms.ColumnHeader AdvancedMainCourse;
        private System.Windows.Forms.ColumnHeader AdvancedDesert;
        private System.Windows.Forms.ColumnHeader AdvancedDrink;
        private System.Windows.Forms.Button p5buttonFoodFilter;
        private System.Windows.Forms.TextBox p5textBoxSelectedFood;
        private System.Windows.Forms.DateTimePicker p5datePickAdvanced;
        private System.Windows.Forms.Label p5labelSearchbyDay;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}