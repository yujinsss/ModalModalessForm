﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModalModalessForm
{
    public partial class FormModal : Form
    {
        public string Title
        {
            set { this.Text = value; }
        }

        public FormModal()
        {
            InitializeComponent();
        }
    }
}
