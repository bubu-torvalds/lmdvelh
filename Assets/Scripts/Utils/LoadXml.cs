using UnityEngine;

public class LoadXml : MonoBehaviour {

    public static Wedding LoadXmlFile() {

        TextAsset xmlFile = Resources.Load<TextAsset>("LeMariageDontVousEtesLeHeros");

        print(xmlFile.ToString());

        return Wedding.LoadFromResources(xmlFile);

    }
}