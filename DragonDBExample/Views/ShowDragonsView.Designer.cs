
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblKills = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtKills = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
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
            this.btnDragonsMoreThan20Kills.Location = new System.Drawing.Point(12, 296);
            this.btnDragonsMoreThan20Kills.Name = "btnDragonsMoreThan20Kills";
            this.btnDragonsMoreThan20Kills.Size = new System.Drawing.Size(212, 116);
            this.btnDragonsMoreThan20Kills.TabIndex = 1;
            this.btnDragonsMoreThan20Kills.Text = "Show Dragons with more than 10 kills";
            this.btnDragonsMoreThan20Kills.UseVisualStyleBackColor = true;
            this.btnDragonsMoreThan20Kills.Click += new System.EventHandler(this.btnDragonsMoreThan20Kills_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(383, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 31);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblKills
            // 
            this.lblKills.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKills.Location = new System.Drawing.Point(383, 58);
            this.lblKills.Name = "lblKills";
            this.lblKills.Size = new System.Drawing.Size(86, 31);
            this.lblKills.TabIndex = 3;
            this.lblKills.Text = "Kills";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(475, 12);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 31);
            this.txtName.TabIndex = 4;
            // 
            // txtKills
            // 
            this.txtKills.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKills.Location = new System.Drawing.Point(475, 58);
            this.txtKills.Multiline = true;
            this.txtKills.Name = "txtKills";
            this.txtKills.Size = new System.Drawing.Size(173, 31);
            this.txtKills.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(655, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 77);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Dragon";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ShowDragonsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DragonDBExample.Properties.Resources.DragonBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtKills);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblKills);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnDragonsMoreThan20Kills);
            this.Controls.Add(this.dgvDragons);
            this.Name = "ShowDragonsView";
            this.Text = "ShowDragonsView";
            this.Load += new System.EventHandler(this.ShowDragonsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDragons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDragons;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn killsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dragonBindingSource;
        private System.Windows.Forms.Button btnDragonsMoreThan20Kills;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblKills;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtKills;
        private System.Windows.Forms.Button btnAdd;
    }
}