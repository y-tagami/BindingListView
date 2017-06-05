namespace Demo
{
    partial class AggregateForm
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
            this.feedsListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.itemsGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.remove_sort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // feedsListBox
            // 
            this.feedsListBox.CheckOnClick = true;
            this.feedsListBox.FormattingEnabled = true;
            this.feedsListBox.Location = new System.Drawing.Point(12, 23);
            this.feedsListBox.Name = "feedsListBox";
            this.feedsListBox.Size = new System.Drawing.Size(324, 74);
            this.feedsListBox.TabIndex = 0;
            this.feedsListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.feedsListBox_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Check the feeds you want to display.";
            // 
            // itemsGrid
            // 
            this.itemsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsGrid.Location = new System.Drawing.Point(12, 106);
            this.itemsGrid.Name = "itemsGrid";
            this.itemsGrid.RowTemplate.Height = 23;
            this.itemsGrid.Size = new System.Drawing.Size(542, 224);
            this.itemsGrid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter by title:";
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(419, 32);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(135, 19);
            this.filterTextBox.TabIndex = 4;
            this.filterTextBox.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(342, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 44);
            this.label3.TabIndex = 5;
            this.label3.Text = "You can still sort the columns - but now the sort is across all the items from ch" +
    "ecked feeds.";
            // 
            // remove_sort
            // 
            this.remove_sort.Location = new System.Drawing.Point(342, 3);
            this.remove_sort.Name = "remove_sort";
            this.remove_sort.Size = new System.Drawing.Size(95, 25);
            this.remove_sort.TabIndex = 6;
            this.remove_sort.Text = "RemoveSort";
            this.remove_sort.UseVisualStyleBackColor = true;
            this.remove_sort.Click += new System.EventHandler(this.remove_sort_Click);
            // 
            // AggregateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 342);
            this.Controls.Add(this.remove_sort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemsGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.feedsListBox);
            this.Name = "AggregateForm";
            this.Text = "Aggregate List View";
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox feedsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView itemsGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button remove_sort;
    }
}