namespace Repaso3D
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonResumen = new System.Windows.Forms.Button();
            this.buttonOrdenar = new System.Windows.Forms.Button();
            this.labelMayor = new System.Windows.Forms.Label();
            this.labelMenor = new System.Windows.Forms.Label();
            this.buttonMayorMenor = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 210);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonResumen
            // 
            this.buttonResumen.Location = new System.Drawing.Point(52, 306);
            this.buttonResumen.Name = "buttonResumen";
            this.buttonResumen.Size = new System.Drawing.Size(132, 70);
            this.buttonResumen.TabIndex = 1;
            this.buttonResumen.Text = "Mostrar Resumen";
            this.buttonResumen.UseVisualStyleBackColor = true;
            this.buttonResumen.Click += new System.EventHandler(this.buttonResumen_Click);
            // 
            // buttonOrdenar
            // 
            this.buttonOrdenar.Enabled = false;
            this.buttonOrdenar.Location = new System.Drawing.Point(229, 306);
            this.buttonOrdenar.Name = "buttonOrdenar";
            this.buttonOrdenar.Size = new System.Drawing.Size(139, 70);
            this.buttonOrdenar.TabIndex = 2;
            this.buttonOrdenar.Text = "Ordenar por Cuota";
            this.buttonOrdenar.UseVisualStyleBackColor = true;
            this.buttonOrdenar.Click += new System.EventHandler(this.buttonOrdenar_Click);
            // 
            // labelMayor
            // 
            this.labelMayor.AutoSize = true;
            this.labelMayor.Location = new System.Drawing.Point(597, 62);
            this.labelMayor.Name = "labelMayor";
            this.labelMayor.Size = new System.Drawing.Size(35, 13);
            this.labelMayor.TabIndex = 3;
            this.labelMayor.Text = "label1";
            // 
            // labelMenor
            // 
            this.labelMenor.AutoSize = true;
            this.labelMenor.Location = new System.Drawing.Point(600, 153);
            this.labelMenor.Name = "labelMenor";
            this.labelMenor.Size = new System.Drawing.Size(35, 13);
            this.labelMenor.TabIndex = 4;
            this.labelMenor.Text = "label2";
            // 
            // buttonMayorMenor
            // 
            this.buttonMayorMenor.Enabled = false;
            this.buttonMayorMenor.Location = new System.Drawing.Point(426, 306);
            this.buttonMayorMenor.Name = "buttonMayorMenor";
            this.buttonMayorMenor.Size = new System.Drawing.Size(162, 70);
            this.buttonMayorMenor.TabIndex = 5;
            this.buttonMayorMenor.Text = "Mostrar Mayor Menor";
            this.buttonMayorMenor.UseVisualStyleBackColor = true;
            this.buttonMayorMenor.Click += new System.EventHandler(this.buttonMayorMenor_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(597, 40);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(35, 13);
            this.labelNombre.TabIndex = 6;
            this.labelNombre.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.buttonMayorMenor);
            this.Controls.Add(this.labelMenor);
            this.Controls.Add(this.labelMayor);
            this.Controls.Add(this.buttonOrdenar);
            this.Controls.Add(this.buttonResumen);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonResumen;
        private System.Windows.Forms.Button buttonOrdenar;
        private System.Windows.Forms.Label labelMayor;
        private System.Windows.Forms.Label labelMenor;
        private System.Windows.Forms.Button buttonMayorMenor;
        private System.Windows.Forms.Label labelNombre;
    }
}

