using Rhino;
using System;

namespace TellDocEvent
{
    public class TellDocEventPlugin : Rhino.PlugIns.PlugIn
    {
        public TellDocEventPlugin()
        {
            Instance = this;
            RhinoApp.WriteLine($"{this.Name} is loaded.");

            RhinoDoc.AddRhinoObject += RhinoDoc_AddRhinoObject;
            RhinoDoc.ReplaceRhinoObject += RhinoDoc_ReplaceRhinoObject;
            RhinoDoc.EndSaveDocument += RhinoDoc_EndSaveDocument;
        }

        private void RhinoDoc_EndSaveDocument(object sender, DocumentSaveEventArgs e)
        {
            RhinoApp.WriteLine("EndSaveDocument");
        }

        private void RhinoDoc_ReplaceRhinoObject(object sender, Rhino.DocObjects.RhinoReplaceObjectEventArgs e)
        {
            RhinoApp.WriteLine("ReplaceRhinoObject");
        }

        private void RhinoDoc_AddRhinoObject(object sender, Rhino.DocObjects.RhinoObjectEventArgs e)
        {
            RhinoApp.WriteLine("AddRhinoObject");
        }

        public static TellDocEventPlugin Instance { get; private set; }
    }
}