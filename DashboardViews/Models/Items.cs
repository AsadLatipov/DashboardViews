using DashboardViews.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DashboardViews.Models
{
    public static class Items
    {
        public static List<MenuItem> Home = new List<MenuItem>(new List<MenuItem> {
                new MenuItem { Title = "C Disk", Image = "../assets/hardDrive.png"},
                new MenuItem { Title = "D Disk", Image = "../assets/hardDrive.png"},
                new MenuItem { Title = "E Disk", Image = "../assets/hardDrive.png"},
                new MenuItem { Title = "F Disk", Image = "../assets/hardDrive.png"}});



        public static List<MenuItem> Desktop = new List<MenuItem>(new List<MenuItem> {
                new MenuItem { Title = "File", Image = "../assets/document.png"},
                new MenuItem { Title = "Alarm", Image = "../assets/alarm.png"},
                new MenuItem { Title = "Calendar", Image = "../assets/calendar.png"},
                new MenuItem { Title = "Trash", Image = "../assets/trash.png"},
                new MenuItem { Title = "Printer", Image = "../assets/hardDrive.png"}});

        public static List<MenuItem> Document = new List<MenuItem>(new List<MenuItem> {
                new MenuItem { Title = "Essay", Image = "../assets/folder_2.png"},
                new MenuItem { Title = "Friends", Image = "../assets/folder_2.png"},
                new MenuItem { Title = "Jhon's", Image = "../assets/folder_2.png"},
                new MenuItem { Title = "Work", Image = "../assets/folder_2.png"},
                new MenuItem { Title = "Source", Image = "../assets/folder_2.png"},
                new MenuItem { Title = "Windows", Image = "../assets/folder_2.png"},
                new MenuItem { Title = "Fronted", Image = "../assets/folder_2.png"}});

        public static List<MenuItem> Download = new List<MenuItem>(new List<MenuItem> {
                new MenuItem { Title = "Python", Image = "../assets/python.png"},
                new MenuItem { Title = "Half-life", Image = "../assets/game.png"},
                new MenuItem { Title = "Telegram", Image = "../assets/telegram.png"},
                new MenuItem { Title = "visual studio", Image = "../assets/vs.png"},
                new MenuItem { Title = "Chrome", Image = "../assets/chrome.png"}});

        public static List<MenuItem> Picture = new List<MenuItem>(new List<MenuItem> {
                new MenuItem { Title = "Flower", Image = "../assets/picture_file.png"},
                new MenuItem { Title = "France", Image = "../assets/picture_file.png"},
                new MenuItem { Title = "Children", Image = "../assets/picture_file.png"},
                new MenuItem { Title = "Wild", Image = "../assets/picture_file.png"},
                new MenuItem { Title = "Birds", Image = "../assets/picture_file.png"},
                new MenuItem { Title = "Animals", Image = "../assets/picture_file.png"},
                new MenuItem { Title = "Night", Image = "../assets/picture_file.png"},
                new MenuItem { Title = "Sunrise", Image = "../assets/picture_file.png"}});

        public static List<MenuItem> Music = new List<MenuItem>(new List<MenuItem> {
                new MenuItem { Title = "I'm Good", Image = "../assets/music_file.png"},
                new MenuItem { Title = "Bad Guy", Image = "../assets/music_file.png"},
                new MenuItem { Title = "Thunder", Image = "../assets/music_file.png"},
                new MenuItem { Title = "For My Hand", Image = "../assets/music_file.png"},
                new MenuItem { Title = "2 be Loved", Image = "../assets/music_file.png"},
                new MenuItem { Title = "Left and Right", Image = "../assets/music_file.png"},
                new MenuItem { Title = "2 step", Image = "../assets/music_file.png"},
                new MenuItem { Title = "Running Up", Image = "../assets/music_file.png"}});



        public static List<MenuItem> Movie = new List<MenuItem>(new List<MenuItem> {
                new MenuItem { Title = "Interstellar", Image = "../assets/movie_file.png"},
                new MenuItem { Title = "The Godfather", Image = "../assets/movie_file.png"},
                new MenuItem { Title = "The Matrix", Image = "../assets/movie_file.png"},
                new MenuItem { Title = "Terminator 2", Image = "../assets/movie_file.png"},
                new MenuItem { Title = "Gladiator", Image = "../assets/movie_file.png"},
                new MenuItem { Title = "Alien", Image = "../assets/movie_file.png"},
                new MenuItem { Title = "Joker", Image = "../assets/movie_file.png"},
                new MenuItem { Title = "Hamilton", Image = "../assets/movie_file.png"}});

        public static List<MenuItem> Trash = new List<MenuItem>(new List<MenuItem> {
                new MenuItem { Title = "data.txt", Image = "../assets/file.png"}});





    }
}
