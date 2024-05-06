namespace IS_transport_company
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
            this.tablesPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).BeginInit();
            this.SuspendLayout();
            // 
            // tablesPanel
            // 
            this.tablesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tablesPanel.AutoScroll = true;
            this.tablesPanel.AutoSize = true;
            this.tablesPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tablesPanel.ColumnCount = 1;
            this.tablesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablesPanel.Location = new System.Drawing.Point(0, 0);
            this.tablesPanel.MaximumSize = new System.Drawing.Size(128, 450);
            this.tablesPanel.Name = "tablesPanel";
            this.tablesPanel.RowCount = 1;
            this.tablesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablesPanel.Size = new System.Drawing.Size(128, 450);
            this.tablesPanel.TabIndex = 0;
            // 
            // tableView
            // 
            this.tableView.AllowUserToAddRows = false;
            this.tableView.AllowUserToDeleteRows = false;
            this.tableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableView.Location = new System.Drawing.Point(134, 0);
            this.tableView.Name = "tableView";
            this.tableView.ReadOnly = true;
            this.tableView.Size = new System.Drawing.Size(483, 450);
            this.tableView.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableView);
            this.Controls.Add(this.tablesPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablesPanel;
        private System.Windows.Forms.DataGridView tableView;
    }
}

