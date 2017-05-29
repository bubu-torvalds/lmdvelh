using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class PrintText {

    public static string printText(Scene currentScene) {
        StringBuilder sb = new StringBuilder();
        sb.Append(currentScene.getDesc() + "\n\n\n");
        foreach (Action action in currentScene.getActions()) {

            int indexChoix = currentScene.getActions().IndexOf(action) + 1;

            sb.Append("[" + indexChoix + "]" + " ");
            sb.Append(action.getQuestion()).Append("\n");
        }

        return sb.ToString();
    }
}


