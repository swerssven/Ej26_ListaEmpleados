
namespace Ej26_ListaEmpleados
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.View_Empleados = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Informacion = new System.Windows.Forms.RichTextBox();
            this.btn_Anyadir2 = new System.Windows.Forms.Button();
            this.btn_Eliminar2 = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // View_Empleados
            // 
            this.View_Empleados.ContextMenuStrip = this.contextMenuStrip1;
            this.View_Empleados.HideSelection = false;
            this.View_Empleados.Location = new System.Drawing.Point(46, 54);
            this.View_Empleados.MultiSelect = false;
            this.View_Empleados.Name = "View_Empleados";
            this.View_Empleados.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.View_Empleados.Size = new System.Drawing.Size(287, 316);
            this.View_Empleados.TabIndex = 0;
            this.View_Empleados.UseCompatibleStateImageBehavior = false;
            this.View_Empleados.View = System.Windows.Forms.View.List;
            this.View_Empleados.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.View_Empleados_ItemSelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.Eliminar});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem1.Text = "Añadir";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.btn_Anyadir2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista EMPLEADOS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(414, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Información:";
            // 
            // txt_Informacion
            // 
            this.txt_Informacion.Location = new System.Drawing.Point(414, 54);
            this.txt_Informacion.Name = "txt_Informacion";
            this.txt_Informacion.ReadOnly = true;
            this.txt_Informacion.Size = new System.Drawing.Size(231, 316);
            this.txt_Informacion.TabIndex = 4;
            this.txt_Informacion.Text = "";
            // 
            // btn_Anyadir2
            // 
            this.btn_Anyadir2.BackColor = System.Drawing.Color.Gold;
            this.btn_Anyadir2.Location = new System.Drawing.Point(230, 386);
            this.btn_Anyadir2.Name = "btn_Anyadir2";
            this.btn_Anyadir2.Size = new System.Drawing.Size(103, 23);
            this.btn_Anyadir2.TabIndex = 5;
            this.btn_Anyadir2.Text = "Añadir";
            this.btn_Anyadir2.UseVisualStyleBackColor = false;
            this.btn_Anyadir2.Click += new System.EventHandler(this.btn_Anyadir2_Click);
            // 
            // btn_Eliminar2
            // 
            this.btn_Eliminar2.BackColor = System.Drawing.Color.Gold;
            this.btn_Eliminar2.Location = new System.Drawing.Point(112, 386);
            this.btn_Eliminar2.Name = "btn_Eliminar2";
            this.btn_Eliminar2.Size = new System.Drawing.Size(103, 23);
            this.btn_Eliminar2.TabIndex = 6;
            this.btn_Eliminar2.Text = "Eliminar";
            this.btn_Eliminar2.UseVisualStyleBackColor = false;
            this.btn_Eliminar2.Click += new System.EventHandler(this.btn_Eliminar2_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(117, 22);
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.Click += new System.EventHandler(this.btn_Eliminar2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.btn_Eliminar2);
            this.Controls.Add(this.btn_Anyadir2);
            this.Controls.Add(this.txt_Informacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.View_Empleados);
            this.Name = "Form1";
            this.Text = "GESTIÓN DE ESTUDIANTES-EMPLEADOS";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txt_Informacion;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button btn_Anyadir2;
        private System.Windows.Forms.Button btn_Eliminar2;
        public System.Windows.Forms.ListView View_Empleados;
        private System.Windows.Forms.ToolStripMenuItem Eliminar;
    }
}

