namespace infragistics_tooltip_repro
{
    partial class FormComboEditor
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
            ultraComboEditor1 = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            ((System.ComponentModel.ISupportInitialize)ultraComboEditor1).BeginInit();
            SuspendLayout();
            // 
            // ultraComboEditor1
            // 
            ultraComboEditor1.Location = new Point(8, 8);
            ultraComboEditor1.Name = "ultraComboEditor1";
            ultraComboEditor1.Size = new Size(240, 25);
            ultraComboEditor1.TabIndex = 0;
            // 
            // FormComboEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ultraComboEditor1);
            Name = "FormComboEditor";
            Text = "FormComboEditor";
            ((System.ComponentModel.ISupportInitialize)ultraComboEditor1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Infragistics.Win.UltraWinEditors.UltraComboEditor ultraComboEditor1;
    }
}