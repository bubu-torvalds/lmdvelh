using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

public class Action {

    [XmlAttribute("code")]
    public string code;
    [XmlText]
    public string question;

    public string getCode() {
        return code;
    }

    public string getQuestion() {
        return question;
    }

}
