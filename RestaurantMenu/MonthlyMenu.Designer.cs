namespace RestaurantMenu
{
    partial class MonthlyMenu
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
            this.p7Calendar = new System.Windows.Forms.MonthCalendar();
            this.p7buttonPreviousPage = new System.Windows.Forms.Button();
            this.p7listViewMonthly = new System.Windows.Forms.ListView();
            this.monthlyDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.monthlySoup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.monthlyCourse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.monthlyDesert = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.monthlyDrink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // p7Calendar
            // 
            this.p7Calendar.Enabled = false;
            this.p7Calendar.Location = new System.Drawing.Point(18, 121);
            this.p7Calendar.Name = "p7Calendar";
            this.p7Calendar.TabIndex = 13;
            // 
            // p7buttonPreviousPage
            // 
            this.p7buttonPreviousPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.p7buttonPreviousPage.Location = new System.Drawing.Point(18, 367);
            this.p7buttonPreviousPage.Name = "p7buttonPreviousPage";
            this.p7buttonPreviousPage.Size = new System.Drawing.Size(262, 51);
            this.p7buttonPreviousPage.TabIndex = 12;
            this.p7buttonPreviousPage.Text = "Previous Page";
            this.p7buttonPreviousPage.UseVisualStyleBackColor = true;
            this.p7buttonPreviousPage.Click += new System.EventHandler(this.p7buttonPreviousPage_Click);
            // 
            // p7listViewMonthly
            // 
            this.p7listViewMonthly.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.monthlyDay,
            this.monthlySoup,
            this.monthlyCourse,
            this.monthlyDesert,
            this.monthlyDrink});
            this.p7listViewMonthly.HideSelection = false;
            this.p7listViewMonthly.Location = new System.Drawing.Point(304, 36);
            this.p7listViewMonthly.MaximumSize = new System.Drawing.Size(600, 500);
            this.p7listViewMonthly.Name = "p7listViewMonthly";
            this.p7listViewMonthly.Size = new System.Drawing.Size(600, 500);
            this.p7listViewMonthly.TabIndex = 11;
            this.p7listViewMonthly.UseCompatibleStateImageBehavior = false;
            this.p7listViewMonthly.View = System.Windows.Forms.View.Details;
            // 
            // monthlyDay
            // 
            this.monthlyDay.Text = "Day";
            this.monthlyDay.Width = 70;
            // 
            // monthlySoup
            // 
            this.monthlySoup.Text = "Soup";
            this.monthlySoup.Width = 144;
            // 
            // monthlyCourse
            // 
            this.monthlyCourse.Text = "Main Course";
            this.monthlyCourse.Width = 146;
            // 
            // monthlyDesert
            // 
            this.monthlyDesert.Text = "Desert";
            this.monthlyDesert.Width = 124;
            // 
            // monthlyDrink
            // 
            this.monthlyDrink.Text = "Drink";
            this.monthlyDrink.Width = 105;
            // 
            // MonthlyMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(976, 557);
            this.Controls.Add(this.p7Calendar);
            this.Controls.Add(this.p7buttonPreviousPage);
            this.Controls.Add(this.p7listViewMonthly);
            this.Name = "MonthlyMenu";
            this.Text = "MonthlyMenu";
            this.Load += new System.EventHandler(this.MonthlyMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar p7Calendar;
        private System.Windows.Forms.Button p7buttonPreviousPage;
        private System.Windows.Forms.ListView p7listViewMonthly;
        private System.Windows.Forms.ColumnHeader monthlyDay;
        private System.Windows.Forms.ColumnHeader monthlySoup;
        private System.Windows.Forms.ColumnHeader monthlyCourse;
        private System.Windows.Forms.ColumnHeader monthlyDesert;
        private System.Windows.Forms.ColumnHeader monthlyDrink;
    }
}