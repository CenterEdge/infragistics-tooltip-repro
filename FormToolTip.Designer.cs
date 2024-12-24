namespace infragistics_tooltip_repro
{
    partial class FormToolTip
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
            components = new System.ComponentModel.Container();
            Infragistics.Win.UltraWinToolTip.UltraToolTipInfo ultraToolTipInfo1 = new Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("4. Close This Form", Infragistics.Win.ToolTipImage.Default, null, Infragistics.Win.DefaultableBoolean.Default);
            button1 = new Button();
            ultraToolTipManager1 = new Infragistics.Win.UltraWinToolTip.UltraToolTipManager(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(8, 8);
            button1.Name = "button1";
            button1.Size = new Size(144, 64);
            button1.TabIndex = 0;
            button1.Text = "3. Hover Over Me";
            ultraToolTipInfo1.ToolTipText = "4. Close This Form";
            ultraToolTipManager1.SetUltraToolTip(button1, ultraToolTipInfo1);
            button1.UseVisualStyleBackColor = true;
            // 
            // ultraToolTipManager1
            // 
            ultraToolTipManager1.ContainingControl = this;
            // 
            // FormToolTip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Name = "FormToolTip";
            Text = "FormToolTip";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Infragistics.Win.UltraWinToolTip.UltraToolTipManager ultraToolTipManager1;
    }
}