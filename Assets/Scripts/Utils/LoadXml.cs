using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LoadXml : MonoBehaviour {

    public static Wedding LoadXmlFile() {

        TextAsset xmlFile = Resources.Load<TextAsset>("LeMariageDontVousEtesLeHeros");

        print(xmlFile.ToString());

        return Wedding.LoadFromResources(xmlFile);

        //return Wedding.Load(Path.Combine(Application.dataPath, "Resources/LeMariageDontVousEtesLeHeros.xml"));

        //return Wedding.Load(Resources.Load)

        /*WWW www = new WWW(Path.Combine(Application.dataPath, "Resources/DataFiles/LeMariageDontVousEtesLeHeros.xml"));
        
        return Wedding.LoadFromText(www.text);*/
    }
}
