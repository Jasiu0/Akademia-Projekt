using System;
namespace Akademia_Projekt
{
    public class AdvancedBook : Book
    {

        public string HttpPath { get; set; }
        public string Description { get; set; }
        public AdvancedBook(string title, string name, string surname, string publishingHouse, int publicationDate, string genre, string description, string httpPath) 
        {
            this.Title = title;
            this.Name = name;
            this.Surname = surname;
            this.PublishingHouse = publishingHouse;
            this.PublicationDate = publicationDate;
            this.Genre = genre;

            this.HttpPath = httpPath;
            this.Description = description;
        }
    }
}