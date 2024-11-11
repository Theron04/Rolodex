using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Codes
{
    public partial class Form1 : Form
    {
        static Product[] products = new Product[1000];
        static char[] letters = { ' ','A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        public Form1()
        {
            InitializeComponent();
            Generate();
            Sort();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void Generate()
        {
            string filename = "produce_codes.txt";
            FileInfo fileProps = new FileInfo(filename);
            if (fileProps.Exists)
            {
                FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read);
                StreamReader data = new StreamReader(file);
                string line;

                int count = 0;
                while ((line = data.ReadLine()) != null)
                {
                    string[] exploded = line.Split(',');

                    Product temp = new Product(exploded[0], Convert.ToInt32(exploded[1]));

                    products[count++] = temp;

                }

                data.Close();

            }
            else
            {
                MessageBox.Show("No file found");
            }
            
        }
        private void Sort()
        {

            
            for (int i = 0; i < products.Length - 1;)
            {
                
                if (products[i + 1] == null) { break; }
                else
                {
                    
                    int n = 0;
                    bool change = false;
                    string name1 = products[i].GetName().ToUpper();
                    string name2 = products[i + 1].GetName().ToUpper();

                    for (int j = 0; j < letters.Length-1;)
                    {
                        if (name1.Length == n) { break; }
                        else if (name2.Length == n) {
                            Product temp = products[i];
                            products[i] = products[i + 1];
                            products[i + 1] = temp;
                            change = true;
                            break;
                        }
                        else if (name1[n].Equals(letters[j]) && name2[n].Equals(letters[j]))
                        {
                            if (name1.Length == n) { break; }
                            else if (name2.Length ==n) {
                                Product temp = products[i];
                                products[i] = products[i + 1];
                                products[i + 1] = temp;
                                change = true;
                                break;
                            }
                            else { n++;j = 0; }
                            
                       }
                        else if (name1[n].Equals(letters[j])) {break; }
                        else if (name2[n].Equals(letters[j]))
                        {
                            Product temp = products[i];
                            products[i] = products[i + 1];
                            products[i + 1] = temp;
                            change = true;
                            break;
                        }
                        else { j++; }
                    }
                    ;
                    if (change) { i = 0; }
                    else { i++; }
                }
            }
        }


        private void Search()
        {
            
            code_view.Text = "";

            string search = Convert.ToString(search_bar.Text);

            if (search != "")
            {



                foreach (Product x in products)
                {
                    if (x != null)
                    {
                        if (x.GetName().Contains(search))
                        {
                            code_view.Text += x.GetName() + ",";
                            code_view.Text += x.GetCode();
                            code_view.AppendText(Environment.NewLine);

                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private void search_bar_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
