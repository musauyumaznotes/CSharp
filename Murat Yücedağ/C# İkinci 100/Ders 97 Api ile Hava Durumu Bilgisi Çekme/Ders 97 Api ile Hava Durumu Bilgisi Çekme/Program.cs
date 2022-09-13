// See https://aka.ms/new-console-template for more information

using System.Xml.Linq;

string api = "14ad2aba611dbef9c504b82a127794c5";
string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
XDocument weather = XDocument.Load(connection);
var temp = weather.Descendants("temperature").ElementAt(0).Attribute("value").Value;
var weathercase = weather.Descendants("clouds").ElementAt(0).Attribute("name").Value;
Console.WriteLine("İstanbul İçin Sıcaklık : " + temp + " ---- Hava Durumu : "+weathercase);
