using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VitaReg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void valuePicker1_OnSelectedEntry(object sender, Registry.Entry entry, int index)
        {
            int offset;
            if (entry != null)
            {
                offset = entry.StartOffset;
            }
            else
            {
                offset = -1;
            }
            toolStripLabelEntryIndex.Text = "Entry " + index.ToString("X03");
            toolStripLabelEntryOffset.Text = "Offset " + offset.ToString("X05");
        }
        private void valuePicker1_OnSelectedValue(object sender, Registry.Value value)
        {
            string str;
            switch (value.CurrentType)
            {
                case Registry.Value.Type.Registry:
                    str = value.ValueRegistry.ToString();
                    break;
                case Registry.Value.Type.Integer:
                    str = value.ValueInteger.ToString();
                    break;
                case Registry.Value.Type.String:
                    str = value.ValueString;
                    break;
                case Registry.Value.Type.Data:
                    str = "";
                    for (int i = 0; i < value.ValueData.Length; i++)
                        str += value.ValueData[i].ToString("X02");
                    break;
                default:
                    str = "UNK.TYPE " + ((int)value.CurrentType).ToString("X02");
                    break;
            }
            textBox1.Text = str;
            toolStripLabelValueIndex.Text = "Value " + value.Index;
            toolStripLabelValueType.Text = "Type " + ((int)value.CurrentType).ToString("X02");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "system.ireg";
            ofd.Filter = "PSVita registry files|*.ireg;*.dreg|PSVita registry index|*.ireg|PSVita registry data|*.dreg|All files|*";
            ofd.Title = "Please select a registry file directly dumped from your PS Vita";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filename = ofd.FileName;
                string name = System.IO.Path.GetDirectoryName(filename) + "\\" + System.IO.Path.GetFileNameWithoutExtension(filename);
                valuePicker1.CurrentRegistry = new Registry(name);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dumpTheRegistryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://hackinformer.com/PlayStationGuide/PSV/tutorials/how_to_registryhack_buttonswap.html");
        }

        private void rewriteTheRegistryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://hackinformer.com/PlayStationGuide/PSV/tutorials/how_to_registryhack_buttonswap.html");
        }

        private void registryInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = "The left box contains the registry entries, the right box contains the values of selected entry.\nA value contains a number, string, data or a registry link.\nA registry link is used to connect two entries.\nIf entry offset is set to FFFFFFFF, then it does not exists.\nCurrently, VitaReg is read-only.";
            MessageBox.Show(text);
        }

        private void aboutTheDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = "VitaReg 2015/Sep/26\nDeveloped by Xeeynamo\nhttp://github.com/Xeeynamo\nhttp://twitter.com/Xeeynamo";
            MessageBox.Show(text);
        }

        private void thanksToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = "Thanks to Major_Tom and Mr.Gas for the read/write method from mail app\nhttps://twitter.com/frtomtomdu80 https://twitter.com/gabaas1 \nThanks to Freakler for the guide https://twitter.com/freakler94 \nThanks to HackInformer that permits to flow information easily https://twitter.com/HackInformer \n\nPlease stop with ePSP and concentrate to native hacks!";
            MessageBox.Show(text);
        }

        private void usefulWebsitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = "http://hackinformer.com \nhttp://wololo.net \nhttp://gbatemp.net/forums/ps-vita-hacking-homebrew.217";
            MessageBox.Show(text);
        }
    }
}
