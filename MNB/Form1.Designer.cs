﻿
using System;

namespace MNB
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.getExchangeRatesResponseBodyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getExchangeRatesResultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getExchangeRatesResponseBodyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.getExchangeRatesResultDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getExchangeRatesResponseBodyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(356, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // getExchangeRatesResponseBodyBindingSource
            // 
            this.getExchangeRatesResponseBodyBindingSource.DataSource = typeof(MNB.MnbServiceReference.GetExchangeRatesResponseBody);
            // 
            // getExchangeRatesResultDataGridViewTextBoxColumn
            // 
            this.getExchangeRatesResultDataGridViewTextBoxColumn.DataPropertyName = "GetExchangeRatesResult";
            this.getExchangeRatesResultDataGridViewTextBoxColumn.HeaderText = "GetExchangeRatesResult";
            this.getExchangeRatesResultDataGridViewTextBoxColumn.Name = "getExchangeRatesResultDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getExchangeRatesResponseBodyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn getExchangeRatesResultDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getExchangeRatesResponseBodyBindingSource;
    }
}

