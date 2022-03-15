
namespace DragonDBExample.Views
{
    partial class ShowDragonsView
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
            this.components = new System.ComponentModel.Container();
            this.dgvDragons = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.killsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dragonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDragonsMoreThan20Kills = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDragons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDragons
            // 
            this.dgvDragons.AutoGenerateColumns = false;
            this.dgvDragons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDragons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.killsDataGridViewTextBoxColumn});
            this.dgvDragons.DataSource = this.dragonBindingSource;
            this.dgvDragons.Location = new System.Drawing.Point(12, 12);
            this.dgvDragons.Name = "dgvDragons";
            this.dgvDragons.Size = new System.Drawing.Size(244, 210);
            this.dgvDragons.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // killsDataGridViewTextBoxColumn
            // 
            this.killsDataGridViewTextBoxColumn.DataPropertyName = "Kills";
            this.killsDataGridViewTextBoxColumn.HeaderText = "Kills";
            this.killsDataGridViewTextBoxColumn.Name = "killsDataGridViewTextBoxColumn";
            // 
            // dragonBindingSource
            // 
            this.dragonBindingSource.DataSource = typeof(DragonDBExample.Models.Dragon);
            // 
            // btnDragonsMoreThan20Kills
            // 
            this.btnDragonsMoreThan20Kills.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDragonsMoreThan20Kills.Location = new System.Drawing.Point(534, 284);
            this.btnDragonsMoreThan20Kills.Name = "btnDragonsMoreThan20Kills";
            this.btnDragonsMoreThan20Kills.Size = new System.Drawing.Size(212, 116);
            this.btnDragonsMoreThan20Kills.TabIndex = 1;
            this.btnDragonsMoreThan20Kills.Text = "Show Dragons with more than 10 kills";
            this.btnDragonsMoreThan20Kills.UseVisualStyleBackColor = true;
            this.btnDragonsMoreThan20Kills.Click += new System.EventHandler(this.btnDragonsMoreThan20Kills_Click);
            // 
            // ShowDragonsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DragonDBExample.Properties.Resources.DragonBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDragonsMoreThan20Kills);
            this.Controls.Add(this.dgvDragons);
            this.Name = "ShowDragonsView";
            this.Text = "ShowDragonsView";
            this.Load += new System.EventHandler(this.ShowDragonsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDragons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDragons;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn killsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dragonBindingSource;
        private System.Windows.Forms.Button btnDragonsMoreThan20Kills;
    }
}