using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ListBox.Homework
{
    public partial class Form1 : Form
    {
        private List<User> users;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.Label LabelSecondName;
        private System.Windows.Forms.Label LabelPhoneNumber;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonAddToListBox;
        private System.Windows.Forms.Button buttonDeleteFromListBox;
        private System.Windows.Forms.Button buttonChangeUserFromListBox;
        private System.Windows.Forms.Button buttonSaveToTXT;
        private System.Windows.Forms.Button buttonLoadFromTXT;
        private System.Windows.Forms.Button buttonSaveToXML;
        private System.Windows.Forms.Button buttonLoadFromXML;
        public Form1()
        {
            InitializeComponent();
            users = new List<User>();
        }
        private void SaveUsers(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (User u in users)
                {
                    writer.WriteLine(u.ToString());
                }
            }
        }
        private void LoadUsers(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            users.Clear();
            listBox1.Items.Clear();
            string line = reader.ReadLine();
            while (line != null)
            {
                string[] parts = line.Split(' ');
                if (parts.Length == 4)
                {
                    string firstName = parts[0];
                    string lastName = parts[1];
                    string email = parts[2];
                    string phone = parts[3];
                    User user = new User(firstName, lastName, email, phone);
                    users.Add(user);
                    listBox1.Items.Add(user.ToString());
                }
                line = reader.ReadLine();
            }
            reader.Close();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                User user = users[index];
                textBoxFirstName.Text = user.FirstName;
                textBoxSecondName.Text = user.LastName;
                textBoxPhoneNumber.Text = user.Email;
                textBoxEmail.Text = user.Phone;
            }
        }

        private void buttonAddToListBox_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxSecondName.Text;
            string email = textBoxPhoneNumber.Text;
            string phone = textBoxEmail.Text;
            User user = new User(firstName, lastName, email, phone);
            users.Add(user);
            listBox1.Items.Add(user.ToString());
            textBoxFirstName.Clear();
            textBoxSecondName.Clear();
            textBoxPhoneNumber.Clear();
            textBoxEmail.Clear();
        }
        private void buttonDeleteFromListBox_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                users.RemoveAt(index);
                listBox1.Items.RemoveAt(index);
                textBoxFirstName.Clear();
                textBoxSecondName.Clear();
                textBoxPhoneNumber.Clear();
                textBoxEmail.Clear();
            }
        }
        private void buttonChangeUserFromListBox_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                string firstName = textBoxFirstName.Text;
                string lastName = textBoxSecondName.Text;
                string email = textBoxPhoneNumber.Text;
                string phone = textBoxEmail.Text;
                User user = new User(firstName, lastName, email, phone);
                users[index] = user;
                listBox1.Items[index] = user.ToString();
            }
        }
        private void buttonSaveToTXT_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Файл с пользователями (Users.txt)|Users.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                SaveUsers(fileName);
            }
        }
        private void buttonLoadFromTXT_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файл с пользователями (Users.txt)|Users.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                listBox1.Items.Clear();
                LoadUsers(fileName);
            }
        }
        private void ExportUsers(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            XmlWriter writer = XmlWriter.Create(fileName);
            serializer.Serialize(writer, users);
            writer.Close();
        }
        private void ImportUsers(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            XmlReader reader = XmlReader.Create(fileName);
            users = (List<User>)serializer.Deserialize(reader);
            reader.Close();
        }
        private void buttonSaveToXML_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.xml)|*.xml";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                ExportUsers(fileName);
            }
        }
        private void buttonLoadFromXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                ImportUsers(fileName);
                listBox1.Items.Clear();
                foreach (User user in users)
                {
                    listBox1.Items.Add(user);
                }
            }
        }
    }
}