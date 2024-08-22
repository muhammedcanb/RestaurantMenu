namespace RestaurantMenu
{
    partial class WeeklyMenu
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
            this.p6Calendar = new System.Windows.Forms.MonthCalendar();
            this.p6buttonPreviousPage = new System.Windows.Forms.Button();
            this.p6listViewWeekly = new System.Windows.Forms.ListView();
            this.dailyDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dailySoup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dailyMainCourse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dailyDesert = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dailyDrink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // p6Calendar
            // 
            this.p6Calendar.BackColor = System.Drawing.Color.Ivory;
            this.p6Calendar.Enabled = false;
            this.p6Calendar.Location = new System.Drawing.Point(18, 84);
            this.p6Calendar.Name = "p6Calendar";
            this.p6Calendar.TabIndex = 16;
            // 
            // p6buttonPreviousPage
            // 
            this.p6buttonPreviousPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.p6buttonPreviousPage.Location = new System.Drawing.Point(587, 381);
            this.p6buttonPreviousPage.Name = "p6buttonPreviousPage";
            this.p6buttonPreviousPage.Size = new System.Drawing.Size(283, 60);
            this.p6buttonPreviousPage.TabIndex = 15;
            this.p6buttonPreviousPage.Text = "Previous Page";
            this.p6buttonPreviousPage.UseVisualStyleBackColor = true;
            this.p6buttonPreviousPage.Click += new System.EventHandler(this.p6buttonPreviousPage_Click);
            // 
            // p6listViewWeekly
            // 
            this.p6listViewWeekly.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dailyDay,
            this.dailySoup,
            this.dailyMainCourse,
            this.dailyDesert,
            this.dailyDrink});
            this.p6listViewWeekly.HideSelection = false;
            this.p6listViewWeekly.Location = new System.Drawing.Point(292, 84);
            this.p6listViewWeekly.Name = "p6listViewWeekly";
            this.p6listViewWeekly.Size = new System.Drawing.Size(579, 207);
            this.p6listViewWeekly.TabIndex = 17;
            this.p6listViewWeekly.UseCompatibleStateImageBehavior = false;
            this.p6listViewWeekly.View = System.Windows.Forms.View.Details;
            // 
            // dailyDay
            // 
            this.dailyDay.Text = "Day";
            this.dailyDay.Width = 61;
            // 
            // dailySoup
            // 
            this.dailySoup.Text = "Soup";
            this.dailySoup.Width = 146;
            // 
            // dailyMainCourse
            // 
            this.dailyMainCourse.Text = "Main Course";
            this.dailyMainCourse.Width = 159;
            // 
            // dailyDesert
            // 
            this.dailyDesert.Text = "Desert";
            this.dailyDesert.Width = 131;
            // 
            // dailyDrink
            // 
            this.dailyDrink.Text = "Drink";
            this.dailyDrink.Width = 70;
            // 
            // WeeklyMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.p6listViewWeekly);
            this.Controls.Add(this.p6Calendar);
            this.Controls.Add(this.p6buttonPreviousPage);
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "WeeklyMenu";
            this.Text = "WeeklyMenu";
            this.Load += new System.EventHandler(this.WeeklyMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar p6Calendar;
        private System.Windows.Forms.Button p6buttonPreviousPage;
        private System.Windows.Forms.ListView p6listViewWeekly;
        private System.Windows.Forms.ColumnHeader dailyDay;
        private System.Windows.Forms.ColumnHeader dailySoup;
        private System.Windows.Forms.ColumnHeader dailyMainCourse;
        private System.Windows.Forms.ColumnHeader dailyDesert;
        private System.Windows.Forms.ColumnHeader dailyDrink;
    }
}