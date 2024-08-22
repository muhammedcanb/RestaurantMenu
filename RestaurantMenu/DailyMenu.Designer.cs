namespace RestaurantMenu
{
    partial class DailyMenu
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
            this.p4buttonPreviousPage = new System.Windows.Forms.Button();
            this.p4Calendar = new System.Windows.Forms.MonthCalendar();
            this.p4listViewDaily = new System.Windows.Forms.ListView();
            this.dailyDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dailySoup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dailyMainCourse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dailyDesert = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dailyDrink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // p4buttonPreviousPage
            // 
            this.p4buttonPreviousPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.p4buttonPreviousPage.Location = new System.Drawing.Point(565, 281);
            this.p4buttonPreviousPage.Name = "p4buttonPreviousPage";
            this.p4buttonPreviousPage.Size = new System.Drawing.Size(306, 46);
            this.p4buttonPreviousPage.TabIndex = 10;
            this.p4buttonPreviousPage.Text = "Previous Page";
            this.p4buttonPreviousPage.UseVisualStyleBackColor = true;
            this.p4buttonPreviousPage.Click += new System.EventHandler(this.p4buttonPreviousPage_Click);
            // 
            // p4Calendar
            // 
            this.p4Calendar.Enabled = false;
            this.p4Calendar.Location = new System.Drawing.Point(18, 59);
            this.p4Calendar.Name = "p4Calendar";
            this.p4Calendar.TabIndex = 9;
            // 
            // p4listViewDaily
            // 
            this.p4listViewDaily.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dailyDay,
            this.dailySoup,
            this.dailyMainCourse,
            this.dailyDesert,
            this.dailyDrink});
            this.p4listViewDaily.HideSelection = false;
            this.p4listViewDaily.Location = new System.Drawing.Point(292, 112);
            this.p4listViewDaily.Name = "p4listViewDaily";
            this.p4listViewDaily.Size = new System.Drawing.Size(579, 92);
            this.p4listViewDaily.TabIndex = 8;
            this.p4listViewDaily.UseCompatibleStateImageBehavior = false;
            this.p4listViewDaily.View = System.Windows.Forms.View.Details;
            // 
            // dailyDay
            // 
            this.dailyDay.Text = "Day";
            this.dailyDay.Width = 82;
            // 
            // dailySoup
            // 
            this.dailySoup.Text = "Soup";
            this.dailySoup.Width = 127;
            // 
            // dailyMainCourse
            // 
            this.dailyMainCourse.Text = "Main Course";
            this.dailyMainCourse.Width = 159;
            // 
            // dailyDesert
            // 
            this.dailyDesert.Text = "Desert";
            this.dailyDesert.Width = 94;
            // 
            // dailyDrink
            // 
            this.dailyDrink.Text = "Drink";
            // 
            // DailyMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(882, 358);
            this.Controls.Add(this.p4buttonPreviousPage);
            this.Controls.Add(this.p4Calendar);
            this.Controls.Add(this.p4listViewDaily);
            this.Name = "DailyMenu";
            this.Text = "DailyMenu";
            this.Load += new System.EventHandler(this.DailyMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button p4buttonPreviousPage;
        private System.Windows.Forms.MonthCalendar p4Calendar;
        private System.Windows.Forms.ListView p4listViewDaily;
        private System.Windows.Forms.ColumnHeader dailyDay;
        private System.Windows.Forms.ColumnHeader dailySoup;
        private System.Windows.Forms.ColumnHeader dailyMainCourse;
        private System.Windows.Forms.ColumnHeader dailyDesert;
        private System.Windows.Forms.ColumnHeader dailyDrink;
    }
}