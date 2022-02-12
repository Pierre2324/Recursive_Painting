namespace RecursiveCallPainting
{
    partial class F_RecursivePainting
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
            this.flp_grid = new System.Windows.Forms.FlowLayoutPanel();
            this.nud_gridSize = new System.Windows.Forms.NumericUpDown();
            this.b_generateGrid = new System.Windows.Forms.Button();
            this.lb_widthHeight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_gridSize)).BeginInit();
            this.SuspendLayout();
            // 
            // flp_grid
            // 
            this.flp_grid.Location = new System.Drawing.Point(0, 42);
            this.flp_grid.Name = "flp_grid";
            this.flp_grid.Size = new System.Drawing.Size(500, 458);
            this.flp_grid.TabIndex = 0;
            // 
            // nud_gridSize
            // 
            this.nud_gridSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_gridSize.Location = new System.Drawing.Point(73, 13);
            this.nud_gridSize.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nud_gridSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_gridSize.Name = "nud_gridSize";
            this.nud_gridSize.Size = new System.Drawing.Size(41, 23);
            this.nud_gridSize.TabIndex = 2;
            this.nud_gridSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // b_generateGrid
            // 
            this.b_generateGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_generateGrid.Location = new System.Drawing.Point(120, 10);
            this.b_generateGrid.Name = "b_generateGrid";
            this.b_generateGrid.Size = new System.Drawing.Size(126, 27);
            this.b_generateGrid.TabIndex = 3;
            this.b_generateGrid.Text = "Generate Grid";
            this.b_generateGrid.UseVisualStyleBackColor = true;
            this.b_generateGrid.Click += new System.EventHandler(this.b_generateGrid_Click);
            // 
            // lb_widthHeight
            // 
            this.lb_widthHeight.AutoSize = true;
            this.lb_widthHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_widthHeight.Location = new System.Drawing.Point(3, 15);
            this.lb_widthHeight.Name = "lb_widthHeight";
            this.lb_widthHeight.Size = new System.Drawing.Size(66, 17);
            this.lb_widthHeight.TabIndex = 4;
            this.lb_widthHeight.Text = "Grid Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Click on a cell to start painting.";
            // 
            // F_RecursivePainting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 501);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_gridSize);
            this.Controls.Add(this.lb_widthHeight);
            this.Controls.Add(this.b_generateGrid);
            this.Controls.Add(this.flp_grid);
            this.Name = "F_RecursivePainting";
            this.Text = "Recursive Painting";
            this.Load += new System.EventHandler(this.F_RecursivePainting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_gridSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_grid;
        private System.Windows.Forms.NumericUpDown nud_gridSize;
        private System.Windows.Forms.Button b_generateGrid;
        private System.Windows.Forms.Label lb_widthHeight;
        private System.Windows.Forms.Label label1;
    }
}

