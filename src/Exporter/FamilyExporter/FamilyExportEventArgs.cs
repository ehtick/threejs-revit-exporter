using System;
using System.Collections.Generic;
using System.IO;

namespace CodeCave.Threejs.Revit.Exporter
{
    public class FamilyExportEventArgs
    {
        public string FamilyFilePath { get; set; }

        public string FamilyName => string.IsNullOrWhiteSpace(FamilyFilePath) ? string.Empty : Path.GetFileNameWithoutExtension(FamilyFilePath);

        public string Symbol { get; set; }

        public Dictionary<Exception, string> Exceptions { get; internal set; }
    }
}
