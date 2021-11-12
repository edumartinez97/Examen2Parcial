
namespace ExamenUnidad2.Vistas
{
    partial class MenuView
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
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.btnEstado = new System.Windows.Forms.Button();
            this.btnTickets = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.Location = new System.Drawing.Point(164, 42);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(151, 38);
            this.btnMantenimiento.TabIndex = 0;
            this.btnMantenimiento.Text = "Mantenimiento";
            this.btnMantenimiento.UseVisualStyleBackColor = true;
            // 
            // btnEstado
            // 
            this.btnEstado.Location = new System.Drawing.Point(164, 101);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(151, 38);
            this.btnEstado.TabIndex = 1;
            this.btnEstado.Text = "Estado";
            this.btnEstado.UseVisualStyleBackColor = true;
            // 
            // btnTickets
            // 
            this.btnTickets.Location = new System.Drawing.Point(164, 145);
            this.btnTickets.Name = "btnTickets";
            this.btnTickets.Size = new System.Drawing.Size(151, 38);
            this.btnTickets.TabIndex = 2;
            this.btnTickets.Text = "Tickets";
            this.btnTickets.UseVisualStyleBackColor = true;
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(179, 189);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(136, 38);
            this.btnDetalle.TabIndex = 3;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            // 
            // MenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 287);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnTickets);
            this.Controls.Add(this.btnEstado);
            this.Controls.Add(this.btnMantenimiento);
            this.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "MenuView";
            this.Text = "MenuView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Button btnTickets;
        private System.Windows.Forms.Button btnDetalle;
    }
}