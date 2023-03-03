using System.Text;

namespace NotePad
{
    public partial class Main : Form
    {
        public string filename;
        public Main()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void ñîçäàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            filename = "";
        }

        private void îòêğûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                    textBox1.Text = streamReader.ReadToEnd();   
                    streamReader.Close();

                }
                catch
                {
                    MessageBox.Show("Ôàéë íåâúåáåííî íåäîñÿãàåì");
                }
             }
                

        }
        

            private void ñîõğàíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
                File.WriteAllText(sfd.FileName, textBox1.Text);


        }

        private void âûõîäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            openFileDialog1.FileName = @"data\Text2.txt";
            openFileDialog1.Filter = "Òåêñòîâûå ôàéëû (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Filter =
            "Òåêñòîâûå ôàéëû (*.txt)|*.txt|All files (*.*)|*.*";
        }

        private void èçìåíåíèåÖâåòàToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void êğàñíûéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.ForeColor = System.Drawing.Color.Red;


        }

        private void çåëåíûéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.ForeColor = System.Drawing.Color.Green;

        }

        private void ñèíèéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.ForeColor = System.Drawing.Color.DarkBlue;
        }
         
        private void æèğíûìToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Font = new Font(this.Font, FontStyle.Bold);
        }

        private void êóğñèâîìToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Font = new Font(this.Font, FontStyle.Italic);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.textBox1.Font = new Font("Segoe UI", 2);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.textBox1.Font = new Font("Segoe UI", 4);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.textBox1.Font = new Font("Segoe UI", 8);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.textBox1.Font = new Font("Segoe UI", 16);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            this.textBox1.Font = new Font("Segoe UI", 32);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.textBox1.Font = new Font("Segoe UI", 64);
        }

        private void îÏğîãğàììåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.Show();
        }

        private void âñòàâèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
                textBox1.Paste();
        }

        private void êîïèğîâàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
                textBox1.Copy();
        }

        private void âûğåçàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }
    }
}