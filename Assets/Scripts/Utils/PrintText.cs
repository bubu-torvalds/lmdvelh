using System.Text;

public class PrintText {

    public static string printText(Scene currentScene) {
        StringBuilder sb = new StringBuilder();
        sb.Append(currentScene.getDesc() + "\n\n\n");
        foreach (Action action in currentScene.getActions()) {
            
            sb.Append(action.getQuestion()).Append("\n");

        }

        return sb.ToString();
    }
}