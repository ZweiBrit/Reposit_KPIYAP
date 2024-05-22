using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

namespace XmlTaskWPF
{
    public partial class MainWindow : Window
    {
        private List<Contact> contacts = new List<Contact>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string lastName = LastNameTextBox.Text;
            DateTime? birthDate = BirthDatePicker.SelectedDate;
            string phoneNumber = PhoneNumberTextBox.Text;

            if (string.IsNullOrWhiteSpace(lastName) || !birthDate.HasValue || string.IsNullOrWhiteSpace(phoneNumber))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            Contact contact = new Contact
            {
                LastName = lastName,
                BirthDate = birthDate.Value,
                PhoneNumber = phoneNumber
            };

            contacts.Add(contact);
            SaveContactToXml(contact);
            UpdateOutput();
        }

        private void SaveContactToXml(Contact contact)
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = System.IO.Path.Combine(documentsPath, "Notebook.xml");

            XElement contactElement = new XElement("Contact",
                new XElement("LastName", contact.LastName),
                new XElement("BirthDate", contact.BirthDate.ToString("yyyy-MM-dd")),
                new XElement("PhoneNumber", contact.PhoneNumber)
            );

            XDocument xDocument;

            if (System.IO.File.Exists(filePath))
            {
                xDocument = XDocument.Load(filePath);
                xDocument.Root.Add(contactElement);
            }
            else
            {
                xDocument = new XDocument(new XElement("Notebook", contactElement));
            }

            xDocument.Save(filePath);

            MessageBox.Show("Контакт успешно сохранен.");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            UpdateOutput();
        }

        private void UpdateOutput()
        {
            OutputStackPanel.Children.Clear();

            if (TextBoxRadioButton.IsChecked == true)
            {
                TextBox textBox = new TextBox
                {
                    Text = string.Join(Environment.NewLine, contacts),
                    IsReadOnly = true,
                    VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                    Height = 150,
                    Width = 560
                };
                OutputStackPanel.Children.Add(textBox);
            }
            else if (TreeViewRadioButton.IsChecked == true)
            {
                TreeView treeView = new TreeView
                {
                    Height = 150,
                    Width = 560
                };
                foreach (var contact in contacts)
                {
                    TreeViewItem item = new TreeViewItem
                    {
                        Header = contact.LastName
                    };
                    item.Items.Add($"Дата рождения: {contact.BirthDate.ToString("yyyy-MM-dd")}");
                    item.Items.Add($"Номер телефона: {contact.PhoneNumber}");
                    treeView.Items.Add(item);
                }
                OutputStackPanel.Children.Add(treeView);
            }
            else if (ListBoxRadioButton.IsChecked == true)
            {
                ListBox listBox = new ListBox
                {
                    Height = 150,
                    Width = 560
                };
                foreach (var contact in contacts)
                {
                    listBox.Items.Add($"{contact.LastName}, {contact.BirthDate.ToString("yyyy-MM-dd")}, {contact.PhoneNumber}");
                }
                OutputStackPanel.Children.Add(listBox);
            }
        }
    }

    public class Contact
    {
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"{LastName}, {BirthDate.ToString("yyyy-MM-dd")}, {PhoneNumber}";
        }
    }
}
