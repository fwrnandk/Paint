namespace SimplePaint
{
    partial class FormPrincipal
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
            groupBox1 = new GroupBox();
            buttonCorCaneta = new Button();
            buttonSalvar = new Button();
            buttonLimpar = new Button();
            buttonBorracha = new Button();
            label2 = new Label();
            comboBoxEspessuradaCaneta = new ComboBox();
            label1 = new Label();
            panelPintura = new Panel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.Black;
            groupBox1.Controls.Add(buttonCorCaneta);
            groupBox1.Controls.Add(buttonSalvar);
            groupBox1.Controls.Add(buttonLimpar);
            groupBox1.Controls.Add(buttonBorracha);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBoxEspessuradaCaneta);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.WhiteSmoke;
            groupBox1.Location = new Point(13, 0);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(889, 135);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personalizar";
            // 
            // buttonCorCaneta
            // 
            buttonCorCaneta.BackColor = Color.Blue;
            buttonCorCaneta.FlatStyle = FlatStyle.Flat;
            buttonCorCaneta.Location = new Point(148, 56);
            buttonCorCaneta.Name = "buttonCorCaneta";
            buttonCorCaneta.Size = new Size(75, 30);
            buttonCorCaneta.TabIndex = 1;
            buttonCorCaneta.UseVisualStyleBackColor = false;
            buttonCorCaneta.Click += buttonCorCaneta_Click_1;
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = Color.Black;
            buttonSalvar.FlatStyle = FlatStyle.Flat;
            buttonSalvar.Location = new Point(756, 55);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(78, 35);
            buttonSalvar.TabIndex = 6;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonLimpar
            // 
            buttonLimpar.BackColor = Color.Black;
            buttonLimpar.FlatStyle = FlatStyle.Flat;
            buttonLimpar.Location = new Point(661, 56);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(77, 34);
            buttonLimpar.TabIndex = 5;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = false;
            buttonLimpar.Click += button1_Click;
            // 
            // buttonBorracha
            // 
            buttonBorracha.BackColor = Color.Black;
            buttonBorracha.FlatStyle = FlatStyle.Flat;
            buttonBorracha.Location = new Point(567, 55);
            buttonBorracha.Name = "buttonBorracha";
            buttonBorracha.Size = new Size(76, 35);
            buttonBorracha.TabIndex = 4;
            buttonBorracha.Text = "Borracha";
            buttonBorracha.UseVisualStyleBackColor = false;
            buttonBorracha.Click += buttonBorracha_Click;
            buttonBorracha.MouseDown += buttonBorracha_MouseDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 59);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 3;
            label2.Text = "Espessura da Caneta";
            label2.Click += label2_Click;
            // 
            // comboBoxEspessuradaCaneta
            // 
            comboBoxEspessuradaCaneta.AccessibleName = "comboBoxEspessuradaCaneta";
            comboBoxEspessuradaCaneta.FormattingEnabled = true;
            comboBoxEspessuradaCaneta.Location = new Point(415, 58);
            comboBoxEspessuradaCaneta.Name = "comboBoxEspessuradaCaneta";
            comboBoxEspessuradaCaneta.Size = new Size(121, 28);
            comboBoxEspessuradaCaneta.TabIndex = 2;
            comboBoxEspessuradaCaneta.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 58);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 1;
            label1.Text = "Cor da Caneta";
            label1.Click += label1_Click;
            // 
            // panelPintura
            // 
            panelPintura.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPintura.BackColor = SystemColors.Window;
            panelPintura.Location = new Point(13, 142);
            panelPintura.Name = "panelPintura";
            panelPintura.Size = new Size(889, 433);
            panelPintura.TabIndex = 1;
            panelPintura.Paint += panelPintura_Paint;
            panelPintura.MouseDown += panelPintura_MouseDown;
            panelPintura.MouseMove += panelPintura_MouseMove;
            panelPintura.MouseUp += panelPintura_MouseUp;
            panelPintura.Resize += panelPintura_Resize;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(915, 600);
            Controls.Add(panelPintura);
            Controls.Add(groupBox1);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Margin = new Padding(4);
            Name = "FormPrincipal";
            ShowIcon = false;
            Text = " Simple Paint";
            Load += FormPrincipal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBoxEspessuradaCaneta;
        private Label label1;
        private Label label2;
        private Button buttonBorracha;
        private Button buttonLimpar;
        private Button buttonSalvar;
        private Button buttonCorCaneta;
        private Panel panelPintura;
    }
}
