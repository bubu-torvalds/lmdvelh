using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

public class Scene {

    [XmlAttribute("title")]
    public string title;
    [XmlAttribute("code")]
    public string code;
    [XmlAttribute("subCode")]
    public string subCode;
    [XmlElement("desc")]
    public string desc;


    [XmlArray("actions")]
    [XmlArrayItem("question")]
    public List<Action> actions = new List<Action>();

    public string getTitle() {
        return title;
    }

    public string getCode() {
        return code;
    }

    public string getSubCode() {
        return subCode;
    }

    public string getDesc() {
        return desc;
    }

    public List<Action> getActions() {
        return actions;
    }
	
}
