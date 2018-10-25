namespace Lab_12
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.agregarButton = new System.Windows.Forms.Button();
            this.listadoComidas = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.proteinasNumeric = new System.Windows.Forms.NumericUpDown();
            this.grasasNumeric = new System.Windows.Forms.NumericUpDown();
            this.carbohidratosNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proteinasNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grasasNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carbohidratosNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.carbohidratosNumeric);
            this.splitContainer1.Panel1.Controls.Add(this.grasasNumeric);
            this.splitContainer1.Panel1.Controls.Add(this.proteinasNumeric);
            this.splitContainer1.Panel1.Controls.Add(this.agregarButton);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.nombreTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.listadoComidas);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(109, 65);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(118, 20);
            this.nombreTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Proteinas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Carbohidratos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Grasas";
            // 
            // agregarButton
            // 
            this.agregarButton.Location = new System.Drawing.Point(95, 238);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(75, 23);
            this.agregarButton.TabIndex = 0;
            this.agregarButton.Text = "Agregar";
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // listadoComidas
            // 
            this.listadoComidas.FormattingEnabled = true;
            this.listadoComidas.Location = new System.Drawing.Point(92, 40);
            this.listadoComidas.Name = "listadoComidas";
            this.listadoComidas.Size = new System.Drawing.Size(340, 304);
            this.listadoComidas.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Eliminar Selección";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Listado";
            // 
            // proteinasNumeric
            // 
            this.proteinasNumeric.Location = new System.Drawing.Point(109, 101);
            this.proteinasNumeric.Name = "proteinasNumeric";
            this.proteinasNumeric.Size = new System.Drawing.Size(120, 20);
            this.proteinasNumeric.TabIndex = 3;
            // 
            // grasasNumeric
            // 
            this.grasasNumeric.Location = new System.Drawing.Point(109, 137);
            this.grasasNumeric.Name = "grasasNumeric";
            this.grasasNumeric.Size = new System.Drawing.Size(120, 20);
            this.grasasNumeric.TabIndex = 7;
            // 
            // carbohidratosNumeric
            // 
            this.carbohidratosNumeric.Location = new System.Drawing.Point(109, 172);
            this.carbohidratosNumeric.Name = "carbohidratosNumeric";
            this.carbohidratosNumeric.Size = new System.Drawing.Size(120, 20);
            this.carbohidratosNumeric.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proteinasNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grasasNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carbohidratosNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox listadoComidas;
        private System.Windows.Forms.NumericUpDown carbohidratosNumeric;
        private System.Windows.Forms.NumericUpDown grasasNumeric;
        private System.Windows.Forms.NumericUpDown proteinasNumeric;
    }
}

