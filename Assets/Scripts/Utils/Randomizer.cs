public class Randomizer{

    public static int random(int min, int max) {

        System.Random rnd = new System.Random();

        return rnd.Next(min, max);         

    }

}