namespace Task_09
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
            this.btn_longTask = new System.Windows.Forms.Button();
            this.btn_cancelarTarea = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_informacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_longTask
            // 
            this.btn_longTask.Location = new System.Drawing.Point(69, 291);
            this.btn_longTask.Name = "btn_longTask";
            this.btn_longTask.Size = new System.Drawing.Size(267, 101);
            this.btn_longTask.TabIndex = 0;
            this.btn_longTask.Text = "Iniciar Long Task";
            this.btn_longTask.UseVisualStyleBackColor = true;
            this.btn_longTask.Click += new System.EventHandler(this.btn_longTask_Click);
            // 
            // btn_cancelarTarea
            // 
            this.btn_cancelarTarea.Location = new System.Drawing.Point(446, 291);
            this.btn_cancelarTarea.Name = "btn_cancelarTarea";
            this.btn_cancelarTarea.Size = new System.Drawing.Size(267, 101);
            this.btn_cancelarTarea.TabIndex = 1;
            this.btn_cancelarTarea.Text = "Cancelar Tarea";
            this.btn_cancelarTarea.UseVisualStyleBackColor = true;
            this.btn_cancelarTarea.Click += new System.EventHandler(this.btn_cancelarTarea_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // lb_informacion
            // 
            this.lb_informacion.AutoSize = true;
            this.lb_informacion.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_informacion.Location = new System.Drawing.Point(298, 83);
            this.lb_informacion.Name = "lb_informacion";
            this.lb_informacion.Size = new System.Drawing.Size(159, 37);
            this.lb_informacion.TabIndex = 3;
            this.lb_informacion.Text = "Informacion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_informacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancelarTarea);
            this.Controls.Add(this.btn_longTask);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_longTask;
        private System.Windows.Forms.Button btn_cancelarTarea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_informacion;
    }
}
