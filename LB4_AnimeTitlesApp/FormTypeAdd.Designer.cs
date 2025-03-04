namespace LB4_AnimeTitlesApp
{
    partial class FormTypeAdd
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
            panel = new Panel();
            TextBoxTypeName = new TextBox();
            labelTypeName = new Label();
            flowLayoutPanelBottom = new FlowLayoutPanel();
            buttonSave = new Button();
            buttonCancel = new Button();
            errorProvider = new ErrorProvider(components);
            panel.SuspendLayout();
            flowLayoutPanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Controls.Add(TextBoxTypeName);
            panel.Controls.Add(labelTypeName);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Padding = new Padding(10);
            panel.Size = new Size(384, 156);
            panel.TabIndex = 0;
            // 
            // TextBoxTypeName
            // 
            TextBoxTypeName.Dock = DockStyle.Top;
            TextBoxTypeName.Location = new Point(10, 35);
            TextBoxTypeName.Name = "TextBoxTypeName";
            TextBoxTypeName.Size = new Size(364, 33);
            TextBoxTypeName.TabIndex = 1;
            TextBoxTypeName.TextChanged += TextBoxTypeName_TextChanged;
            TextBoxTypeName.Validating += TextBoxTypeName_Validating;
            // 
            // labelTypeName
            // 
            labelTypeName.AutoSize = true;
            labelTypeName.Dock = DockStyle.Top;
            labelTypeName.Location = new Point(10, 10);
            labelTypeName.Name = "labelTypeName";
            labelTypeName.Size = new Size(104, 25);
            labelTypeName.TabIndex = 0;
            labelTypeName.Text = "Тип аниме";
            // 
            // flowLayoutPanelBottom
            // 
            flowLayoutPanelBottom.AutoSize = true;
            flowLayoutPanelBottom.Controls.Add(buttonSave);
            flowLayoutPanelBottom.Controls.Add(buttonCancel);
            flowLayoutPanelBottom.Dock = DockStyle.Bottom;
            flowLayoutPanelBottom.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelBottom.Location = new Point(0, 95);
            flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            flowLayoutPanelBottom.Padding = new Padding(10);
            flowLayoutPanelBottom.Size = new Size(384, 61);
            flowLayoutPanelBottom.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Location = new Point(211, 13);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(150, 35);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(55, 13);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(150, 35);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormTypeAdd
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 156);
            Controls.Add(flowLayoutPanelBottom);
            Controls.Add(panel);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormTypeAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Validating += TextBoxTypeName_Validating;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            flowLayoutPanelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel;
        private FlowLayoutPanel flowLayoutPanelBottom;
        private Button buttonSave;
        private Button buttonCancel;
        private Label labelTypeName;
        protected internal TextBox TextBoxTypeName;
        private ErrorProvider errorProvider;
    }
}