using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEParaPeliculas
{
    public class oPelicula
    {
        public oPelicula(string nombre, List<StringValue> atributos, string recomendacion)
        {
            Nombre = nombre;
            Atributos = atributos;
            Recomendacion = recomendacion;
        }

        public oPelicula()
        {
        }

        public string Nombre { get; set; }
        public List<StringValue> Atributos { get; set; }
        public string Recomendacion { get; set; }
    }

    public class StringValue
    {
        public StringValue(string s)
        {
            _value = s;
        }
        public string Value { get { return _value; } set { _value = value; } }
        string _value;
    }

    public static class CRUDPeliculas
    {
        public static List<oPelicula> GetListPeliculas()
        {
            string NameBC = "BC.json";
            var listPeliculas = new List<oPelicula>();
            try
            {
                if (!File.Exists(NameBC))
                {
                    File.Create(NameBC).Close();
                }

                using (StreamReader fileBC = new StreamReader( NameBC, Encoding.UTF8, false))
                {
                    var json = fileBC.ReadToEnd();
                    var configJson = new JsonSerializerSettings();
                    configJson.Culture = new CultureInfo("es-ES",false);
                    listPeliculas = JsonConvert.DeserializeObject<List<oPelicula>>(json, configJson);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listPeliculas;
        }

        public static bool SaveFile(List<oPelicula> data)
        {
            string NameBC = "BC.json";
            string respaldoName = "BC" + DateTime.Now.ToString("_dd_MM_yyyy") + ".json";
            try
            {
                if (!File.Exists(NameBC))
                {
                    File.Create(NameBC).Close();
                }
                else
                {
                    if (!File.Exists(respaldoName))
                        File.Create(respaldoName).Close();


                    using (StreamReader fileBC = new StreamReader(NameBC, Encoding.UTF8, false))
                    {
                        var json = fileBC.ReadToEnd();

                        using (StreamWriter fileRespaldo = new StreamWriter(respaldoName, false, Encoding.UTF8))
                        {
                            fileRespaldo.Write(json);
                        }
                    }
                    File.Delete(NameBC);
                    File.Create(NameBC).Close();
                }


                using (StreamWriter fileBC = new StreamWriter(NameBC, false, Encoding.UTF8))
                {
                    var configJson = new JsonSerializerSettings();
                    configJson.Culture = new CultureInfo("es-ES", false);
                    var dataJson = JsonConvert.SerializeObject(data, configJson);                    
                    fileBC.Write(dataJson);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
    }
}
