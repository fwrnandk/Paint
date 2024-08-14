using System.Drawing.Imaging;

namespace SimplePaint
{
    public partial class FormPrincipal : Form
    {
        private bool flagpintar = false;
        private Graphics graphicsPainelPintura;
        private float espessuraCaneta;
        private Color corBorracha;
        private bool flagApagar = false;
        private Image imagemASalvar;
        private Graphics graphicsImagemSalvar;

        public FormPrincipal()
        {
            InitializeComponent();

            buttonBorracha.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            buttonLimpar.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            buttonSalvar.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;

            for (int i = 2; i <= 100; i += 2)
            {
                comboBoxEspessuradaCaneta.Items.Add(i);
            }
            comboBoxEspessuradaCaneta.Text = "10";
            comboBoxEspessuradaCaneta.IntegralHeight = false;
            comboBoxEspessuradaCaneta.MaxDropDownItems = 5;

            graphicsPainelPintura = panelPintura.CreateGraphics();
            espessuraCaneta = float.Parse(comboBoxEspessuradaCaneta.Text);
            corBorracha = panelPintura.BackColor;

            imagemASalvar = new Bitmap(panelPintura.Width, panelPintura.Height);
            graphicsImagemSalvar = Graphics.FromImage(imagemASalvar);
            graphicsImagemSalvar.Clear(panelPintura.BackColor);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            espessuraCaneta = float.Parse(comboBoxEspessuradaCaneta.SelectedItem.ToString());
        }

        private void buttonBorracha_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza disso? Todo o desenho será apagado!", "Apagar desenho", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                graphicsPainelPintura.Clear(Color.White);
                imagemASalvar = new Bitmap(panelPintura.Width, panelPintura.Height);
                graphicsImagemSalvar = Graphics.FromImage(imagemASalvar);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog(); // Janela para salvar arquivos
            saveFileDialog.Filter = "Portable Network Graphics|.png|Arquivo JPEG|.jpeg"; // Atribuindo formatos de imagem para o usuário escolher
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Definindo a extensão da imagem que iremos salvar
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        imagemASalvar.Save(saveFileDialog.FileName, ImageFormat.Png);
                        break;
                    case 2:
                        imagemASalvar.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                        break;
                }
            }
        }

        private void buttonCorCaneta_Click_1(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            var corEscolhida = colorDialog.ShowDialog();

            if (corEscolhida == DialogResult.OK)
            {
                buttonCorCaneta.BackColor = colorDialog.Color;
            }
        }

        private void panelPintura_MouseDown(object sender, MouseEventArgs e)
        {
            flagpintar = true;
        }

        private void panelPintura_MouseUp(object sender, MouseEventArgs e)
        {
            flagpintar = false;
        }

        private void panelPintura_MouseMove(object sender, MouseEventArgs e)
        {
            if (flagpintar)
            {
                if (!flagApagar)
                {
                    graphicsPainelPintura.DrawEllipse(new Pen(buttonCorCaneta.BackColor, espessuraCaneta), new RectangleF(e.X, e.Y, espessuraCaneta, espessuraCaneta));
                    graphicsImagemSalvar.DrawEllipse(new Pen(buttonCorCaneta.BackColor, espessuraCaneta), new RectangleF(e.X, e.Y, espessuraCaneta, espessuraCaneta));
                }
                else
                {
                    graphicsPainelPintura.DrawRectangle(new Pen(corBorracha, espessuraCaneta), new Rectangle(e.X, e.Y, (int)espessuraCaneta, (int)espessuraCaneta));

                    graphicsImagemSalvar.DrawRectangle(new Pen(corBorracha, espessuraCaneta), new Rectangle(e.X, e.Y, (int)espessuraCaneta, (int)espessuraCaneta));
                }
            }

        }

        private void buttonBorracha_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    corBorracha = colorDialog.Color;
                }
            }
            else
            {
                if (!flagApagar)
                {
                    flagApagar = true;
                    buttonBorracha.BackColor = corBorracha;
                }
                else
                {
                    flagApagar = false;
                    buttonBorracha.BackColor = Color.Black;
                }

            }
        }

        private void panelPintura_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelPintura_Resize(object sender, EventArgs e)
        {
            graphicsPainelPintura = panelPintura.CreateGraphics();
            var imgTemp = new Bitmap(panelPintura.Width, panelPintura.Height);
            var graphicsImgTemp = Graphics.FromImage(imgTemp);
            graphicsImgTemp.DrawImage(imagemASalvar, 0, 0);
            imagemASalvar = imgTemp;
            graphicsImagemSalvar = graphicsImgTemp;

        }
    }
}
