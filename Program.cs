//Punto 4 
using System.Net;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;

string url =@"https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre";
var request = (HttpWebRequest)WebRequest.Create(url);
request.Method = "GET";
request.ContentType = "application/json";
request.Accept = "application/json";






