using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Xml.Schema;

namespace DataFromXML {
    public partial class MainPage : UserControl {

        public MainPage() {
            InitializeComponent();
            grid.ItemsSource = GetData();
        }

        ObservableCollection<Contact> GetData() {

            XDocument doc = XDocument.Load("/DataFromXML;component/Contacts.xml");

            var items = from item in doc.Descendants("Contacts")
                        select new Contact() {
                            FirstName = item.Element("FirstName").Value,
                            LastName = item.Element("LastName").Value,
                            Company = item.Element("Company").Value,
                            ID = int.Parse(item.Element("ID").Value)
                        };

            ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();
            foreach (Contact contact in items) {
                contacts.Add(contact);
            }
            return contacts;
        }
    }

    public class Contact {
        public int ID {
            get;
            set;
        }
        public string FirstName {
            get;
            set;
        }
        public string LastName {
            get;
            set;
        }
        public string Company {
            get;
            set;
        }
    }
}
