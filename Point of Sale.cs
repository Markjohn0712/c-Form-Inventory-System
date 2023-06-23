using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PG
{
    public partial class Point_of_Sale : Form
    {
        public Point_of_Sale()
        {
            InitializeComponent();
        
        }

        private void cmdCustomer_Click(object sender, EventArgs e)
        {
            ((PG.MDIParent1)this.MdiParent).FormCustomer();
           
        }

        private void cmdProductItem_Click(object sender, EventArgs e)
        {
            ((PG.MDIParent1)this.MdiParent).FormProduct();
        }
       
        public void Function(String func)
        {
            if (func == "PRODITEM")
            {
                cmdProductItem.Enabled = false;
                cmdCustomer.Enabled = true;
                CmdSupplier.Enabled = true;
                Var.formCustomer.Close();
                Var.formSupplier.Close();

            }
            else if (func == "CUSTOMER")
            {
                cmdCustomer.Enabled = false;
                cmdProductItem.Enabled = true;
                CmdSupplier.Enabled = true;
                Var.formProduct.Close();
                Var.formCustomer.Close();
                Var.formSupplier.Close();

            }
            else if (func == "USER")
            {
                cmdCustomer.Enabled = true;
                cmdProductItem.Enabled = true;
                CmdSupplier.Enabled = true;
                Var.formCustomer.Close();
                Var.formProduct.Close();
                Var.formSupplier.Close();
            }
            else if (func == "SUPPLIER")
            {
                CmdSupplier.Enabled = false;
                cmdCustomer.Enabled = true;
                cmdProductItem.Enabled = true;
          
                Var.formCustomer.Close();
                Var.formProduct.Close();
              

            }
            else if (func == "Hide")
            {
               
            }

        }

        
        private void Point_of_Sale_Load(object sender, EventArgs e)
        {
            timerProducts.Start();
            timerPurchases.Start();
            timerRevenue.Start();
            timerProfit.Start();

        }

        private void btnDoraemon_MouseEnter(object sender, EventArgs e)
        {
            btnDoraemon.BackColor = Color.FromArgb(0, 255, 73, 73);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timerProducts_Tick(object sender, EventArgs e)
        {
            int val = Convert.ToInt16(labelProducts.Text);

            if (val < 120)
            {
                val += 1;
                labelProducts.Text = val.ToString();
            }
            else
            {
                timerProducts.Stop();
            }
        }

        private void timerPurchases_Tick(object sender, EventArgs e)
        {
            int val = Convert.ToInt16(labelPurchases.Text);

            if (val < 350)
            {
                val += 1;
                labelPurchases.Text = val.ToString();
            }
            else
            {
                timerPurchases.Stop();
            }
        }

        private void timerRevenue_Tick(object sender, EventArgs e)
        {
   
        }

        private void timerProfit_Tick(object sender, EventArgs e)
        {

        }

        private void cmdTransaction_Click(object sender, EventArgs e)
        {
            ((PG.MDIParent1)this.MdiParent).FormTransaction();
        }

        private void CmdSupplier_Click(object sender, EventArgs e)
        {
            ((PG.MDIParent1)this.MdiParent).FormSupplier();
        }

        private void btnDoraemon_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ((PG.MDIParent1)this.MdiParent).FormGraphReport();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            ((PG.MDIParent1)this.MdiParent).FormItem();
        }
    }
 }













   