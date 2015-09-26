using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VitaReg
{
    public partial class ValuePicker : UserControl
    {
        private Registry reg;
        private Registry.Entry curEntry;
        public Registry CurrentRegistry
        {
            get { return reg; }
            set
            {
                reg = value;
                PopulateEntries(listEntries.Items);
            }
        }
        public ValuePicker()
        {
            InitializeComponent();
        }

        void PopulateEntries(ListBox.ObjectCollection list)
        {
            if (reg == null)
                return;
            list.Clear();
            for (int i = 0; i < reg.CurrentHeader.EntriesCount; i++)
                list.Add(/*i.ToString("X03") + " - " + */reg.GetEntryDesc(i).Name);
        }
        void PopulateValues(ListBox.ObjectCollection list, int entryIndex)
        {
            if (reg == null)
                return;
            list.Clear();
            curEntry = reg.GetEntry(entryIndex);
            if (curEntry != null)
            {
                for (int i = 0; i < curEntry.Count; i++)
                    list.Add(curEntry.GetValue(i).Name);
            }
        }

        private void listEntries_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ((ListBox)sender).SelectedIndex;
            if (index >= 0)
            {
                PopulateValues(listValues.Items, index);
                if (OnSelectedEntry != null)
                    OnSelectedEntry(this, reg.GetEntry(index), index);
            }
        }
        private void listValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ((ListBox)sender).SelectedIndex;
            if (index >= 0 && curEntry != null)
            {
                if (OnSelectedValue != null)
                    OnSelectedValue(this, curEntry.GetValue(index));
            }
        }
        public delegate void SelectedEntry(object sender, Registry.Entry entry, int index);
        public event SelectedEntry OnSelectedEntry;
        public delegate void SelectedValue(object sender, Registry.Value value);
        public event SelectedValue OnSelectedValue;
    }
}
