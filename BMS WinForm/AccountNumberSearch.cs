﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMS_WinForm.DL;

namespace BMS_WinForm
{
    public partial class AccountNumberSearch : UserControl
    {
        public AccountNumberSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach (var A in AdminDL.CustomersList)
            {
                if (txtSearchAccountNumber.Text == A.AccountNumber.ToString())
                {
                    check = true;
                    SearchResult S = new SearchResult(A);
                    S.ShowDialog();

                }
            }
            if (check == false)
            {
                MessageBox.Show("No User Found with Such AccountNumber");
            }

        }
    }
}
