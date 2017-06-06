using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

[XmlRoot("wedding")]
public class Wedding {

    [XmlArray("scenes")]
    [XmlArrayItem("scene")]
    public List<Scene> scenes = new List<Scene>();

    public static Wedding Load(string path) {

        XmlSerializer serializer = new XmlSerializer(typeof(Wedding));
        using(var stream = new FileStream(path, FileMode.Open)) {
            return serializer.Deserialize(stream) as Wedding;
        }

    }

    public static Wedding LoadFromResources(UnityEngine.TextAsset xmlFile) {        

        XmlSerializer serializer = new XmlSerializer(typeof(Wedding));
        StringReader reader = new StringReader(xmlFile.ToString());
        Wedding wedding = serializer.Deserialize(reader) as Wedding;
        reader.Close();

        return wedding;
    }    

    public static Wedding LoadFromText(string text) {
        XmlSerializer serializer = new XmlSerializer(typeof(Wedding));
        return serializer.Deserialize(new StringReader(text)) as Wedding;
    }

    public List<Scene> getScenes() {
        return scenes;
    }

}
