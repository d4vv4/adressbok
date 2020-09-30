using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.CodeDom.Compiler;

namespace Inlämningsuppgift1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //körs när programmet startar
            onStartUp();

        }

        string file = @"C:\Users\david\Dropbox\.NET\.Programmering C#\Inlämningsuppgift1\Inlämningsuppgift1.txt";

        private int UniqueID()
        {

            int localID = 0;
            StreamReader reader = new StreamReader(file);

            string[] lines = File.ReadAllLines(file);
            reader.Close();
            string ids = "";

            for (int i = 0; i < lines.Length; i++)
            {
                string row = lines[i];
                string[] thisRow = row.Split(',');
                ids += int.Parse(thisRow[0]) + ", ";
            }

            while (true)
            {
                for (int i = 0; i < ids.Length + 1; i++)
                {
                    if (ids.Contains(localID.ToString()))
                    {
                        localID++;
                    }
                    else
                    {
                        return localID;
                    }
                }
            }


        }

        int tempId;

        private void onStartUp()
        {
            btnChange.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int uniqueId = UniqueID();
            string name = txtName.Text;
            string adress = txtAdress.Text;
            string postal = txtPostal.Text;
            string city = txtCity.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;


            if (name != "" && adress != "" && postal != "" && city != "" && phone != "" && email != "")
            {
                lblError.Text = "";
                StreamWriter writer = new StreamWriter(file, true);

                writer.WriteLine(uniqueId + "," + name + "," + adress + "," + postal + "," + city + "," + phone + "," + email);
                writer.Close();
                txtName.Text = "";
                txtAdress.Text = "";
                txtPostal.Text = "";
                txtCity.Text = "";
                txtPhone.Text = "";
                txtEmail.Text = "";
            }
            else
            {
                lblError.Text = "Fyll i samtliga fält";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchResult.Items.Clear();
            string name = txtNameSearch.Text.ToLower();
            string postal = txtPostalSearch.Text.ToLower();

            if (name == "" && postal == "")
            {
                lblErrorSearch.Text = "Fyll i vad du vill söka efter";
            }
            else if (name != "" && postal == "")
            {
                lblErrorSearch.Text = "";
                StreamReader reader = new StreamReader(file);
                string row = reader.ReadLine();
                while (row != null)
                {
                    string[] userValues = row.Split(',');
                    if (userValues[1].Contains(name))
                    {
                        SearchResult.Items.Add(userValues[0] + "," + userValues[1] + "," + userValues[2] + "," + userValues[3] + "," +
                            userValues[4] + "," + userValues[5] + "," + userValues[6]);

                    }
                    row = reader.ReadLine();
                }
                reader.Close();
            }
            else if ((name == "" && postal != ""))
            {
                lblErrorSearch.Text = "";
                StreamReader reader = new StreamReader(file);
                string row = reader.ReadLine();
                while (row != null)
                {
                    string[] userValues = row.Split(',');
                    if (userValues[4].Contains(postal))
                    {
                        SearchResult.Items.Add(userValues[0] + "," + userValues[1] + "," + userValues[2] + "," + userValues[3] + "," +
                            userValues[4] + "," + userValues[5] + "," + userValues[6]);

                    }
                    row = reader.ReadLine();
                }
                reader.Close();
            }
            else if ((name != "" && postal != ""))
            {
                lblErrorSearch.Text = "";
                StreamReader reader = new StreamReader(file);
                string row = reader.ReadLine();
                while (row != null)
                {
                    string[] userValues = row.Split(',');
                    if (userValues[1].Contains(name) && userValues[4].Contains(postal))
                    {
                        SearchResult.Items.Add(userValues[0] + "," + userValues[1] + "," + userValues[2] + "," + userValues[3] + "," +
                            userValues[4] + "," + userValues[5] + "," + userValues[6]);

                    }
                    row = reader.ReadLine();
                }
                reader.Close();
            }

        }

        private void SearchResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblErrorSearch.Text = "";
            btnRegister.Enabled = false;
            btnChange.Enabled = true;
            btnDelete.Enabled = true;
            string selectedEntry = SearchResult.SelectedItem.ToString();
            string[] userValues = selectedEntry.Split(',');
            txtName.Text = userValues[1];
            txtAdress.Text = userValues[2];
            txtPostal.Text = userValues[3];
            txtCity.Text = userValues[4];
            txtPhone.Text = userValues[5];
            txtEmail.Text = userValues[6];
            tempId = int.Parse(userValues[0]);

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string adress = txtAdress.Text;
            string postal = txtPostal.Text;
            string city = txtCity.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;

            string[] lines = File.ReadAllLines(file);

            int i = 0;
            while (true)
            {
                string row = lines[i];
                string[] userValues = row.Split(',');

                if (userValues[0] == tempId.ToString())
                {
                    lines[i] = tempId + "," + name + "," + adress + "," + postal + "," +
                    city + "," + phone + "," + email;

                    for (int j = 0; j < lines.Length; j++)
                    {
                        File.WriteAllLines(file, lines);
                    }
                    break;
                }
                i++;
            }
            txtName.Text = "";
            txtAdress.Text = "";
            txtPostal.Text = "";
            txtCity.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            btnChange.Enabled = false;
            btnDelete.Enabled = false;
            btnRegister.Enabled = true;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            lblErrorSearch.Text = "";
            btnChange.Enabled = false;
            btnDelete.Enabled = false;
            btnRegister.Enabled = true;
            txtName.Text = "";
            txtAdress.Text = "";
            txtPostal.Text = "";
            txtCity.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SearchResult.Items.Clear();
            btnChange.Enabled = false;
            btnDelete.Enabled = false;
            btnRegister.Enabled = true;
            txtName.Text = "";
            txtAdress.Text = "";
            txtPostal.Text = "";
            txtCity.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtNameSearch.Text = "";
            txtPostalSearch.Text = "";

            string[] lines = File.ReadAllLines(file);
            File.WriteAllText(file, String.Empty);

            for (int i = 0; i < lines.Length; i++)
            {
                string row = lines[i];
                string[] userValues = row.Split(',');

                if (userValues[0] == tempId.ToString())
                {
                    continue;
                }
                else
                {
                    StreamWriter writer = new StreamWriter(file, true);
                    writer.WriteLine(lines[i]);
                    writer.Close();
                }

            }

        }
    }
}

