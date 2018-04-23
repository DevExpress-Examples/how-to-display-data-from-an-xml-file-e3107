Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports System.Xml
Imports System.Xml.Linq
Imports System.IO
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Xml.Schema

Namespace DataFromXML
	Partial Public Class MainPage
		Inherits UserControl

		Public Sub New()
			InitializeComponent()
			grid.DataSource = GetData()
		End Sub

		Private Function GetData() As ObservableCollection(Of Contact)

			Dim doc As XDocument = XDocument.Load("/DataFromXML;component/Contacts.xml")

			Dim items = _
				From item In doc.Descendants("Contacts") _
				Select New Contact() With {.FirstName = item.Element("FirstName").Value, .LastName = item.Element("LastName").Value, .Company = item.Element("Company").Value, .ID = Integer.Parse(item.Element("ID").Value)}

			Dim contacts As New ObservableCollection(Of Contact)()
			For Each contact As Contact In items
				contacts.Add(contact)
			Next contact
			Return contacts
		End Function
	End Class

	Public Class Contact
		Private privateID As Integer
		Public Property ID() As Integer
			Get
				Return privateID
			End Get
			Set(ByVal value As Integer)
				privateID = value
			End Set
		End Property
		Private privateFirstName As String
		Public Property FirstName() As String
			Get
				Return privateFirstName
			End Get
			Set(ByVal value As String)
				privateFirstName = value
			End Set
		End Property
		Private privateLastName As String
		Public Property LastName() As String
			Get
				Return privateLastName
			End Get
			Set(ByVal value As String)
				privateLastName = value
			End Set
		End Property
		Private privateCompany As String
		Public Property Company() As String
			Get
				Return privateCompany
			End Get
			Set(ByVal value As String)
				privateCompany = value
			End Set
		End Property
	End Class
End Namespace
