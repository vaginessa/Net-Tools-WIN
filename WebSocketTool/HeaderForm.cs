﻿using System;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace WebSocketTool
{
    public partial class HeaderForm : Form
    {
        public NameValueCollection Headers
        {
            get
            {
                NameValueCollection collection = new NameValueCollection();
                foreach (DataGridViewRow row in headers.Rows)
                {
                    string name = (string)row.Cells[0].Value;
                    string value = (string)row.Cells[1].Value;
                    if (!string.IsNullOrWhiteSpace(name))
                        collection.Add(name, value);
                }
                return collection;
            }
        }
        public HeaderForm()
        {
            InitializeComponent();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (headers.SelectedRows.Count > 0 && !headers.SelectedRows[0].IsNewRow)
                headers.Rows.Remove(headers.SelectedRows[0]);
        }

        private void done_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void HeaderForm_Load(object sender, EventArgs e)
        {

        }
    }
}