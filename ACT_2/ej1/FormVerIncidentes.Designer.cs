namespace ej1
{
    partial class FormVerIncidentes
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
            lsbIncidentes = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lsbIncidentes
            // 
            lsbIncidentes.FormattingEnabled = true;
            lsbIncidentes.HorizontalScrollbar = true;
            lsbIncidentes.ItemHeight = 28;
            lsbIncidentes.Location = new Point(12, 12);
            lsbIncidentes.Name = "lsbIncidentes";
            lsbIncidentes.ScrollAlwaysVisible = true;
            lsbIncidentes.Size = new Size(778, 536);
            lsbIncidentes.TabIndex = 0;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(305, 554);
            button1.Name = "button1";
            button1.Size = new Size(182, 57);
            button1.TabIndex = 1;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormVerIncidentes
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 619);
            Controls.Add(button1);
            Controls.Add(lsbIncidentes);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FormVerIncidentes";
            Text = "FormVerIncidentes";
            ResumeLayout(false);
        }

        #endregion

        public ListBox lsbIncidentes;
        private Button button1;
    }
}