using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using XmlToObjectConvertor;
using XmlToObjectConvertor.DataAccessLayer;

namespace XmlConverter
{
    public partial class MainForm : Form
    {
        List<Person> personList;
        List<Person> dbPersonList;

        string xmlFile = null;
        string convertedXMLFilePath = null;
        string xmlFromObject = null;

        DBConnection dbc = new DBConnection();

        public MainForm()
        {
            InitializeComponent();
            dbPersonList = dbc.Select();
            btnLoad_Click(this, null);
            try
            {
                convertedXMLFilePath = ConfigurationSettings.AppSettings["ConvertedXMLPath"];
            }
            catch(Exception ex)
            {
                MessageBox.Show("convertedXMLFilePath Exception");
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "TXT Files (.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                txtFileName.Text = Path.GetFileName(file);
                this.Refresh();

                try
                {
                    xmlFile = File.ReadAllText(file);
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Read From File failed! " + ex.Message);
                }
            }
        }

        private void btnConvertToObject_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(xmlFile))
            {
                personList = Deserialize<List<Person>>(xmlFile);

                if (personList != null)
                    FillRichTextBox(personList);
            }
            else
            {
                MessageBox.Show("You must upload File before converting!","Warning");
            }

        }

        public T Deserialize<T>(string input) where T : class
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T), new XmlRootAttribute("PersonList"));

                using (StringReader stringReader = new StringReader(input))
                    return (T) serializer.Deserialize(stringReader);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
                return null;
            }
        }

        public string Serialize(List<Person> personList)
        {
            XmlSerializer ser = new XmlSerializer(personList.GetType(), "MyPersonList");
            string result = string.Empty;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                ser.Serialize(memoryStream, personList);

                memoryStream.Position = 0;
                result = new StreamReader(memoryStream).ReadToEnd();
            }

            return result;
        }

        private void FillRichTextBox(List<Person> personList)
        {
            foreach(Person person in personList)
            {
                listBox.Items.Add(person.ToString());
            }
        }

        private void btnUpdateAll_Click(object sender, EventArgs e)
        {

            if (personList != null)
            {
                Logger.Write("Inserting to database");
                dbc.Insert(personList);
                btnLoad_Click(this, null);
            }
            else
                MessageBox.Show("Your list is empty!");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dbListBox.Items.Clear();

            dbPersonList = dbc.Select();

            foreach(Person person in dbPersonList)
            {
                dbListBox.Items.Add(person.ToString());
            }
        }

        private void btnMakeXML_Click(object sender, EventArgs e)
        {
            btnLoad_Click(this,null);

            try
            {
                string fileName = DateTime.Now.ToString("ddMMyyyy") + "_XML.xml";
                string fullPath = convertedXMLFilePath + @"\" + fileName;

                string xmlFromObject = Serialize(dbc.Select());

                if (xmlFromObject.Contains("<Person>"))
                {
                    File.WriteAllText(fullPath, xmlFromObject);
                    MessageBox.Show("File Created at path : " + fullPath, "SystemInformation");
                }
                else
                {
                    MessageBox.Show("No data for creating file!","Warning");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
                Logger.Write("Exception: " + ex.Message);
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CreatePerson newPerson = new CreatePerson();
            newPerson.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dbListBox.Text.Split(',')[0].Split(':')[1].Trim();
                dbc.Delete(id);
                btnLoad_Click(this, null);
            }
            catch(Exception ex)
            {
                if(ex.Message.Contains("Index was outside the bounds of the array"))
                MessageBox.Show("Please select row you want to delete.","Error");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Logger.Write("MainForm loaded..");
        }
    }
}
