using System;
using System.Windows;
using System.Xml.Linq;

namespace NotebookApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string lastName = LastNameTextBox.Text;
            DateTime birthDate = BirthDatePicker.SelectedDate.HasValue ? BirthDatePicker.SelectedDate.Value : DateTime.Now;
            string phoneNumber = PhoneNumberTextBox.Text;

            if (string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(phoneNumber))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            Contact contact = new Contact
            {
                LastName = lastName,
                BirthDate = birthDate,
                PhoneNumber = phoneNumber
            };

            SaveContactToXml(contact);
        }

        private void SaveContactToXml(Contact contact)
        {
            string filePath = "Notebook.xml";

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
    }
}
