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
            this.tableInteractiveButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableInteractivePanel = new System.Windows.Forms.TableLayoutPanel();
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
            this.tableView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.tableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableView.Location = new System.Drawing.Point(134, 0);
            this.tableView.MultiSelect = false;
            this.tableView.Name = "tableView";
            this.tableView.ReadOnly = true;
            this.tableView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableView.Size = new System.Drawing.Size(483, 450);
            this.tableView.TabIndex = 1;
            this.tableView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.tableView_DataBindingComplete);
            // 
            // tableInteractiveButtonPanel
            // 
            this.tableInteractiveButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableInteractiveButtonPanel.AutoSize = true;
            this.tableInteractiveButtonPanel.ColumnCount = 3;
            this.tableInteractiveButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableInteractiveButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableInteractiveButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableInteractiveButtonPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableInteractiveButtonPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableInteractiveButtonPanel.Location = new System.Drawing.Point(624, 414);
            this.tableInteractiveButtonPanel.Name = "tableInteractiveButtonPanel";
            this.tableInteractiveButtonPanel.RowCount = 1;
            this.tableInteractiveButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableInteractiveButtonPanel.Size = new System.Drawing.Size(249, 36);
            this.tableInteractiveButtonPanel.TabIndex = 0;
            // 
            // tableInteractivePanel
            // 
            this.tableInteractivePanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableInteractivePanel.ColumnCount = 2;
            this.tableInteractivePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableInteractivePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248F));
            this.tableInteractivePanel.Location = new System.Drawing.Point(624, 12);
            this.tableInteractivePanel.Name = "tableInteractivePanel";
            this.tableInteractivePanel.RowCount = 5;
            this.tableInteractivePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableInteractivePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableInteractivePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableInteractivePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableInteractivePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableInteractivePanel.Size = new System.Drawing.Size(249, 396);
            this.tableInteractivePanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.tableInteractivePanel);
            this.Controls.Add(this.tableInteractiveButtonPanel);
            this.Controls.Add(this.tableView);
            this.Controls.Add(this.tablesPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablesPanel;
        private System.Windows.Forms.DataGridView tableView;
        private System.Windows.Forms.TableLayoutPanel tableInteractiveButtonPanel;
        private System.Windows.Forms.TableLayoutPanel tableInteractivePanel;
    }
}

