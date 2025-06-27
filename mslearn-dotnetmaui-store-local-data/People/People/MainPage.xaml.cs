using People.Models;
using System.Collections.Generic;

namespace People;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        string dbPath = FileAccessHelper.GetLocalFilePath("people.db3");
        statusMessage.Text = $"Ruta de la base de datos:\n{dbPath}"; 

    }

    public void OnNewButtonClicked(object sender, EventArgs args)
    {
        statusMessage.Text = "";

        App.PersonRepo.AddNewPerson(newPerson.Text);
        statusMessage.Text = App.PersonRepo.StatusMessage;
    }

    public void OnGetButtonClicked(object sender, EventArgs args)
    {
        statusMessage.Text = "";

        List<Person> people = App.PersonRepo.GetAllPeople();
        peopleList.ItemsSource = people;
    }

}

