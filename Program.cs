//Punto 4 
using System.Net;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;


string url = @"https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre ";
var request = (HttpWebRequest)WebRequest.Create(url);
request.Method = "GET";
request.ContentType = "application/json";
request.Accept = "application/json";
Root enlistarDatos;
try
{
    WebResponse response = request.GetResponse();
    Stream strReader = response.GetResponseStream();
    if (strReader == null) return;
    StreamReader objReader = new StreamReader(strReader);
    string responseBody = objReader.ReadToEnd();
    enlistarDatos = JsonSerializer.Deserialize<Root>(responseBody);
    //Usar datos obtenidos: 
    Console.WriteLine("Listado de provincias y su correspondiente id: ");
    foreach(var i in enlistarDatos.Provincias){
        Console.WriteLine("Nombre: "+i.Nombre);
        Console.WriteLine("ID: "+i.Id+"\n");
    }
}
catch (WebException ex)
{
    Console.WriteLine("Error: "+ex.Message);
}

