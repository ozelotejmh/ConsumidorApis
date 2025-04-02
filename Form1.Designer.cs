namespace ConsumidorApis
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView dataGridView;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            
            // Button Mostrar
            this.btnMostrar.Text = "Mostrar Datos";
            this.btnMostrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMostrar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnMostrar.ForeColor = System.Drawing.Color.White;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Size = new System.Drawing.Size(150, 40);
            this.btnMostrar.Location = new System.Drawing.Point(20, 20);
            this.btnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);

            
            // DataGridView
            this.dataGridView.Size = new System.Drawing.Size(760, 350);
            this.dataGridView.Location = new System.Drawing.Point(20, 80);
            this.dataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ReadOnly = true;
            
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dataGridView);
            this.Text = "Consumidor de APIs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
        }

        

        #endregion
    }
}