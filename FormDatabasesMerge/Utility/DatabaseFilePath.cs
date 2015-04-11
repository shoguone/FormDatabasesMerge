using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FormDatabasesMerge.Utility
{
    public class DatabaseFilePath
    {
        private string dbExtension = Properties.Settings.Default.DBExtension;
        private string driveLetter = Properties.Settings.Default.InternalDriveLetter;
        private string serverAddress = Properties.Settings.Default.ExternalServerAddress;

        //private string _pair;
        //public string Pair
        //{
        //    get { return _pair; }
        //    set { _pair = value; }
        //}

        private string _path;
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        private string _fileName;
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        private string _internalDirectory;
        public string InternalDirectory
        {
            get { return _internalDirectory; }
            set { _internalDirectory = value; }
        }

        private string _externalDirectory;
        public string ExternalDirectory
        {
            get { return _externalDirectory; }
            set { _externalDirectory = value; }
        }

        //private string _internalPath;
        public string InternalPath
        {
            get { return _internalDirectory + _fileName + dbExtension; }
        }

        private string _year;
        public string Year
        {
            get { return _year; }
            set { _year = value; }
        }

        private string _number;
        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }



        public DatabaseFilePath()
        {

        }

        public DatabaseFilePath(string path)
        {
            _path = path;

            _fileName = Regex.Match(_path, @"[^\\]+(?=" + Regex.Escape(dbExtension) + ")").Value;

            string directory = Regex.Match(_path, @".+(?=" + Regex.Escape(_fileName) + ")").Value;
            string letter = Regex.Match(directory, @"^\\*[^\\]+?(?=\\)").Value;

            _internalDirectory = directory.Replace(letter, driveLetter + ":");
            _externalDirectory = directory.Replace(letter, serverAddress);

            var numbers = _fileName.Split('-');
            if (numbers.Count() < 2)
            {
                numbers = new string[2];
                if (_fileName.Length > 8)
                {
                    numbers[0] = _fileName.Substring(0, 8);
                    numbers[1] = _fileName.Substring(8);
                }
                else
                {
                    numbers[0] = numbers[1] = _fileName;
                }
            }
            _year = Regex.Match(Regex.Escape(numbers[0]), @"\d+").Value;
            _number = numbers[1];

        }

    }
}
