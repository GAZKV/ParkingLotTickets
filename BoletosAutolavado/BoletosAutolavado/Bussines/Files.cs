using BoletosAutolavado.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BoletosAutolavado.Bussines
{
    class Files
    {
        private string AdressFile;
        public Files()
        {
            AdressFile = string.Empty;
        }

        public void saveSerials(string fullPath, object documento)
        {
            if (fullPath == null)
            {
                throw new Exception("_Serialize: Path not set");
            }

            string DirName = Path.GetDirectoryName(fullPath);

            if (!((DirName == null) || (DirName.Trim().Length == 0)))
            {
                if (!Directory.Exists(DirName))
                {
                    Directory.CreateDirectory(DirName);
                }
            }

            using (FileStream stream = new FileStream(fullPath, FileMode.Create))
            {
                XmlSerializer format = new XmlSerializer(typeof(Serials));
                format.Serialize(stream, documento);
            }
        }

        public Serials loadSerials(string fullPath)
        {
            Serials msc = null;
            try
            {
                using (FileStream stream = new FileStream(fullPath, FileMode.Open))
                {

                    XmlSerializer format = new XmlSerializer(typeof(Serials));

                    msc = format.Deserialize(stream) as Serials;

                }
            }
            catch (DirectoryNotFoundException)
            {
                Serials cadena = new Serials();
                saveSerials(fullPath, cadena);
                using (FileStream stream = new FileStream(fullPath, FileMode.Open))
                {

                    XmlSerializer format = new XmlSerializer(typeof(Serials));

                    msc = format.Deserialize(stream) as Serials;

                }
            }
            catch (FileNotFoundException)
            {
                Serials cadena = new Serials();
                saveSerials(fullPath, cadena);
                using (FileStream stream = new FileStream(fullPath, FileMode.Open))
                {

                    XmlSerializer format = new XmlSerializer(typeof(Serials));

                    msc = format.Deserialize(stream) as Serials;

                }
            }

            return msc;
        }

        public void saveCars(string fullPath, object documento)
        {
            if (fullPath == null)
            {
                throw new Exception("_Serialize: Path not set");
            }

            string DirName = Path.GetDirectoryName(fullPath);

            if (!((DirName == null) || (DirName.Trim().Length == 0)))
            {
                if (!Directory.Exists(DirName))
                {
                    Directory.CreateDirectory(DirName);
                }
            }

            using (FileStream stream = new FileStream(fullPath, FileMode.Create))
            {
                XmlSerializer format = new XmlSerializer(typeof(Cars));
                format.Serialize(stream, documento);
            }
        }

        public Cars loadCars(string fullPath)
        {
            Cars msc = null;
            try
            {
                using (FileStream stream = new FileStream(fullPath, FileMode.Open))
                {

                    XmlSerializer format = new XmlSerializer(typeof(Cars));

                    msc = format.Deserialize(stream) as Cars;

                }
            }
            catch (DirectoryNotFoundException)
            {
                Cars cadena = new Cars();
                saveCars(fullPath, cadena);
                using (FileStream stream = new FileStream(fullPath, FileMode.Open))
                {

                    XmlSerializer format = new XmlSerializer(typeof(Cars));

                    msc = format.Deserialize(stream) as Cars;

                }
            }
            catch (FileNotFoundException)
            {
                Cars cadena = new Cars();
                saveCars(fullPath, cadena);
                using (FileStream stream = new FileStream(fullPath, FileMode.Open))
                {

                    XmlSerializer format = new XmlSerializer(typeof(Cars));

                    msc = format.Deserialize(stream) as Cars;

                }
            }

            return msc;
        }

        public void saveTarifa(string fullPath, object documento)
        {
            if (fullPath == null)
            {
                throw new Exception("_Serialize: Path not set");
            }

            string DirName = Path.GetDirectoryName(fullPath);

            if (!((DirName == null) || (DirName.Trim().Length == 0)))
            {
                if (!Directory.Exists(DirName))
                {
                    Directory.CreateDirectory(DirName);
                }
            }

            using (FileStream stream = new FileStream(fullPath, FileMode.Create))
            {
                XmlSerializer format = new XmlSerializer(typeof(Prices));
                format.Serialize(stream, documento);
            }
        }

        public Prices loadTarifa(string fullPath)
        {
            Prices msc = null;
            try
            {
                using (FileStream stream = new FileStream(fullPath, FileMode.Open))
                {

                    XmlSerializer format = new XmlSerializer(typeof(Prices));

                    msc = format.Deserialize(stream) as Prices;

                }
            }
            catch (DirectoryNotFoundException)
            {
                Prices cadena = new Prices();
                saveTarifa(fullPath, cadena);
                using (FileStream stream = new FileStream(fullPath, FileMode.Open))
                {

                    XmlSerializer format = new XmlSerializer(typeof(Prices));

                    msc = format.Deserialize(stream) as Prices;

                }
            }
            catch (FileNotFoundException)
            {
                Prices cadena = new Prices();
                saveTarifa(fullPath, cadena);
                using (FileStream stream = new FileStream(fullPath, FileMode.Open))
                {

                    XmlSerializer format = new XmlSerializer(typeof(Prices));

                    msc = format.Deserialize(stream) as Prices;

                }
            }

            return msc;
        }

        public void Save(string FullPath, string Documento)
        {

            if (FullPath == null)
            {
                throw new Exception("_Save: Path not set");
            }

            string DirName = Path.GetDirectoryName(FullPath);


            if (!((DirName == null) || (DirName.Trim().Length == 0)))
            {
                if (!Directory.Exists(DirName))
                {
                    Directory.CreateDirectory(DirName);
                }
            }

            System.IO.File.WriteAllText(FullPath, Documento);

        }
        public string Load(string AdressFile)
        {
            this.AdressFile = AdressFile;
            string text = null;
            try
            {
                text = System.IO.File.ReadAllText(AdressFile);
            }
            catch (DirectoryNotFoundException)
            {
                String cadena = string.Empty;
                Save(AdressFile, cadena);
                text = Load(AdressFile);
            }
            catch (FileNotFoundException)
            {
                String cadena = string.Empty;
                Save(AdressFile, cadena);
                text = Load(AdressFile);
            }

            return text;
        }
        public string[] LoadLines(string AdressFile)
        {
            this.AdressFile = AdressFile;
            string[] text = null;
            try
            {
                text = System.IO.File.ReadAllLines(AdressFile);
            }
            catch (DirectoryNotFoundException)
            {
                String cadena = string.Empty;
                Save(AdressFile, cadena);
                text = LoadLines(AdressFile);
            }
            catch (FileNotFoundException)
            {
                String cadena = string.Empty;
                Save(AdressFile, cadena);
                text = LoadLines(AdressFile);
            }
            return text;
        }
    }
}
